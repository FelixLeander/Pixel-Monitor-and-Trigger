namespace PixelControlledApi
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
            buttonSetLocation = new Button();
            textBoxHexColorLocation = new TextBox();
            numericUpDownLocationDelay = new NumericUpDown();
            pictureBox1 = new PictureBox();
            numericUpDownObservingDelay = new NumericUpDown();
            textBoxObservingColor = new TextBox();
            buttonToggleObserve = new Button();
            groupBoxSetup = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            numericUpDownLocationX = new NumericUpDown();
            numericUpDownLocationY = new NumericUpDown();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            labelTimeBetweenObserving = new Label();
            labelHexColorObserving = new Label();
            label4 = new Label();
            textBoxTargetColor = new TextBox();
            textBox1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLocationDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownObservingDelay).BeginInit();
            groupBoxSetup.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLocationX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLocationY).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSetLocation
            // 
            tableLayoutPanel1.SetColumnSpan(buttonSetLocation, 2);
            buttonSetLocation.Dock = DockStyle.Fill;
            buttonSetLocation.Location = new Point(3, 3);
            buttonSetLocation.Name = "buttonSetLocation";
            buttonSetLocation.Size = new Size(188, 23);
            buttonSetLocation.TabIndex = 0;
            buttonSetLocation.Text = "Set Location";
            buttonSetLocation.UseVisualStyleBackColor = true;
            buttonSetLocation.Click += Button1_Click;
            // 
            // textBoxHexColorLocation
            // 
            textBoxHexColorLocation.Dock = DockStyle.Fill;
            textBoxHexColorLocation.Location = new Point(47, 61);
            textBoxHexColorLocation.Name = "textBoxHexColorLocation";
            textBoxHexColorLocation.ReadOnly = true;
            textBoxHexColorLocation.Size = new Size(144, 23);
            textBoxHexColorLocation.TabIndex = 1;
            // 
            // numericUpDownLocationDelay
            // 
            numericUpDownLocationDelay.Dock = DockStyle.Fill;
            numericUpDownLocationDelay.Location = new Point(47, 32);
            numericUpDownLocationDelay.Name = "numericUpDownLocationDelay";
            numericUpDownLocationDelay.Size = new Size(144, 23);
            numericUpDownLocationDelay.TabIndex = 2;
            numericUpDownLocationDelay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            tableLayoutPanel3.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            // 
            // numericUpDownObservingDelay
            // 
            numericUpDownObservingDelay.Dock = DockStyle.Fill;
            numericUpDownObservingDelay.Location = new Point(118, 32);
            numericUpDownObservingDelay.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownObservingDelay.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownObservingDelay.Name = "numericUpDownObservingDelay";
            numericUpDownObservingDelay.Size = new Size(100, 23);
            numericUpDownObservingDelay.TabIndex = 4;
            numericUpDownObservingDelay.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // textBoxObservingColor
            // 
            textBoxObservingColor.Dock = DockStyle.Fill;
            textBoxObservingColor.Location = new Point(118, 61);
            textBoxObservingColor.Name = "textBoxObservingColor";
            textBoxObservingColor.ReadOnly = true;
            textBoxObservingColor.Size = new Size(100, 23);
            textBoxObservingColor.TabIndex = 5;
            // 
            // buttonToggleObserve
            // 
            buttonToggleObserve.BackColor = Color.LightGreen;
            tableLayoutPanel2.SetColumnSpan(buttonToggleObserve, 3);
            buttonToggleObserve.Dock = DockStyle.Fill;
            buttonToggleObserve.Location = new Point(3, 3);
            buttonToggleObserve.Name = "buttonToggleObserve";
            buttonToggleObserve.Size = new Size(303, 23);
            buttonToggleObserve.TabIndex = 6;
            buttonToggleObserve.Text = "Start Observing";
            buttonToggleObserve.UseVisualStyleBackColor = false;
            buttonToggleObserve.Click += ButtonToggleObserve_Click;
            // 
            // groupBoxSetup
            // 
            groupBoxSetup.AutoSize = true;
            groupBoxSetup.Controls.Add(tableLayoutPanel1);
            groupBoxSetup.Dock = DockStyle.Fill;
            groupBoxSetup.Location = new Point(3, 3);
            groupBoxSetup.Name = "groupBoxSetup";
            groupBoxSetup.Size = new Size(200, 168);
            groupBoxSetup.TabIndex = 7;
            groupBoxSetup.TabStop = false;
            groupBoxSetup.Text = "Setup";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(buttonSetLocation, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxHexColorLocation, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownLocationDelay, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDownLocationX, 1, 3);
            tableLayoutPanel1.Controls.Add(numericUpDownLocationY, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(194, 146);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(38, 29);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 29);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 87);
            label3.Name = "label3";
            label3.Size = new Size(38, 29);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 116);
            label5.Name = "label5";
            label5.Size = new Size(38, 29);
            label5.TabIndex = 6;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDownLocationX
            // 
            numericUpDownLocationX.Dock = DockStyle.Fill;
            numericUpDownLocationX.Location = new Point(47, 90);
            numericUpDownLocationX.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownLocationX.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            numericUpDownLocationX.Name = "numericUpDownLocationX";
            numericUpDownLocationX.Size = new Size(144, 23);
            numericUpDownLocationX.TabIndex = 7;
            numericUpDownLocationX.ValueChanged += NumericUpDownLocationX_ValueChanged;
            // 
            // numericUpDownLocationY
            // 
            numericUpDownLocationY.Dock = DockStyle.Fill;
            numericUpDownLocationY.Location = new Point(47, 119);
            numericUpDownLocationY.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownLocationY.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            numericUpDownLocationY.Name = "numericUpDownLocationY";
            numericUpDownLocationY.Size = new Size(144, 23);
            numericUpDownLocationY.TabIndex = 8;
            numericUpDownLocationY.ValueChanged += NumericUpDownLocationX_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(209, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 168);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Use";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(buttonToggleObserve, 0, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownObservingDelay, 1, 1);
            tableLayoutPanel2.Controls.Add(textBoxObservingColor, 1, 2);
            tableLayoutPanel2.Controls.Add(button1, 2, 3);
            tableLayoutPanel2.Controls.Add(labelTimeBetweenObserving, 0, 1);
            tableLayoutPanel2.Controls.Add(labelHexColorObserving, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(textBoxTargetColor, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(309, 146);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(224, 90);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 11;
            button1.Text = "Color Picker";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click_1;
            // 
            // labelTimeBetweenObserving
            // 
            labelTimeBetweenObserving.AutoSize = true;
            labelTimeBetweenObserving.Dock = DockStyle.Fill;
            labelTimeBetweenObserving.Location = new Point(3, 29);
            labelTimeBetweenObserving.Name = "labelTimeBetweenObserving";
            labelTimeBetweenObserving.Size = new Size(109, 29);
            labelTimeBetweenObserving.TabIndex = 7;
            labelTimeBetweenObserving.Text = "Once every n (mm)";
            labelTimeBetweenObserving.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelHexColorObserving
            // 
            labelHexColorObserving.AutoSize = true;
            labelHexColorObserving.Dock = DockStyle.Fill;
            labelHexColorObserving.Location = new Point(3, 58);
            labelHexColorObserving.Name = "labelHexColorObserving";
            labelHexColorObserving.Size = new Size(109, 29);
            labelHexColorObserving.TabIndex = 8;
            labelHexColorObserving.Text = "label4";
            labelHexColorObserving.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 87);
            label4.Name = "label4";
            label4.Size = new Size(109, 29);
            label4.TabIndex = 9;
            label4.Text = "label4";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxTargetColor
            // 
            textBoxTargetColor.Dock = DockStyle.Fill;
            textBoxTargetColor.Location = new Point(118, 90);
            textBoxTargetColor.Name = "textBoxTargetColor";
            textBoxTargetColor.Size = new Size(100, 23);
            textBoxTargetColor.TabIndex = 10;
            textBoxTargetColor.TextChanged += TextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(530, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            tableLayoutPanel3.SetRowSpan(textBox1, 2);
            textBox1.Size = new Size(267, 444);
            textBox1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(textBox1, 2, 0);
            tableLayoutPanel3.Controls.Add(groupBoxSetup, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(800, 450);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownLocationDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownObservingDelay).EndInit();
            groupBoxSetup.ResumeLayout(false);
            groupBoxSetup.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLocationX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLocationY).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSetLocation;
        private TextBox textBoxHexColorLocation;
        private NumericUpDown numericUpDownLocationDelay;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDownObservingDelay;
        private TextBox textBoxObservingColor;
        private Button buttonToggleObserve;
        private GroupBox groupBoxSetup;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTimeBetweenObserving;
        private Label labelHexColorObserving;
        private Label label3;
        private Label label5;
        private NumericUpDown numericUpDownLocationX;
        private NumericUpDown numericUpDownLocationY;
        private Label label4;
        private TextBox textBoxTargetColor;
        private Button button1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}