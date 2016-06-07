namespace RasterMaSys.UI
{
    partial class WaterQualityDistributionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterQualityDistributionForm));
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.cmb_dataList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_FieldList = new System.Windows.Forms.ComboBox();
            this.btn_showData = new System.Windows.Forms.Button();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(10, 46);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(699, 559);
            this.axMapControl1.TabIndex = 0;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(522, 324);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // cmb_dataList
            // 
            this.cmb_dataList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dataList.FormattingEnabled = true;
            this.cmb_dataList.Items.AddRange(new object[] {
            "2012年8月1日",
            "2012年12月1日",
            "2013年4月1日",
            "2016年3月27日"});
            this.cmb_dataList.Location = new System.Drawing.Point(86, 15);
            this.cmb_dataList.Name = "cmb_dataList";
            this.cmb_dataList.Size = new System.Drawing.Size(113, 20);
            this.cmb_dataList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "水质数据:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "水质类别:";
            // 
            // cmb_FieldList
            // 
            this.cmb_FieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FieldList.FormattingEnabled = true;
            this.cmb_FieldList.ItemHeight = 12;
            this.cmb_FieldList.Location = new System.Drawing.Point(286, 15);
            this.cmb_FieldList.Name = "cmb_FieldList";
            this.cmb_FieldList.Size = new System.Drawing.Size(101, 20);
            this.cmb_FieldList.TabIndex = 5;
            // 
            // btn_showData
            // 
            this.btn_showData.Location = new System.Drawing.Point(409, 13);
            this.btn_showData.Name = "btn_showData";
            this.btn_showData.Size = new System.Drawing.Size(75, 23);
            this.btn_showData.TabIndex = 6;
            this.btn_showData.Text = "查看";
            this.btn_showData.UseVisualStyleBackColor = true;
            this.btn_showData.Click += new System.EventHandler(this.btn_showData_Click);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(502, 12);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(202, 28);
            this.axToolbarControl1.TabIndex = 8;
            // 
            // WaterQualityDistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 617);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.btn_showData);
            this.Controls.Add(this.cmb_FieldList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_dataList);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.axMapControl1);
            this.Name = "WaterQualityDistributionForm";
            this.Text = "水质分布状况";
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.ComboBox cmb_dataList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_FieldList;
        private System.Windows.Forms.Button btn_showData;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
    }
}