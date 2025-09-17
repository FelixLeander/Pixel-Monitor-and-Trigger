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
            buttonPickPixelDelayed = new Button();
            pictureBoxPickedColor = new PictureBox();
            button2 = new Button();
            pictureBoxRecordedColor = new PictureBox();
            buttonRecordColor = new Button();
            buttonPickColor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickedColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecordedColor).BeginInit();
            SuspendLayout();
            // 
            // buttonPickPixelDelayed
            // 
            buttonPickPixelDelayed.Location = new Point(12, 12);
            buttonPickPixelDelayed.Name = "buttonPickPixelDelayed";
            buttonPickPixelDelayed.Size = new Size(218, 23);
            buttonPickPixelDelayed.TabIndex = 0;
            buttonPickPixelDelayed.Text = "Pick point in 3sec";
            buttonPickPixelDelayed.UseVisualStyleBackColor = true;
            buttonPickPixelDelayed.Click += Button1_Click;
            // 
            // pictureBoxPickedColor
            // 
            pictureBoxPickedColor.Location = new Point(12, 41);
            pictureBoxPickedColor.Name = "pictureBoxPickedColor";
            pictureBoxPickedColor.Size = new Size(768, 138);
            pictureBoxPickedColor.TabIndex = 1;
            pictureBoxPickedColor.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(647, 12);
            button2.Name = "button2";
            button2.Size = new Size(133, 23);
            button2.TabIndex = 2;
            button2.Text = "Start/Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // pictureBoxRecordedColor
            // 
            pictureBoxRecordedColor.Dock = DockStyle.Bottom;
            pictureBoxRecordedColor.Location = new Point(0, 250);
            pictureBoxRecordedColor.Name = "pictureBoxRecordedColor";
            pictureBoxRecordedColor.Size = new Size(792, 32);
            pictureBoxRecordedColor.TabIndex = 3;
            pictureBoxRecordedColor.TabStop = false;
            pictureBoxRecordedColor.MouseClick += PictureBox2_MouseClick;
            // 
            // buttonRecordColor
            // 
            buttonRecordColor.AutoSize = true;
            buttonRecordColor.Location = new Point(12, 219);
            buttonRecordColor.Name = "buttonRecordColor";
            buttonRecordColor.Size = new Size(86, 25);
            buttonRecordColor.TabIndex = 4;
            buttonRecordColor.Text = "Record Color";
            buttonRecordColor.UseVisualStyleBackColor = true;
            buttonRecordColor.Click += Button3_Click;
            // 
            // buttonPickColor
            // 
            buttonPickColor.AutoSize = true;
            buttonPickColor.Location = new Point(371, 185);
            buttonPickColor.Name = "buttonPickColor";
            buttonPickColor.Size = new Size(104, 25);
            buttonPickColor.TabIndex = 5;
            buttonPickColor.Text = "buttonPickColor";
            buttonPickColor.UseVisualStyleBackColor = true;
            buttonPickColor.Click += ButtonSetColor_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 282);
            Controls.Add(buttonPickColor);
            Controls.Add(buttonRecordColor);
            Controls.Add(pictureBoxRecordedColor);
            Controls.Add(button2);
            Controls.Add(pictureBoxPickedColor);
            Controls.Add(buttonPickPixelDelayed);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickedColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecordedColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPickPixelDelayed;
        private PictureBox pictureBoxPickedColor;
        private Button button2;
        private PictureBox pictureBoxRecordedColor;
        private Button buttonRecordColor;
        private Button buttonPickColor;
    }
}
