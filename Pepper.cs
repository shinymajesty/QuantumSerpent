using QuantumSerpent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public class Pepper : Food
    {
        public Pepper(Position position, int hotness = 1) : base(position)
        {
            Energy = 3;
            Hotness = hotness;
        }

        public int Hotness { get; set; } = 1;
    }
}
