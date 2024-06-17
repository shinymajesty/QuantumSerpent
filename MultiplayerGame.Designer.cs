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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            canvas = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            lblScoreboard = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblSpeedModifier = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblIP = new Label();
            lblPlayerCount = new Label();
            lblTime = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel2 = new Panel();
            btnStopGame = new Button();
            btnStart = new Button();
            btnShutDown = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 24F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(794, 45);
            lblName.TabIndex = 0;
            lblName.Text = "Server Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(canvas, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 354);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // canvas
            // 
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(3, 3);
            canvas.Name = "canvas";
            canvas.Size = new Size(391, 348);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(lblSpeedModifier);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(lblScoreboard);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(400, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 348);
            panel1.TabIndex = 1;
            // 
            // lblScoreboard
            // 
            lblScoreboard.Dock = DockStyle.Top;
            lblScoreboard.Font = new Font("Segoe UI", 14F);
            lblScoreboard.Location = new Point(0, 0);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(391, 39);
            lblScoreboard.TabIndex = 0;
            lblScoreboard.Text = "Scores:";
            lblScoreboard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 39);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(391, 121);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // lblSpeedModifier
            // 
            lblSpeedModifier.Dock = DockStyle.Top;
            lblSpeedModifier.Font = new Font("Segoe UI", 14F);
            lblSpeedModifier.Location = new Point(0, 160);
            lblSpeedModifier.Name = "lblSpeedModifier";
            lblSpeedModifier.Size = new Size(391, 39);
            lblSpeedModifier.TabIndex = 2;
            lblSpeedModifier.Text = "Speed Modifier: 1.00x";
            lblSpeedModifier.TextAlign = ContentAlignment.MiddleLeft;
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
            tableLayoutPanel4.Location = new Point(3, 408);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(794, 39);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // lblIP
            // 
            lblIP.Dock = DockStyle.Fill;
            lblIP.Font = new Font("Segoe UI", 12F);
            lblIP.Location = new Point(3, 0);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(258, 39);
            lblIP.TabIndex = 0;
            lblIP.Text = "Host IP:";
            lblIP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayerCount
            // 
            lblPlayerCount.Dock = DockStyle.Fill;
            lblPlayerCount.Font = new Font("Segoe UI", 12F);
            lblPlayerCount.Location = new Point(267, 0);
            lblPlayerCount.Name = "lblPlayerCount";
            lblPlayerCount.Size = new Size(258, 39);
            lblPlayerCount.TabIndex = 1;
            lblPlayerCount.Text = "ConnectedClients:";
            lblPlayerCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Fill;
            lblTime.Font = new Font("Segoe UI", 12F);
            lblTime.Location = new Point(531, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(260, 39);
            lblTime.TabIndex = 2;
            lblTime.Text = "Game Time:";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnStart, 1, 0);
            tableLayoutPanel5.Controls.Add(btnStopGame, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 199);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(391, 78);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnShutDown);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 71);
            panel2.TabIndex = 4;
            // 
            // btnStopGame
            // 
            btnStopGame.Dock = DockStyle.Fill;
            btnStopGame.FlatStyle = FlatStyle.Flat;
            btnStopGame.Location = new Point(3, 3);
            btnStopGame.Name = "btnStopGame";
            btnStopGame.Size = new Size(189, 72);
            btnStopGame.TabIndex = 0;
            btnStopGame.Text = "Stop Game";
            btnStopGame.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(198, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(190, 72);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnShutDown
            // 
            btnShutDown.BackColor = Color.Firebrick;
            btnShutDown.Dock = DockStyle.Fill;
            btnShutDown.FlatStyle = FlatStyle.Popup;
            btnShutDown.ForeColor = Color.White;
            btnShutDown.Location = new Point(0, 0);
            btnShutDown.Name = "btnShutDown";
            btnShutDown.Size = new Size(391, 71);
            btnShutDown.TabIndex = 1;
            btnShutDown.Text = "Shut Dwn Server";
            btnShutDown.UseVisualStyleBackColor = false;
            // 
            // MultiplayerGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MultiplayerGame";
            Text = "MultiplayerGame";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox canvas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label lblScoreboard;
        private Label lblSpeedModifier;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private Button btnShutDown;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnStart;
        private Button btnStopGame;
        private Label lblTime;
        private Label lblPlayerCount;
        private Label lblIP;
    }
}