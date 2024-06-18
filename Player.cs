using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuantumSerpent
{
    [Serializable]
    public class Player
    {
        private readonly List<Position> items = new List<Position>();
        Directions direction;

        // Original constructor
        protected Player(int x, int y, Directions initialDirection, int initialLength = 3)
        {
            if (initialLength < 1)
            {
                throw new ArgumentException("Initial length must be greater than 0");
            }
            // Initialize the snake
            for (int i = 0; i < initialLength; i++)
            {
                items.Add(new Position(x, y));
            }
            direction = initialDirection;
        }

        // JSON deserialization constructor LEAVE HIM HERE IT SAY 0 REFERENCES BUT LEAVE HIM HERE YOU KNOW HOW MUCH EFFORT IT WAS OK? DO NOT DELETE
        [JsonConstructor]
        public Player(string name, int x, int y, int initialLength, Directions initialDirection, PlayerState state, List<Position> items)
        {
            this.Name = name;
            this.direction = initialDirection;
            this.State = state;
            this.items = items ?? new List<Position>();
            if (this.items.Count == 0)
            {
                for (int i = 0; i < initialLength; i++)
                {
                    this.items.Add(new Position(x, y));
                }
            }
        }

        virtual public bool HandleKey(Keys keycode)
        {
            Directions oldDir = PlayerDirection;
            if (!CanMove)
            {
                return false;
            }
            if (keycode == UpKey)
            {
                PlayerDirection = Directions.Up;
            }
            else if (keycode == DownKey)
            {
                PlayerDirection = Directions.Down;
            }
            else if (keycode == LeftKey)
            {
                PlayerDirection = Directions.Left;
            }
            else if (keycode == RightKey)
            {
                PlayerDirection = Directions.Right;
            }
            return PlayerDirection != oldDir;
        }

        virtual public void Move(Directions direction)
        {
            if (HasMoved)
            {
                return;
            }
            switch (direction)
            {
                case Directions.Up:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X, Y - 1));
                    break;
                case Directions.Right:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X + 1, Y));
                    break;
                case Directions.Down:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X, Y + 1));
                    break;
                case Directions.Left:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X - 1, Y));
                    break;
            }
        }

        [JsonIgnore]
        public int Score => items.Count;
        [JsonProperty("direction")]
        public Directions PlayerDirection
        {
            get => direction;
            set
            {
                if (value == Directions.Up && direction != Directions.Down ||
                   value == Directions.Right && direction != Directions.Left ||
                   value == Directions.Down && direction != Directions.Up ||
                   value == Directions.Left && direction != Directions.Right)
                {
                    direction = value;
                }
            }
        }
        [JsonIgnore]
        public int X => items[0].X;
        [JsonIgnore]
        public int Y => items[0].Y;
        public string Name { get; set; } = "";
        [JsonIgnore]
        public bool HasMoved { get; set; } = false;
        [JsonIgnore]
        public bool CanMove { get; set; } = true;
        [JsonIgnore]
        public Keys UpKey { get; set; } = Keys.Up;
        [JsonIgnore]
        public Keys DownKey { get; set; } = Keys.Down;
        [JsonIgnore]
        public Keys LeftKey { get; set; } = Keys.Left;
        [JsonIgnore]
        public Keys RightKey { get; set; } = Keys.Right;
        [JsonIgnore]
        public Brush BodyColor { get; set; } = Brushes.Black;
        [JsonIgnore]
        public Brush HeadColor { get; set; } = Brushes.Green;
        [JsonProperty("items")]
        public IEnumerable<Position> Items => items;
        [JsonProperty("state")]
        public PlayerState State { get; set; } = PlayerState.Alive;
        private static int instanceCount = 0;

        public static Player Create(int maxWidth, int maxHeight, string name)
        {
            instanceCount++;
            int x;
            int y;
            Directions direction;
            switch (instanceCount)
            {
                case 1:
                    x = 2;
                    y = maxHeight - 2;
                    direction = Directions.Up;
                    return new Player(x, y, direction)
                    {
                        Name = name == "" ? "Player 1" : name,
                    };
                case 2:
                    x = maxWidth - 2;
                    y = 2;
                    direction = Directions.Down;
                    return new Player(x, y, direction)
                    {
                        UpKey = Keys.W,
                        DownKey = Keys.S,
                        LeftKey = Keys.A,
                        RightKey = Keys.D,
                        Name = name == "" ? "Player 2" : name,
                        BodyColor = Brushes.Blue,
                        HeadColor = Brushes.Red
                    };

                default:
                    throw new InvalidOperationException("Only 2 players are allowed");
            }
        }

        public static Player Create(string name, int x, int y, int initLength, Directions initDir)
        {
            instanceCount++;
            return new Player(x, y, initDir, initLength)
            {
                Name = name == "" ? "Player " + instanceCount : name,
            };
        }

        public void Eat(Food food)
        {
            for (int i = 0; i < food.Energy; i++)
                items.Add(new Position(-1, -1));
        }

        public static void Reset()
        {
            instanceCount = 0;
        }

        public string SerializeToJson() // Encode the data so it can be sent over the network
        {
            var data = new
            {
                this.Name,
                Position = new { this.X, this.Y },
                PlayerState = this.State.ToString()
            };

            return JsonConvert.SerializeObject(data);
        }

        public static string SerializeListToJson(List<Player> players)
        {
            return JsonConvert.SerializeObject(players.Select(p => new
            {
                Name = p.Name,
                Position = new { X = p.X, Y = p.Y },
                PlayerState = p.State.ToString()
            }));
        }

        public string SerializeDirectionToJson()
        {
            return JsonConvert.SerializeObject(new { Direction = this.PlayerDirection.ToString() });
        }

        public static Player DeserializeFromJson(string json)
        {
            return JsonConvert.DeserializeObject<Player>(json);
        }
    }
}
