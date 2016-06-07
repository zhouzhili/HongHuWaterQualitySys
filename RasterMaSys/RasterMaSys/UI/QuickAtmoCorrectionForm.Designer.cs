namespace RasterMaSys.UI
{
    partial class QuickAtmoCorrectionForm
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.isDisplayResult = new System.Windows.Forms.CheckBox();
            this.btn_pickFolder = new System.Windows.Forms.Button();
            this.txb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pickFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_inputIMG = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(260, 168);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(61, 36);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(164, 168);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(61, 36);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // isDisplayResult
            // 
            this.isDisplayResult.AutoSize = true;
            this.isDisplayResult.Checked = true;
            this.isDisplayResult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDisplayResult.Location = new System.Drawing.Point(223, 124);
            this.isDisplayResult.Name = "isDisplayResult";
            this.isDisplayResult.Size = new System.Drawing.Size(72, 16);
            this.isDisplayResult.TabIndex = 15;
            this.isDisplayResult.Text = "显示结果";
            this.isDisplayResult.UseVisualStyleBackColor = true;
            // 
            // btn_pickFolder
            // 
            this.btn_pickFolder.Location = new System.Drawing.Point(436, 74);
            this.btn_pickFolder.Name = "btn_pickFolder";
            this.btn_pickFolder.Size = new System.Drawing.Size(75, 24);
            this.btn_pickFolder.TabIndex = 14;
            this.btn_pickFolder.Text = "选择文件";
            this.btn_pickFolder.UseVisualStyleBackColor = true;
            this.btn_pickFolder.Click += new System.EventHandler(this.btn_pickFolder_Click);
            // 
            // txb_output
            // 
            this.txb_output.Location = new System.Drawing.Point(117, 77);
            this.txb_output.Name = "txb_output";
            this.txb_output.Size = new System.Drawing.Size(300, 21);
            this.txb_output.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "输出文件:";
            // 
            // btn_pickFile
            // 
            this.btn_pickFile.Location = new System.Drawing.Point(436, 21);
            this.btn_pickFile.Name = "btn_pickFile";
            this.btn_pickFile.Size = new System.Drawing.Size(75, 24);
            this.btn_pickFile.TabIndex = 11;
            this.btn_pickFile.Text = "选择影像";
            this.btn_pickFile.UseVisualStyleBackColor = true;
            this.btn_pickFile.Click += new System.EventHandler(this.btn_pickFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "输入影像:";
            // 
            // cmb_inputIMG
            // 
            this.cmb_inputIMG.FormattingEnabled = true;
            this.cmb_inputIMG.Location = new System.Drawing.Point(117, 22);
            this.cmb_inputIMG.Name = "cmb_inputIMG";
            this.cmb_inputIMG.Size = new System.Drawing.Size(300, 20);
            this.cmb_inputIMG.TabIndex = 18;
            // 
            // QuickAtmoCorrectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 229);
            this.Controls.Add(this.cmb_inputIMG);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.isDisplayResult);
            this.Controls.Add(this.btn_pickFolder);
            this.Controls.Add(this.txb_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pickFile);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(548, 268);
            this.MinimumSize = new System.Drawing.Size(548, 268);
            this.Name = "QuickAtmoCorrectionForm";
            this.Text = "大气校正";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckBox isDisplayResult;
        private System.Windows.Forms.Button btn_pickFolder;
        private System.Windows.Forms.TextBox txb_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pickFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_inputIMG;
    }
}