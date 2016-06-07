using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using RasterMaSys.DAL;
using RasterMaSys.Model;
using RasterMaSys.BLL;

namespace RasterMaSys.UI
{
    public partial class ImgListForm : Form
    {
        public ImgListForm(IMap pMap)
        {
            InitializeComponent();
            this._pMap = pMap;
            LoadData();
        }

        private readonly IMap _pMap;

        private void LoadData()
        {
            List<rasterTable> imgList = DataAccess.GetAllData();
            this.dataGridView1.DataSource = imgList;
        }

        private void 添加至显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IRasterLayer pRasterLayer = DatagridViewMenuClass.AddImgToShow(this.dataGridView1);
            if (pRasterLayer != null)
            {
                this._pMap.AddLayer(pRasterLayer);
            }
        }

        private void 打开所在文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatagridViewMenuClass.OpenSelectDir(this.dataGridView1);
        }

        //dataGridView调整格式,去除空格
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is string)
            {
                e.Value = e.Value.ToString().Trim();
            }
        }
    }
}
