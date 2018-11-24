namespace WaveFunctionCollapseEditor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sLimit = new System.Windows.Forms.NumericUpDown();
            this.sName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sPeriodic = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sHeight = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.sWidth = new System.Windows.Forms.NumericUpDown();
            this.panelTiled = new System.Windows.Forms.Panel();
            this.sTextOutput = new System.Windows.Forms.CheckBox();
            this.stSubset = new System.Windows.Forms.TextBox();
            this.stBlack = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelOverlapping = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.oGround = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.oSymmetry = new System.Windows.Forms.NumericUpDown();
            this.oPeriodicInput = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oN = new System.Windows.Forms.NumericUpDown();
            this.rSimpleTiled = new System.Windows.Forms.RadioButton();
            this.rOverlapping = new System.Windows.Forms.RadioButton();
            this.listSamples = new System.Windows.Forms.ListBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.cmdSaveText = new System.Windows.Forms.Button();
            this.cmdSaveImage = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cmdRun = new System.Windows.Forms.Button();
            this.zoom = new System.Windows.Forms.NumericUpDown();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.sRetries = new System.Windows.Forms.NumericUpDown();
            this.numSeed = new System.Windows.Forms.NumericUpDown();
            this.rndSeed = new System.Windows.Forms.CheckBox();
            this.tiles = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWidth)).BeginInit();
            this.panelTiled.SuspendLayout();
            this.panelOverlapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSymmetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picOutput
            // 
            this.picOutput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picOutput.Location = new System.Drawing.Point(335, 226);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(155, 153);
            this.picOutput.TabIndex = 0;
            this.picOutput.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.picGroup);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.listSamples);
            this.groupBox1.Controls.Add(this.cmdBrowse);
            this.groupBox1.Controls.Add(this.picInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 680);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // picGroup
            // 
            this.picGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picGroup.Location = new System.Drawing.Point(6, 385);
            this.picGroup.Name = "picGroup";
            this.picGroup.Size = new System.Drawing.Size(300, 288);
            this.picGroup.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.sLimit);
            this.panel3.Controls.Add(this.sName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.sPeriodic);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.sHeight);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.sWidth);
            this.panel3.Controls.Add(this.panelTiled);
            this.panel3.Controls.Add(this.panelOverlapping);
            this.panel3.Controls.Add(this.rSimpleTiled);
            this.panel3.Controls.Add(this.rOverlapping);
            this.panel3.Location = new System.Drawing.Point(136, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 344);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Limit";
            // 
            // sLimit
            // 
            this.sLimit.Location = new System.Drawing.Point(70, 85);
            this.sLimit.Name = "sLimit";
            this.sLimit.Size = new System.Drawing.Size(91, 20);
            this.sLimit.TabIndex = 26;
            this.sLimit.ValueChanged += new System.EventHandler(this.settingChanged);
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(70, 7);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(91, 20);
            this.sName.TabIndex = 25;
            this.sName.TextChanged += new System.EventHandler(this.settingChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // sPeriodic
            // 
            this.sPeriodic.AutoSize = true;
            this.sPeriodic.Location = new System.Drawing.Point(6, 111);
            this.sPeriodic.Name = "sPeriodic";
            this.sPeriodic.Size = new System.Drawing.Size(64, 17);
            this.sPeriodic.TabIndex = 23;
            this.sPeriodic.Text = "Periodic";
            this.sPeriodic.UseVisualStyleBackColor = true;
            this.sPeriodic.CheckedChanged += new System.EventHandler(this.settingChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Height";
            // 
            // sHeight
            // 
            this.sHeight.Location = new System.Drawing.Point(70, 59);
            this.sHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sHeight.Name = "sHeight";
            this.sHeight.Size = new System.Drawing.Size(91, 20);
            this.sHeight.TabIndex = 19;
            this.sHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.sHeight.ValueChanged += new System.EventHandler(this.settingChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Width";
            // 
            // sWidth
            // 
            this.sWidth.Location = new System.Drawing.Point(70, 33);
            this.sWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.sWidth.Name = "sWidth";
            this.sWidth.Size = new System.Drawing.Size(91, 20);
            this.sWidth.TabIndex = 17;
            this.sWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.sWidth.ValueChanged += new System.EventHandler(this.settingChanged);
            // 
            // panelTiled
            // 
            this.panelTiled.Controls.Add(this.sTextOutput);
            this.panelTiled.Controls.Add(this.stSubset);
            this.panelTiled.Controls.Add(this.stBlack);
            this.panelTiled.Controls.Add(this.label3);
            this.panelTiled.Location = new System.Drawing.Point(0, 153);
            this.panelTiled.Name = "panelTiled";
            this.panelTiled.Size = new System.Drawing.Size(161, 52);
            this.panelTiled.TabIndex = 16;
            // 
            // sTextOutput
            // 
            this.sTextOutput.AutoSize = true;
            this.sTextOutput.Location = new System.Drawing.Point(70, 30);
            this.sTextOutput.Name = "sTextOutput";
            this.sTextOutput.Size = new System.Drawing.Size(82, 17);
            this.sTextOutput.TabIndex = 29;
            this.sTextOutput.Text = "Text Output";
            this.sTextOutput.UseVisualStyleBackColor = true;
            this.sTextOutput.TextChanged += new System.EventHandler(this.settingChanged);
            // 
            // stSubset
            // 
            this.stSubset.Location = new System.Drawing.Point(70, 5);
            this.stSubset.Name = "stSubset";
            this.stSubset.Size = new System.Drawing.Size(91, 20);
            this.stSubset.TabIndex = 12;
            this.stSubset.TextChanged += new System.EventHandler(this.settingChanged);
            // 
            // stBlack
            // 
            this.stBlack.AutoSize = true;
            this.stBlack.Location = new System.Drawing.Point(6, 30);
            this.stBlack.Name = "stBlack";
            this.stBlack.Size = new System.Drawing.Size(53, 17);
            this.stBlack.TabIndex = 6;
            this.stBlack.Text = "Black";
            this.stBlack.UseVisualStyleBackColor = true;
            this.stBlack.TextChanged += new System.EventHandler(this.settingChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subset";
            // 
            // panelOverlapping
            // 
            this.panelOverlapping.Controls.Add(this.label8);
            this.panelOverlapping.Controls.Add(this.oGround);
            this.panelOverlapping.Controls.Add(this.label7);
            this.panelOverlapping.Controls.Add(this.oSymmetry);
            this.panelOverlapping.Controls.Add(this.oPeriodicInput);
            this.panelOverlapping.Controls.Add(this.label4);
            this.panelOverlapping.Controls.Add(this.oN);
            this.panelOverlapping.Enabled = false;
            this.panelOverlapping.Location = new System.Drawing.Point(0, 234);
            this.panelOverlapping.Name = "panelOverlapping";
            this.panelOverlapping.Size = new System.Drawing.Size(161, 106);
            this.panelOverlapping.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ground";
            // 
            // oGround
            // 
            this.oGround.Location = new System.Drawing.Point(70, 58);
            this.oGround.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.oGround.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.oGround.Name = "oGround";
            this.oGround.Size = new System.Drawing.Size(91, 20);
            this.oGround.TabIndex = 10;
            this.oGround.ValueChanged += new System.EventHandler(this.settingChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Symmetry";
            // 
            // oSymmetry
            // 
            this.oSymmetry.Location = new System.Drawing.Point(70, 32);
            this.oSymmetry.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.oSymmetry.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.oSymmetry.Name = "oSymmetry";
            this.oSymmetry.Size = new System.Drawing.Size(91, 20);
            this.oSymmetry.TabIndex = 8;
            this.oSymmetry.ValueChanged += new System.EventHandler(this.settingChanged);
            // 
            // oPeriodicInput
            // 
            this.oPeriodicInput.AutoSize = true;
            this.oPeriodicInput.Location = new System.Drawing.Point(6, 84);
            this.oPeriodicInput.Name = "oPeriodicInput";
            this.oPeriodicInput.Size = new System.Drawing.Size(91, 17);
            this.oPeriodicInput.TabIndex = 6;
            this.oPeriodicInput.Text = "Periodic Input";
            this.oPeriodicInput.UseVisualStyleBackColor = true;
            this.oPeriodicInput.CheckedChanged += new System.EventHandler(this.settingChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "N";
            // 
            // oN
            // 
            this.oN.Location = new System.Drawing.Point(70, 6);
            this.oN.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.oN.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.oN.Name = "oN";
            this.oN.Size = new System.Drawing.Size(91, 20);
            this.oN.TabIndex = 4;
            this.oN.ValueChanged += new System.EventHandler(this.settingChanged);
            // 
            // rSimpleTiled
            // 
            this.rSimpleTiled.AutoSize = true;
            this.rSimpleTiled.Checked = true;
            this.rSimpleTiled.Location = new System.Drawing.Point(3, 130);
            this.rSimpleTiled.Name = "rSimpleTiled";
            this.rSimpleTiled.Size = new System.Drawing.Size(79, 17);
            this.rSimpleTiled.TabIndex = 14;
            this.rSimpleTiled.TabStop = true;
            this.rSimpleTiled.Text = "SimpleTiled";
            this.rSimpleTiled.UseVisualStyleBackColor = true;
            // 
            // rOverlapping
            // 
            this.rOverlapping.AutoSize = true;
            this.rOverlapping.Location = new System.Drawing.Point(0, 211);
            this.rOverlapping.Name = "rOverlapping";
            this.rOverlapping.Size = new System.Drawing.Size(82, 17);
            this.rOverlapping.TabIndex = 13;
            this.rOverlapping.Text = "Overlapping";
            this.rOverlapping.UseVisualStyleBackColor = true;
            // 
            // listSamples
            // 
            this.listSamples.FormattingEnabled = true;
            this.listSamples.Location = new System.Drawing.Point(6, 19);
            this.listSamples.Name = "listSamples";
            this.listSamples.Size = new System.Drawing.Size(124, 342);
            this.listSamples.TabIndex = 9;
            this.listSamples.SelectedIndexChanged += new System.EventHandler(this.listSamples_SelectedIndexChanged);
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(6, 19);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(124, 26);
            this.cmdBrowse.TabIndex = 8;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Visible = false;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // picInput
            // 
            this.picInput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picInput.Location = new System.Drawing.Point(6, 373);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(124, 99);
            this.picInput.TabIndex = 7;
            this.picInput.TabStop = false;
            // 
            // cmdSaveText
            // 
            this.cmdSaveText.Location = new System.Drawing.Point(678, 197);
            this.cmdSaveText.Name = "cmdSaveText";
            this.cmdSaveText.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveText.TabIndex = 8;
            this.cmdSaveText.Text = "Save Text";
            this.cmdSaveText.UseVisualStyleBackColor = true;
            this.cmdSaveText.Click += new System.EventHandler(this.cmdSaveText_Click);
            // 
            // cmdSaveImage
            // 
            this.cmdSaveImage.Location = new System.Drawing.Point(759, 197);
            this.cmdSaveImage.Name = "cmdSaveImage";
            this.cmdSaveImage.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveImage.TabIndex = 9;
            this.cmdSaveImage.Text = "Save Image";
            this.cmdSaveImage.UseVisualStyleBackColor = true;
            this.cmdSaveImage.Click += new System.EventHandler(this.cmdSaveImage_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(335, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(499, 147);
            this.txtLog.TabIndex = 10;
            // 
            // cmdRun
            // 
            this.cmdRun.Location = new System.Drawing.Point(335, 197);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(337, 23);
            this.cmdRun.TabIndex = 11;
            this.cmdRun.Text = "Run";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRecalc_Click);
            // 
            // zoom
            // 
            this.zoom.Location = new System.Drawing.Point(683, 168);
            this.zoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(47, 20);
            this.zoom.TabIndex = 12;
            this.zoom.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // update
            // 
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // sRetries
            // 
            this.sRetries.Location = new System.Drawing.Point(784, 168);
            this.sRetries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sRetries.Name = "sRetries";
            this.sRetries.Size = new System.Drawing.Size(47, 20);
            this.sRetries.TabIndex = 13;
            this.sRetries.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numSeed
            // 
            this.numSeed.Location = new System.Drawing.Point(385, 166);
            this.numSeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSeed.Minimum = new decimal(new int[] {
            2147483646,
            0,
            0,
            -2147483648});
            this.numSeed.Name = "numSeed";
            this.numSeed.Size = new System.Drawing.Size(120, 20);
            this.numSeed.TabIndex = 14;
            this.numSeed.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // rndSeed
            // 
            this.rndSeed.AutoSize = true;
            this.rndSeed.Checked = true;
            this.rndSeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rndSeed.Location = new System.Drawing.Point(511, 169);
            this.rndSeed.Name = "rndSeed";
            this.rndSeed.Size = new System.Drawing.Size(107, 17);
            this.rndSeed.TabIndex = 30;
            this.rndSeed.Text = "Randomize Seed";
            this.rndSeed.UseVisualStyleBackColor = true;
            // 
            // tiles
            // 
            this.tiles.Location = new System.Drawing.Point(496, 226);
            this.tiles.Name = "tiles";
            this.tiles.Size = new System.Drawing.Size(82, 61);
            this.tiles.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(736, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Retries";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Zoom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Seed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 694);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tiles);
            this.Controls.Add(this.rndSeed);
            this.Controls.Add(this.numSeed);
            this.Controls.Add(this.sRetries);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cmdSaveImage);
            this.Controls.Add(this.cmdSaveText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picOutput);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "WaveFunctionCollapseEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sWidth)).EndInit();
            this.panelTiled.ResumeLayout(false);
            this.panelTiled.PerformLayout();
            this.panelOverlapping.ResumeLayout(false);
            this.panelOverlapping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSymmetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.ListBox listSamples;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTiled;
        private System.Windows.Forms.TextBox stSubset;
        private System.Windows.Forms.CheckBox stBlack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelOverlapping;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown oGround;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown oSymmetry;
        private System.Windows.Forms.CheckBox oPeriodicInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown oN;
        private System.Windows.Forms.RadioButton rSimpleTiled;
        private System.Windows.Forms.RadioButton rOverlapping;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox sPeriodic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown sHeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown sWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sLimit;
        private System.Windows.Forms.Button cmdSaveText;
        private System.Windows.Forms.Button cmdSaveImage;
        private System.Windows.Forms.CheckBox sTextOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.NumericUpDown zoom;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.NumericUpDown sRetries;
        private System.Windows.Forms.NumericUpDown numSeed;
        private System.Windows.Forms.CheckBox rndSeed;
        private System.Windows.Forms.FlowLayoutPanel picGroup;
        private System.Windows.Forms.Panel tiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}

