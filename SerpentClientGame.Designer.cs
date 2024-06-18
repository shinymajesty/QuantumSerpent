namespace QuantumSerpent
{
    partial class SerpentClientGame
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
            tableLayoutPanel2 = new TableLayoutPanel();
            canvas = new PictureBox();
            panel1 = new Panel();
            lblScoreboard = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            txtName = new RichTextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnJoin = new Button();
            btnDC = new Button();
            scoreboard = new TableLayoutPanel();
            lblTitle = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblPort = new Label();
            lblClientIP = new Label();
            lblHostIP = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(15, 15, 15);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1031, 631);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(canvas, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 66);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1025, 498);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // canvas
            // 
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(3, 3);
            canvas.Name = "canvas";
            canvas.Size = new Size(506, 492);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblScoreboard);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(btnDC);
            panel1.Controls.Add(scoreboard);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(515, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 456);
            panel1.TabIndex = 1;
            // 
            // lblScoreboard
            // 
            lblScoreboard.Dock = DockStyle.Top;
            lblScoreboard.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreboard.ForeColor = Color.Lime;
            lblScoreboard.Location = new Point(0, 0);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(507, 40);
            lblScoreboard.TabIndex = 1;
            lblScoreboard.Text = "Scores:";
            lblScoreboard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 0);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 142);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(502, 115);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9050274F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.09497F));
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(txtName, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(496, 51);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 51);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(25, 25, 25);
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.ForeColor = Color.Lime;
            txtName.Location = new Point(116, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(377, 45);
            txtName.TabIndex = 3;
            txtName.Text = "";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.69307F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.30693F));
            tableLayoutPanel6.Controls.Add(btnJoin, 1, 0);
            tableLayoutPanel6.Location = new Point(3, 60);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(496, 52);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnJoin
            // 
            btnJoin.Dock = DockStyle.Fill;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.ForeColor = Color.Lime;
            btnJoin.Location = new Point(254, 3);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(239, 46);
            btnJoin.TabIndex = 0;
            btnJoin.Text = "Join!";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // btnDC
            // 
            btnDC.BackColor = Color.Red;
            btnDC.Dock = DockStyle.Bottom;
            btnDC.FlatStyle = FlatStyle.Flat;
            btnDC.ForeColor = Color.Black;
            btnDC.Location = new Point(0, 380);
            btnDC.Name = "btnDC";
            btnDC.Size = new Size(507, 76);
            btnDC.TabIndex = 2;
            btnDC.Text = "Disconnect";
            btnDC.UseVisualStyleBackColor = false;
            btnDC.Click += btnDC_Click;
            // 
            // scoreboard
            // 
            scoreboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            scoreboard.ColumnCount = 2;
            scoreboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            scoreboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            scoreboard.Location = new Point(3, 43);
            scoreboard.Name = "scoreboard";
            scoreboard.RowCount = 1;
            scoreboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            scoreboard.Size = new Size(504, 93);
            scoreboard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1025, 63);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Connected to Server:";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(lblPort, 2, 0);
            tableLayoutPanel4.Controls.Add(lblClientIP, 1, 0);
            tableLayoutPanel4.Controls.Add(lblHostIP, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 570);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1025, 58);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // lblPort
            // 
            lblPort.Dock = DockStyle.Fill;
            lblPort.Font = new Font("Segoe UI", 14F);
            lblPort.ForeColor = Color.Lime;
            lblPort.Location = new Point(685, 0);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(337, 58);
            lblPort.TabIndex = 2;
            lblPort.Text = "Port:";
            lblPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClientIP
            // 
            lblClientIP.Dock = DockStyle.Fill;
            lblClientIP.Font = new Font("Segoe UI", 14F);
            lblClientIP.ForeColor = Color.Lime;
            lblClientIP.Location = new Point(344, 0);
            lblClientIP.Name = "lblClientIP";
            lblClientIP.Size = new Size(335, 58);
            lblClientIP.TabIndex = 1;
            lblClientIP.Text = "Client IP:";
            lblClientIP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHostIP
            // 
            lblHostIP.Dock = DockStyle.Fill;
            lblHostIP.Font = new Font("Segoe UI", 14F);
            lblHostIP.ForeColor = Color.Lime;
            lblHostIP.Location = new Point(3, 0);
            lblHostIP.Name = "lblHostIP";
            lblHostIP.Size = new Size(335, 58);
            lblHostIP.TabIndex = 0;
            lblHostIP.Text = "Host IP:";
            lblHostIP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SerpentClientGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 631);
            Controls.Add(tableLayoutPanel1);
            KeyPreview = true;
            Name = "SerpentClientGame";
            Text = "SerpentClientGame";
            KeyDown += SerpentClientGame_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox canvas;
        private Label lblTitle;
        private Panel panel1;
        private Label lblScoreboard;
        private TableLayoutPanel scoreboard;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblPort;
        private Label lblClientIP;
        private Label lblHostIP;
        private Button btnDC;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private RichTextBox txtName;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnJoin;
    }
}