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
            canvas = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.Location = new Point(3, 2);
            canvas.Margin = new Padding(3, 2, 3, 2);
            canvas.Name = "canvas";
            canvas.Size = new Size(647, 446);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += Canvas_Paint;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 50;
            gameTimer.Tick += GameTimer_Tick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(656, 370);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(253, 78);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(btnStart);
            Controls.Add(canvas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGame";
            Text = "FrmGame";
            KeyDown += FrmGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private System.Windows.Forms.Timer gameTimer;
        private Button btnStart;
    }
}
