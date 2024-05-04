using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    class Food(int x, int y)
    {
        public Position Position { get; set; } = new Position(x, y);
        public int Energy { get; set; } = 1;
    }
}
