namespace RasterMaSys.UI
{
    partial class InterpolationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterpolationForm));
            this.txb_inputImg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_selectImg = new System.Windows.Forms.Button();
            this.gb_regressionMethod = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.NumericUpDown();
            this.num7 = new System.Windows.Forms.NumericUpDown();
            this.btn_interpolation = new System.Windows.Forms.Button();
            this.btn_saveImg = new System.Windows.Forms.Button();
            this.gb_waterFields = new System.Windows.Forms.GroupBox();
            this.rad_COD = new System.Windows.Forms.RadioButton();
            this.rad_NH4N = new System.Windows.Forms.RadioButton();
            this.rad_TN = new System.Windows.Forms.RadioButton();
            this.rad_TP = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.label_fun = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txb_output = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.gb_regressionMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num7)).BeginInit();
            this.gb_waterFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_inputImg
            // 
            this.txb_inputImg.Location = new System.Drawing.Point(78, 14);
            this.txb_inputImg.Name = "txb_inputImg";
            this.txb_inputImg.Size = new System.Drawing.Size(283, 21);
            this.txb_inputImg.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "输入影像:";
            // 
            // btn_selectImg
            // 
            this.btn_selectImg.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectImg.Image")));
            this.btn_selectImg.Location = new System.Drawing.Point(367, 12);
            this.btn_selectImg.Name = "btn_selectImg";
            this.btn_selectImg.Size = new System.Drawing.Size(27, 23);
            this.btn_selectImg.TabIndex = 13;
            this.btn_selectImg.UseVisualStyleBackColor = true;
            this.btn_selectImg.Click += new System.EventHandler(this.btn_selectImg_Click);
            // 
            // gb_regressionMethod
            // 
            this.gb_regressionMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_regressionMethod.Controls.Add(this.radioButton1);
            this.gb_regressionMethod.Controls.Add(this.radioButton2);
            this.gb_regressionMethod.Controls.Add(this.radioButton3);
            this.gb_regressionMethod.Controls.Add(this.radioButton4);
            this.gb_regressionMethod.Location = new System.Drawing.Point(14, 46);
            this.gb_regressionMethod.Name = "gb_regressionMethod";
            this.gb_regressionMethod.Size = new System.Drawing.Size(380, 54);
            this.gb_regressionMethod.TabIndex = 14;
            this.gb_regressionMethod.TabStop = false;
            this.gb_regressionMethod.Text = "模型拟合方法";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(292, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "指数模型";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(197, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "二次模型";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(106, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "多元线性";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "一元线性";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "回归方程:";
            // 
            // num2
            // 
            this.num2.DecimalPlaces = 3;
            this.num2.Location = new System.Drawing.Point(300, 111);
            this.num2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(58, 21);
            this.num2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "*";
            // 
            // cmb2
            // 
            this.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "b1",
            "b2",
            "b3",
            "b4",
            "b5",
            "b6",
            "b7",
            "b1/b2",
            "b1/b4",
            "b2/b4",
            "b4/(b1+b2)",
            "b4/(b1+b3)",
            "(b4-b2)/(b4+b2)"});
            this.cmb2.Location = new System.Drawing.Point(381, 111);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 20);
            this.cmb2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(508, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "^2+";
            // 
            // cmb3
            // 
            this.cmb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3.FormattingEnabled = true;
            this.cmb3.Items.AddRange(new object[] {
            "b1",
            "b2",
            "b3",
            "b4",
            "b5",
            "b6",
            "b7",
            "b1/b2",
            "b1/b4",
            "b2/b4",
            "b4/(b1+b2)",
            "b4/(b1+b3)",
            "(b4-b2)/(b4+b2)"});
            this.cmb3.Location = new System.Drawing.Point(624, 110);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(122, 20);
            this.cmb3.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // num3
            // 
            this.num3.DecimalPlaces = 3;
            this.num3.Location = new System.Drawing.Point(537, 111);
            this.num3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(58, 21);
            this.num3.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "+";
            // 
            // cmb4
            // 
            this.cmb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb4.FormattingEnabled = true;
            this.cmb4.Items.AddRange(new object[] {
            "b1",
            "b2",
            "b3",
            "b4",
            "b5",
            "b6",
            "b7",
            "b1/b2",
            "b1/b4",
            "b2/b4",
            "b4/(b1+b2)",
            "b4/(b1+b3)",
            "(b4-b2)/(b4+b2)"});
            this.cmb4.Location = new System.Drawing.Point(153, 150);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(122, 20);
            this.cmb4.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "*";
            // 
            // num4
            // 
            this.num4.DecimalPlaces = 3;
            this.num4.Location = new System.Drawing.Point(74, 150);
            this.num4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(58, 21);
            this.num4.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "+";
            // 
            // cmb5
            // 
            this.cmb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb5.FormattingEnabled = true;
            this.cmb5.Items.AddRange(new object[] {
            "b1",
            "b2",
            "b3",
            "b4",
            "b5",
            "b6",
            "b7",
            "b1/b2",
            "b1/b4",
            "b2/b4",
            "b4/(b1+b2)",
            "b4/(b1+b3)",
            "(b4-b2)/(b4+b2)"});
            this.cmb5.Location = new System.Drawing.Point(378, 150);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(124, 20);
            this.cmb5.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "*";
            // 
            // num5
            // 
            this.num5.DecimalPlaces = 3;
            this.num5.Location = new System.Drawing.Point(303, 150);
            this.num5.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(58, 21);
            this.num5.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(755, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 35;
            this.label11.Text = "+";
            // 
            // cmb6
            // 
            this.cmb6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb6.FormattingEnabled = true;
            this.cmb6.Items.AddRange(new object[] {
            "b1",
            "b2",
            "b3",
            "b4",
            "b5",
            "b6",
            "b7",
            "b1/b2",
            "b1/b4",
            "b2/b4",
            "b4/(b1+b2)",
            "b4/(b1+b3)",
            "(b4-b2)/(b4+b2)"});
            this.cmb6.Location = new System.Drawing.Point(623, 148);
            this.cmb6.Name = "cmb6";
            this.cmb6.Size = new System.Drawing.Size(123, 20);
            this.cmb6.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(603, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "*";
            // 
            // num6
            // 
            this.num6.DecimalPlaces = 3;
            this.num6.Location = new System.Drawing.Point(539, 148);
            this.num6.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num6.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(58, 21);
            this.num6.TabIndex = 32;
            // 
            // num7
            // 
            this.num7.DecimalPlaces = 3;
            this.num7.Location = new System.Drawing.Point(772, 147);
            this.num7.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num7.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(58, 21);
            this.num7.TabIndex = 36;
            // 
            // btn_interpolation
            // 
            this.btn_interpolation.Location = new System.Drawing.Point(72, 207);
            this.btn_interpolation.Name = "btn_interpolation";
            this.btn_interpolation.Size = new System.Drawing.Size(75, 28);
            this.btn_interpolation.TabIndex = 40;
            this.btn_interpolation.Text = "插值水质";
            this.btn_interpolation.UseVisualStyleBackColor = true;
            this.btn_interpolation.Click += new System.EventHandler(this.btn_interpolation_Click);
            // 
            // btn_saveImg
            // 
            this.btn_saveImg.Location = new System.Drawing.Point(178, 207);
            this.btn_saveImg.Name = "btn_saveImg";
            this.btn_saveImg.Size = new System.Drawing.Size(104, 28);
            this.btn_saveImg.TabIndex = 43;
            this.btn_saveImg.Text = "导出水质分布图";
            this.btn_saveImg.UseVisualStyleBackColor = true;
            this.btn_saveImg.Click += new System.EventHandler(this.btn_saveImg_Click);
            // 
            // gb_waterFields
            // 
            this.gb_waterFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_waterFields.Controls.Add(this.rad_COD);
            this.gb_waterFields.Controls.Add(this.rad_NH4N);
            this.gb_waterFields.Controls.Add(this.rad_TN);
            this.gb_waterFields.Controls.Add(this.rad_TP);
            this.gb_waterFields.Location = new System.Drawing.Point(425, 46);
            this.gb_waterFields.Name = "gb_waterFields";
            this.gb_waterFields.Size = new System.Drawing.Size(401, 54);
            this.gb_waterFields.TabIndex = 44;
            this.gb_waterFields.TabStop = false;
            this.gb_waterFields.Text = "反演水质参数因变量";
            // 
            // rad_COD
            // 
            this.rad_COD.AutoSize = true;
            this.rad_COD.Location = new System.Drawing.Point(256, 24);
            this.rad_COD.Name = "rad_COD";
            this.rad_COD.Size = new System.Drawing.Size(83, 16);
            this.rad_COD.TabIndex = 3;
            this.rad_COD.TabStop = true;
            this.rad_COD.Text = "化学需氧量";
            this.rad_COD.UseVisualStyleBackColor = true;
            // 
            // rad_NH4N
            // 
            this.rad_NH4N.AutoSize = true;
            this.rad_NH4N.Location = new System.Drawing.Point(178, 24);
            this.rad_NH4N.Name = "rad_NH4N";
            this.rad_NH4N.Size = new System.Drawing.Size(47, 16);
            this.rad_NH4N.TabIndex = 2;
            this.rad_NH4N.TabStop = true;
            this.rad_NH4N.Text = "氨氮";
            this.rad_NH4N.UseVisualStyleBackColor = true;
            // 
            // rad_TN
            // 
            this.rad_TN.AutoSize = true;
            this.rad_TN.Location = new System.Drawing.Point(100, 24);
            this.rad_TN.Name = "rad_TN";
            this.rad_TN.Size = new System.Drawing.Size(47, 16);
            this.rad_TN.TabIndex = 1;
            this.rad_TN.TabStop = true;
            this.rad_TN.Text = "总氮";
            this.rad_TN.UseVisualStyleBackColor = true;
            // 
            // rad_TP
            // 
            this.rad_TP.AutoSize = true;
            this.rad_TP.Checked = true;
            this.rad_TP.Location = new System.Drawing.Point(22, 24);
            this.rad_TP.Name = "rad_TP";
            this.rad_TP.Size = new System.Drawing.Size(47, 16);
            this.rad_TP.TabIndex = 0;
            this.rad_TP.TabStop = true;
            this.rad_TP.Text = "总磷";
            this.rad_TP.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 48;
            this.label13.Text = "+";
            // 
            // cmb1
            // 
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "b1",
            "b2",
            "b3",
            "b4",
            "b5",
            "b6",
            "b7",
            "b1/b2",
            "b1/b4",
            "b2/b4",
            "b4/(b1+b2)",
            "b4/(b1+b3)",
            "(b4-b2)/(b4+b2)"});
            this.cmb1.Location = new System.Drawing.Point(154, 111);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(124, 20);
            this.cmb1.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(136, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 16);
            this.label14.TabIndex = 46;
            this.label14.Text = "^";
            // 
            // num1
            // 
            this.num1.DecimalPlaces = 3;
            this.num1.Location = new System.Drawing.Point(74, 112);
            this.num1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(58, 21);
            this.num1.TabIndex = 45;
            // 
            // label_fun
            // 
            this.label_fun.AutoSize = true;
            this.label_fun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_fun.Location = new System.Drawing.Point(76, 183);
            this.label_fun.Name = "label_fun";
            this.label_fun.Size = new System.Drawing.Size(0, 12);
            this.label_fun.TabIndex = 49;
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(787, 8);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(27, 23);
            this.btn_save.TabIndex = 52;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txb_output
            // 
            this.txb_output.Location = new System.Drawing.Point(498, 10);
            this.txb_output.Name = "txb_output";
            this.txb_output.Size = new System.Drawing.Size(283, 21);
            this.txb_output.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(432, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 50;
            this.label15.Text = "输出结果:";
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Location = new System.Drawing.Point(13, 252);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(817, 345);
            this.axPageLayoutControl1.TabIndex = 53;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(71, 418);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 54;
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(306, 207);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(265, 28);
            this.axToolbarControl1.TabIndex = 55;
            // 
            // InterpolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 609);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axPageLayoutControl1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txb_output);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label_fun);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.gb_waterFields);
            this.Controls.Add(this.btn_saveImg);
            this.Controls.Add(this.btn_interpolation);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_regressionMethod);
            this.Controls.Add(this.btn_selectImg);
            this.Controls.Add(this.txb_inputImg);
            this.Controls.Add(this.label1);
            this.Name = "InterpolationForm";
            this.Text = "插值";
            this.gb_regressionMethod.ResumeLayout(false);
            this.gb_regressionMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num7)).EndInit();
            this.gb_waterFields.ResumeLayout(false);
            this.gb_waterFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectImg;
        private System.Windows.Forms.TextBox txb_inputImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_regressionMethod;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown num6;
        private System.Windows.Forms.NumericUpDown num7;
        private System.Windows.Forms.Button btn_interpolation;
        private System.Windows.Forms.Button btn_saveImg;
        private System.Windows.Forms.GroupBox gb_waterFields;
        private System.Windows.Forms.RadioButton rad_COD;
        private System.Windows.Forms.RadioButton rad_NH4N;
        private System.Windows.Forms.RadioButton rad_TN;
        private System.Windows.Forms.RadioButton rad_TP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Label label_fun;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txb_output;
        private System.Windows.Forms.Label label15;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
    }
}