using System;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using RasterMaSys.BLL;
using RasterMaSys.Util;

namespace RasterMaSys.UI
{
    public partial class QuickAtmoCorrectionForm : Form
    {
        public QuickAtmoCorrectionForm(AxMapControl pMapControl)
        {
            InitializeComponent();
            this._axMapControl = pMapControl;
            InitInput.InitRsCombox(this._axMapControl, this.cmb_inputIMG);
        }

        private readonly AxMapControl _axMapControl;

        //初始化输入影像控件

        //选择需要校正的影像
        private void btn_pickFile_Click(object sender, EventArgs e)
        {
            this.cmb_inputIMG.SelectedItem = null;
            this.cmb_inputIMG.Text = InitInput.IninSelectImg("影像文件|*.tif|所有文件|*.*");
        }

        //输出文件保存路径
        private void btn_pickFolder_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "影像文件|*.tif";
            saveFile.FilterIndex = 1;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string saveFileName = @"C:\WINDOWS\Temp\quac.tif";
                saveFileName = saveFile.FileName;
                if (Path.GetExtension(saveFileName) == null)
                {
                    saveFileName = saveFileName + ".tif";
                }
                else if (Path.GetExtension(saveFileName) != ".tif")
                {
                    saveFileName = Path.GetDirectoryName(saveFileName) + "\\" +
                                   Path.GetFileNameWithoutExtension(saveFileName) + ".tif";
                }
                this.txb_output.Text = saveFileName;
            }
        }
        //点击确定，开始校正
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string inputFile = "";
            if (this.cmb_inputIMG.SelectedItem != null)
            {
                inputFile = this.cmb_inputIMG.ValueMember;
            }
            else
            {
                inputFile = this.cmb_inputIMG.Text;
            }
            string outputName = this.txb_output.Text.Trim();
            //进行大气校正
            IdlProcess.IdlAtmoCorrection(inputFile, outputName);
            //展示结果
            if (this.isDisplayResult.Checked)
            {
                DataShowControl imgShowControl = new DataShowControl(this._axMapControl.Map);
                imgShowControl.DisplayImg(outputName);
            }
            this.Dispose();
        }
        //取消校正
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }


}
