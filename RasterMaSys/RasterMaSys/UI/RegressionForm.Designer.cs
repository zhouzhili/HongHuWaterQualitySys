namespace RasterMaSys.UI
{
    partial class RegressionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegressionForm));
            this.cmb_QualityList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_inputImg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_selectImg = new System.Windows.Forms.Button();
            this.gb_waterFields = new System.Windows.Forms.GroupBox();
            this.rad_COD = new System.Windows.Forms.RadioButton();
            this.rad_NH4N = new System.Windows.Forms.RadioButton();
            this.rad_TN = new System.Windows.Forms.RadioButton();
            this.rad_TP = new System.Windows.Forms.RadioButton();
            this.gb_regressionMethod = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gb_bands = new System.Windows.Forms.GroupBox();
            this.ck6 = new System.Windows.Forms.CheckBox();
            this.ck5 = new System.Windows.Forms.CheckBox();
            this.ck4 = new System.Windows.Forms.CheckBox();
            this.ck3 = new System.Windows.Forms.CheckBox();
            this.ck2 = new System.Windows.Forms.CheckBox();
            this.ck1 = new System.Windows.Forms.CheckBox();
            this.ck_b7 = new System.Windows.Forms.CheckBox();
            this.ck_b6 = new System.Windows.Forms.CheckBox();
            this.ck_b5 = new System.Windows.Forms.CheckBox();
            this.ck_b4 = new System.Windows.Forms.CheckBox();
            this.ck_b3 = new System.Windows.Forms.CheckBox();
            this.ck_b2 = new System.Windows.Forms.CheckBox();
            this.ck_b1 = new System.Windows.Forms.CheckBox();
            this.btn_saveInfo = new System.Windows.Forms.Button();
            this.btn_clearInfo = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.richtxb_info = new System.Windows.Forms.RichTextBox();
            this.gb_waterFields.SuspendLayout();
            this.gb_regressionMethod.SuspendLayout();
            this.gb_bands.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_QualityList
            // 
            this.cmb_QualityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_QualityList.FormattingEnabled = true;
            this.cmb_QualityList.Location = new System.Drawing.Point(78, 44);
            this.cmb_QualityList.Name = "cmb_QualityList";
            this.cmb_QualityList.Size = new System.Drawing.Size(132, 20);
            this.cmb_QualityList.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "水质数据:";
            // 
            // txb_inputImg
            // 
            this.txb_inputImg.Location = new System.Drawing.Point(78, 9);
            this.txb_inputImg.Name = "txb_inputImg";
            this.txb_inputImg.Size = new System.Drawing.Size(619, 21);
            this.txb_inputImg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "输入影像:";
            // 
            // btn_selectImg
            // 
            this.btn_selectImg.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectImg.Image")));
            this.btn_selectImg.Location = new System.Drawing.Point(703, 7);
            this.btn_selectImg.Name = "btn_selectImg";
            this.btn_selectImg.Size = new System.Drawing.Size(27, 23);
            this.btn_selectImg.TabIndex = 7;
            this.btn_selectImg.UseVisualStyleBackColor = true;
            this.btn_selectImg.Click += new System.EventHandler(this.btn_selectImg_Click);
            // 
            // gb_waterFields
            // 
            this.gb_waterFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_waterFields.Controls.Add(this.rad_COD);
            this.gb_waterFields.Controls.Add(this.rad_NH4N);
            this.gb_waterFields.Controls.Add(this.rad_TN);
            this.gb_waterFields.Controls.Add(this.rad_TP);
            this.gb_waterFields.Location = new System.Drawing.Point(12, 83);
            this.gb_waterFields.Name = "gb_waterFields";
            this.gb_waterFields.Size = new System.Drawing.Size(718, 54);
            this.gb_waterFields.TabIndex = 10;
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
            // gb_regressionMethod
            // 
            this.gb_regressionMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_regressionMethod.Controls.Add(this.radioButton1);
            this.gb_regressionMethod.Controls.Add(this.radioButton2);
            this.gb_regressionMethod.Controls.Add(this.radioButton3);
            this.gb_regressionMethod.Controls.Add(this.radioButton4);
            this.gb_regressionMethod.Location = new System.Drawing.Point(12, 263);
            this.gb_regressionMethod.Name = "gb_regressionMethod";
            this.gb_regressionMethod.Size = new System.Drawing.Size(718, 54);
            this.gb_regressionMethod.TabIndex = 11;
            this.gb_regressionMethod.TabStop = false;
            this.gb_regressionMethod.Text = "拟合方法";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(302, 25);
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
            this.radioButton2.Location = new System.Drawing.Point(209, 25);
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
            this.radioButton3.Location = new System.Drawing.Point(116, 25);
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
            this.radioButton4.Location = new System.Drawing.Point(23, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "一元线性";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gb_bands
            // 
            this.gb_bands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_bands.Controls.Add(this.ck6);
            this.gb_bands.Controls.Add(this.ck5);
            this.gb_bands.Controls.Add(this.ck4);
            this.gb_bands.Controls.Add(this.ck3);
            this.gb_bands.Controls.Add(this.ck2);
            this.gb_bands.Controls.Add(this.ck1);
            this.gb_bands.Controls.Add(this.ck_b7);
            this.gb_bands.Controls.Add(this.ck_b6);
            this.gb_bands.Controls.Add(this.ck_b5);
            this.gb_bands.Controls.Add(this.ck_b4);
            this.gb_bands.Controls.Add(this.ck_b3);
            this.gb_bands.Controls.Add(this.ck_b2);
            this.gb_bands.Controls.Add(this.ck_b1);
            this.gb_bands.Location = new System.Drawing.Point(12, 156);
            this.gb_bands.Name = "gb_bands";
            this.gb_bands.Size = new System.Drawing.Size(718, 88);
            this.gb_bands.TabIndex = 12;
            this.gb_bands.TabStop = false;
            this.gb_bands.Text = "反演水质参数自变量";
            // 
            // ck6
            // 
            this.ck6.AutoSize = true;
            this.ck6.Location = new System.Drawing.Point(277, 62);
            this.ck6.Name = "ck6";
            this.ck6.Size = new System.Drawing.Size(84, 16);
            this.ck6.TabIndex = 14;
            this.ck6.Text = "b4/(b1+b3)";
            this.ck6.UseVisualStyleBackColor = true;
            // 
            // ck5
            // 
            this.ck5.AutoSize = true;
            this.ck5.Location = new System.Drawing.Point(149, 62);
            this.ck5.Name = "ck5";
            this.ck5.Size = new System.Drawing.Size(84, 16);
            this.ck5.TabIndex = 13;
            this.ck5.Text = "b4/(b1+b2)";
            this.ck5.UseVisualStyleBackColor = true;
            // 
            // ck4
            // 
            this.ck4.AutoSize = true;
            this.ck4.Location = new System.Drawing.Point(22, 63);
            this.ck4.Name = "ck4";
            this.ck4.Size = new System.Drawing.Size(114, 16);
            this.ck4.TabIndex = 12;
            this.ck4.Text = "(b4-b2)/(b4+b2)";
            this.ck4.UseVisualStyleBackColor = true;
            // 
            // ck3
            // 
            this.ck3.AutoSize = true;
            this.ck3.Location = new System.Drawing.Point(622, 30);
            this.ck3.Name = "ck3";
            this.ck3.Size = new System.Drawing.Size(54, 16);
            this.ck3.TabIndex = 11;
            this.ck3.Text = "b2/b4";
            this.ck3.UseVisualStyleBackColor = true;
            // 
            // ck2
            // 
            this.ck2.AutoSize = true;
            this.ck2.Location = new System.Drawing.Point(541, 30);
            this.ck2.Name = "ck2";
            this.ck2.Size = new System.Drawing.Size(54, 16);
            this.ck2.TabIndex = 10;
            this.ck2.Text = "b1/b4";
            this.ck2.UseVisualStyleBackColor = true;
            // 
            // ck1
            // 
            this.ck1.AutoSize = true;
            this.ck1.Location = new System.Drawing.Point(461, 30);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(54, 16);
            this.ck1.TabIndex = 9;
            this.ck1.Text = "b1/b2";
            this.ck1.UseVisualStyleBackColor = true;
            // 
            // ck_b7
            // 
            this.ck_b7.AutoSize = true;
            this.ck_b7.Location = new System.Drawing.Point(406, 30);
            this.ck_b7.Name = "ck_b7";
            this.ck_b7.Size = new System.Drawing.Size(36, 16);
            this.ck_b7.TabIndex = 6;
            this.ck_b7.Text = "b7";
            this.ck_b7.UseVisualStyleBackColor = true;
            // 
            // ck_b6
            // 
            this.ck_b6.AutoSize = true;
            this.ck_b6.Location = new System.Drawing.Point(345, 30);
            this.ck_b6.Name = "ck_b6";
            this.ck_b6.Size = new System.Drawing.Size(36, 16);
            this.ck_b6.TabIndex = 5;
            this.ck_b6.Text = "b6";
            this.ck_b6.UseVisualStyleBackColor = true;
            // 
            // ck_b5
            // 
            this.ck_b5.AutoSize = true;
            this.ck_b5.Location = new System.Drawing.Point(277, 30);
            this.ck_b5.Name = "ck_b5";
            this.ck_b5.Size = new System.Drawing.Size(36, 16);
            this.ck_b5.TabIndex = 4;
            this.ck_b5.Text = "b5";
            this.ck_b5.UseVisualStyleBackColor = true;
            // 
            // ck_b4
            // 
            this.ck_b4.AutoSize = true;
            this.ck_b4.Location = new System.Drawing.Point(212, 30);
            this.ck_b4.Name = "ck_b4";
            this.ck_b4.Size = new System.Drawing.Size(36, 16);
            this.ck_b4.TabIndex = 3;
            this.ck_b4.Text = "b4";
            this.ck_b4.UseVisualStyleBackColor = true;
            // 
            // ck_b3
            // 
            this.ck_b3.AutoSize = true;
            this.ck_b3.Location = new System.Drawing.Point(149, 30);
            this.ck_b3.Name = "ck_b3";
            this.ck_b3.Size = new System.Drawing.Size(36, 16);
            this.ck_b3.TabIndex = 2;
            this.ck_b3.Text = "b3";
            this.ck_b3.UseVisualStyleBackColor = true;
            // 
            // ck_b2
            // 
            this.ck_b2.AutoSize = true;
            this.ck_b2.Location = new System.Drawing.Point(82, 30);
            this.ck_b2.Name = "ck_b2";
            this.ck_b2.Size = new System.Drawing.Size(36, 16);
            this.ck_b2.TabIndex = 1;
            this.ck_b2.Text = "b2";
            this.ck_b2.UseVisualStyleBackColor = true;
            // 
            // ck_b1
            // 
            this.ck_b1.AutoSize = true;
            this.ck_b1.Checked = true;
            this.ck_b1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_b1.Location = new System.Drawing.Point(23, 30);
            this.ck_b1.Name = "ck_b1";
            this.ck_b1.Size = new System.Drawing.Size(36, 16);
            this.ck_b1.TabIndex = 0;
            this.ck_b1.Text = "b1";
            this.ck_b1.UseVisualStyleBackColor = true;
            // 
            // btn_saveInfo
            // 
            this.btn_saveInfo.Location = new System.Drawing.Point(376, 341);
            this.btn_saveInfo.Name = "btn_saveInfo";
            this.btn_saveInfo.Size = new System.Drawing.Size(85, 34);
            this.btn_saveInfo.TabIndex = 16;
            this.btn_saveInfo.Text = "保存信息";
            this.btn_saveInfo.UseVisualStyleBackColor = true;
            this.btn_saveInfo.Click += new System.EventHandler(this.btn_saveInfo_Click);
            // 
            // btn_clearInfo
            // 
            this.btn_clearInfo.Location = new System.Drawing.Point(253, 341);
            this.btn_clearInfo.Name = "btn_clearInfo";
            this.btn_clearInfo.Size = new System.Drawing.Size(85, 34);
            this.btn_clearInfo.TabIndex = 15;
            this.btn_clearInfo.Text = "清除信息";
            this.btn_clearInfo.UseVisualStyleBackColor = true;
            this.btn_clearInfo.Click += new System.EventHandler(this.btn_clearInfo_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(494, 341);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 34);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(132, 341);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(85, 34);
            this.btn_Calculate.TabIndex = 13;
            this.btn_Calculate.Text = "计算回归模型";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // richtxb_info
            // 
            this.richtxb_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxb_info.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richtxb_info.Location = new System.Drawing.Point(14, 404);
            this.richtxb_info.Name = "richtxb_info";
            this.richtxb_info.ReadOnly = true;
            this.richtxb_info.Size = new System.Drawing.Size(716, 250);
            this.richtxb_info.TabIndex = 17;
            this.richtxb_info.Text = "";
            // 
            // RegressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 666);
            this.Controls.Add(this.richtxb_info);
            this.Controls.Add(this.btn_saveInfo);
            this.Controls.Add(this.btn_clearInfo);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.gb_bands);
            this.Controls.Add(this.gb_regressionMethod);
            this.Controls.Add(this.gb_waterFields);
            this.Controls.Add(this.cmb_QualityList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_selectImg);
            this.Controls.Add(this.txb_inputImg);
            this.Controls.Add(this.label1);
            this.Name = "RegressionForm";
            this.Text = "回归拟合";
            this.gb_waterFields.ResumeLayout(false);
            this.gb_waterFields.PerformLayout();
            this.gb_regressionMethod.ResumeLayout(false);
            this.gb_regressionMethod.PerformLayout();
            this.gb_bands.ResumeLayout(false);
            this.gb_bands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_QualityList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_selectImg;
        private System.Windows.Forms.TextBox txb_inputImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_waterFields;
        private System.Windows.Forms.RadioButton rad_COD;
        private System.Windows.Forms.RadioButton rad_NH4N;
        private System.Windows.Forms.RadioButton rad_TN;
        private System.Windows.Forms.RadioButton rad_TP;
        private System.Windows.Forms.GroupBox gb_regressionMethod;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gb_bands;
        private System.Windows.Forms.CheckBox ck5;
        private System.Windows.Forms.CheckBox ck4;
        private System.Windows.Forms.CheckBox ck3;
        private System.Windows.Forms.CheckBox ck2;
        private System.Windows.Forms.CheckBox ck1;
        private System.Windows.Forms.CheckBox ck_b7;
        private System.Windows.Forms.CheckBox ck_b6;
        private System.Windows.Forms.CheckBox ck_b5;
        private System.Windows.Forms.CheckBox ck_b4;
        private System.Windows.Forms.CheckBox ck_b3;
        private System.Windows.Forms.CheckBox ck_b2;
        private System.Windows.Forms.CheckBox ck_b1;
        private System.Windows.Forms.Button btn_saveInfo;
        private System.Windows.Forms.Button btn_clearInfo;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.CheckBox ck6;
        private System.Windows.Forms.RichTextBox richtxb_info;
    }
}