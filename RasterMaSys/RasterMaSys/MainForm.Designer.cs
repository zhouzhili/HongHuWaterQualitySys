namespace RasterMaSys
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.rasterMaPage = new System.Windows.Forms.TabPage();
            this.label_listImg = new System.Windows.Forms.Label();
            this.listImg = new System.Windows.Forms.PictureBox();
            this.label_imgSearch = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.PictureBox();
            this.label_addImg = new System.Windows.Forms.Label();
            this.addImgBox = new System.Windows.Forms.PictureBox();
            this.rasterProcessPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lakeExtractionBox = new System.Windows.Forms.PictureBox();
            this.atmosphCorrectionBox = new System.Windows.Forms.PictureBox();
            this.radCalibrationBox = new System.Windows.Forms.PictureBox();
            this.statisticPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picBox_areaChange = new System.Windows.Forms.PictureBox();
            this.picBox_waterQuality = new System.Windows.Forms.PictureBox();
            this.inversionPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picBox_interpolation = new System.Windows.Forms.PictureBox();
            this.picBox_Regression = new System.Windows.Forms.PictureBox();
            this.picBox_CalculateRelativity = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开属性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看元信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rad_rgb = new System.Windows.Forms.RadioButton();
            this.label_b = new System.Windows.Forms.Label();
            this.rad_gray = new System.Windows.Forms.RadioButton();
            this.cmb_bandB = new System.Windows.Forms.ComboBox();
            this.label_g = new System.Windows.Forms.Label();
            this.cmb_bandR = new System.Windows.Forms.ComboBox();
            this.cmb_bandG = new System.Windows.Forms.ComboBox();
            this.label_r = new System.Windows.Forms.Label();
            this.label_layer = new System.Windows.Forms.Label();
            this.cmb_layerList = new System.Windows.Forms.ComboBox();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.rasterMaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addImgBox)).BeginInit();
            this.rasterProcessPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakeExtractionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atmosphCorrectionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalibrationBox)).BeginInit();
            this.statisticPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_areaChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_waterQuality)).BeginInit();
            this.inversionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_interpolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Regression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CalculateRelativity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.rasterMaPage);
            this.tabControl.Controls.Add(this.rasterProcessPage);
            this.tabControl.Controls.Add(this.statisticPage);
            this.tabControl.Controls.Add(this.inversionPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(10, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(20, 8);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 136);
            this.tabControl.TabIndex = 0;
            // 
            // rasterMaPage
            // 
            this.rasterMaPage.Controls.Add(this.label_listImg);
            this.rasterMaPage.Controls.Add(this.listImg);
            this.rasterMaPage.Controls.Add(this.label_imgSearch);
            this.rasterMaPage.Controls.Add(this.searchBox);
            this.rasterMaPage.Controls.Add(this.label_addImg);
            this.rasterMaPage.Controls.Add(this.addImgBox);
            this.rasterMaPage.Location = new System.Drawing.Point(4, 32);
            this.rasterMaPage.Name = "rasterMaPage";
            this.rasterMaPage.Padding = new System.Windows.Forms.Padding(3);
            this.rasterMaPage.Size = new System.Drawing.Size(976, 100);
            this.rasterMaPage.TabIndex = 0;
            this.rasterMaPage.Text = "影像库管理";
            this.rasterMaPage.UseVisualStyleBackColor = true;
            // 
            // label_listImg
            // 
            this.label_listImg.AutoSize = true;
            this.label_listImg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_listImg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_listImg.Location = new System.Drawing.Point(233, 65);
            this.label_listImg.Name = "label_listImg";
            this.label_listImg.Size = new System.Drawing.Size(65, 20);
            this.label_listImg.TabIndex = 6;
            this.label_listImg.Text = "影像列表";
            // 
            // listImg
            // 
            this.listImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listImg.Image = ((System.Drawing.Image)(resources.GetObject("listImg.Image")));
            this.listImg.Location = new System.Drawing.Point(225, 5);
            this.listImg.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.listImg.Name = "listImg";
            this.listImg.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.listImg.Size = new System.Drawing.Size(80, 88);
            this.listImg.TabIndex = 5;
            this.listImg.TabStop = false;
            this.listImg.Click += new System.EventHandler(this.listImg_Click);
            // 
            // label_imgSearch
            // 
            this.label_imgSearch.AutoSize = true;
            this.label_imgSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_imgSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_imgSearch.Location = new System.Drawing.Point(22, 65);
            this.label_imgSearch.Name = "label_imgSearch";
            this.label_imgSearch.Size = new System.Drawing.Size(65, 20);
            this.label_imgSearch.TabIndex = 4;
            this.label_imgSearch.Text = "影像检索";
            // 
            // searchBox
            // 
            this.searchBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBox.Image = ((System.Drawing.Image)(resources.GetObject("searchBox.Image")));
            this.searchBox.Location = new System.Drawing.Point(16, 5);
            this.searchBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.searchBox.Size = new System.Drawing.Size(80, 88);
            this.searchBox.TabIndex = 3;
            this.searchBox.TabStop = false;
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // label_addImg
            // 
            this.label_addImg.AutoSize = true;
            this.label_addImg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_addImg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_addImg.Location = new System.Drawing.Point(127, 65);
            this.label_addImg.Name = "label_addImg";
            this.label_addImg.Size = new System.Drawing.Size(65, 20);
            this.label_addImg.TabIndex = 2;
            this.label_addImg.Text = "影像入库";
            // 
            // addImgBox
            // 
            this.addImgBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImgBox.Image = ((System.Drawing.Image)(resources.GetObject("addImgBox.Image")));
            this.addImgBox.Location = new System.Drawing.Point(120, 5);
            this.addImgBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addImgBox.Name = "addImgBox";
            this.addImgBox.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.addImgBox.Size = new System.Drawing.Size(80, 88);
            this.addImgBox.TabIndex = 1;
            this.addImgBox.TabStop = false;
            this.addImgBox.Click += new System.EventHandler(this.addImgBox_Click);
            // 
            // rasterProcessPage
            // 
            this.rasterProcessPage.Controls.Add(this.label4);
            this.rasterProcessPage.Controls.Add(this.label2);
            this.rasterProcessPage.Controls.Add(this.label1);
            this.rasterProcessPage.Controls.Add(this.lakeExtractionBox);
            this.rasterProcessPage.Controls.Add(this.atmosphCorrectionBox);
            this.rasterProcessPage.Controls.Add(this.radCalibrationBox);
            this.rasterProcessPage.Location = new System.Drawing.Point(4, 32);
            this.rasterProcessPage.Name = "rasterProcessPage";
            this.rasterProcessPage.Padding = new System.Windows.Forms.Padding(3);
            this.rasterProcessPage.Size = new System.Drawing.Size(976, 100);
            this.rasterProcessPage.TabIndex = 1;
            this.rasterProcessPage.Text = "影像处理";
            this.rasterProcessPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(248, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "湖区提取";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(132, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "大气校正";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "辐射定标";
            // 
            // lakeExtractionBox
            // 
            this.lakeExtractionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lakeExtractionBox.Image = ((System.Drawing.Image)(resources.GetObject("lakeExtractionBox.Image")));
            this.lakeExtractionBox.Location = new System.Drawing.Point(242, 9);
            this.lakeExtractionBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.lakeExtractionBox.Name = "lakeExtractionBox";
            this.lakeExtractionBox.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.lakeExtractionBox.Size = new System.Drawing.Size(80, 85);
            this.lakeExtractionBox.TabIndex = 11;
            this.lakeExtractionBox.TabStop = false;
            this.lakeExtractionBox.Click += new System.EventHandler(this.lakeExtractionBox_Click);
            // 
            // atmosphCorrectionBox
            // 
            this.atmosphCorrectionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atmosphCorrectionBox.Image = ((System.Drawing.Image)(resources.GetObject("atmosphCorrectionBox.Image")));
            this.atmosphCorrectionBox.Location = new System.Drawing.Point(126, 6);
            this.atmosphCorrectionBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.atmosphCorrectionBox.Name = "atmosphCorrectionBox";
            this.atmosphCorrectionBox.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.atmosphCorrectionBox.Size = new System.Drawing.Size(80, 88);
            this.atmosphCorrectionBox.TabIndex = 7;
            this.atmosphCorrectionBox.TabStop = false;
            this.atmosphCorrectionBox.Click += new System.EventHandler(this.atmosphCorrectionBox_Click);
            // 
            // radCalibrationBox
            // 
            this.radCalibrationBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radCalibrationBox.Image = ((System.Drawing.Image)(resources.GetObject("radCalibrationBox.Image")));
            this.radCalibrationBox.Location = new System.Drawing.Point(13, 6);
            this.radCalibrationBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.radCalibrationBox.Name = "radCalibrationBox";
            this.radCalibrationBox.Padding = new System.Windows.Forms.Padding(18, 10, 50, 0);
            this.radCalibrationBox.Size = new System.Drawing.Size(80, 88);
            this.radCalibrationBox.TabIndex = 5;
            this.radCalibrationBox.TabStop = false;
            this.radCalibrationBox.Click += new System.EventHandler(this.radCalibrationBox_Click);
            // 
            // statisticPage
            // 
            this.statisticPage.Controls.Add(this.label7);
            this.statisticPage.Controls.Add(this.label5);
            this.statisticPage.Controls.Add(this.picBox_areaChange);
            this.statisticPage.Controls.Add(this.picBox_waterQuality);
            this.statisticPage.Location = new System.Drawing.Point(4, 32);
            this.statisticPage.Name = "statisticPage";
            this.statisticPage.Padding = new System.Windows.Forms.Padding(3);
            this.statisticPage.Size = new System.Drawing.Size(976, 100);
            this.statisticPage.TabIndex = 2;
            this.statisticPage.Text = "统计分析";
            this.statisticPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(126, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "水域面积统计";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "水质分布";
            // 
            // picBox_areaChange
            // 
            this.picBox_areaChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_areaChange.Image = ((System.Drawing.Image)(resources.GetObject("picBox_areaChange.Image")));
            this.picBox_areaChange.Location = new System.Drawing.Point(130, 6);
            this.picBox_areaChange.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.picBox_areaChange.Name = "picBox_areaChange";
            this.picBox_areaChange.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.picBox_areaChange.Size = new System.Drawing.Size(79, 88);
            this.picBox_areaChange.TabIndex = 17;
            this.picBox_areaChange.TabStop = false;
            this.picBox_areaChange.Click += new System.EventHandler(this.picBox_areaChange_Click);
            // 
            // picBox_waterQuality
            // 
            this.picBox_waterQuality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_waterQuality.Image = ((System.Drawing.Image)(resources.GetObject("picBox_waterQuality.Image")));
            this.picBox_waterQuality.Location = new System.Drawing.Point(17, 6);
            this.picBox_waterQuality.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.picBox_waterQuality.Name = "picBox_waterQuality";
            this.picBox_waterQuality.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.picBox_waterQuality.Size = new System.Drawing.Size(80, 88);
            this.picBox_waterQuality.TabIndex = 11;
            this.picBox_waterQuality.TabStop = false;
            this.picBox_waterQuality.Click += new System.EventHandler(this.picBox_waterQuality_Click);
            // 
            // inversionPage
            // 
            this.inversionPage.Controls.Add(this.label9);
            this.inversionPage.Controls.Add(this.label8);
            this.inversionPage.Controls.Add(this.label6);
            this.inversionPage.Controls.Add(this.picBox_interpolation);
            this.inversionPage.Controls.Add(this.picBox_Regression);
            this.inversionPage.Controls.Add(this.picBox_CalculateRelativity);
            this.inversionPage.Location = new System.Drawing.Point(4, 32);
            this.inversionPage.Name = "inversionPage";
            this.inversionPage.Padding = new System.Windows.Forms.Padding(3);
            this.inversionPage.Size = new System.Drawing.Size(976, 100);
            this.inversionPage.TabIndex = 3;
            this.inversionPage.Text = "水质反演";
            this.inversionPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(254, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "水质插值";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(136, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "回归拟合";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(14, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "计算相关性";
            // 
            // picBox_interpolation
            // 
            this.picBox_interpolation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_interpolation.Image = ((System.Drawing.Image)(resources.GetObject("picBox_interpolation.Image")));
            this.picBox_interpolation.Location = new System.Drawing.Point(251, 6);
            this.picBox_interpolation.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.picBox_interpolation.Name = "picBox_interpolation";
            this.picBox_interpolation.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.picBox_interpolation.Size = new System.Drawing.Size(80, 88);
            this.picBox_interpolation.TabIndex = 17;
            this.picBox_interpolation.TabStop = false;
            this.picBox_interpolation.Click += new System.EventHandler(this.picBox_interpolation_Click);
            // 
            // picBox_Regression
            // 
            this.picBox_Regression.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_Regression.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Regression.Image")));
            this.picBox_Regression.Location = new System.Drawing.Point(132, 6);
            this.picBox_Regression.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.picBox_Regression.Name = "picBox_Regression";
            this.picBox_Regression.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.picBox_Regression.Size = new System.Drawing.Size(80, 88);
            this.picBox_Regression.TabIndex = 15;
            this.picBox_Regression.TabStop = false;
            this.picBox_Regression.Click += new System.EventHandler(this.picBox_Regression_Click);
            // 
            // picBox_CalculateRelativity
            // 
            this.picBox_CalculateRelativity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_CalculateRelativity.Image = ((System.Drawing.Image)(resources.GetObject("picBox_CalculateRelativity.Image")));
            this.picBox_CalculateRelativity.Location = new System.Drawing.Point(13, 6);
            this.picBox_CalculateRelativity.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.picBox_CalculateRelativity.Name = "picBox_CalculateRelativity";
            this.picBox_CalculateRelativity.Padding = new System.Windows.Forms.Padding(12, 5, 50, 0);
            this.picBox_CalculateRelativity.Size = new System.Drawing.Size(80, 88);
            this.picBox_CalculateRelativity.TabIndex = 13;
            this.picBox_CalculateRelativity.TabStop = false;
            this.picBox_CalculateRelativity.Click += new System.EventHandler(this.picBox_CalculateRelativity_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(9, 186);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axTOCControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axLicenseControl1);
            this.splitContainer1.Panel2.Controls.Add(this.axMapControl1);
            this.splitContainer1.Panel2.Controls.Add(this.shapeContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(975, 440);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 1;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axTOCControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(168, 440);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.打开属性表ToolStripMenuItem,
            this.查看元信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "移除";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 打开属性表ToolStripMenuItem
            // 
            this.打开属性表ToolStripMenuItem.Name = "打开属性表ToolStripMenuItem";
            this.打开属性表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开属性表ToolStripMenuItem.Text = "打开属性表";
            // 
            // 查看元信息ToolStripMenuItem
            // 
            this.查看元信息ToolStripMenuItem.Name = "查看元信息ToolStripMenuItem";
            this.查看元信息ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查看元信息ToolStripMenuItem.Text = "查看元信息";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(332, 215);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(803, 440);
            this.axMapControl1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(803, 440);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(68, 165);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(75, 23);
            // 
            // rad_rgb
            // 
            this.rad_rgb.AutoSize = true;
            this.rad_rgb.Location = new System.Drawing.Point(307, 151);
            this.rad_rgb.Name = "rad_rgb";
            this.rad_rgb.Size = new System.Drawing.Size(41, 16);
            this.rad_rgb.TabIndex = 1;
            this.rad_rgb.Text = "RGB";
            this.rad_rgb.UseVisualStyleBackColor = true;
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(543, 152);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(17, 12);
            this.label_b.TabIndex = 10;
            this.label_b.Text = "B:";
            // 
            // rad_gray
            // 
            this.rad_gray.AutoSize = true;
            this.rad_gray.Checked = true;
            this.rad_gray.Location = new System.Drawing.Point(252, 151);
            this.rad_gray.Name = "rad_gray";
            this.rad_gray.Size = new System.Drawing.Size(47, 16);
            this.rad_gray.TabIndex = 0;
            this.rad_gray.TabStop = true;
            this.rad_gray.Text = "Gray";
            this.rad_gray.UseVisualStyleBackColor = true;
            // 
            // cmb_bandB
            // 
            this.cmb_bandB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bandB.FormattingEnabled = true;
            this.cmb_bandB.Items.AddRange(new object[] {
            "band 1",
            "band 2",
            "band 3",
            "band 4",
            "band 5",
            "band 6"});
            this.cmb_bandB.Location = new System.Drawing.Point(562, 149);
            this.cmb_bandB.Name = "cmb_bandB";
            this.cmb_bandB.Size = new System.Drawing.Size(60, 20);
            this.cmb_bandB.TabIndex = 9;
            // 
            // label_g
            // 
            this.label_g.AutoSize = true;
            this.label_g.Location = new System.Drawing.Point(453, 152);
            this.label_g.Name = "label_g";
            this.label_g.Size = new System.Drawing.Size(17, 12);
            this.label_g.TabIndex = 8;
            this.label_g.Text = "G:";
            // 
            // cmb_bandR
            // 
            this.cmb_bandR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bandR.FormattingEnabled = true;
            this.cmb_bandR.Items.AddRange(new object[] {
            "band 1",
            "band 2",
            "band 3",
            "band 4",
            "band 5",
            "band 6"});
            this.cmb_bandR.Location = new System.Drawing.Point(382, 149);
            this.cmb_bandR.Name = "cmb_bandR";
            this.cmb_bandR.Size = new System.Drawing.Size(60, 20);
            this.cmb_bandR.TabIndex = 3;
            // 
            // cmb_bandG
            // 
            this.cmb_bandG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bandG.FormattingEnabled = true;
            this.cmb_bandG.Items.AddRange(new object[] {
            "band 1",
            "band 2",
            "band 3",
            "band 4",
            "band 5",
            "band 6"});
            this.cmb_bandG.Location = new System.Drawing.Point(472, 149);
            this.cmb_bandG.Name = "cmb_bandG";
            this.cmb_bandG.Size = new System.Drawing.Size(60, 20);
            this.cmb_bandG.TabIndex = 7;
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Location = new System.Drawing.Point(363, 152);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(17, 12);
            this.label_r.TabIndex = 4;
            this.label_r.Text = "R:";
            // 
            // label_layer
            // 
            this.label_layer.AutoSize = true;
            this.label_layer.Location = new System.Drawing.Point(13, 152);
            this.label_layer.Name = "label_layer";
            this.label_layer.Size = new System.Drawing.Size(59, 12);
            this.label_layer.TabIndex = 12;
            this.label_layer.Text = "选择图层:";
            // 
            // cmb_layerList
            // 
            this.cmb_layerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_layerList.FormattingEnabled = true;
            this.cmb_layerList.Location = new System.Drawing.Point(76, 148);
            this.cmb_layerList.Name = "cmb_layerList";
            this.cmb_layerList.Size = new System.Drawing.Size(158, 20);
            this.cmb_layerList.TabIndex = 13;
            this.cmb_layerList.Click += new System.EventHandler(this.cmb_layerList_Click);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axToolbarControl1.Location = new System.Drawing.Point(685, 145);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(155, 28);
            this.axToolbarControl1.TabIndex = 2;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(634, 145);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(33, 28);
            this.btn_refresh.TabIndex = 11;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 41);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 636);
            this.Controls.Add(this.cmb_layerList);
            this.Controls.Add(this.label_layer);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.rad_rgb);
            this.Controls.Add(this.cmb_bandB);
            this.Controls.Add(this.label_g);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.cmb_bandR);
            this.Controls.Add(this.rad_gray);
            this.Controls.Add(this.cmb_bandG);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label_r);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "洪湖水质反演系统";
            this.tabControl.ResumeLayout(false);
            this.rasterMaPage.ResumeLayout(false);
            this.rasterMaPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addImgBox)).EndInit();
            this.rasterProcessPage.ResumeLayout(false);
            this.rasterProcessPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lakeExtractionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atmosphCorrectionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCalibrationBox)).EndInit();
            this.statisticPage.ResumeLayout(false);
            this.statisticPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_areaChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_waterQuality)).EndInit();
            this.inversionPage.ResumeLayout(false);
            this.inversionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_interpolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Regression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CalculateRelativity)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage rasterMaPage;
        private System.Windows.Forms.TabPage rasterProcessPage;
        private System.Windows.Forms.TabPage statisticPage;
        private System.Windows.Forms.TabPage inversionPage;
        private System.Windows.Forms.Label label_addImg;
        private System.Windows.Forms.PictureBox addImgBox;
        private System.Windows.Forms.PictureBox searchBox;
        private System.Windows.Forms.Label label_imgSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开属性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看元信息ToolStripMenuItem;
        private System.Windows.Forms.Label label_listImg;
        private System.Windows.Forms.PictureBox listImg;
        private System.Windows.Forms.ComboBox cmb_bandR;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Label label_g;
        private System.Windows.Forms.ComboBox cmb_bandG;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.ComboBox cmb_bandB;
        private System.Windows.Forms.RadioButton rad_rgb;
        private System.Windows.Forms.RadioButton rad_gray;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label_layer;
        private System.Windows.Forms.ComboBox cmb_layerList;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBox_waterQuality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picBox_areaChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picBox_CalculateRelativity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBox_Regression;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picBox_interpolation;
        private System.Windows.Forms.PictureBox lakeExtractionBox;
        private System.Windows.Forms.PictureBox atmosphCorrectionBox;
        private System.Windows.Forms.PictureBox radCalibrationBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

