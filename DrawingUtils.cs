using QuantumSerpent;
using System.Drawing;
using System.Linq;
using System.Windows.Forms; 

public static class DrawUtils
{
    public static void DrawGame(Graphics graphics, int scale, GameState gameState, IEnumerable<Player> playerList, IEnumerable<Food> foodList, Control canvas)
    {
        // Create off-screen bitmap and graphics object
        using var offScreenBitmap = new Bitmap(canvas.Width, canvas.Height);
        using var offScreenGraphics = Graphics.FromImage(offScreenBitmap);

        // Draw players
        if (gameState != GameState.GameOver)
        {
            foreach (Player player in playerList)
            {
                if (player.State == PlayerState.Alive)
                {
                    foreach (Position item in player.Items)
                    {
                        Brush brush = (player.Items.First() == item) ? player.HeadColor : player.BodyColor;
                        offScreenGraphics.FillRectangle(brush, item.X * scale, item.Y * scale, scale, scale);
                    }

                    // Draw player's name label
                    var nameLabel = new Label()
                    {
                        Text = player.Name,
                        AutoSize = true,
                        Width = 0,
                        Height = 0,
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        BackColor = Color.Transparent,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    Size preferredSize = nameLabel.GetPreferredSize(Size.Empty);
                    int newWidth = preferredSize.Width;
                    nameLabel.Location = new Point((player.X * scale - newWidth / 2), (player.Y * scale - 20));
                    canvas.Controls.Add(nameLabel); // Add to canvas (you may need to adjust this based on your UI framework)
                }
            }
        }

        // Draw food
        foreach (Food food in foodList)
        {
            Brush brush = (food is Pepper) ? Brushes.Red : Brushes.Green;
            offScreenGraphics.FillRectangle(brush, food.Position.X * scale, food.Position.Y * scale, scale, scale);
        }

        // Draw the off-screen bitmap to the screen
        graphics.DrawImage(offScreenBitmap, 0, 0);
    }
    public static void UpdateScoreboard(TableLayoutPanel scoreboardTBL, IEnumerable<Player> playerList)
    {
        scoreboardTBL.Controls.Clear();
        scoreboardTBL.RowStyles.Clear();

        scoreboardTBL.RowCount = playerList.Count();

        for (int i = 0; i < playerList.Count(); i++)
        {
            Player p = playerList.ElementAtOrDefault(i);
            if (p == null) continue;

            // Add row style
            scoreboardTBL.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Create name label
            Label lblName = new()
            {
                Text = p.Name,
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = ((SolidBrush)p.HeadColor).Color,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label lblScore = new()
            {
                Text = p.Score.ToString(),
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = ((SolidBrush)p.HeadColor).Color,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Add labels to table
            scoreboardTBL.Controls.Add(lblName, 0, i);
            scoreboardTBL.Controls.Add(lblScore, 1, i);
        }
    }
}
