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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnDC = new Button();
            lblScoreboard = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblTitle = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblPort = new Label();
            lblClientIP = new Label();
            lblHostIP = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1020, 604);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.9722939F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.0277061F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1014, 477);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 471);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDC);
            panel1.Controls.Add(lblScoreboard);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(641, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 471);
            panel1.TabIndex = 1;
            // 
            // btnDC
            // 
            btnDC.BackColor = Color.Red;
            btnDC.Dock = DockStyle.Bottom;
            btnDC.FlatStyle = FlatStyle.Flat;
            btnDC.ForeColor = Color.Black;
            btnDC.Location = new Point(0, 395);
            btnDC.Name = "btnDC";
            btnDC.Size = new Size(370, 76);
            btnDC.TabIndex = 2;
            btnDC.Text = "Disconnect";
            btnDC.UseVisualStyleBackColor = false;
            // 
            // lblScoreboard
            // 
            lblScoreboard.Dock = DockStyle.Top;
            lblScoreboard.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreboard.ForeColor = Color.Lime;
            lblScoreboard.Location = new Point(0, 0);
            lblScoreboard.Name = "lblScoreboard";
            lblScoreboard.Size = new Size(370, 40);
            lblScoreboard.TabIndex = 1;
            lblScoreboard.Text = "Scores:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Location = new Point(3, 43);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(367, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1014, 60);
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
            tableLayoutPanel4.Location = new Point(3, 546);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1014, 55);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // lblPort
            // 
            lblPort.Dock = DockStyle.Fill;
            lblPort.Font = new Font("Segoe UI", 14F);
            lblPort.ForeColor = Color.Lime;
            lblPort.Location = new Point(679, 0);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(332, 55);
            lblPort.TabIndex = 2;
            lblPort.Text = "Port:";
            lblPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClientIP
            // 
            lblClientIP.Dock = DockStyle.Fill;
            lblClientIP.Font = new Font("Segoe UI", 14F);
            lblClientIP.ForeColor = Color.Lime;
            lblClientIP.Location = new Point(341, 0);
            lblClientIP.Name = "lblClientIP";
            lblClientIP.Size = new Size(332, 55);
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
            lblHostIP.Size = new Size(332, 55);
            lblHostIP.TabIndex = 0;
            lblHostIP.Text = "Host IP:";
            lblHostIP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SerpentClientGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 604);
            Controls.Add(tableLayoutPanel1);
            Name = "SerpentClientGame";
            Text = "SerpentClientGame";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Panel panel1;
        private Label lblScoreboard;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblPort;
        private Label lblClientIP;
        private Label lblHostIP;
        private Button btnDC;
    }
}