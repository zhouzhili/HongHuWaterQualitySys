using System;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using RasterMaSys.BLL;
using RasterMaSys.Util;

namespace RasterMaSys.UI
{
    public partial class CalhonghuBoundaryForm : Form
    {
        /// <summary>
        /// 湖区提取利用洪湖的中红外影像数据
        /// 1.对影像进行裁剪，提取出影像中的洪湖范围
        /// 2.对影像进行重分类，提取水域范围
        /// 3.将重分类后的影像转换为矢量文件
        /// </summary>
        /// <param name="axMapControl"></param>
        public CalhonghuBoundaryForm(AxMapControl axMapControl)
        {
            InitializeComponent();
            this._axMapControl = axMapControl;
        }

        private AxMapControl _axMapControl;

        //点击确认后开始提取湖区面积
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string input = this.txb_input.Text.Trim();
            int threshold = Convert.ToInt32(this.thresholdNum.Value);
            string output = this.txb_output.Text.Trim();
            bool diaplay = this.isDisplayResult.Checked;
            this.WriteRemapAscii(threshold);

            if (!File.Exists(output))
            {
                //调用GP工具进行湖区提取
                GpToolsClass gpTools = new GpToolsClass();
                gpTools.CalculateBoundary(input, output);

                //调用显示工具进行显示
                if (diaplay&&File.Exists(output))
                {
                    DataShowControl dataShow = new DataShowControl(this._axMapControl.Map);
                    dataShow.DisplayShp(output);
                }
            }
            else
            {
                MessageBox.Show("指定的输出文件已存在,请修改输出名称");
            }
            
        }
        //选择中红外影像
        private void btn_pickFile_Click(object sender, EventArgs e)
        {
            this.txb_input.Text = InitInput.IninSelectImg("landsat中红外波段|*.tif|所有文件|*.*");
        }
        //选择保存路径
        private void btn_pickFolder_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog=new SaveFileDialog();
            saveFileDialog.Filter = "shapefile文件|*.shp";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                this.txb_output.Text = saveFileDialog.FileName;
            }
        }

        //将阈值写入分类时要使用的Ascii文件
        private void WriteRemapAscii(int threshold)
        {
            string remapStr = string.Format("0 {0} 1", threshold);
            FileStream fs = new FileStream(@"D:\RasterMaSysTemp\remap.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(remapStr);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        //取消按钮
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
