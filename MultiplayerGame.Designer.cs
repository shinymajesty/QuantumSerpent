namespace QuantumSerpent
{
    partial class MultiplayerGame
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            canvas = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnStart = new Button();
            btnStopGame = new Button();
            btnShutDown = new Button();
            lblSpeedModifier = new Label();
            tblScore = new TableLayoutPanel();
            lblScoreboard = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblTime = new Label();
            lblPlayerCount = new Label();
            lblIP = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(15, 15, 15);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.Lime;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1124, 596);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 24F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(1118, 59);
            lblName.TabIndex = 0;
            lblName.Text = "Server Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.20628F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.79372F));
            tableLayoutPanel2.Controls.Add(canvas, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 62);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1118, 470);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // canvas
            // 
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(3, 3);
            canvas.Name = "canvas";
            canvas.Size = new Size(644, 464);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += Canvas_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblSpeedModifier);
            panel1.Controls.Add(tblScore);
            panel1.Controls.Add(lblScoreboard);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(653, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 464);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 199);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 265);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Controls.Add(btnShutDown, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(462, 265);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnStart, 1, 0);
            tableLayoutPanel5.Controls.Add(btnStopGame, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(456, 126);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(231, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(222, 120);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStopGame
            // 
            btnStopGame.Dock = DockStyle.Fill;
            btnStopGame.FlatStyle = FlatStyle.Flat;
            btnStopGame.Location = new Point(3, 3);
            btnStopGame.Name = "btnStopGame";
            btnStopGame.Size = new Size(222, 120);
            btnStopGame.TabIndex = 0;
            btnStopGame.Text = "Reset";
            btnStopGame.UseVisualStyleBackColor = true;
            btnStopGame.Click += btnStopGame_Click;
            // 
            // btnShutDown
            // 
            btnShutDown.BackColor = Color.Firebrick;
            btnShutDown.Dock = DockStyle.Fill;
            btnShutDown.FlatStyle = FlatStyle.Popup;
            btnShutDown.ForeColor = Color.White;
            btnShutDown.Location = new Point(3, 135);
            btnShutDown.Name = "btnShutDown";
            btnShutDown.Size = new Size(456, 127);
            btnShutDown.TabIndex = 1;
            btnShutDown.Text = "Shut Dwn Server";
            btnShutDown.UseVisualStyleBackColor = false;
            btnShutDown.Click += btnShutDown_Click;
            // 
            // lblSpeedModifier
            // 
            lblSpeedModifier.Dock = DockStyle.Top;
            lblSpeedModifier.Font = new Font("Segoe UI", 14F);
            lblSpeedModifier.Location = new Point(0, 160);
            lblSpeedModifier.Name = "lblSpeedModifier";
            lblSpeedModifier.Size = new Size(462, 39);
            lblSpeedModifier.TabIndex = 2;
            lblSpeedModifier.Text = "Speed Modifier: 1.00x";
            lblSpeedModifier.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblScore
            // 
            tblScore.ColumnCount = 2;
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tblScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblScore.Dock = DockStyle.Top;
            tblScore.Location = new Point(0, 39);
            tblScore.Name = "tblScore";
            tblScore.RowCount = 1;
            tblScore.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblScore.Size = new Size(462, 121);
            tblScore.TabIndex = 1;
            // 
            // lblScoreboard
            // 
            lblScoreboard.Dock = DockStyle.Top;
            lblScoreboard.Font = new Font("Segoe UI", 14F);
            lblScoreboard.Location = new Point(0, 0);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(462, 39);
            lblScoreboard.TabIndex = 0;
            lblScoreboard.Text = "Scores:";
            lblScoreboard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.Controls.Add(lblTime, 2, 0);
            tableLayoutPanel4.Controls.Add(lblPlayerCount, 1, 0);
            tableLayoutPanel4.Controls.Add(lblIP, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 538);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1118, 55);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Fill;
            lblTime.Font = new Font("Segoe UI", 12F);
            lblTime.Location = new Point(747, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(368, 55);
            lblTime.TabIndex = 2;
            lblTime.Text = "Game Time:";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayerCount
            // 
            lblPlayerCount.Dock = DockStyle.Fill;
            lblPlayerCount.Font = new Font("Segoe UI", 12F);
            lblPlayerCount.Location = new Point(375, 0);
            lblPlayerCount.Name = "lblPlayerCount";
            lblPlayerCount.Size = new Size(366, 55);
            lblPlayerCount.TabIndex = 1;
            lblPlayerCount.Text = "ConnectedClients:";
            lblPlayerCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIP
            // 
            lblIP.Dock = DockStyle.Fill;
            lblIP.Font = new Font("Segoe UI", 12F);
            lblIP.Location = new Point(3, 0);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(366, 55);
            lblIP.TabIndex = 0;
            lblIP.Text = "Host IP:";
            lblIP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gameTimer
            // 
            gameTimer.Tick += GameTimer_Tick;
            // 
            // MultiplayerGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 596);
            Controls.Add(tableLayoutPanel1);
            Name = "MultiplayerGame";
            Text = "MultiplayerGame";
            FormClosing += MultiplayerGame_FormClosing;
            KeyDown += MultiplayerGame_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox canvas;
        private Panel panel1;
        private Label lblScoreboard;
        private Label lblSpeedModifier;
        private TableLayoutPanel tblScore;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private Button btnShutDown;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnStart;
        private Button btnStopGame;
        private Label lblTime;
        private Label lblPlayerCount;
        private Label lblIP;
        private System.Windows.Forms.Timer gameTimer;
        private TableLayoutPanel tableLayoutPanel3;
    }
}