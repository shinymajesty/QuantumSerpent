using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    class Position (int x, int y)
    {
        public int X { get; set; } = x;

        public int Y { get; set; } = y;
        public static bool operator ==(Position a, Position b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(Position a, Position b) => !(a == b);
    }
}
