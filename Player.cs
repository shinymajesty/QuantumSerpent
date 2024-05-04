using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    class Player
    {
        private readonly List<Position> items = [];
        Directions direction;
        private Player(int x, int y, Directions initialDirection, int initialLength = 3)
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


        public void HandleKey(Keys keycode)
        {
            if(keycode == UpKey)
            {
                PlayerDirection = Directions.Up;
            }
            else if(keycode == DownKey)
            {
                PlayerDirection = Directions.Down;
            }
            else if(keycode == LeftKey)
            {
                PlayerDirection = Directions.Left;
            }
            else if(keycode == RightKey)
            {
                PlayerDirection = Directions.Right;
            }
        }
        public void Move(Directions direction)
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
        public int Score => items.Count;

        
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
        public int X => items[0].X;
        public int Y => items[0].Y;
        public string Name { get; set; } = "";
        public bool HasMoved { get; set; } = false;
        public Keys UpKey { get; set; } = Keys.Up;
        public Keys DownKey { get; set; } = Keys.Down;
        public Keys LeftKey { get; set; } = Keys.Left;
        public Keys RightKey { get; set; } = Keys.Right;
        public Brush BodyColor { get; set; } = Brushes.Black;
        public Brush HeadColor { get; set; } = Brushes.Green;


        public IEnumerable<Position> Items => items;
        public PlayerState State { get; set; } = PlayerState.Alive;
        private static int instanceCount = 0;
        public static Player Create(int maxWidth, int maxHeight, string name)
        {
            instanceCount++;
            int x = 0;
            int y = 0;
            Directions direction = Directions.Left;
            switch(instanceCount)
            {
                case 1:
                    x = 2;
                    y = maxHeight - 2;
                    direction = Directions.Up;
                    return new Player(x, y, direction);
                case 2:
                    x = maxWidth - 2;
                    y = 2;
                    direction = Directions.Left;
                    return new Player(x, y, direction)
                    {
                        UpKey = Keys.W,
                        DownKey = Keys.S,
                        LeftKey = Keys.A,
                        RightKey = Keys.D,
                        Name = name,
                        BodyColor = Brushes.Blue,
                        HeadColor = Brushes.Red
                    };

                default:
                    throw new InvalidOperationException("Only 2 players are allowed");
            }
        }
        public void Eat(Food food)
        {
            for(int i = 0; i < food.Energy; i++)
            items.Add(new Position(X,Y));
        }
    }
}