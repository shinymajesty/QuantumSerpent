namespace QuantumSerpent
{
    partial class SinglePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinglePlayer));
            canvas = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            pnlTitleBackground = new Panel();
            lblTitle = new Label();
            pnlCanvasBG = new Panel();
            lblMSG = new Label();
            tLPGameStats = new TableLayoutPanel();
            tLPSettings = new TableLayoutPanel();
            lblPlayer1 = new Label();
            lblDifficulty = new Label();
            lblBots = new Label();
            txtName1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            chkBot1 = new CheckBox();
            chkBot2 = new CheckBox();
            btnDifficulty = new Button();
            btnSpawn = new Button();
            pnlSettingsBG = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBack = new Button();
            BtnReset = new Button();
            scoreboardTBL = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            pnlTitleBackground.SuspendLayout();
            pnlCanvasBG.SuspendLayout();
            tLPSettings.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            pnlSettingsBG.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.BackColor = Color.FromArgb(15, 15, 15);
            canvas.BackgroundImage = Properties.Resources.tiles;
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
            gameTimer.Interval = 250;
            gameTimer.Tick += GameTimer_Tick;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(15, 15, 15);
            btnStart.Dock = DockStyle.Fill;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.LimeGreen;
            btnStart.Location = new Point(255, 2);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(247, 67);
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
            pnlCanvasBG.Controls.Add(lblMSG);
            pnlCanvasBG.Controls.Add(canvas);
            pnlCanvasBG.Controls.Add(tLPGameStats);
            pnlCanvasBG.Dock = DockStyle.Left;
            pnlCanvasBG.Location = new Point(0, 0);
            pnlCanvasBG.Name = "pnlCanvasBG";
            pnlCanvasBG.Size = new Size(506, 581);
            pnlCanvasBG.TabIndex = 5;
            // 
            // lblMSG
            // 
            lblMSG.BackColor = Color.Black;
            lblMSG.Font = new Font("Segoe UI", 24F);
            lblMSG.ForeColor = Color.Red;
            lblMSG.Location = new Point(6, 235);
            lblMSG.Name = "lblMSG";
            lblMSG.Size = new Size(497, 62);
            lblMSG.TabIndex = 8;
            lblMSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tLPGameStats
            // 
            tLPGameStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tLPGameStats.BackColor = Color.FromArgb(15, 15, 15);
            tLPGameStats.ColumnCount = 3;
            tLPGameStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tLPGameStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tLPGameStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tLPGameStats.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tLPGameStats.Location = new Point(3, 507);
            tLPGameStats.Name = "tLPGameStats";
            tLPGameStats.RowCount = 1;
            tLPGameStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLPGameStats.Size = new Size(500, 71);
            tLPGameStats.TabIndex = 1;
            // 
            // tLPSettings
            // 
            tLPSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tLPSettings.BackColor = Color.FromArgb(15, 15, 15);
            tLPSettings.ColumnCount = 2;
            tLPSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.647295F));
            tLPSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.35271F));
            tLPSettings.Controls.Add(lblPlayer1, 0, 0);
            tLPSettings.Controls.Add(lblDifficulty, 0, 3);
            tLPSettings.Controls.Add(lblBots, 0, 2);
            tLPSettings.Controls.Add(txtName1, 1, 0);
            tLPSettings.Controls.Add(tableLayoutPanel3, 1, 2);
            tLPSettings.Controls.Add(btnDifficulty, 1, 3);
            tLPSettings.Controls.Add(btnSpawn, 1, 1);
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
            // lblPlayer1
            // 
            lblPlayer1.Dock = DockStyle.Fill;
            lblPlayer1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPlayer1.ForeColor = Color.Aqua;
            lblPlayer1.Location = new Point(3, 0);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(112, 56);
            lblPlayer1.TabIndex = 9;
            lblPlayer1.Text = "Name:";
            lblPlayer1.TextAlign = ContentAlignment.MiddleLeft;
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
            chkBot1.Size = new Size(87, 36);
            chkBot1.TabIndex = 0;
            chkBot1.Text = "Bot 1";
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
            chkBot2.Size = new Size(94, 36);
            chkBot2.TabIndex = 1;
            chkBot2.Text = "Bot 2 ";
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
            // btnSpawn
            // 
            btnSpawn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSpawn.FlatStyle = FlatStyle.Flat;
            btnSpawn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpawn.ForeColor = Color.LimeGreen;
            btnSpawn.Location = new Point(293, 59);
            btnSpawn.Name = "btnSpawn";
            btnSpawn.Size = new Size(203, 50);
            btnSpawn.TabIndex = 8;
            btnSpawn.Text = "Add Player";
            btnSpawn.UseVisualStyleBackColor = true;
            btnSpawn.Click += BtnAddPlayer_Click;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnBack, 0, 0);
            tableLayoutPanel1.Controls.Add(btnStart, 1, 0);
            tableLayoutPanel1.Location = new Point(512, 507);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(505, 71);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(15, 15, 15);
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(3, 2);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(246, 67);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.FromArgb(15, 15, 15);
            BtnReset.FlatStyle = FlatStyle.Flat;
            BtnReset.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReset.ForeColor = Color.LimeGreen;
            BtnReset.Location = new Point(808, 345);
            BtnReset.Margin = new Padding(3, 2, 3, 2);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(203, 59);
            BtnReset.TabIndex = 9;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click;
            // 
            // scoreboardTBL
            // 
            scoreboardTBL.BackColor = Color.FromArgb(15, 15, 15);
            scoreboardTBL.ColumnCount = 2;
            scoreboardTBL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            scoreboardTBL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            scoreboardTBL.Dock = DockStyle.Fill;
            scoreboardTBL.Location = new Point(0, 0);
            scoreboardTBL.Name = "scoreboardTBL";
            scoreboardTBL.RowCount = 1;
            scoreboardTBL.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            scoreboardTBL.Size = new Size(200, 100);
            scoreboardTBL.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(scoreboardTBL);
            panel1.Location = new Point(515, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 11;
            // 
            // SinglePlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1020, 581);
            Controls.Add(panel1);
            Controls.Add(BtnReset);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlTitleBackground);
            Controls.Add(pnlCanvasBG);
            Controls.Add(pnlSettingsBG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(500, 500);
            Name = "SinglePlayer";
            Text = "FrmGame";
            FormClosed += SinglePlayer_FormClosed;
            Load += FrmGame_Load;
            KeyDown += FrmGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            pnlTitleBackground.ResumeLayout(false);
            pnlCanvasBG.ResumeLayout(false);
            tLPSettings.ResumeLayout(false);
            tLPSettings.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            pnlSettingsBG.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;

        public PictureBox buffer { get; private set; }

        private System.Windows.Forms.Timer gameTimer;
        private Button btnStart;
        private Panel pnlTitleBackground;
        private Label lblTitle;
        private Panel pnlCanvasBG;
        private TableLayoutPanel tLPGameStats;
        private TableLayoutPanel tLPSettings;
        private Panel pnlSettingsBG;
        private Label lblBots;
        private TextBox txtName1;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox chkBot1;
        private CheckBox chkBot2;
        private Label lblDifficulty;
        private Button btnDifficulty;
        private Label lblMSG;
        private Button btnSpawn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBack;
        private Label lblPlayer1;
        private Button BtnReset;
        private TableLayoutPanel scoreboardTBL;
        private Panel panel1;
    }
}
