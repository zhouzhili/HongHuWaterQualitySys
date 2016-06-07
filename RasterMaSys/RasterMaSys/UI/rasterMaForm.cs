using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using RasterMaSys.BLL;
using RasterMaSys.DAL;
using RasterMaSys.Util;
using RasterMaSys.Model;

namespace RasterMaSys.UI
{
    public partial class RasterMaForm : Form
    {
        public RasterMaForm(IMap pMap)
        {
            InitializeComponent();
            //设置初始选项
            this.sensorTypeComboBox.SelectedItem = "所有影像";
            this.dataGridView1.ReadOnly = true;
            this._mainFormMap = pMap;
        }

        private readonly IMap _mainFormMap;

        /// <summary>
        /// 获取输入的查询条件，并进行验证，返回SearchCondition对象
        /// </summary>
        /// <returns>SearchCondition</returns>
        private SearchCondition GetSearchCondition()
        {
            SearchCondition scCondition = new SearchCondition();
            if (this.sensorTypeComboBox.SelectedItem != null)
            {
                if (this.sensorTypeComboBox.SelectedItem.ToString() != "所有影像")
                {
                    scCondition.SensorType = this.sensorTypeComboBox.SelectedItem.ToString();
                }

            }

            scCondition.RsStarTime = this.rsTimeStart.Value;
            scCondition.RsEndTime = this.rsTimeEnd.Value;

            if (MyValidateUtil.IsShort(this.rowIdStart.Text.Trim()))
            {
                scCondition.StartRowId = short.Parse(this.rowIdStart.Text.Trim());
            }

            if (MyValidateUtil.IsShort(this.rowIdEnd.Text.Trim()))
            {
                scCondition.EndRowId = short.Parse(this.rowIdEnd.Text.Trim());
            }

            if (MyValidateUtil.IsShort(this.colIdStart.Text.Trim()))
            {
                scCondition.StartColId = short.Parse(this.colIdStart.Text.Trim());
            }

            if (MyValidateUtil.IsShort(this.colIdEnd.Text.Trim()))
            {
                scCondition.EndColId = short.Parse(this.colIdEnd.Text.Trim());
            }

            if (MyValidateUtil.IsDouble(this.cloudAge.Text.Trim()))
            {
                scCondition.CloudAge = double.Parse(this.cloudAge.Text.Trim());
            }

            return scCondition;
        }

        //查询按钮
        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.SearchData();
        }

        private void SearchData()
        {
            this.dataGridView1.DataSource = null;
            SearchCondition scSearchCondition = this.GetSearchCondition();
            List<rasterTable> resulTables = DataAccess.GetData(scSearchCondition);
            if (resulTables.Count > 0)
            {
                this.dataGridView1.DataSource = resulTables;
            }
        }

        /// <summary>
        /// 添加信息入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDataBtn_Click(object sender, EventArgs e)
        {
            AddInfoForm addInfoForm = new AddInfoForm(this.dataGridView1,this.GetSearchCondition());
            addInfoForm.Show();         
        }

        //修改
        private void editDataBtn_Click(object sender, EventArgs e)
        {
            int rowIndex =this. dataGridView1.CurrentCell.RowIndex;
            rasterTable ts =this. dataGridView1.Rows[rowIndex].DataBoundItem as rasterTable;
            if (ts !=null)
            {
                ModifyDataForm modifyDataForm = new ModifyDataForm(ts,this.dataGridView1,this.GetSearchCondition());
                modifyDataForm.Show();
                this.SearchData();
            }
            else
            {
                MessageBox.Show("请选择需要修改的行");
            }
        }

        //删除
        private void deleteDataBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
            rasterTable ts = this.dataGridView1.Rows[rowIndex].DataBoundItem as rasterTable;
            if (ts!=null)
            {
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                string str = string.Format("确定删除路径为{0}的记录吗?", ts.path);
                DialogResult dr = MessageBox.Show(str, "取消删除", messageBoxButtons);
                if (dr == DialogResult.Yes)
                {
                    int result = DataAccess.DeletData(ts);
                    if (result > 0)
                    {
                        this.SearchData();
                        MessageBox.Show("删除成功!");
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                } 
            }
            else
            {
                MessageBox.Show("请选择需要修改的行");
            }
        }

        //添加显示
        private void 添加至显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IRasterLayer pRasterLayer = DatagridViewMenuClass.AddImgToShow(this.dataGridView1);
            if (pRasterLayer != null)
            {
                this._mainFormMap.AddLayer(pRasterLayer);
            }
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatagridViewMenuClass.OpenSelectDir(this.dataGridView1);
        }

        //调整格式，去除空格
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is string)
            {
                e.Value = e.Value.ToString().Trim();
            }
        }
    }
}
