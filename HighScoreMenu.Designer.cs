namespace QuantumSerpent
{
    partial class HighScoreMenu
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
            label1 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDiscard = new Button();
            btnSave = new Button();
            label2 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(15, 15, 15);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(409, 61);
            label1.TabIndex = 1;
            label1.Text = "High Scores:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(0, 70);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(204, 141);
            flowLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnDiscard, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 253);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(415, 58);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnDiscard
            // 
            btnDiscard.BackColor = Color.FromArgb(15, 15, 15);
            btnDiscard.Dock = DockStyle.Fill;
            btnDiscard.FlatStyle = FlatStyle.Flat;
            btnDiscard.ForeColor = Color.Aqua;
            btnDiscard.Location = new Point(3, 3);
            btnDiscard.Name = "btnDiscard";
            btnDiscard.Size = new Size(201, 52);
            btnDiscard.TabIndex = 4;
            btnDiscard.Text = "Don't Save";
            btnDiscard.UseVisualStyleBackColor = false;
            btnDiscard.Click += BtnDiscard_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(15, 15, 15);
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Aqua;
            btnSave.Location = new Point(210, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(202, 52);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Score";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(0, 214);
            label2.Name = "label2";
            label2.Size = new Size(415, 36);
            label2.TabIndex = 0;
            label2.Text = "Your Score: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 67);
            panel1.TabIndex = 4;
            // 
            // HighScoreMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(415, 311);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel);
            Name = "HighScoreMenu";
            Text = "HighScoreMenu";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button btnDiscard;
        private Button btnSave;
        private Panel panel1;
    }
}