namespace PixelToyControl.Ui
{
    partial class DeviceAttributeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelDescriptor = new Label();
            trackBarSteps = new TrackBar();
            labelStepValue = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSteps).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelDescriptor, 0, 0);
            tableLayoutPanel1.Controls.Add(trackBarSteps, 1, 0);
            tableLayoutPanel1.Controls.Add(labelStepValue, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(334, 49);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelDescriptor
            // 
            labelDescriptor.AutoSize = true;
            labelDescriptor.Dock = DockStyle.Fill;
            labelDescriptor.Location = new Point(3, 0);
            labelDescriptor.Name = "labelDescriptor";
            labelDescriptor.Size = new Size(68, 15);
            labelDescriptor.TabIndex = 0;
            labelDescriptor.Text = "[descriptor]";
            labelDescriptor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trackBarSteps
            // 
            trackBarSteps.Dock = DockStyle.Fill;
            trackBarSteps.Location = new Point(77, 3);
            trackBarSteps.Name = "trackBarSteps";
            tableLayoutPanel1.SetRowSpan(trackBarSteps, 2);
            trackBarSteps.Size = new Size(254, 43);
            trackBarSteps.TabIndex = 1;
            trackBarSteps.Scroll += TrackBarSteps_Scroll;
            // 
            // labelStepValue
            // 
            labelStepValue.AutoSize = true;
            labelStepValue.Dock = DockStyle.Fill;
            labelStepValue.Location = new Point(3, 15);
            labelStepValue.Name = "labelStepValue";
            labelStepValue.Size = new Size(68, 34);
            labelStepValue.TabIndex = 2;
            labelStepValue.Text = "[stepValue]";
            labelStepValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DeviceAttributeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            Controls.Add(tableLayoutPanel1);
            Name = "DeviceAttributeControl";
            Size = new Size(334, 49);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSteps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelDescriptor;
        private Label labelStepValue;
        internal TrackBar trackBarSteps;
    }
}
