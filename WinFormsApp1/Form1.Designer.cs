namespace WinFormsApp1
{
    partial class Form1
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
            Label label1;
            colorDialog1 = new ColorDialog();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt4 = new Button();
            bt5 = new Button();
            bt6 = new Button();
            bt7 = new Button();
            bt8 = new Button();
            bt9 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 9;
            label1.Text = "Vez de:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(0, -1);
            bt1.Name = "bt1";
            bt1.Size = new Size(100, 100);
            bt1.TabIndex = 0;
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += button1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(106, 0);
            bt2.Name = "bt2";
            bt2.Size = new Size(100, 100);
            bt2.TabIndex = 1;
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += button1_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(212, 0);
            bt3.Name = "bt3";
            bt3.Size = new Size(100, 100);
            bt3.TabIndex = 2;
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += button1_Click;
            // 
            // bt4
            // 
            bt4.Location = new Point(0, 101);
            bt4.Name = "bt4";
            bt4.Size = new Size(100, 100);
            bt4.TabIndex = 3;
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += button1_Click;
            // 
            // bt5
            // 
            bt5.Location = new Point(106, 101);
            bt5.Name = "bt5";
            bt5.Size = new Size(100, 100);
            bt5.TabIndex = 4;
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += button1_Click;
            // 
            // bt6
            // 
            bt6.Location = new Point(212, 101);
            bt6.Name = "bt6";
            bt6.Size = new Size(100, 100);
            bt6.TabIndex = 5;
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += button1_Click;
            // 
            // bt7
            // 
            bt7.Location = new Point(0, 207);
            bt7.Name = "bt7";
            bt7.Size = new Size(100, 100);
            bt7.TabIndex = 6;
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += button1_Click;
            // 
            // bt8
            // 
            bt8.Location = new Point(106, 207);
            bt8.Name = "bt8";
            bt8.Size = new Size(100, 100);
            bt8.TabIndex = 7;
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += button1_Click;
            // 
            // bt9
            // 
            bt9.Location = new Point(212, 207);
            bt9.Name = "bt9";
            bt9.Size = new Size(100, 100);
            bt9.TabIndex = 8;
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(318, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(424, 309);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(bt9);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JogoDaVelha3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button bt5;
        private Button bt6;
        private Button bt7;
        private Button bt8;
        private Button bt9;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
