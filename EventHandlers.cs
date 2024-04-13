using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public delegate void GameOverEventHandler(object sender, EventArgs e);

    public class EventHandlers
    {
        public event GameOverEventHandler? GameOver;

        public void OnGameOver(object sender, EventArgs e)
        {
            GameOver?.Invoke(sender, e);
        }
        public void TriggerGameOver()
        {
            OnGameOver(this, EventArgs.Empty);
        }
    }
}
