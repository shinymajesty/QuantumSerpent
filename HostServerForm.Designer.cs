namespace QuantumSerpent
{
    partial class HostServerForm
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
            panel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            nUP_Interval = new NumericUpDown();
            lblInterval = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            nUD_initLength = new NumericUpDown();
            lblLength = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            trackBar_PlayerCount = new TrackBar();
            lblSliderCountVal = new Label();
            label2 = new Label();
            rTB_Name = new RichTextBox();
            label1 = new Label();
            lblTitle = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnLaunch = new Button();
            btnBack = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUP_Interval).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_initLength).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_PlayerCount).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(15, 15, 15);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(529, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(lblInterval);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(lblLength);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rTB_Name);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(29, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 354);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(nUP_Interval, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 256);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(470, 38);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // nUP_Interval
            // 
            nUP_Interval.BackColor = Color.FromArgb(15, 15, 15);
            nUP_Interval.Font = new Font("Segoe UI", 14F);
            nUP_Interval.ForeColor = Color.White;
            nUP_Interval.Location = new Point(3, 3);
            nUP_Interval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nUP_Interval.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nUP_Interval.Name = "nUP_Interval";
            nUP_Interval.Size = new Size(56, 32);
            nUP_Interval.TabIndex = 6;
            nUP_Interval.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lblInterval
            // 
            lblInterval.Dock = DockStyle.Top;
            lblInterval.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblInterval.ForeColor = Color.White;
            lblInterval.ImageAlign = ContentAlignment.MiddleLeft;
            lblInterval.Location = new Point(0, 222);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(470, 34);
            lblInterval.TabIndex = 9;
            lblInterval.Text = "Timer Interval";
            lblInterval.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(nUD_initLength, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 184);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(470, 38);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // nUD_initLength
            // 
            nUD_initLength.BackColor = Color.FromArgb(15, 15, 15);
            nUD_initLength.Font = new Font("Segoe UI", 14F);
            nUD_initLength.ForeColor = Color.White;
            nUD_initLength.Location = new Point(3, 3);
            nUD_initLength.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nUD_initLength.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nUD_initLength.Name = "nUD_initLength";
            nUD_initLength.Size = new Size(56, 32);
            nUD_initLength.TabIndex = 6;
            nUD_initLength.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblLength
            // 
            lblLength.Dock = DockStyle.Top;
            lblLength.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblLength.ForeColor = Color.White;
            lblLength.ImageAlign = ContentAlignment.MiddleLeft;
            lblLength.Location = new Point(0, 150);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(470, 34);
            lblLength.TabIndex = 7;
            lblLength.Text = "Initial Length";
            lblLength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(trackBar_PlayerCount, 0, 0);
            tableLayoutPanel3.Controls.Add(lblSliderCountVal, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.ForeColor = Color.FromArgb(15, 15, 15);
            tableLayoutPanel3.Location = new Point(0, 102);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(470, 48);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // trackBar_PlayerCount
            // 
            trackBar_PlayerCount.Location = new Point(3, 3);
            trackBar_PlayerCount.Maximum = 4;
            trackBar_PlayerCount.Minimum = 1;
            trackBar_PlayerCount.Name = "trackBar_PlayerCount";
            trackBar_PlayerCount.Size = new Size(229, 42);
            trackBar_PlayerCount.TabIndex = 3;
            trackBar_PlayerCount.Value = 2;
            trackBar_PlayerCount.ValueChanged += trackBar_PlayerCount_ValueChanged;
            // 
            // lblSliderCountVal
            // 
            lblSliderCountVal.Dock = DockStyle.Fill;
            lblSliderCountVal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSliderCountVal.ForeColor = Color.White;
            lblSliderCountVal.Location = new Point(238, 0);
            lblSliderCountVal.Name = "lblSliderCountVal";
            lblSliderCountVal.Size = new Size(229, 48);
            lblSliderCountVal.TabIndex = 4;
            lblSliderCountVal.Text = "Selected: 2";
            lblSliderCountVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(0, 68);
            label2.Name = "label2";
            label2.Size = new Size(470, 34);
            label2.TabIndex = 2;
            label2.Text = "Player Count";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rTB_Name
            // 
            rTB_Name.BackColor = Color.FromArgb(15, 15, 15);
            rTB_Name.Dock = DockStyle.Top;
            rTB_Name.Font = new Font("Segoe UI", 14F);
            rTB_Name.ForeColor = Color.White;
            rTB_Name.Location = new Point(0, 34);
            rTB_Name.Multiline = false;
            rTB_Name.Name = "rTB_Name";
            rTB_Name.ScrollBars = RichTextBoxScrollBars.None;
            rTB_Name.Size = new Size(470, 34);
            rTB_Name.TabIndex = 1;
            rTB_Name.Text = "";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(470, 34);
            label1.TabIndex = 0;
            label1.Text = "Host Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(224, 224, 224);
            lblTitle.Location = new Point(29, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(470, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Setup Host";
            lblTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnLaunch, 1, 0);
            tableLayoutPanel2.Controls.Add(btnBack, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(29, 408);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(470, 39);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnLaunch
            // 
            btnLaunch.Dock = DockStyle.Fill;
            btnLaunch.FlatStyle = FlatStyle.Flat;
            btnLaunch.Font = new Font("Segoe UI", 14F);
            btnLaunch.ForeColor = Color.Red;
            btnLaunch.Location = new Point(238, 3);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(229, 33);
            btnLaunch.TabIndex = 1;
            btnLaunch.Text = "Go Live!";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.ForeColor = Color.FromArgb(224, 224, 224);
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(229, 33);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // HostServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "HostServerForm";
            Text = "HostServerForm";
            FormClosed += HostServerForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUP_Interval).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUD_initLength).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_PlayerCount).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnLaunch;
        private Button btnBack;
        private RichTextBox rTB_Name;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private TrackBar trackBar_PlayerCount;
        private Label lblSliderCountVal;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private NumericUpDown nUP_Interval;
        private Label lblInterval;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown nUD_initLength;
        private Label lblLength;
    }
}