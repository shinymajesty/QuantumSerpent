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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSingleplayer = new Button();
            btnQuitGame = new Button();
            btnMultiplayer = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.QuanumSerpentFont;
            pictureBox1.Location = new Point(201, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 152);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnSingleplayer, 0, 0);
            tableLayoutPanel1.Controls.Add(btnQuitGame, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMultiplayer, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(201, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Size = new Size(391, 227);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnSingleplayer
            // 
            btnSingleplayer.Dock = DockStyle.Fill;
            btnSingleplayer.FlatStyle = FlatStyle.Flat;
            btnSingleplayer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnSingleplayer.ForeColor = Color.LimeGreen;
            btnSingleplayer.Location = new Point(3, 3);
            btnSingleplayer.Name = "btnSingleplayer";
            btnSingleplayer.Size = new Size(385, 69);
            btnSingleplayer.TabIndex = 1;
            btnSingleplayer.Text = "Singleplayer";
            btnSingleplayer.UseVisualStyleBackColor = true;
            btnSingleplayer.Click += btnSingleplayer_Click;
            btnSingleplayer.MouseEnter += Button1_MouseEnter;
            btnSingleplayer.MouseLeave += Button1_MouseLeave;
            // 
            // btnQuitGame
            // 
            btnQuitGame.Dock = DockStyle.Fill;
            btnQuitGame.FlatStyle = FlatStyle.Flat;
            btnQuitGame.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnQuitGame.ForeColor = Color.LimeGreen;
            btnQuitGame.Location = new Point(3, 153);
            btnQuitGame.Name = "btnQuitGame";
            btnQuitGame.Size = new Size(385, 71);
            btnQuitGame.TabIndex = 3;
            btnQuitGame.Text = "Quit Game";
            btnQuitGame.UseVisualStyleBackColor = true;
            btnQuitGame.Click += btnQuitGame_Click;
            btnQuitGame.MouseEnter += Button1_MouseEnter;
            btnQuitGame.MouseLeave += Button1_MouseLeave;
            // 
            // btnMultiplayer
            // 
            btnMultiplayer.Dock = DockStyle.Fill;
            btnMultiplayer.FlatStyle = FlatStyle.Flat;
            btnMultiplayer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnMultiplayer.ForeColor = Color.LimeGreen;
            btnMultiplayer.Location = new Point(3, 78);
            btnMultiplayer.Name = "btnMultiplayer";
            btnMultiplayer.Size = new Size(385, 69);
            btnMultiplayer.TabIndex = 2;
            btnMultiplayer.Text = "Multiplayer";
            btnMultiplayer.UseVisualStyleBackColor = true;
            btnMultiplayer.Click += btnMultiplayer_Click;
            btnMultiplayer.MouseEnter += Button1_MouseEnter;
            btnMultiplayer.MouseLeave += Button1_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 161);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(794, 233);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.Size = new Size(800, 397);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 397);
            Controls.Add(tableLayoutPanel4);
            Name = "MainMenu";
            Text = "MainMenu";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSingleplayer;
        private Button btnQuitGame;
        private Button btnMultiplayer;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}