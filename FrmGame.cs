namespace QuantumSerpent
{
    public partial class FrmGame : Form
    {
        Directions playerDirection = Directions.Right;
        readonly static Player player = new(50, 50, 10);
        
        public FrmGame()
        {
            InitializeComponent();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Game loop
            player.Move(playerDirection);

            canvas.Invalidate(); // Force redraw
        }

       

        private void BtnStart_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            btnStart.Enabled = false;
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // Draw the whole game situation
            Graphics graphics = e.Graphics;

            foreach (Position item in player.Items)
            {
                Brush brush;
                if (player.Items.First() == item)
                {
                    brush = Brushes.Red;
                }
                else
                {
                    brush = Brushes.Black;
                }
                graphics.FillRectangle(brush, item.X, item.Y, 20, 20);
            }
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            Directions newDirection = e.KeyCode switch
            {
                Keys.Right when playerDirection != Directions.Left => Directions.Right,
                Keys.Left when playerDirection != Directions.Right => Directions.Left,
                Keys.Up when playerDirection != Directions.Down => Directions.Up,
                Keys.Down when playerDirection != Directions.Up => Directions.Down,
                _ => playerDirection
            };

            playerDirection = newDirection;
        }
    }
}
