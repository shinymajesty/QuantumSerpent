using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public enum Directions
    {
        Up,
        Right,
        Down,
        Left
    }
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }
    public enum GameState
    {
        Running,
        Paused,
        GameOver
    }
    public enum PlayerState
    {
        Alive,
        Dead
    }

}
