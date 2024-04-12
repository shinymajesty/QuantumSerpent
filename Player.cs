using System;
using System.Collections.Generic;
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
            const int OFFSET = 20;
            switch (direction)
            {
                case Directions.Up:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X, Y - OFFSET));
                    break;
                case Directions.Right:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X + OFFSET, Y));
                    break;
                case Directions.Down:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X, Y + OFFSET));
                    break;
                case Directions.Left:
                    items.RemoveAt(items.Count - 1);
                    items.Insert(0, new Position(X - OFFSET, Y));
                    break;
            }
        }
        public int Score => items.Count;

        public int X => items[0].X;

        public int Y => items[0].Y;

        public IEnumerable<Position> Items => items;
    }
}