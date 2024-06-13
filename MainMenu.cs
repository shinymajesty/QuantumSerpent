using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class MainMenu : Form
    {
        readonly (int, int, int) btnForeColor = (15, 15, 15);
        readonly (int, int, int) btnHoverColor = (35, 35, 35);

        SinglePlayer? singlePlayer;

        Multiplayer? multiplayer;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(btnHoverColor.Item1, btnHoverColor.Item2, btnHoverColor.Item3);
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.FromArgb(btnForeColor.Item1, btnForeColor.Item2, btnForeColor.Item3);
        }

        private void btnSingleplayer_Click(object sender, EventArgs e)
        {
            singlePlayer = new SinglePlayer(this);
            singlePlayer.Show();
            HideMainMenu();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            multiplayer = new Multiplayer();
            multiplayer.Show();
            HideMainMenu();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HideMainMenu()
        {
            this.Hide();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible == false)
            {
                //Application.Exit();
                return;
            }
            if (singlePlayer != null)
            {
                singlePlayer.Close();
            }
            if (multiplayer != null)
            {
                multiplayer.Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
