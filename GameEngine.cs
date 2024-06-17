using QuantumSerpent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace QuantumSerpent
{
    public delegate void GameOverFunction(Player player);
    internal class GameEngine
    {
        public static Random Rnd = new();
        public static double CalculateInterval(List<Player> playerList)
        {
            return GameSettings.Difficulty switch
            {
                Difficulty.Easy => 200,
                Difficulty.Medium => 100,
                Difficulty.Hard => 15,
                _ => 200
            } / (((4) / ((1 + (Math.Pow(Math.E, -0.01 * (playerList.Sum(player => player.Score) - (3 * playerList.Count))))))) - 1.2);
        }
        public static void GenerateFood(List<Player> playerList, List<Food> foodList, int maxWidth, int maxHeight)
        {
            int x;
            int y;
            bool success;
            do
            {
                x = Rnd.Next(0, maxWidth);
                y = Rnd.Next(0, maxHeight);
                //Check if the food is not on a player
                success = true;

                foreach (var player in playerList)
                {
                    if (player == null) continue;
                    foreach (var item in player.Items)
                    {
                        var newPos = new Position(x, y);
                        if (newPos == item)
                        {
                            success = false;
                            break;
                        }
                    }
                }
                foreach (var food in foodList)
                {
                    var newPos = new Position(x, y);
                    if (newPos == food.Position)
                    {
                        success = false;
                        break;
                    }
                }
            } while (!success);

            if (Rnd.Next(0, 100) < 50)
            {
                foodList.Add(new Pepper(new Position(x, y)));
            }
            else
            {
                foodList.Add(new Food(new Position(x, y)));
            }
        }
        public static void CheckCollision(List<Player> playerList, List<Food> foodList, int maxWidth, int maxHeight, GameOverFunction gameOverFunction)
        {
            GameState gameState = GameState.Running;
            foreach (Player player1 in playerList)
            {
                if (player1 == null) continue;
                //Check border collision
                if (player1.X < 0 || player1.X >= maxWidth || player1.Y < 0 || player1.Y >= maxHeight)
                {
                    KillPlayer(player1, playerList, gameOverFunction);
                }
                //Check if player has collided with itself
                foreach (var item in player1.Items.Skip(1))
                {
                    if (player1.X == item.X && player1.Y == item.Y)
                    {
                        KillPlayer(player1, playerList, gameOverFunction);
                    }
                }
                //Check if player has collided with another player
                foreach (var player2 in playerList)
                {
                    if (player2 == null) continue;
                    if (player1 == player2)
                    {
                        continue;
                    }
                    foreach (var item in player2.Items)
                    {
                        if (player1.X == item.X && player1.Y == item.Y)
                        {
                            KillPlayer(player1, playerList, gameOverFunction);
                        }
                    }
                }

                //Check if player has collided with food
                for (int i = foodList.Count - 1; i >= 0; i--)
                {
                    var food = foodList[i];
                    foreach (var item in playerList)
                    {
                        if (item == null) continue;
                        // Check if player has collided with food
                        var newPos = new Position(item.X, item.Y);
                        if (newPos == food.Position)
                        {
                            item.Eat(food);
                            foodList.Remove(food);
                            if (foodList.Count == 0)
                                GenerateFood(playerList, foodList, maxWidth, maxHeight);
                            break; // not possible that there is more than one food at the same position
                        }
                    }
                }
            }

            for (int i = 0; i < playerList.Count; i++)
            {
                var player = playerList[i];
                if (player == null) continue;
                if (player.State == PlayerState.Dead)
                {
                    playerList.RemoveAt(i);
                    i--; // Decrement i to account for the removed element
                         // Optionally, if you only want to remove one dead player, you can break here
                }
            }
        }
        private static void KillPlayer(Player player1, List<Player> playerList, GameOverFunction gameOverFunction)
        {
            if (PlayerDied(player1, playerList) == GameState.GameOver)
            {
                gameOverFunction(player1);
            }
        }
        private static GameState PlayerDied(Player player, List<Player> playerList)
        {
            player.State = PlayerState.Dead;
            bool allDead = true;

            foreach (var item in playerList)
            {
                if (item.State == PlayerState.Alive)
                {
                    allDead = false;
                    break;
                }
            }

            if (allDead)
            {
                return GameState.GameOver;
            }
            return GameState.Running;
        }

    }
}
