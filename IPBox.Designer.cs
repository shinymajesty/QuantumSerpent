namespace QuantumSerpent
{
    partial class IPBox
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
            lblTitle = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblIP = new Label();
            txtIP = new RichTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtPort = new RichTextBox();
            lblPort = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCnt = new Button();
            btnBack = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5531921F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.9148941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(366, 211);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enter Host IP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(360, 114);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.67F));
            tableLayoutPanel3.Controls.Add(lblIP, 0, 0);
            tableLayoutPanel3.Controls.Add(txtIP, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(354, 51);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblIP
            // 
            lblIP.Dock = DockStyle.Fill;
            lblIP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblIP.ForeColor = Color.White;
            lblIP.Location = new Point(3, 0);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(111, 51);
            lblIP.TabIndex = 0;
            lblIP.Text = "Host IP:";
            lblIP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtIP
            // 
            txtIP.BackColor = Color.FromArgb(15, 15, 15);
            txtIP.Dock = DockStyle.Fill;
            txtIP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtIP.ForeColor = Color.Blue;
            txtIP.Location = new Point(120, 3);
            txtIP.Multiline = false;
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(231, 45);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.67F));
            tableLayoutPanel4.Controls.Add(txtPort, 1, 0);
            tableLayoutPanel4.Controls.Add(lblPort, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 60);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(354, 51);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // txtPort
            // 
            txtPort.BackColor = Color.FromArgb(15, 15, 15);
            txtPort.Dock = DockStyle.Fill;
            txtPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            txtPort.ForeColor = Color.Blue;
            txtPort.Location = new Point(120, 3);
            txtPort.Multiline = false;
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(231, 45);
            txtPort.TabIndex = 2;
            txtPort.Text = "9876";
            // 
            // lblPort
            // 
            lblPort.Dock = DockStyle.Fill;
            lblPort.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPort.ForeColor = Color.White;
            lblPort.Location = new Point(3, 0);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(111, 51);
            lblPort.TabIndex = 0;
            lblPort.Text = "Port:";
            lblPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.61111F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.3888855F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 160);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(360, 48);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(btnCnt, 1, 0);
            tableLayoutPanel6.Controls.Add(btnBack, 0, 0);
            tableLayoutPanel6.Location = new Point(124, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(230, 42);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCnt
            // 
            btnCnt.Dock = DockStyle.Fill;
            btnCnt.FlatStyle = FlatStyle.Flat;
            btnCnt.Font = new Font("Segoe UI", 14F);
            btnCnt.ForeColor = Color.Lime;
            btnCnt.Location = new Point(118, 3);
            btnCnt.Name = "btnCnt";
            btnCnt.Size = new Size(109, 36);
            btnCnt.TabIndex = 1;
            btnCnt.Text = "Connect";
            btnCnt.UseVisualStyleBackColor = true;
            btnCnt.Click += btnCnt_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 36);
            btnBack.TabIndex = 0;
            btnBack.Text = "Cancel";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // IPBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(366, 211);
            Controls.Add(tableLayoutPanel1);
            Name = "IPBox";
            Text = "Enter Host IP";
            FormClosed += IPBox_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblIP;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblPort;
        private RichTextBox txtIP;
        private RichTextBox txtPort;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnCnt;
        private Button btnBack;
    }
}