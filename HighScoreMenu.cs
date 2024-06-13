using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace QuantumSerpent
{
    public partial class HighScoreMenu : Form
    {
        private FileDAO fileDAO = new("highscores.txt");
        private HighScore player;
        public HighScoreMenu(HighScore score)
        {
            this.player = score;
            InitializeComponent();
            DisplayHighScores(); 
            label2.Text = $"Your score: {score.Score}";
        }

        private void DisplayHighScores()
        {
            List<HighScore> highScores = fileDAO.GetAllHighScores();
            flowLayoutPanel.Controls.Clear();

            foreach (var highScore in highScores)
            {
                Label label = new Label
                {
                    Text = $"{highScore.PlayerName}: {highScore.Score}",
                    AutoSize = false,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.Aqua,
                    Dock = DockStyle.Top,
                };

                

                flowLayoutPanel.Controls.Add(label);
            }
        }



        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            fileDAO.SaveHighScore(player);
            btnSave.Text = "Saved!";
            btnSave.Enabled = false;
            DisplayHighScores();
        }

    }
}
