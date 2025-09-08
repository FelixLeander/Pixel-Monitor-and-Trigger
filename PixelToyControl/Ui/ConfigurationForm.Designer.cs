namespace PixelToyControl.Ui
{
    partial class ConfigurationForm
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
            tableLayoutPanelMain = new TableLayoutPanel();
            groupBoxPickPixel = new GroupBox();
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
            groupBox1 = new GroupBox();
            tableLayoutPanelTriggerConfig = new TableLayoutPanel();
            labelColorView = new Label();
            pictureBoxColor = new PictureBox();
            label2 = new Label();
            textBoxHexColor = new TextBox();
            buttonSetHex = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            groupBoxDefinedActions = new GroupBox();
            checkedListBoxActions = new CheckedListBox();
            labelActionsCount = new Label();
            groupBoxDefineAction = new GroupBox();
            listBoxDevices = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            groupBoxPickPixel.SuspendLayout();
            tableLayoutPanelPosition.SuspendLayout();
            tableLayoutPanelCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanelTriggerConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColor).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBoxDefinedActions.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Dock = DockStyle.Fill;
            pictureBoxPreview.Location = new Point(159, 34);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(164, 100);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            pictureBoxPreview.MouseClick += PictureBoxPreview_MouseClick;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 3;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(groupBoxPickPixel, 0, 0);
            tableLayoutPanelMain.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanelMain.Controls.Add(groupBox2, 2, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxDefinedActions, 1, 0);
            tableLayoutPanelMain.Controls.Add(groupBoxDefineAction, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(129, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(729, 448);
            tableLayoutPanelMain.TabIndex = 5;
            // 
            // groupBoxPickPixel
            // 
            groupBoxPickPixel.AutoSize = true;
            groupBoxPickPixel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxPickPixel.Controls.Add(tableLayoutPanelPosition);
            groupBoxPickPixel.Dock = DockStyle.Fill;
            groupBoxPickPixel.Location = new Point(3, 3);
            groupBoxPickPixel.Name = "groupBoxPickPixel";
            groupBoxPickPixel.Size = new Size(332, 159);
            groupBoxPickPixel.TabIndex = 9;
            groupBoxPickPixel.TabStop = false;
            groupBoxPickPixel.Text = "Pick Pixel Posistion";
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
            tableLayoutPanelPosition.Location = new Point(3, 19);
            tableLayoutPanelPosition.Name = "tableLayoutPanelPosition";
            tableLayoutPanelPosition.RowCount = 2;
            tableLayoutPanelPosition.RowStyles.Add(new RowStyle());
            tableLayoutPanelPosition.RowStyles.Add(new RowStyle());
            tableLayoutPanelPosition.Size = new Size(326, 137);
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
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(tableLayoutPanelTriggerConfig);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 135);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pick Pixel Color";
            // 
            // tableLayoutPanelTriggerConfig
            // 
            tableLayoutPanelTriggerConfig.AutoSize = true;
            tableLayoutPanelTriggerConfig.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelTriggerConfig.ColumnCount = 3;
            tableLayoutPanelTriggerConfig.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelTriggerConfig.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelTriggerConfig.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelTriggerConfig.Controls.Add(labelColorView, 0, 0);
            tableLayoutPanelTriggerConfig.Controls.Add(pictureBoxColor, 1, 0);
            tableLayoutPanelTriggerConfig.Controls.Add(label2, 0, 1);
            tableLayoutPanelTriggerConfig.Controls.Add(textBoxHexColor, 1, 1);
            tableLayoutPanelTriggerConfig.Controls.Add(buttonSetHex, 2, 1);
            tableLayoutPanelTriggerConfig.Dock = DockStyle.Fill;
            tableLayoutPanelTriggerConfig.Location = new Point(3, 19);
            tableLayoutPanelTriggerConfig.Name = "tableLayoutPanelTriggerConfig";
            tableLayoutPanelTriggerConfig.RowCount = 2;
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle());
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle());
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTriggerConfig.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelTriggerConfig.Size = new Size(326, 113);
            tableLayoutPanelTriggerConfig.TabIndex = 4;
            // 
            // labelColorView
            // 
            labelColorView.AutoSize = true;
            labelColorView.Dock = DockStyle.Fill;
            labelColorView.Location = new Point(3, 0);
            labelColorView.Name = "labelColorView";
            labelColorView.Size = new Size(36, 18);
            labelColorView.TabIndex = 3;
            labelColorView.Text = "Color";
            labelColorView.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBoxColor
            // 
            tableLayoutPanelTriggerConfig.SetColumnSpan(pictureBoxColor, 2);
            pictureBoxColor.Dock = DockStyle.Top;
            pictureBoxColor.Location = new Point(45, 3);
            pictureBoxColor.Name = "pictureBoxColor";
            pictureBoxColor.Size = new Size(278, 12);
            pictureBoxColor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxColor.TabIndex = 1;
            pictureBoxColor.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Hex";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxHexColor
            // 
            textBoxHexColor.Dock = DockStyle.Top;
            textBoxHexColor.Location = new Point(45, 21);
            textBoxHexColor.Name = "textBoxHexColor";
            textBoxHexColor.Size = new Size(239, 23);
            textBoxHexColor.TabIndex = 4;
            textBoxHexColor.KeyDown += TextBoxHexColor_KeyDown;
            // 
            // buttonSetHex
            // 
            buttonSetHex.AutoSize = true;
            buttonSetHex.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSetHex.Location = new Point(290, 21);
            buttonSetHex.Name = "buttonSetHex";
            buttonSetHex.Size = new Size(33, 25);
            buttonSetHex.TabIndex = 5;
            buttonSetHex.Text = "Set";
            buttonSetHex.UseVisualStyleBackColor = true;
            buttonSetHex.Click += ButtonSetHex_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(547, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(179, 159);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(173, 137);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 25);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.Location = new Point(89, 3);
            button2.Name = "button2";
            button2.Size = new Size(81, 25);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxDefinedActions
            // 
            groupBoxDefinedActions.Controls.Add(checkedListBoxActions);
            groupBoxDefinedActions.Controls.Add(labelActionsCount);
            groupBoxDefinedActions.Dock = DockStyle.Fill;
            groupBoxDefinedActions.Location = new Point(341, 3);
            groupBoxDefinedActions.Name = "groupBoxDefinedActions";
            tableLayoutPanelMain.SetRowSpan(groupBoxDefinedActions, 3);
            groupBoxDefinedActions.Size = new Size(200, 442);
            groupBoxDefinedActions.TabIndex = 11;
            groupBoxDefinedActions.TabStop = false;
            groupBoxDefinedActions.Text = "Defined Actions";
            // 
            // checkedListBoxActions
            // 
            checkedListBoxActions.Dock = DockStyle.Fill;
            checkedListBoxActions.FormattingEnabled = true;
            checkedListBoxActions.Items.AddRange(new object[] { "dummy" });
            checkedListBoxActions.Location = new Point(3, 19);
            checkedListBoxActions.Name = "checkedListBoxActions";
            checkedListBoxActions.Size = new Size(194, 405);
            checkedListBoxActions.TabIndex = 5;
            // 
            // labelActionsCount
            // 
            labelActionsCount.Dock = DockStyle.Bottom;
            labelActionsCount.Location = new Point(3, 424);
            labelActionsCount.Name = "labelActionsCount";
            labelActionsCount.Size = new Size(194, 15);
            labelActionsCount.TabIndex = 6;
            labelActionsCount.Text = "Defined Actions:";
            labelActionsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxDefineAction
            // 
            groupBoxDefineAction.AutoSize = true;
            groupBoxDefineAction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxDefineAction.Dock = DockStyle.Fill;
            groupBoxDefineAction.Location = new Point(3, 309);
            groupBoxDefineAction.Name = "groupBoxDefineAction";
            groupBoxDefineAction.Size = new Size(332, 136);
            groupBoxDefineAction.TabIndex = 12;
            groupBoxDefineAction.TabStop = false;
            groupBoxDefineAction.Text = "Configuree Action";
            // 
            // listBoxDevices
            // 
            listBoxDevices.Dock = DockStyle.Left;
            listBoxDevices.FormattingEnabled = true;
            listBoxDevices.Location = new Point(0, 0);
            listBoxDevices.Name = "listBoxDevices";
            listBoxDevices.Size = new Size(129, 448);
            listBoxDevices.TabIndex = 6;
            // 
            // ConfigurationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 448);
            Controls.Add(tableLayoutPanelMain);
            Controls.Add(listBoxDevices);
            Name = "ConfigurationForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            groupBoxPickPixel.ResumeLayout(false);
            groupBoxPickPixel.PerformLayout();
            tableLayoutPanelPosition.ResumeLayout(false);
            tableLayoutPanelPosition.PerformLayout();
            tableLayoutPanelCoords.ResumeLayout(false);
            tableLayoutPanelCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDelay).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanelTriggerConfig.ResumeLayout(false);
            tableLayoutPanelTriggerConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxColor).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBoxDefinedActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPreview;
        private TableLayoutPanel tableLayoutPanelMain;
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
        private CheckedListBox checkedListBoxActions;
        private PictureBox pictureBoxColor;
        private Label label2;
        private Label labelColorView;
        private TextBox textBoxHexColor;
        private Button buttonSetHex;
        private GroupBox groupBox1;
        private GroupBox groupBoxPickPixel;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private GroupBox groupBoxDefinedActions;
        private Label labelActionsCount;
        private GroupBox groupBoxDefineAction;
        private ListBox listBoxDevices;
    }
}