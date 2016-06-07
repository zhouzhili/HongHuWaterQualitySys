namespace RasterMaSys.UI
{
    partial class CalculateRelativityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateRelativityForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_inputImg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_QualityList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_COD = new System.Windows.Forms.CheckBox();
            this.checkBox_NH4N = new System.Windows.Forms.CheckBox();
            this.checkBox_TN = new System.Windows.Forms.CheckBox();
            this.checkBox_TP = new System.Windows.Forms.CheckBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.richtxb_result = new System.Windows.Forms.RichTextBox();
            this.btn_selectImg = new System.Windows.Forms.Button();
            this.btn_clearInfo = new System.Windows.Forms.Button();
            this.btn_saveInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入影像:";
            // 
            // txb_inputImg
            // 
            this.txb_inputImg.Location = new System.Drawing.Point(79, 13);
            this.txb_inputImg.Name = "txb_inputImg";
            this.txb_inputImg.Size = new System.Drawing.Size(467, 21);
            this.txb_inputImg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "水质数据:";
            // 
            // cmb_QualityList
            // 
            this.cmb_QualityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_QualityList.FormattingEnabled = true;
            this.cmb_QualityList.Location = new System.Drawing.Point(79, 53);
            this.cmb_QualityList.Name = "cmb_QualityList";
            this.cmb_QualityList.Size = new System.Drawing.Size(132, 20);
            this.cmb_QualityList.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_COD);
            this.groupBox1.Controls.Add(this.checkBox_NH4N);
            this.groupBox1.Controls.Add(this.checkBox_TN);
            this.groupBox1.Controls.Add(this.checkBox_TP);
            this.groupBox1.Location = new System.Drawing.Point(10, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水质参数";
            // 
            // checkBox_COD
            // 
            this.checkBox_COD.AutoSize = true;
            this.checkBox_COD.Checked = true;
            this.checkBox_COD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_COD.Location = new System.Drawing.Point(287, 25);
            this.checkBox_COD.Name = "checkBox_COD";
            this.checkBox_COD.Size = new System.Drawing.Size(84, 16);
            this.checkBox_COD.TabIndex = 3;
            this.checkBox_COD.Text = "化学需氧量";
            this.checkBox_COD.UseVisualStyleBackColor = true;
            // 
            // checkBox_NH4N
            // 
            this.checkBox_NH4N.AutoSize = true;
            this.checkBox_NH4N.Checked = true;
            this.checkBox_NH4N.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_NH4N.Location = new System.Drawing.Point(211, 25);
            this.checkBox_NH4N.Name = "checkBox_NH4N";
            this.checkBox_NH4N.Size = new System.Drawing.Size(48, 16);
            this.checkBox_NH4N.TabIndex = 2;
            this.checkBox_NH4N.Text = "氨氮";
            this.checkBox_NH4N.UseVisualStyleBackColor = true;
            // 
            // checkBox_TN
            // 
            this.checkBox_TN.AutoSize = true;
            this.checkBox_TN.Checked = true;
            this.checkBox_TN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TN.Location = new System.Drawing.Point(140, 25);
            this.checkBox_TN.Name = "checkBox_TN";
            this.checkBox_TN.Size = new System.Drawing.Size(48, 16);
            this.checkBox_TN.TabIndex = 1;
            this.checkBox_TN.Text = "总氮";
            this.checkBox_TN.UseVisualStyleBackColor = true;
            // 
            // checkBox_TP
            // 
            this.checkBox_TP.AutoSize = true;
            this.checkBox_TP.Checked = true;
            this.checkBox_TP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_TP.Location = new System.Drawing.Point(69, 25);
            this.checkBox_TP.Name = "checkBox_TP";
            this.checkBox_TP.Size = new System.Drawing.Size(48, 16);
            this.checkBox_TP.TabIndex = 0;
            this.checkBox_TP.Text = "总磷";
            this.checkBox_TP.UseVisualStyleBackColor = true;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(66, 174);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(85, 34);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "计算相关性";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(428, 174);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 34);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // richtxb_result
            // 
            this.richtxb_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxb_result.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richtxb_result.Location = new System.Drawing.Point(10, 224);
            this.richtxb_result.Name = "richtxb_result";
            this.richtxb_result.ReadOnly = true;
            this.richtxb_result.Size = new System.Drawing.Size(566, 263);
            this.richtxb_result.TabIndex = 8;
            this.richtxb_result.Text = "";
            // 
            // btn_selectImg
            // 
            this.btn_selectImg.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectImg.Image")));
            this.btn_selectImg.Location = new System.Drawing.Point(552, 12);
            this.btn_selectImg.Name = "btn_selectImg";
            this.btn_selectImg.Size = new System.Drawing.Size(27, 23);
            this.btn_selectImg.TabIndex = 2;
            this.btn_selectImg.UseVisualStyleBackColor = true;
            this.btn_selectImg.Click += new System.EventHandler(this.btn_selectImg_Click);
            // 
            // btn_clearInfo
            // 
            this.btn_clearInfo.Location = new System.Drawing.Point(187, 174);
            this.btn_clearInfo.Name = "btn_clearInfo";
            this.btn_clearInfo.Size = new System.Drawing.Size(85, 34);
            this.btn_clearInfo.TabIndex = 9;
            this.btn_clearInfo.Text = "清除信息";
            this.btn_clearInfo.UseVisualStyleBackColor = true;
            this.btn_clearInfo.Click += new System.EventHandler(this.btn_clearInfo_Click);
            // 
            // btn_saveInfo
            // 
            this.btn_saveInfo.Location = new System.Drawing.Point(310, 174);
            this.btn_saveInfo.Name = "btn_saveInfo";
            this.btn_saveInfo.Size = new System.Drawing.Size(85, 34);
            this.btn_saveInfo.TabIndex = 10;
            this.btn_saveInfo.Text = "保存信息";
            this.btn_saveInfo.UseVisualStyleBackColor = true;
            this.btn_saveInfo.Click += new System.EventHandler(this.btn_saveInfo_Click);
            // 
            // CalculateRelativityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 499);
            this.Controls.Add(this.btn_saveInfo);
            this.Controls.Add(this.btn_clearInfo);
            this.Controls.Add(this.richtxb_result);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_QualityList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_selectImg);
            this.Controls.Add(this.txb_inputImg);
            this.Controls.Add(this.label1);
            this.Name = "CalculateRelativityForm";
            this.Text = "计算相关性";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_inputImg;
        private System.Windows.Forms.Button btn_selectImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_QualityList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_COD;
        private System.Windows.Forms.CheckBox checkBox_NH4N;
        private System.Windows.Forms.CheckBox checkBox_TN;
        private System.Windows.Forms.CheckBox checkBox_TP;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RichTextBox richtxb_result;
        private System.Windows.Forms.Button btn_clearInfo;
        private System.Windows.Forms.Button btn_saveInfo;
    }
}