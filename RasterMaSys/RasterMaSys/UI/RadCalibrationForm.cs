using System;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using RasterMaSys.BLL;


namespace RasterMaSys.UI
{
    public partial class RadCalibrationForm : Form
    {
        public RadCalibrationForm(AxMapControl pMapControl)
        {
            InitializeComponent();
            this.pMapControl = pMapControl;
        }

        private AxMapControl pMapControl;

        //选择MTL.txt文件
        private void btn_pickFile_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog=new OpenFileDialog();
            openFileDialog.Filter = "Landsat头文件|*_MTL.txt|所有文件|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txb_input.Text = openFileDialog.FileName;
            }
        }

        //保存文件夹
        private void btn_pickFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser=new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.txb_output.Text = folderBrowser.SelectedPath;
            }
        }

        //辐射定标
        private void btn_OK_Click(object sender, EventArgs e)
        {
            string inputStr = this.txb_input.Text.Trim();
            string outputStr = this.txb_output.Text.Trim();

            //检查输入的头文件和保存路径是否正确
            if (File.Exists(inputStr)&& Directory.Exists(outputStr))
            {
                FileInfo fileInfo=new FileInfo(inputStr);
                if (fileInfo.Extension == ".txt")
                {
                    //调用辐射定标函数
                    string[] resultStr = IdlProcess.IdlRadCalibration(inputStr, outputStr);
                    //如果勾选显示结果，则调用影像显示函数
                    if (isDisplayResult.Checked)
                    {
                        DataShowControl imgShow=new DataShowControl(pMapControl.Map);
                        imgShow.DisplayImg(resultStr[0]);
                        imgShow.DisplayImg(resultStr[1]);
                    }
                    //完成定标和显示后关闭当前窗口
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("输入的Landsat头文件格式不正确，正确格式为*._MTL.txt");
                }
            }
            else
            {
                MessageBox.Show("输入的文件或文件夹不存在，请修改！");
            }
        }
        //取消
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
