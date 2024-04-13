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
        public static string Player1_Name { get; set; } = "Player 1";
        public static string Player2_Name { get; set; } = "Player 2";
        public static bool Bot1 { get; set; } = false;
        public static bool Bot2 { get; set; } = false;

    }
}
