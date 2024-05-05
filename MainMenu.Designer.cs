namespace QuantumSerpent
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnSingleplayer = new Button();
            btnMultiplayer = new Button();
            btnQuitGame = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.QuanumSerpentFont;
            pictureBox1.Location = new Point(195, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 86);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSingleplayer
            // 
            btnSingleplayer.Dock = DockStyle.Fill;
            btnSingleplayer.FlatStyle = FlatStyle.Flat;
            btnSingleplayer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnSingleplayer.ForeColor = Color.LimeGreen;
            btnSingleplayer.Location = new Point(3, 3);
            btnSingleplayer.Name = "btnSingleplayer";
            btnSingleplayer.Size = new Size(343, 46);
            btnSingleplayer.TabIndex = 1;
            btnSingleplayer.Text = "Singleplayer";
            btnSingleplayer.UseVisualStyleBackColor = true;
            btnSingleplayer.Click += btnSingleplayer_Click;
            btnSingleplayer.MouseEnter += Button1_MouseEnter;
            btnSingleplayer.MouseLeave += Button1_MouseLeave;
            // 
            // btnMultiplayer
            // 
            btnMultiplayer.Dock = DockStyle.Fill;
            btnMultiplayer.FlatStyle = FlatStyle.Flat;
            btnMultiplayer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnMultiplayer.ForeColor = Color.LimeGreen;
            btnMultiplayer.Location = new Point(3, 55);
            btnMultiplayer.Name = "btnMultiplayer";
            btnMultiplayer.Size = new Size(343, 46);
            btnMultiplayer.TabIndex = 2;
            btnMultiplayer.Text = "Multiplayer";
            btnMultiplayer.UseVisualStyleBackColor = true;
            btnMultiplayer.Click += btnMultiplayer_Click;
            btnMultiplayer.MouseEnter += Button1_MouseEnter;
            btnMultiplayer.MouseLeave += Button1_MouseLeave;
            // 
            // btnQuitGame
            // 
            btnQuitGame.Dock = DockStyle.Fill;
            btnQuitGame.FlatStyle = FlatStyle.Flat;
            btnQuitGame.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnQuitGame.ForeColor = Color.LimeGreen;
            btnQuitGame.Location = new Point(3, 107);
            btnQuitGame.Name = "btnQuitGame";
            btnQuitGame.Size = new Size(343, 48);
            btnQuitGame.TabIndex = 3;
            btnQuitGame.Text = "Quit Game";
            btnQuitGame.UseVisualStyleBackColor = true;
            btnQuitGame.Click += btnQuitGame_Click;
            btnQuitGame.MouseEnter += Button1_MouseEnter;
            btnQuitGame.MouseLeave += Button1_MouseLeave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnSingleplayer, 0, 0);
            tableLayoutPanel1.Controls.Add(btnQuitGame, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMultiplayer, 0, 1);
            tableLayoutPanel1.Location = new Point(225, 162);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Size = new Size(349, 158);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "MainMenu";
            Text = "MainMenu";
            FormClosing += MainMenu_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSingleplayer;
        private Button btnMultiplayer;
        private Button btnQuitGame;
        private TableLayoutPanel tableLayoutPanel1;
    }
}