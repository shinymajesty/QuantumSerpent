using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    static class GameSettings
    {
        public static Difficulty Difficulty { get; set; } = Difficulty.Easy;

        public static int Speed { get; set; } = 166;
        public static int Size { get; set; } = 20;
        public static bool Bot1 { get; set; } = false;
        public static bool Bot2 { get; set; } = false;

    }
}
