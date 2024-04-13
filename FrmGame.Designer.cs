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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblScore = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
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
            btnStart.Location = new Point(807, 513);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(207, 65);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(512, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 93);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(15, 15, 15);
            label1.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(499, 87);
            label1.TabIndex = 0;
            label1.Text = "Quantum Serpent";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(canvas);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 581);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(15, 15, 15);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lblScore, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(3, 507);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(500, 71);
            tableLayoutPanel1.TabIndex = 1;
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
            lblScore.Text = "Score: 0";
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
            label2.Text = "Speed: 15";
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
            label3.Text = "Player1";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(15, 15, 15);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.647295F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.35271F));
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(499, 227);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox2.ForeColor = Color.Aqua;
            textBox2.Location = new Point(121, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 39);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 75);
            label4.TabIndex = 0;
            label4.Text = "Player 1:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(3, 150);
            label6.Name = "label6";
            label6.Size = new Size(112, 77);
            label6.TabIndex = 2;
            label6.Text = "Bots";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(3, 75);
            label5.Name = "label5";
            label5.Size = new Size(112, 75);
            label5.TabIndex = 1;
            label5.Text = "Player 2:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.BackColor = Color.FromArgb(15, 15, 15);
            textBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBox1.ForeColor = Color.Aqua;
            textBox1.Location = new Point(121, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 39);
            textBox1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(checkBox2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(121, 153);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(375, 71);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.FlatAppearance.BorderColor = Color.Aqua;
            checkBox1.FlatAppearance.BorderSize = 2;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Font = new Font("Segoe UI", 18F);
            checkBox1.ForeColor = Color.Aqua;
            checkBox1.Location = new Point(3, 17);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Bot 1 (Dumb)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Left;
            checkBox2.AutoSize = true;
            checkBox2.FlatAppearance.BorderColor = Color.Aqua;
            checkBox2.FlatAppearance.BorderSize = 2;
            checkBox2.FlatStyle = FlatStyle.Popup;
            checkBox2.Font = new Font("Segoe UI", 18F);
            checkBox2.ForeColor = Color.Aqua;
            checkBox2.Location = new Point(190, 17);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(170, 36);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Bot 2 (Smart)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aqua;
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Location = new Point(512, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(511, 233);
            panel3.TabIndex = 7;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1019, 581);
            Controls.Add(panel1);
            Controls.Add(btnStart);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(500, 500);
            Name = "FrmGame";
            Text = "FrmGame";
            KeyDown += FrmGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private System.Windows.Forms.Timer gameTimer;
        private Button btnStart;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblScore;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
