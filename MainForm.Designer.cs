
namespace ImageProccessing
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResetGamma = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbDegamma = new System.Windows.Forms.CheckBox();
            this.nudGammaMin = new System.Windows.Forms.NumericUpDown();
            this.nudGamma = new System.Windows.Forms.NumericUpDown();
            this.nudGammaMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetContrast = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudContrast = new System.Windows.Forms.NumericUpDown();
            this.trbContrast = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.nudContrastAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnResetAlpha = new System.Windows.Forms.Button();
            this.nudAlpha = new System.Windows.Forms.NumericUpDown();
            this.trbAlpha = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGrayC = new System.Windows.Forms.Button();
            this.btnGrayR = new System.Windows.Forms.Button();
            this.btnGrayG = new System.Windows.Forms.Button();
            this.btnGrayB = new System.Windows.Forms.Button();
            this.btnGrayM = new System.Windows.Forms.Button();
            this.btnGrayY = new System.Windows.Forms.Button();
            this.btnResetGray = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetThres = new System.Windows.Forms.Button();
            this.trbThres = new System.Windows.Forms.TrackBar();
            this.nudThres = new System.Windows.Forms.NumericUpDown();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chtRgb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.chtR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.chtG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.chtB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLena = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSizeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdImage = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGammaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGammaMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrastAmount)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThres)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRgb)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtR)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtG)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pcbMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 693);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 20);
            this.tabControl1.Location = new System.Drawing.Point(548, 26);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 664);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(266, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "画像処理";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnResetGamma);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.chbDegamma);
            this.groupBox5.Controls.Add(this.nudGammaMin);
            this.groupBox5.Controls.Add(this.nudGamma);
            this.groupBox5.Controls.Add(this.nudGammaMax);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.groupBox5.Location = new System.Drawing.Point(17, 505);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 97);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ガンマ補正";
            // 
            // btnResetGamma
            // 
            this.btnResetGamma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetGamma.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.btnResetGamma.Location = new System.Drawing.Point(170, 68);
            this.btnResetGamma.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnResetGamma.Name = "btnResetGamma";
            this.btnResetGamma.Size = new System.Drawing.Size(54, 23);
            this.btnResetGamma.TabIndex = 21;
            this.btnResetGamma.Text = "Reset";
            this.btnResetGamma.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(98, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "γ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(5, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "最小";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbDegamma
            // 
            this.chbDegamma.AutoSize = true;
            this.chbDegamma.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chbDegamma.Location = new System.Drawing.Point(175, 32);
            this.chbDegamma.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.chbDegamma.Name = "chbDegamma";
            this.chbDegamma.Size = new System.Drawing.Size(45, 19);
            this.chbDegamma.TabIndex = 3;
            this.chbDegamma.Text = "1/γ";
            this.chbDegamma.UseVisualStyleBackColor = true;
            // 
            // nudGammaMin
            // 
            this.nudGammaMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudGammaMin.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudGammaMin.Location = new System.Drawing.Point(40, 29);
            this.nudGammaMin.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.nudGammaMin.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudGammaMin.Name = "nudGammaMin";
            this.nudGammaMin.Size = new System.Drawing.Size(50, 23);
            this.nudGammaMin.TabIndex = 2;
            // 
            // nudGamma
            // 
            this.nudGamma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudGamma.DecimalPlaces = 2;
            this.nudGamma.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGamma.Location = new System.Drawing.Point(116, 29);
            this.nudGamma.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGamma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudGamma.Name = "nudGamma";
            this.nudGamma.Size = new System.Drawing.Size(50, 23);
            this.nudGamma.TabIndex = 2;
            this.nudGamma.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // nudGammaMax
            // 
            this.nudGammaMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudGammaMax.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudGammaMax.Location = new System.Drawing.Point(40, 59);
            this.nudGammaMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGammaMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGammaMax.Name = "nudGammaMax";
            this.nudGammaMax.Size = new System.Drawing.Size(50, 23);
            this.nudGammaMax.TabIndex = 4;
            this.nudGammaMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(5, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "最大";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetContrast);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudContrast);
            this.groupBox2.Controls.Add(this.trbContrast);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudContrastAmount);
            this.groupBox2.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(17, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 95);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "コントラスト";
            // 
            // btnResetContrast
            // 
            this.btnResetContrast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetContrast.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.btnResetContrast.Location = new System.Drawing.Point(170, 66);
            this.btnResetContrast.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnResetContrast.Name = "btnResetContrast";
            this.btnResetContrast.Size = new System.Drawing.Size(54, 23);
            this.btnResetContrast.TabIndex = 21;
            this.btnResetContrast.Text = "Reset";
            this.btnResetContrast.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "しきい値";
            // 
            // nudContrast
            // 
            this.nudContrast.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudContrast.Location = new System.Drawing.Point(58, 28);
            this.nudContrast.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudContrast.Name = "nudContrast";
            this.nudContrast.Size = new System.Drawing.Size(49, 23);
            this.nudContrast.TabIndex = 13;
            this.nudContrast.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // trbContrast
            // 
            this.trbContrast.Location = new System.Drawing.Point(109, 21);
            this.trbContrast.Maximum = 255;
            this.trbContrast.Name = "trbContrast";
            this.trbContrast.Size = new System.Drawing.Size(114, 45);
            this.trbContrast.TabIndex = 14;
            this.trbContrast.Value = 127;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "量";
            // 
            // nudContrastAmount
            // 
            this.nudContrastAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudContrastAmount.DecimalPlaces = 2;
            this.nudContrastAmount.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudContrastAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudContrastAmount.Location = new System.Drawing.Point(57, 61);
            this.nudContrastAmount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContrastAmount.Name = "nudContrastAmount";
            this.nudContrastAmount.Size = new System.Drawing.Size(49, 23);
            this.nudContrastAmount.TabIndex = 4;
            this.nudContrastAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnResetAlpha);
            this.groupBox9.Controls.Add(this.nudAlpha);
            this.groupBox9.Controls.Add(this.trbAlpha);
            this.groupBox9.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.groupBox9.Location = new System.Drawing.Point(17, 123);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(230, 90);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "αチャンネル";
            // 
            // btnResetAlpha
            // 
            this.btnResetAlpha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetAlpha.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.btnResetAlpha.Location = new System.Drawing.Point(170, 61);
            this.btnResetAlpha.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnResetAlpha.Name = "btnResetAlpha";
            this.btnResetAlpha.Size = new System.Drawing.Size(54, 23);
            this.btnResetAlpha.TabIndex = 22;
            this.btnResetAlpha.Text = "Reset";
            this.btnResetAlpha.UseVisualStyleBackColor = true;
            // 
            // nudAlpha
            // 
            this.nudAlpha.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.nudAlpha.Location = new System.Drawing.Point(15, 30);
            this.nudAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(45, 24);
            this.nudAlpha.TabIndex = 11;
            this.nudAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // trbAlpha
            // 
            this.trbAlpha.Location = new System.Drawing.Point(66, 22);
            this.trbAlpha.Maximum = 255;
            this.trbAlpha.Name = "trbAlpha";
            this.trbAlpha.Size = new System.Drawing.Size(154, 45);
            this.trbAlpha.TabIndex = 12;
            this.trbAlpha.Value = 255;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel2);
            this.groupBox7.Controls.Add(this.btnResetGray);
            this.groupBox7.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.groupBox7.Location = new System.Drawing.Point(17, 233);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(230, 128);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "グレースケール";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnGrayC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGrayR, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGrayG, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGrayB, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGrayM, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGrayY, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(201, 70);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // btnGrayC
            // 
            this.btnGrayC.BackColor = System.Drawing.Color.Cyan;
            this.btnGrayC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrayC.FlatAppearance.BorderSize = 0;
            this.btnGrayC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrayC.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrayC.ForeColor = System.Drawing.Color.Black;
            this.btnGrayC.Location = new System.Drawing.Point(3, 38);
            this.btnGrayC.Name = "btnGrayC";
            this.btnGrayC.Size = new System.Drawing.Size(61, 29);
            this.btnGrayC.TabIndex = 6;
            this.btnGrayC.Text = "C";
            this.btnGrayC.UseVisualStyleBackColor = false;
            // 
            // btnGrayR
            // 
            this.btnGrayR.BackColor = System.Drawing.Color.Red;
            this.btnGrayR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrayR.FlatAppearance.BorderSize = 0;
            this.btnGrayR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrayR.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrayR.ForeColor = System.Drawing.Color.Black;
            this.btnGrayR.Location = new System.Drawing.Point(3, 3);
            this.btnGrayR.Name = "btnGrayR";
            this.btnGrayR.Size = new System.Drawing.Size(61, 29);
            this.btnGrayR.TabIndex = 3;
            this.btnGrayR.Text = "R";
            this.btnGrayR.UseVisualStyleBackColor = false;
            // 
            // btnGrayG
            // 
            this.btnGrayG.BackColor = System.Drawing.Color.Green;
            this.btnGrayG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrayG.FlatAppearance.BorderSize = 0;
            this.btnGrayG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrayG.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrayG.ForeColor = System.Drawing.Color.Black;
            this.btnGrayG.Location = new System.Drawing.Point(70, 3);
            this.btnGrayG.Name = "btnGrayG";
            this.btnGrayG.Size = new System.Drawing.Size(61, 29);
            this.btnGrayG.TabIndex = 4;
            this.btnGrayG.Text = "G";
            this.btnGrayG.UseVisualStyleBackColor = false;
            // 
            // btnGrayB
            // 
            this.btnGrayB.BackColor = System.Drawing.Color.Blue;
            this.btnGrayB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrayB.FlatAppearance.BorderSize = 0;
            this.btnGrayB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrayB.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrayB.ForeColor = System.Drawing.Color.Black;
            this.btnGrayB.Location = new System.Drawing.Point(137, 3);
            this.btnGrayB.Name = "btnGrayB";
            this.btnGrayB.Size = new System.Drawing.Size(61, 29);
            this.btnGrayB.TabIndex = 5;
            this.btnGrayB.Text = "B";
            this.btnGrayB.UseVisualStyleBackColor = false;
            // 
            // btnGrayM
            // 
            this.btnGrayM.BackColor = System.Drawing.Color.Magenta;
            this.btnGrayM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrayM.FlatAppearance.BorderSize = 0;
            this.btnGrayM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrayM.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrayM.Location = new System.Drawing.Point(70, 38);
            this.btnGrayM.Name = "btnGrayM";
            this.btnGrayM.Size = new System.Drawing.Size(61, 29);
            this.btnGrayM.TabIndex = 7;
            this.btnGrayM.Text = "M";
            this.btnGrayM.UseVisualStyleBackColor = false;
            // 
            // btnGrayY
            // 
            this.btnGrayY.BackColor = System.Drawing.Color.Yellow;
            this.btnGrayY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrayY.FlatAppearance.BorderSize = 0;
            this.btnGrayY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrayY.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrayY.ForeColor = System.Drawing.Color.Black;
            this.btnGrayY.Location = new System.Drawing.Point(137, 38);
            this.btnGrayY.Name = "btnGrayY";
            this.btnGrayY.Size = new System.Drawing.Size(61, 29);
            this.btnGrayY.TabIndex = 8;
            this.btnGrayY.Text = "Y";
            this.btnGrayY.UseVisualStyleBackColor = false;
            // 
            // btnResetGray
            // 
            this.btnResetGray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetGray.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.btnResetGray.Location = new System.Drawing.Point(170, 99);
            this.btnResetGray.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnResetGray.Name = "btnResetGray";
            this.btnResetGray.Size = new System.Drawing.Size(54, 23);
            this.btnResetGray.TabIndex = 20;
            this.btnResetGray.Text = "Reset";
            this.btnResetGray.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetThres);
            this.groupBox1.Controls.Add(this.trbThres);
            this.groupBox1.Controls.Add(this.nudThres);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2値化";
            // 
            // btnResetThres
            // 
            this.btnResetThres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnResetThres.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.btnResetThres.Location = new System.Drawing.Point(170, 61);
            this.btnResetThres.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnResetThres.Name = "btnResetThres";
            this.btnResetThres.Size = new System.Drawing.Size(54, 23);
            this.btnResetThres.TabIndex = 20;
            this.btnResetThres.Text = "Reset";
            this.btnResetThres.UseVisualStyleBackColor = true;
            // 
            // trbThres
            // 
            this.trbThres.Location = new System.Drawing.Point(66, 21);
            this.trbThres.Maximum = 255;
            this.trbThres.Name = "trbThres";
            this.trbThres.Size = new System.Drawing.Size(154, 45);
            this.trbThres.TabIndex = 13;
            this.trbThres.Value = 255;
            // 
            // nudThres
            // 
            this.nudThres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudThres.Font = new System.Drawing.Font("Meiryo UI", 10F);
            this.nudThres.Location = new System.Drawing.Point(15, 28);
            this.nudThres.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudThres.Name = "nudThres";
            this.nudThres.Size = new System.Drawing.Size(45, 24);
            this.nudThres.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage10.Controls.Add(this.tabControl2);
            this.tabPage10.Location = new System.Drawing.Point(4, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(266, 656);
            this.tabPage10.TabIndex = 5;
            this.tabPage10.Text = "ヒストグラム";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(4, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(261, 299);
            this.tabControl2.TabIndex = 15;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.chtRgb);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(253, 271);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "RGB";
            // 
            // chtRgb
            // 
            this.chtRgb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chtRgb.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chtRgb.ChartAreas.Add(chartArea1);
            this.chtRgb.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.WhiteSmoke;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chtRgb.Legends.Add(legend1);
            this.chtRgb.Location = new System.Drawing.Point(3, 3);
            this.chtRgb.Name = "chtRgb";
            this.chtRgb.Size = new System.Drawing.Size(247, 265);
            this.chtRgb.TabIndex = 13;
            this.chtRgb.Text = "chart1";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage7.Controls.Add(this.chtR);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(253, 271);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "R成分";
            // 
            // chtR
            // 
            this.chtR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chtR.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.chtR.ChartAreas.Add(chartArea2);
            this.chtR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.WhiteSmoke;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chtR.Legends.Add(legend2);
            this.chtR.Location = new System.Drawing.Point(3, 3);
            this.chtR.Name = "chtR";
            this.chtR.Size = new System.Drawing.Size(247, 265);
            this.chtR.TabIndex = 14;
            this.chtR.Text = "chart1";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage8.Controls.Add(this.chtG);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(253, 271);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "G成分";
            // 
            // chtG
            // 
            this.chtG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chtG.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.chtG.ChartAreas.Add(chartArea3);
            this.chtG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.BackColor = System.Drawing.Color.WhiteSmoke;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chtG.Legends.Add(legend3);
            this.chtG.Location = new System.Drawing.Point(3, 3);
            this.chtG.Name = "chtG";
            this.chtG.Size = new System.Drawing.Size(247, 265);
            this.chtG.TabIndex = 14;
            this.chtG.Text = "chart1";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage9.Controls.Add(this.chtB);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(253, 271);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "B成分";
            // 
            // chtB
            // 
            this.chtB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chtB.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea4.Name = "ChartArea1";
            this.chtB.ChartAreas.Add(chartArea4);
            this.chtB.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.BackColor = System.Drawing.Color.WhiteSmoke;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chtB.Legends.Add(legend4);
            this.chtB.Location = new System.Drawing.Point(3, 3);
            this.chtB.Name = "chtB";
            this.chtB.Size = new System.Drawing.Size(247, 265);
            this.chtB.TabIndex = 14;
            this.chtB.Text = "chart1";
            // 
            // pcbMain
            // 
            this.pcbMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbMain.Location = new System.Drawing.Point(3, 26);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(539, 664);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMain.TabIndex = 2;
            this.pcbMain.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmSizeMode});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 23);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuLena,
            this.toolStripMenuItem2,
            this.mnuClose});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(70, 19);
            this.tsmFile.Text = "ファイル(&F)";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(174, 22);
            this.mnuOpen.Text = "開く(&O)...";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(174, 22);
            this.mnuSave.Text = "保存(&S)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuLena
            // 
            this.mnuLena.Name = "mnuLena";
            this.mnuLena.Size = new System.Drawing.Size(174, 22);
            this.mnuLena.Text = "サンプル画像(Lena)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuClose.Size = new System.Drawing.Size(174, 22);
            this.mnuClose.Text = "終了(&X)";
            // 
            // tsmSizeMode
            // 
            this.tsmSizeMode.Name = "tsmSizeMode";
            this.tsmSizeMode.Size = new System.Drawing.Size(88, 19);
            this.tsmSizeMode.Text = "表示モード(&V)";
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "image";
            // 
            // sfdImage
            // 
            this.sfdImage.FileName = "Result";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "ImageProccessing";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGammaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGammaMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContrastAmount)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThres)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtRgb)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtR)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtG)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnResetAlpha;
        private System.Windows.Forms.NumericUpDown nudAlpha;
        private System.Windows.Forms.TrackBar trbAlpha;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnResetGray;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetThres;
        private System.Windows.Forms.TrackBar trbThres;
        private System.Windows.Forms.NumericUpDown nudThres;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRgb;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtR;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtG;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtB;
        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuLena;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem tsmSizeMode;
        private System.Windows.Forms.Button btnGrayC;
        private System.Windows.Forms.Button btnGrayR;
        private System.Windows.Forms.Button btnGrayG;
        private System.Windows.Forms.Button btnGrayB;
        private System.Windows.Forms.Button btnGrayM;
        private System.Windows.Forms.Button btnGrayY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetContrast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudContrast;
        private System.Windows.Forms.TrackBar trbContrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudContrastAmount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnResetGamma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbDegamma;
        private System.Windows.Forms.NumericUpDown nudGammaMin;
        private System.Windows.Forms.NumericUpDown nudGamma;
        private System.Windows.Forms.NumericUpDown nudGammaMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.SaveFileDialog sfdImage;
    }
}

