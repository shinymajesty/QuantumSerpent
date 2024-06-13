using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public class FileDAO
    {
        private string filePath;

        public FileDAO(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveHighScore(HighScore highscore)
        {
            List<HighScore> highScores = GetAllHighScores();

            // Add the new high score to the list
            highScores.Add(highscore);

            // Sort the high scores by score in descending order
            highScores = highScores.OrderByDescending(hs => hs.Score).ToList();

            // Ensure only the top 100 scores are kept
            if (highScores.Count > 100)
            {
                highScores = highScores.Take(100).ToList();
            }

            // Write the top 100 high scores to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var hs in highScores)
                {
                    writer.WriteLine($"{hs.PlayerName},{hs.Score}");
                }
            }
        }


        public List<HighScore> GetAllHighScores()
        {
            List<HighScore> highScores = new List<HighScore>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                        {
                            highScores.Add(new HighScore(parts[0], score));
                        }
                    }
                }
            }

            return highScores;
        }
    }
}
