using QuantumSerpent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public class Food(Position position)
    {
        public int Energy { get; set; } = 1;
        public Position Position { get; set; } = position;
    }

}
