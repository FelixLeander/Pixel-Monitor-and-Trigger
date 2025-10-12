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
            numericUpDownIdleOne = new NumericUpDown();
            numericUpDownIdleTwo = new NumericUpDown();
            numericUpDownEscalateOne = new NumericUpDown();
            numericUpDownEscaleTwo = new NumericUpDown();
            buttonTestVibs = new Button();
            numericUpDownTriggerTime = new NumericUpDown();
            buttonTestTrigger = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPickedColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecordedColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdleOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdleTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEscalateOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEscaleTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTriggerTime).BeginInit();
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
            buttonPickColor.Location = new Point(12, 183);
            buttonPickColor.Name = "buttonPickColor";
            buttonPickColor.Size = new Size(110, 25);
            buttonPickColor.TabIndex = 5;
            buttonPickColor.Text = "Open ColorPicker";
            buttonPickColor.UseVisualStyleBackColor = true;
            buttonPickColor.Click += ButtonSetColor_Click;
            // 
            // numericUpDownIdleOne
            // 
            numericUpDownIdleOne.DecimalPlaces = 2;
            numericUpDownIdleOne.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownIdleOne.Location = new Point(319, 186);
            numericUpDownIdleOne.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownIdleOne.Name = "numericUpDownIdleOne";
            numericUpDownIdleOne.Size = new Size(44, 23);
            numericUpDownIdleOne.TabIndex = 6;
            numericUpDownIdleOne.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // numericUpDownIdleTwo
            // 
            numericUpDownIdleTwo.DecimalPlaces = 2;
            numericUpDownIdleTwo.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownIdleTwo.Location = new Point(369, 186);
            numericUpDownIdleTwo.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownIdleTwo.Name = "numericUpDownIdleTwo";
            numericUpDownIdleTwo.Size = new Size(44, 23);
            numericUpDownIdleTwo.TabIndex = 7;
            numericUpDownIdleTwo.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // numericUpDownEscalateOne
            // 
            numericUpDownEscalateOne.DecimalPlaces = 2;
            numericUpDownEscalateOne.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownEscalateOne.Location = new Point(450, 186);
            numericUpDownEscalateOne.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEscalateOne.Name = "numericUpDownEscalateOne";
            numericUpDownEscalateOne.Size = new Size(44, 23);
            numericUpDownEscalateOne.TabIndex = 8;
            numericUpDownEscalateOne.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownEscaleTwo
            // 
            numericUpDownEscaleTwo.DecimalPlaces = 2;
            numericUpDownEscaleTwo.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownEscaleTwo.Location = new Point(500, 186);
            numericUpDownEscaleTwo.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEscaleTwo.Name = "numericUpDownEscaleTwo";
            numericUpDownEscaleTwo.Size = new Size(44, 23);
            numericUpDownEscaleTwo.TabIndex = 9;
            numericUpDownEscaleTwo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonTestVibs
            // 
            buttonTestVibs.Location = new Point(550, 185);
            buttonTestVibs.Name = "buttonTestVibs";
            buttonTestVibs.Size = new Size(230, 23);
            buttonTestVibs.TabIndex = 10;
            buttonTestVibs.Text = "Hover to idle / click to esclate";
            buttonTestVibs.UseVisualStyleBackColor = true;
            buttonTestVibs.MouseDown += ButtonEscalate_MouseDown;
            buttonTestVibs.MouseLeave += ButtonTestVibs_MouseLeave;
            buttonTestVibs.MouseHover += ButtonTestVibs_MouseHover;
            buttonTestVibs.MouseUp += ButtonEscalate_MouseUp;
            // 
            // numericUpDownTriggerTime
            // 
            numericUpDownTriggerTime.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownTriggerTime.Location = new Point(140, 222);
            numericUpDownTriggerTime.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownTriggerTime.Name = "numericUpDownTriggerTime";
            numericUpDownTriggerTime.Size = new Size(90, 23);
            numericUpDownTriggerTime.TabIndex = 11;
            numericUpDownTriggerTime.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // buttonTestTrigger
            // 
            buttonTestTrigger.Location = new Point(236, 222);
            buttonTestTrigger.Name = "buttonTestTrigger";
            buttonTestTrigger.Size = new Size(66, 23);
            buttonTestTrigger.TabIndex = 12;
            buttonTestTrigger.Text = "Test Vibe";
            buttonTestTrigger.UseVisualStyleBackColor = true;
            buttonTestTrigger.Click += ButtonTestTrigger_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 282);
            Controls.Add(buttonTestTrigger);
            Controls.Add(numericUpDownTriggerTime);
            Controls.Add(buttonTestVibs);
            Controls.Add(numericUpDownEscaleTwo);
            Controls.Add(numericUpDownEscalateOne);
            Controls.Add(numericUpDownIdleTwo);
            Controls.Add(numericUpDownIdleOne);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdleOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownIdleTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEscalateOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEscaleTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTriggerTime).EndInit();
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
        private NumericUpDown numericUpDownIdleOne;
        private NumericUpDown numericUpDownIdleTwo;
        private NumericUpDown numericUpDownEscalateOne;
        private NumericUpDown numericUpDownEscaleTwo;
        private Button buttonTestVibs;
        private NumericUpDown numericUpDownTriggerTime;
        private Button buttonTestTrigger;
    }
}
