using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RasterMaSys.DAL;
using RasterMaSys.Model;
using RasterMaSys.Util;

namespace RasterMaSys.UI
{
    public partial class ModifyDataForm : Form
    {
        public ModifyDataForm(rasterTable ts, DataGridView dg, SearchCondition sc)
        {
            InitializeComponent();
            this._selecData = ts;
            InitForm(ts);
        }

        private rasterTable _selecData;
        private DataGridView _dataGridView;
        private SearchCondition _condition;

        //获取路径
        private void getPathbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imgPathtxb.Text = openFileDialog.FileName;
            }
        }

        //修改
        private void confirmAddBtn_Click(object sender, EventArgs e)
        {
            rasterTable modifyTable = this.GetImgInfo();
            if (modifyTable.path != null)
            {
                int resultState = DataAccess.ModifyData(modifyTable);
                if (resultState > 0)
                {
                    MessageBox.Show("数据修改成功");
                    this.UpdateDataGridView();
                }
                else
                {
                    MessageBox.Show("数据修改失败");
                }
            }
            else
            {
                MessageBox.Show("影像路径不能为空!");
            }
        }

        private void UpdateDataGridView()
        {
            this._dataGridView.DataSource = null;
            SearchCondition scSearchCondition = this._condition;
            List<rasterTable> resulTables = DataAccess.GetData(scSearchCondition);
            if (resulTables.Count > 0)
            {
                this._dataGridView.DataSource = resulTables;
            }
        }

        /// <summary>
        /// 获取窗口中填写的影像信息，并做初步验证
        /// </summary>
        /// <returns></returns>
        private rasterTable GetImgInfo()
        {
            rasterTable imgInfo = new rasterTable();
            if (!String.IsNullOrEmpty(this.imgPathtxb.Text.Trim()))
            {
                imgInfo.path = this.imgPathtxb.Text.Trim();
            }
            imgInfo.id = this._selecData.id;
            imgInfo.sensor = this.imgSensorTypecomboBox.SelectedItem.ToString();
            imgInfo.rstime = this.imgDateTimePicker.Value;

            if (MyValidateUtil.IsShort(this.imgRowIdtxb.Text))
            {
                imgInfo.rowID = short.Parse(this.imgRowIdtxb.Text);
            }
            if (MyValidateUtil.IsShort(this.imgColIdtxb.Text))
            {
                imgInfo.colID = short.Parse(this.imgColIdtxb.Text);
            }
            if (MyValidateUtil.IsDouble(this.imgCloudtxb.Text))
            {
                imgInfo.cloudage = double.Parse(this.imgCloudtxb.Text);
            }

            return imgInfo;
        }

        //初始化窗口
        private void InitForm(rasterTable ts)
        {
            this.imgPathtxb.Text = ts.path.Trim();
            int index = this.imgSensorTypecomboBox.FindString(ts.sensor.Trim());
            this.imgSensorTypecomboBox.SelectedIndex = index;
            this.imgDateTimePicker.Value = ts.rstime;
            if (ts.rowID != null)
            {
                this.imgRowIdtxb.Text = ts.rowID.ToString();
            }
            if (ts.colID != null)
            {
                this.imgColIdtxb.Text = ts.colID.ToString();
            }
            if (ts.cloudage != null)
            {
                this.imgCloudtxb.Text = ts.cloudage.ToString();
            }
        }
    }
}
