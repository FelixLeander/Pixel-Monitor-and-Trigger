namespace Test
{
    partial class MainForm
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(110, 119);
            button1.Name = "button1";
            button1.Size = new Size(218, 23);
            button1.TabIndex = 0;
            button1.Text = "Pick point in 3sec";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 280);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(400, 119);
            button2.Name = "button2";
            button2.Size = new Size(133, 23);
            button2.TabIndex = 2;
            button2.Text = "Start/Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(776, 32);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += PictureBox2_MouseClick;
            // 
            // button3
            // 
            button3.Location = new Point(12, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button3;
    }
}
