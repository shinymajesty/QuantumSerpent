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

        DrawCheckerboard(offScreenGraphics, scale, canvas.Height / scale, canvas.Width / scale);

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
    private static void DrawCheckerboard(Graphics graphics, int squareSize, int rows, int columns)
    {
        // Calculate total size based on rows and columns
        int totalWidth = squareSize * columns;
        int totalHeight = squareSize * rows;

        // Create brushes for each color
        using (Brush brush1 = new SolidBrush(GameSettings.Color1))
        using (Brush brush2 = new SolidBrush(GameSettings.Color2))
        {
            // Loop through each square and draw it
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    // Determine which color to use based on row and column indices
                    Brush brush = (row + col) % 2 == 0 ? brush1 : brush2;

                    // Calculate the position of the square
                    int x = col * squareSize;
                    int y = row * squareSize;

                    // Draw the square
                    graphics.FillRectangle(brush, x, y, squareSize, squareSize);
                }
            }
        }
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
