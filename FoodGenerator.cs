using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    class FoodGenerator(Player player)
    {
        private readonly Random random = new();
        private readonly int width;
        private readonly int height;
        private readonly Player player = player;

        public Food Generate()
        {
            int x = random.Next(0, width);
            int y = random.Next(0, height);

            while (player.Items.Any(item => item.X == x && item.Y == y))
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            }

            return new Food(x, y);
        }
    }
}
