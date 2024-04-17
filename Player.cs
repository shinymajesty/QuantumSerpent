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
        readonly List<Position> items = [];

        public Player(int x, int y, int initialLength = 3)
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
        }

        

        public void Move(Directions direction)
        {
            if(HasMoved)
            {
                return;
            }
            switch (direction)
            {
                case Directions.Up:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X, Y-1));
                    break;
                case Directions.Right:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X+1, Y));
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
        public Directions PlayerDirection { get; set; }
        public int X => items[0].X;
        public int Y => items[0].Y;
        public string Name { get; set; } = "";
        public bool HasMoved { get; set; } = false;
        


        public IEnumerable<Position> Items => items;
        public PlayerState State { get; set; } = PlayerState.Alive;

    }
}