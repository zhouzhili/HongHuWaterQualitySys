namespace RasterMaSys.UI
{
    partial class RadCalibrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_input = new System.Windows.Forms.TextBox();
            this.btn_pickFile = new System.Windows.Forms.Button();
            this.btn_pickFolder = new System.Windows.Forms.Button();
            this.txb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isDisplayResult = new System.Windows.Forms.CheckBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Landsat头文件:";
            // 
            // txb_input
            // 
            this.txb_input.Location = new System.Drawing.Point(117, 24);
            this.txb_input.Name = "txb_input";
            this.txb_input.Size = new System.Drawing.Size(300, 21);
            this.txb_input.TabIndex = 1;
            // 
            // btn_pickFile
            // 
            this.btn_pickFile.Location = new System.Drawing.Point(436, 21);
            this.btn_pickFile.Name = "btn_pickFile";
            this.btn_pickFile.Size = new System.Drawing.Size(75, 24);
            this.btn_pickFile.TabIndex = 2;
            this.btn_pickFile.Text = "选择文件";
            this.btn_pickFile.UseVisualStyleBackColor = true;
            this.btn_pickFile.Click += new System.EventHandler(this.btn_pickFile_Click);
            // 
            // btn_pickFolder
            // 
            this.btn_pickFolder.Location = new System.Drawing.Point(436, 70);
            this.btn_pickFolder.Name = "btn_pickFolder";
            this.btn_pickFolder.Size = new System.Drawing.Size(75, 24);
            this.btn_pickFolder.TabIndex = 5;
            this.btn_pickFolder.Text = "选择文件夹";
            this.btn_pickFolder.UseVisualStyleBackColor = true;
            this.btn_pickFolder.Click += new System.EventHandler(this.btn_pickFolder_Click);
            // 
            // txb_output
            // 
            this.txb_output.Location = new System.Drawing.Point(117, 73);
            this.txb_output.Name = "txb_output";
            this.txb_output.Size = new System.Drawing.Size(300, 21);
            this.txb_output.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出文件夹:";
            // 
            // isDisplayResult
            // 
            this.isDisplayResult.AutoSize = true;
            this.isDisplayResult.Checked = true;
            this.isDisplayResult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDisplayResult.Location = new System.Drawing.Point(223, 120);
            this.isDisplayResult.Name = "isDisplayResult";
            this.isDisplayResult.Size = new System.Drawing.Size(72, 16);
            this.isDisplayResult.TabIndex = 6;
            this.isDisplayResult.Text = "显示结果";
            this.isDisplayResult.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(164, 164);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(61, 36);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(260, 164);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(61, 36);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // RadCalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 229);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.isDisplayResult);
            this.Controls.Add(this.btn_pickFolder);
            this.Controls.Add(this.txb_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pickFile);
            this.Controls.Add(this.txb_input);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(548, 268);
            this.MinimumSize = new System.Drawing.Size(548, 268);
            this.Name = "RadCalibrationForm";
            this.Text = "辐射定标";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_input;
        private System.Windows.Forms.Button btn_pickFile;
        private System.Windows.Forms.Button btn_pickFolder;
        private System.Windows.Forms.TextBox txb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isDisplayResult;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}