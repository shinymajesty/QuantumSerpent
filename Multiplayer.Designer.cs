namespace QuantumSerpent
{
    partial class Multiplayer
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
            pnlMenu1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnJoin = new Button();
            btnHost = new Button();
            pnael1 = new Panel();
            listView1 = new ListView();
            btnBack = new Button();
            pnlMenu1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnael1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu1
            // 
            pnlMenu1.Controls.Add(tableLayoutPanel1);
            pnlMenu1.Dock = DockStyle.Fill;
            pnlMenu1.Location = new Point(0, 0);
            pnlMenu1.Name = "pnlMenu1";
            pnlMenu1.Size = new Size(800, 450);
            pnlMenu1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(pnael1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.Controls.Add(btnBack, 0, 0);
            tableLayoutPanel2.Controls.Add(btnJoin, 2, 0);
            tableLayoutPanel2.Controls.Add(btnHost, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(163, 408);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(474, 39);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnJoin
            // 
            btnJoin.Dock = DockStyle.Fill;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.Font = new Font("Segoe UI", 14F);
            btnJoin.ForeColor = Color.White;
            btnJoin.Location = new Point(318, 3);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(153, 33);
            btnJoin.TabIndex = 1;
            btnJoin.Text = "Join Server";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // btnHost
            // 
            btnHost.Dock = DockStyle.Fill;
            btnHost.FlatStyle = FlatStyle.Flat;
            btnHost.Font = new Font("Segoe UI", 14F);
            btnHost.ForeColor = Color.White;
            btnHost.Location = new Point(160, 3);
            btnHost.Name = "btnHost";
            btnHost.Size = new Size(152, 33);
            btnHost.TabIndex = 0;
            btnHost.Text = "Host Server";
            btnHost.UseVisualStyleBackColor = true;
            btnHost.Click += this.btnHost_Click;
            // 
            // pnael1
            // 
            pnael1.AutoScroll = true;
            pnael1.Controls.Add(listView1);
            pnael1.Dock = DockStyle.Fill;
            pnael1.Location = new Point(163, 3);
            pnael1.Name = "pnael1";
            pnael1.Size = new Size(474, 399);
            pnael1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(26, 26, 26);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(474, 399);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(151, 33);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Multiplayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMenu1);
            Name = "Multiplayer";
            Text = "Multiplayer";
            FormClosed += Multiplayer_FormClosed;
            pnlMenu1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pnael1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu1;
        private Button btnJoin;
        private Button btnHost;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnael1;
        private ListView listView1;
        private Button btnBack;
    }
}