namespace QuantumSerpent
{
    partial class FrmGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            canvas = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            pnlTitleBackground = new Panel();
            lblTitle = new Label();
            pnlCanvasBG = new Panel();
            tLPGameStats = new TableLayoutPanel();
            lblScore = new Label();
            label2 = new Label();
            label3 = new Label();
            tLPSettings = new TableLayoutPanel();
            lblDifficulty = new Label();
            txtName2 = new TextBox();
            lblPlayer1 = new Label();
            lblBots = new Label();
            lblPlayer2 = new Label();
            txtName1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            chkBot1 = new CheckBox();
            chkBot2 = new CheckBox();
            btnDifficulty = new Button();
            pnlSettingsBG = new Panel();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            pnlTitleBackground.SuspendLayout();
            pnlCanvasBG.SuspendLayout();
            tLPGameStats.SuspendLayout();
            tLPSettings.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            pnlSettingsBG.SuspendLayout();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.BackColor = Color.FromArgb(15, 15, 15);
            canvas.Location = new Point(3, 2);
            canvas.Margin = new Padding(3, 2, 3, 2);
            canvas.MaximumSize = new Size(500, 500);
            canvas.Name = "canvas";
            canvas.Size = new Size(500, 500);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += Canvas_Paint;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 166;
            gameTimer.Tick += GameTimer_Tick;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStart.BackColor = Color.FromArgb(15, 15, 15);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.LimeGreen;
            btnStart.Location = new Point(808, 513);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(207, 65);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // pnlTitleBackground
            // 
            pnlTitleBackground.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTitleBackground.BackColor = Color.Aqua;
            pnlTitleBackground.Controls.Add(lblTitle);
            pnlTitleBackground.Location = new Point(512, 0);
            pnlTitleBackground.Name = "pnlTitleBackground";
            pnlTitleBackground.Size = new Size(505, 93);
            pnlTitleBackground.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.BackColor = Color.FromArgb(15, 15, 15);
            lblTitle.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Aqua;
            lblTitle.Location = new Point(3, 3);
            lblTitle.Margin = new Padding(3);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(3);
            lblTitle.Size = new Size(499, 87);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quantum Serpent";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCanvasBG
            // 
            pnlCanvasBG.BackColor = Color.Aqua;
            pnlCanvasBG.Controls.Add(tLPGameStats);
            pnlCanvasBG.Controls.Add(canvas);
            pnlCanvasBG.Dock = DockStyle.Left;
            pnlCanvasBG.Location = new Point(0, 0);
            pnlCanvasBG.Name = "pnlCanvasBG";
            pnlCanvasBG.Size = new Size(506, 581);
            pnlCanvasBG.TabIndex = 5;
            // 
            // tLPGameStats
            // 
            tLPGameStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tLPGameStats.BackColor = Color.FromArgb(15, 15, 15);
            tLPGameStats.ColumnCount = 3;
            tLPGameStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tLPGameStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tLPGameStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tLPGameStats.Controls.Add(lblScore, 0, 0);
            tLPGameStats.Controls.Add(label2, 1, 0);
            tLPGameStats.Controls.Add(label3, 2, 0);
            tLPGameStats.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tLPGameStats.Location = new Point(3, 507);
            tLPGameStats.Name = "tLPGameStats";
            tLPGameStats.RowCount = 1;
            tLPGameStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLPGameStats.Size = new Size(500, 71);
            tLPGameStats.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Dock = DockStyle.Fill;
            lblScore.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.LimeGreen;
            lblScore.Location = new Point(3, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(160, 71);
            lblScore.TabIndex = 0;
            lblScore.Text = "Player 1:";
            lblScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(169, 0);
            label2.Name = "label2";
            label2.Size = new Size(160, 71);
            label2.TabIndex = 1;
            label2.Text = "Player 2:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(335, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 71);
            label3.TabIndex = 2;
            label3.Text = "Speed:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tLPSettings
            // 
            tLPSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tLPSettings.BackColor = Color.FromArgb(15, 15, 15);
            tLPSettings.ColumnCount = 2;
            tLPSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.647295F));
            tLPSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.35271F));
            tLPSettings.Controls.Add(lblDifficulty, 0, 3);
            tLPSettings.Controls.Add(txtName2, 1, 1);
            tLPSettings.Controls.Add(lblPlayer1, 0, 0);
            tLPSettings.Controls.Add(lblBots, 0, 2);
            tLPSettings.Controls.Add(lblPlayer2, 0, 1);
            tLPSettings.Controls.Add(txtName1, 1, 0);
            tLPSettings.Controls.Add(tableLayoutPanel3, 1, 2);
            tLPSettings.Controls.Add(btnDifficulty, 1, 3);
            tLPSettings.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tLPSettings.Location = new Point(3, 3);
            tLPSettings.Name = "tLPSettings";
            tLPSettings.RowCount = 4;
            tLPSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 25.000618F));
            tLPSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006256F));
            tLPSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006256F));
            tLPSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 24.9981289F));
            tLPSettings.Size = new Size(499, 227);
            tLPSettings.TabIndex = 6;
            // 
            // lblDifficulty
            // 
            lblDifficulty.Dock = DockStyle.Fill;
            lblDifficulty.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblDifficulty.ForeColor = Color.Aqua;
            lblDifficulty.Location = new Point(3, 168);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(112, 59);
            lblDifficulty.TabIndex = 6;
            lblDifficulty.Text = "Diffculty";
            lblDifficulty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName2
            // 
            txtName2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName2.BackColor = Color.FromArgb(15, 15, 15);
            txtName2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            txtName2.ForeColor = Color.Aqua;
            txtName2.Location = new Point(121, 64);
            txtName2.MaxLength = 16;
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(375, 39);
            txtName2.TabIndex = 4;
            // 
            // lblPlayer1
            // 
            lblPlayer1.Dock = DockStyle.Fill;
            lblPlayer1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPlayer1.ForeColor = Color.Aqua;
            lblPlayer1.Location = new Point(3, 0);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(112, 56);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "Player 1:";
            lblPlayer1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBots
            // 
            lblBots.Dock = DockStyle.Fill;
            lblBots.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblBots.ForeColor = Color.Aqua;
            lblBots.Location = new Point(3, 112);
            lblBots.Name = "lblBots";
            lblBots.Size = new Size(112, 56);
            lblBots.TabIndex = 2;
            lblBots.Text = "Bots";
            lblBots.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlayer2
            // 
            lblPlayer2.Dock = DockStyle.Fill;
            lblPlayer2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPlayer2.ForeColor = Color.Aqua;
            lblPlayer2.Location = new Point(3, 56);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(112, 56);
            lblPlayer2.TabIndex = 1;
            lblPlayer2.Text = "Player 2:";
            lblPlayer2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName1
            // 
            txtName1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName1.BackColor = Color.FromArgb(15, 15, 15);
            txtName1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            txtName1.ForeColor = Color.Aqua;
            txtName1.Location = new Point(121, 8);
            txtName1.MaxLength = 16;
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(375, 39);
            txtName1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(chkBot1, 0, 0);
            tableLayoutPanel3.Controls.Add(chkBot2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(121, 115);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(375, 50);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // chkBot1
            // 
            chkBot1.Anchor = AnchorStyles.Left;
            chkBot1.AutoSize = true;
            chkBot1.FlatAppearance.BorderColor = Color.Aqua;
            chkBot1.FlatAppearance.BorderSize = 2;
            chkBot1.FlatStyle = FlatStyle.Popup;
            chkBot1.Font = new Font("Segoe UI", 18F);
            chkBot1.ForeColor = Color.Aqua;
            chkBot1.Location = new Point(3, 7);
            chkBot1.Name = "chkBot1";
            chkBot1.Size = new Size(174, 36);
            chkBot1.TabIndex = 0;
            chkBot1.Text = "Bot 1 (Dumb)";
            chkBot1.UseVisualStyleBackColor = true;
            // 
            // chkBot2
            // 
            chkBot2.Anchor = AnchorStyles.Left;
            chkBot2.AutoSize = true;
            chkBot2.FlatAppearance.BorderColor = Color.Aqua;
            chkBot2.FlatAppearance.BorderSize = 2;
            chkBot2.FlatStyle = FlatStyle.Popup;
            chkBot2.Font = new Font("Segoe UI", 18F);
            chkBot2.ForeColor = Color.Aqua;
            chkBot2.Location = new Point(190, 7);
            chkBot2.Name = "chkBot2";
            chkBot2.Size = new Size(170, 36);
            chkBot2.TabIndex = 1;
            chkBot2.Text = "Bot 2 (Smart)";
            chkBot2.UseVisualStyleBackColor = true;
            // 
            // btnDifficulty
            // 
            btnDifficulty.Dock = DockStyle.Fill;
            btnDifficulty.FlatStyle = FlatStyle.Flat;
            btnDifficulty.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDifficulty.ForeColor = Color.LimeGreen;
            btnDifficulty.Location = new Point(121, 171);
            btnDifficulty.Name = "btnDifficulty";
            btnDifficulty.Size = new Size(375, 53);
            btnDifficulty.TabIndex = 7;
            btnDifficulty.Text = "The Last Serpent";
            btnDifficulty.UseVisualStyleBackColor = true;
            btnDifficulty.Click += BtnDifficulty_Click;
            // 
            // pnlSettingsBG
            // 
            pnlSettingsBG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSettingsBG.BackColor = Color.Aqua;
            pnlSettingsBG.Controls.Add(tLPSettings);
            pnlSettingsBG.Location = new Point(512, 110);
            pnlSettingsBG.Name = "pnlSettingsBG";
            pnlSettingsBG.Size = new Size(505, 233);
            pnlSettingsBG.TabIndex = 7;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1020, 581);
            Controls.Add(pnlTitleBackground);
            Controls.Add(btnStart);
            Controls.Add(pnlCanvasBG);
            Controls.Add(pnlSettingsBG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(500, 500);
            Name = "FrmGame";
            Text = "FrmGame";
            Load += FrmGame_Load;
            KeyDown += FrmGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            pnlTitleBackground.ResumeLayout(false);
            pnlCanvasBG.ResumeLayout(false);
            tLPGameStats.ResumeLayout(false);
            tLPGameStats.PerformLayout();
            tLPSettings.ResumeLayout(false);
            tLPSettings.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            pnlSettingsBG.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private System.Windows.Forms.Timer gameTimer;
        private Button btnStart;
        private Panel pnlTitleBackground;
        private Label lblTitle;
        private Panel pnlCanvasBG;
        private TableLayoutPanel tLPGameStats;
        private Label lblScore;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tLPSettings;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Panel pnlSettingsBG;
        private Label lblBots;
        private TextBox txtName2;
        private TextBox txtName1;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox chkBot1;
        private CheckBox chkBot2;
        private Label lblDifficulty;
        private Button btnDifficulty;
    }
}
