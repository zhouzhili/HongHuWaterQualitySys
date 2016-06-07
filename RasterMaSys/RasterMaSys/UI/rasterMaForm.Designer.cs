using System.Windows.Forms;

namespace RasterMaSys.UI
{
    partial class RasterMaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasterMaForm));
            this.conditionBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cloudAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colIdEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colIdStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rowIdEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rowIdStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rsTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rsTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sensorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteDataBtn = new System.Windows.Forms.Button();
            this.editDataBtn = new System.Windows.Forms.Button();
            this.addDataBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加至显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conditionBox
            // 
            this.conditionBox.Controls.Add(this.label9);
            this.conditionBox.Controls.Add(this.cloudAge);
            this.conditionBox.Controls.Add(this.label8);
            this.conditionBox.Controls.Add(this.colIdEnd);
            this.conditionBox.Controls.Add(this.label7);
            this.conditionBox.Controls.Add(this.colIdStart);
            this.conditionBox.Controls.Add(this.label6);
            this.conditionBox.Controls.Add(this.rowIdEnd);
            this.conditionBox.Controls.Add(this.label5);
            this.conditionBox.Controls.Add(this.rowIdStart);
            this.conditionBox.Controls.Add(this.label4);
            this.conditionBox.Controls.Add(this.rsTimeEnd);
            this.conditionBox.Controls.Add(this.label3);
            this.conditionBox.Controls.Add(this.rsTimeStart);
            this.conditionBox.Controls.Add(this.label2);
            this.conditionBox.Controls.Add(this.sensorTypeComboBox);
            this.conditionBox.Controls.Add(this.label1);
            this.conditionBox.Location = new System.Drawing.Point(23, 12);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Padding = new System.Windows.Forms.Padding(10);
            this.conditionBox.Size = new System.Drawing.Size(432, 188);
            this.conditionBox.TabIndex = 0;
            this.conditionBox.TabStop = false;
            this.conditionBox.Text = "检索条件";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // cloudAge
            // 
            this.cloudAge.Location = new System.Drawing.Point(107, 143);
            this.cloudAge.Name = "cloudAge";
            this.cloudAge.Size = new System.Drawing.Size(87, 21);
            this.cloudAge.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "云量(小于):";
            // 
            // colIdEnd
            // 
            this.colIdEnd.Location = new System.Drawing.Point(355, 108);
            this.colIdEnd.Name = "colIdEnd";
            this.colIdEnd.Size = new System.Drawing.Size(43, 21);
            this.colIdEnd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "至";
            // 
            // colIdStart
            // 
            this.colIdStart.Location = new System.Drawing.Point(289, 108);
            this.colIdStart.Name = "colIdStart";
            this.colIdStart.Size = new System.Drawing.Size(40, 21);
            this.colIdStart.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "列号:";
            // 
            // rowIdEnd
            // 
            this.rowIdEnd.Location = new System.Drawing.Point(174, 106);
            this.rowIdEnd.Name = "rowIdEnd";
            this.rowIdEnd.Size = new System.Drawing.Size(43, 21);
            this.rowIdEnd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "至";
            // 
            // rowIdStart
            // 
            this.rowIdStart.Location = new System.Drawing.Point(107, 106);
            this.rowIdStart.Name = "rowIdStart";
            this.rowIdStart.Size = new System.Drawing.Size(40, 21);
            this.rowIdStart.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "行    号:";
            // 
            // rsTimeEnd
            // 
            this.rsTimeEnd.Location = new System.Drawing.Point(269, 69);
            this.rsTimeEnd.Name = "rsTimeEnd";
            this.rsTimeEnd.Size = new System.Drawing.Size(126, 21);
            this.rsTimeEnd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "至";
            // 
            // rsTimeStart
            // 
            this.rsTimeStart.Location = new System.Drawing.Point(107, 68);
            this.rsTimeStart.Name = "rsTimeStart";
            this.rsTimeStart.Size = new System.Drawing.Size(126, 21);
            this.rsTimeStart.TabIndex = 4;
            this.rsTimeStart.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "时间范围:";
            // 
            // sensorTypeComboBox
            // 
            this.sensorTypeComboBox.DropDownHeight = 115;
            this.sensorTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorTypeComboBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sensorTypeComboBox.FormattingEnabled = true;
            this.sensorTypeComboBox.IntegralHeight = false;
            this.sensorTypeComboBox.Items.AddRange(new object[] {
            "Landsat8 OLI_TIRS",
            "Landsat7 ETM SLC-off",
            "Landsat7 ETM SLC-on",
            "Landsat5 TM",
            "所有影像"});
            this.sensorTypeComboBox.Location = new System.Drawing.Point(107, 29);
            this.sensorTypeComboBox.Name = "sensorTypeComboBox";
            this.sensorTypeComboBox.Size = new System.Drawing.Size(154, 20);
            this.sensorTypeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "传感器类型:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteDataBtn);
            this.groupBox1.Controls.Add(this.editDataBtn);
            this.groupBox1.Controls.Add(this.addDataBtn);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Location = new System.Drawing.Point(496, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理工具";
            // 
            // deleteDataBtn
            // 
            this.deleteDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteDataBtn.Image")));
            this.deleteDataBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDataBtn.Location = new System.Drawing.Point(218, 113);
            this.deleteDataBtn.Name = "deleteDataBtn";
            this.deleteDataBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.deleteDataBtn.Size = new System.Drawing.Size(110, 36);
            this.deleteDataBtn.TabIndex = 3;
            this.deleteDataBtn.Text = "影像信息删除";
            this.deleteDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteDataBtn.UseVisualStyleBackColor = true;
            this.deleteDataBtn.Click += new System.EventHandler(this.deleteDataBtn_Click);
            // 
            // editDataBtn
            // 
            this.editDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("editDataBtn.Image")));
            this.editDataBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editDataBtn.Location = new System.Drawing.Point(72, 113);
            this.editDataBtn.Name = "editDataBtn";
            this.editDataBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.editDataBtn.Size = new System.Drawing.Size(110, 36);
            this.editDataBtn.TabIndex = 2;
            this.editDataBtn.Text = " 影像信息修改";
            this.editDataBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editDataBtn.UseVisualStyleBackColor = true;
            this.editDataBtn.Click += new System.EventHandler(this.editDataBtn_Click);
            // 
            // addDataBtn
            // 
            this.addDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("addDataBtn.Image")));
            this.addDataBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDataBtn.Location = new System.Drawing.Point(218, 33);
            this.addDataBtn.Name = "addDataBtn";
            this.addDataBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.addDataBtn.Size = new System.Drawing.Size(110, 36);
            this.addDataBtn.TabIndex = 1;
            this.addDataBtn.Text = "    影像入库";
            this.addDataBtn.UseVisualStyleBackColor = true;
            this.addDataBtn.Click += new System.EventHandler(this.addDataBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(72, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(110, 36);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = " 影像查询";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 216);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(867, 379);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加至显示ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
            // 
            // 添加至显示ToolStripMenuItem
            // 
            this.添加至显示ToolStripMenuItem.Name = "添加至显示ToolStripMenuItem";
            this.添加至显示ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加至显示ToolStripMenuItem.Text = "添加至显示";
            this.添加至显示ToolStripMenuItem.Click += new System.EventHandler(this.添加至显示ToolStripMenuItem_Click);
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开所在文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // RasterMaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 610);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.conditionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RasterMaForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Text = "影像库管理";
            this.conditionBox.ResumeLayout(false);
            this.conditionBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox conditionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sensorTypeComboBox;
        private DateTimePicker rsTimeEnd;
        private Label label3;
        private DateTimePicker rsTimeStart;
        private Label label2;
        private Label label9;
        private TextBox cloudAge;
        private Label label8;
        private TextBox colIdEnd;
        private Label label7;
        private TextBox colIdStart;
        private Label label6;
        private TextBox rowIdEnd;
        private Label label5;
        private TextBox rowIdStart;
        private Label label4;
        private GroupBox groupBox1;
        private Button deleteDataBtn;
        private Button editDataBtn;
        private Button addDataBtn;
        private Button searchBtn;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 添加至显示ToolStripMenuItem;
        private ToolStripMenuItem 打开文件夹ToolStripMenuItem;
    }
}