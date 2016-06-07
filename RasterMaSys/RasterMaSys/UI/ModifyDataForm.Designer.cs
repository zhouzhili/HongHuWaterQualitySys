namespace RasterMaSys.UI
{
    partial class ModifyDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyDataForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgPathtxb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imgCloudtxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imgColIdtxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imgRowIdtxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imgDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.imgSensorTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmAddBtn = new System.Windows.Forms.Button();
            this.getPathbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getPathbtn);
            this.groupBox1.Controls.Add(this.imgPathtxb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.imgCloudtxb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.imgColIdtxb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.imgRowIdtxb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.imgDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imgSensorTypecomboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影像信息";
            // 
            // imgPathtxb
            // 
            this.imgPathtxb.Location = new System.Drawing.Point(92, 33);
            this.imgPathtxb.Name = "imgPathtxb";
            this.imgPathtxb.Size = new System.Drawing.Size(250, 21);
            this.imgPathtxb.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "影像路径:";
            // 
            // imgCloudtxb
            // 
            this.imgCloudtxb.Location = new System.Drawing.Point(92, 212);
            this.imgCloudtxb.Name = "imgCloudtxb";
            this.imgCloudtxb.Size = new System.Drawing.Size(162, 21);
            this.imgCloudtxb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "影像云量:";
            // 
            // imgColIdtxb
            // 
            this.imgColIdtxb.Location = new System.Drawing.Point(92, 175);
            this.imgColIdtxb.Name = "imgColIdtxb";
            this.imgColIdtxb.Size = new System.Drawing.Size(162, 21);
            this.imgColIdtxb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "影像列号:";
            // 
            // imgRowIdtxb
            // 
            this.imgRowIdtxb.Location = new System.Drawing.Point(92, 138);
            this.imgRowIdtxb.Name = "imgRowIdtxb";
            this.imgRowIdtxb.Size = new System.Drawing.Size(162, 21);
            this.imgRowIdtxb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "影像行号:";
            // 
            // imgDateTimePicker
            // 
            this.imgDateTimePicker.Location = new System.Drawing.Point(92, 101);
            this.imgDateTimePicker.Name = "imgDateTimePicker";
            this.imgDateTimePicker.Size = new System.Drawing.Size(162, 21);
            this.imgDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "成像时间:";
            // 
            // imgSensorTypecomboBox
            // 
            this.imgSensorTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imgSensorTypecomboBox.FormattingEnabled = true;
            this.imgSensorTypecomboBox.Items.AddRange(new object[] {
            "Landsat8 OLI_TIRS",
            "Landsat7 ETM SLC-off",
            "Landsat7 ETM SLC-on",
            "Landsat5 TM",
            "未知"});
            this.imgSensorTypecomboBox.Location = new System.Drawing.Point(92, 65);
            this.imgSensorTypecomboBox.Name = "imgSensorTypecomboBox";
            this.imgSensorTypecomboBox.Size = new System.Drawing.Size(162, 20);
            this.imgSensorTypecomboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "传感器类型:";
            // 
            // confirmAddBtn
            // 
            this.confirmAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("confirmAddBtn.Image")));
            this.confirmAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.confirmAddBtn.Location = new System.Drawing.Point(158, 297);
            this.confirmAddBtn.Name = "confirmAddBtn";
            this.confirmAddBtn.Size = new System.Drawing.Size(91, 33);
            this.confirmAddBtn.TabIndex = 3;
            this.confirmAddBtn.Text = "确定修改";
            this.confirmAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmAddBtn.UseVisualStyleBackColor = true;
            this.confirmAddBtn.Click += new System.EventHandler(this.confirmAddBtn_Click);
            // 
            // getPathbtn
            // 
            this.getPathbtn.Image = ((System.Drawing.Image)(resources.GetObject("getPathbtn.Image")));
            this.getPathbtn.Location = new System.Drawing.Point(348, 31);
            this.getPathbtn.Name = "getPathbtn";
            this.getPathbtn.Size = new System.Drawing.Size(30, 23);
            this.getPathbtn.TabIndex = 16;
            this.getPathbtn.UseVisualStyleBackColor = true;
            this.getPathbtn.Click += new System.EventHandler(this.getPathbtn_Click);
            // 
            // ModifyDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 353);
            this.Controls.Add(this.confirmAddBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifyDataForm";
            this.Text = "修改信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmAddBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getPathbtn;
        private System.Windows.Forms.TextBox imgPathtxb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox imgCloudtxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imgColIdtxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imgRowIdtxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker imgDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox imgSensorTypecomboBox;
        private System.Windows.Forms.Label label1;
    }
}