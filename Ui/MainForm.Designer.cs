namespace ProjectMerlin.Ui
{
    partial class MainForm
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
            pictureBoxPreview = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanelPosition = new TableLayoutPanel();
            tableLayoutPanelCoords = new TableLayoutPanel();
            labelX = new Label();
            labelY = new Label();
            numericUpDownX = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            label1 = new Label();
            buttonPickPosition = new Button();
            numericUpDownDelay = new NumericUpDown();
            labelDelay = new Label();
            tableLayoutPanelTriggerConfig = new TableLayoutPanel();
            labelColorView = new Label();
            labelColor = new Label();
            pictureBoxColor = new PictureBox();
            label2 = new Label();
            textBoxHexColor = new TextBox();
            buttonSetHex = new Button();
            checkedListBox1 = new CheckedListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonDeviceAdd = new Button();
            buttonDeviceRemove = new Button();
            listBoxDevices = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelPosition.SuspendLayout();
            tableLayoutPanelCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).BeginInit();
            tableLayoutPanelTriggerConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColor).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Dock = DockStyle.Fill;
            pictureBoxPreview.Location = new Point(159, 34);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(100, 100);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            pictureBoxPreview.MouseClick += PictureBoxPreview_MouseClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanelPosition, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelTriggerConfig, 0, 1);
            tableLayoutPanel1.Controls.Add(checkedListBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(135, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(723, 448);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanelPosition
            // 
            tableLayoutPanelPosition.AutoSize = true;
            tableLayoutPanelPosition.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelPosition.ColumnCount = 4;
            tableLayoutPanelPosition.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelPosition.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelPosition.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelPosition.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPosition.Controls.Add(tableLayoutPanelCoords, 0, 1);
            tableLayoutPanelPosition.Controls.Add(pictureBoxPreview, 3, 1);
            tableLayoutPanelPosition.Controls.Add(buttonPickPosition, 0, 0);
            tableLayoutPanelPosition.Controls.Add(numericUpDownDelay, 2, 0);
            tableLayoutPanelPosition.Controls.Add(labelDelay, 3, 0);
            tableLayoutPanelPosition.Dock = DockStyle.Fill;
            tableLayoutPanelPosition.Location = new Point(3, 3);
            tableLayoutPanelPosition.Name = "tableLayoutPanelPosition";
            tableLayoutPanelPosition.RowCount = 2;
            tableLayoutPanelPosition.RowStyles.Add(new RowStyle());
            tableLayoutPanelPosition.RowStyles.Add(new RowStyle());
            tableLayoutPanelPosition.Size = new Size(262, 137);
            tableLayoutPanelPosition.TabIndex = 3;
            // 
            // tableLayoutPanelCoords
            // 
            tableLayoutPanelCoords.AutoSize = true;
            tableLayoutPanelCoords.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelCoords.ColumnCount = 2;
            tableLayoutPanelCoords.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelCoords.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelCoords.Controls.Add(labelX, 0, 1);
            tableLayoutPanelCoords.Controls.Add(labelY, 0, 2);
            tableLayoutPanelCoords.Controls.Add(numericUpDownX, 1, 1);
            tableLayoutPanelCoords.Controls.Add(numericUpDownY, 1, 2);
            tableLayoutPanelCoords.Controls.Add(label1, 0, 0);
            tableLayoutPanelCoords.Dock = DockStyle.Fill;
            tableLayoutPanelCoords.Location = new Point(3, 34);
            tableLayoutPanelCoords.Name = "tableLayoutPanelCoords";
            tableLayoutPanelCoords.RowCount = 3;
            tableLayoutPanelCoords.RowStyles.Add(new RowStyle());
            tableLayoutPanelCoords.RowStyles.Add(new RowStyle());
            tableLayoutPanelCoords.RowStyles.Add(new RowStyle());
            tableLayoutPanelCoords.Size = new Size(109, 100);
            tableLayoutPanelCoords.TabIndex = 1;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Dock = DockStyle.Fill;
            labelX.Location = new Point(3, 15);
            labelX.Name = "labelX";
            labelX.Size = new Size(17, 29);
            labelX.TabIndex = 0;
            labelX.Text = "X:";
            labelX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Dock = DockStyle.Top;
            labelY.Location = new Point(3, 44);
            labelY.Name = "labelY";
            labelY.Size = new Size(17, 15);
            labelY.TabIndex = 1;
            labelY.Text = "Y:";
            labelY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Dock = DockStyle.Fill;
            numericUpDownX.Location = new Point(26, 18);
            numericUpDownX.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownX.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(80, 23);
            numericUpDownX.TabIndex = 2;
            numericUpDownX.ValueChanged += NumericUpDownXyCords_ValueChanged;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Dock = DockStyle.Fill;
            numericUpDownY.Location = new Point(26, 47);
            numericUpDownY.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownY.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(80, 23);
            numericUpDownY.TabIndex = 3;
            numericUpDownY.ValueChanged += NumericUpDownXyCords_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanelCoords.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 4;
            label1.Text = "Fine-Tune";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonPickPosition
            // 
            buttonPickPosition.AutoSize = true;
            buttonPickPosition.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPickPosition.Dock = DockStyle.Fill;
            buttonPickPosition.Location = new Point(3, 3);
            buttonPickPosition.Name = "buttonPickPosition";
            buttonPickPosition.Size = new Size(109, 25);
            buttonPickPosition.TabIndex = 2;
            buttonPickPosition.Text = "Pick Position";
            buttonPickPosition.UseVisualStyleBackColor = true;
            buttonPickPosition.Click += ButtonPickPosition_Click;
            // 
            // numericUpDownDelay
            // 
            numericUpDownDelay.AutoSize = true;
            numericUpDownDelay.Dock = DockStyle.Fill;
            numericUpDownDelay.Location = new Point(118, 3);
            numericUpDownDelay.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownDelay.Name = "numericUpDownDelay";
            numericUpDownDelay.Size = new Size(35, 23);
            numericUpDownDelay.TabIndex = 4;
            numericUpDownDelay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // labelDelay
            // 
            labelDelay.AutoSize = true;
            labelDelay.Dock = DockStyle.Left;
            labelDelay.Location = new Point(159, 0);
            labelDelay.Name = "labelDelay";
            labelDelay.Size = new Size(90, 31);
            labelDelay.TabIndex = 5;
            labelDelay.Text = "Delay (seconds)";
            labelDelay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelTriggerConfig
            // 
            tableLayoutPanelTriggerConfig.ColumnCount = 3;
            tableLayoutPanelTriggerConfig.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelTriggerConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelTriggerConfig.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelTriggerConfig.Controls.Add(labelColorView, 0, 1);
            tableLayoutPanelTriggerConfig.Controls.Add(labelColor, 0, 0);
            tableLayoutPanelTriggerConfig.Controls.Add(pictureBoxColor, 1, 1);
            tableLayoutPanelTriggerConfig.Controls.Add(label2, 0, 2);
            tableLayoutPanelTriggerConfig.Controls.Add(textBoxHexColor, 1, 2);
            tableLayoutPanelTriggerConfig.Controls.Add(buttonSetHex, 2, 2);
            tableLayoutPanelTriggerConfig.Dock = DockStyle.Fill;
            tableLayoutPanelTriggerConfig.Location = new Point(3, 146);
            tableLayoutPanelTriggerConfig.Name = "tableLayoutPanelTriggerConfig";
            tableLayoutPanelTriggerConfig.RowCount = 4;
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle());
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle());
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle());
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTriggerConfig.Size = new Size(262, 299);
            tableLayoutPanelTriggerConfig.TabIndex = 4;
            // 
            // labelColorView
            // 
            labelColorView.AutoSize = true;
            labelColorView.Location = new Point(3, 15);
            labelColorView.Name = "labelColorView";
            labelColorView.Size = new Size(36, 15);
            labelColorView.TabIndex = 3;
            labelColorView.Text = "Color";
            labelColorView.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            tableLayoutPanelTriggerConfig.SetColumnSpan(labelColor, 3);
            labelColor.Dock = DockStyle.Top;
            labelColor.Location = new Point(3, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(256, 15);
            labelColor.TabIndex = 0;
            labelColor.Text = "Selected Color";
            labelColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxColor
            // 
            tableLayoutPanelTriggerConfig.SetColumnSpan(pictureBoxColor, 2);
            pictureBoxColor.Dock = DockStyle.Top;
            pictureBoxColor.Location = new Point(45, 18);
            pictureBoxColor.Name = "pictureBoxColor";
            pictureBoxColor.Size = new Size(214, 12);
            pictureBoxColor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxColor.TabIndex = 1;
            pictureBoxColor.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(36, 31);
            label2.TabIndex = 2;
            label2.Text = "Hex";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxHexColor
            // 
            textBoxHexColor.Dock = DockStyle.Top;
            textBoxHexColor.Location = new Point(45, 36);
            textBoxHexColor.Name = "textBoxHexColor";
            textBoxHexColor.Size = new Size(175, 23);
            textBoxHexColor.TabIndex = 4;
            textBoxHexColor.KeyDown += TextBoxHexColor_KeyDown;
            // 
            // buttonSetHex
            // 
            buttonSetHex.AutoSize = true;
            buttonSetHex.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSetHex.Location = new Point(226, 36);
            buttonSetHex.Name = "buttonSetHex";
            buttonSetHex.Size = new Size(33, 25);
            buttonSetHex.TabIndex = 5;
            buttonSetHex.Text = "Set";
            buttonSetHex.UseVisualStyleBackColor = true;
            buttonSetHex.Click += ButtonSetHex_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(271, 3);
            checkedListBox1.Name = "checkedListBox1";
            tableLayoutPanel1.SetRowSpan(checkedListBox1, 2);
            checkedListBox1.Size = new Size(200, 442);
            checkedListBox1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(buttonDeviceAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonDeviceRemove, 0, 1);
            tableLayoutPanel2.Controls.Add(listBoxDevices, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(135, 448);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // buttonDeviceAdd
            // 
            buttonDeviceAdd.AutoSize = true;
            buttonDeviceAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDeviceAdd.Dock = DockStyle.Fill;
            buttonDeviceAdd.Location = new Point(3, 3);
            buttonDeviceAdd.Name = "buttonDeviceAdd";
            buttonDeviceAdd.Size = new Size(129, 25);
            buttonDeviceAdd.TabIndex = 1;
            buttonDeviceAdd.Text = "Add Device";
            buttonDeviceAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDeviceRemove
            // 
            buttonDeviceRemove.AutoSize = true;
            buttonDeviceRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDeviceRemove.Dock = DockStyle.Fill;
            buttonDeviceRemove.Enabled = false;
            buttonDeviceRemove.Location = new Point(3, 34);
            buttonDeviceRemove.Name = "buttonDeviceRemove";
            buttonDeviceRemove.Size = new Size(129, 25);
            buttonDeviceRemove.TabIndex = 2;
            buttonDeviceRemove.Text = "Remove Device";
            buttonDeviceRemove.UseVisualStyleBackColor = true;
            // 
            // listBoxDevices
            // 
            listBoxDevices.Dock = DockStyle.Fill;
            listBoxDevices.FormattingEnabled = true;
            listBoxDevices.Location = new Point(3, 65);
            listBoxDevices.Name = "listBoxDevices";
            tableLayoutPanel2.SetRowSpan(listBoxDevices, 3);
            listBoxDevices.Size = new Size(129, 380);
            listBoxDevices.TabIndex = 0;
            listBoxDevices.SelectedIndexChanged += ListBoxDevices_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 448);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanelPosition.ResumeLayout(false);
            tableLayoutPanelPosition.PerformLayout();
            tableLayoutPanelCoords.ResumeLayout(false);
            tableLayoutPanelCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).EndInit();
            tableLayoutPanelTriggerConfig.ResumeLayout(false);
            tableLayoutPanelTriggerConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColor).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPreview;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ListBox listBoxDevices;
        private Button buttonDeviceAdd;
        private Button buttonDeviceRemove;
        private TableLayoutPanel tableLayoutPanelCoords;
        private Label labelX;
        private Label labelY;
        private NumericUpDown numericUpDownX;
        private NumericUpDown numericUpDownY;
        private NumericUpDown numericUpDownDelay;
        private Button buttonPickPosition;
        private TableLayoutPanel tableLayoutPanelPosition;
        private Label labelDelay;
        private Label label1;
        private TableLayoutPanel tableLayoutPanelTriggerConfig;
        private Label labelColor;
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBoxColor;
        private Label label2;
        private Label labelColorView;
        private TextBox textBoxHexColor;
        private Button buttonSetHex;
    }
}