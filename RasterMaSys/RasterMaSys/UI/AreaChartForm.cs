using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace RasterMaSys.UI
{
    public partial class AreaChartForm : Form
    {
        

        public AreaChartForm()
        {
            InitializeComponent();
        }

        public void BandingData(Dictionary<DateTime,double>dictionary )
        {
            List<DateTime> dates = dictionary.Keys.ToList();
            dates.Sort();

            int count = dates.Count;
            for (int i = count - 1; i > -1; i--)
            {
                var date = dates[i];
                chart1.Series[0].Points.InsertXY(0,date.ToShortDateString(),dictionary[date]);
            }

        }

        //保存图表
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile=new SaveFileDialog();
            saveFile.Filter = "BMP文件|*.bmp";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(saveFile.FileName,ImageFormat.Bmp);
            }
        }

       
    }
}
