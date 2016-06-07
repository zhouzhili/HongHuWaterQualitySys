using System;
using System.Windows.Forms;
using RasterMaSys.DAL;
using RasterMaSys.Model;
using RasterMaSys.Util;
using System.Collections.Generic;

namespace RasterMaSys.UI
{
    public partial class AddInfoForm : Form
    {
        public AddInfoForm(DataGridView dg,SearchCondition sc)
        {
            InitializeComponent();
            this._dataGridView = dg;
            this._condition = sc;
        }

        private DataGridView _dataGridView;
        private SearchCondition _condition;


        /// <summary>
        /// 获取窗口中填写的影像信息，并做初步验证
        /// </summary>
        /// <returns></returns>
        private rasterTable GetImgInfo()
        {
            rasterTable imgInfo=new rasterTable();
            if (!String.IsNullOrEmpty(this.imgPathtxb.Text.Trim()))
            {
                imgInfo.path = this.imgPathtxb.Text.Trim();
            }
            
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

        /// <summary>
        /// 确认添加按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmAddBtn_Click(object sender, EventArgs e)
        {
            rasterTable rasterTable = this.GetImgInfo();
            if (rasterTable.path!=null)
            {
              int result=  DataAccess.AddImgData(rasterTable);
                if (result > 0)
                {
                    MessageBox.Show("添加成功!");
                    if (this._dataGridView != null && this._condition != null)
                    {
                        this.UpdateDataGridView();
                    }
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
        /// 获取文件夹绝对路径按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getPathbtn_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog=new OpenFileDialog();
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imgPathtxb.Text = openFileDialog.FileName;
            }
        }
    }
}
