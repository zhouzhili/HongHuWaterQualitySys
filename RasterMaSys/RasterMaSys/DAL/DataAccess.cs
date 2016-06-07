using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using RasterMaSys.Util;
using RasterMaSys.Model;

namespace RasterMaSys.DAL
{
    public class DataAccess
    {
        /// <summary>
        /// 根据输入的查询条件，从数据库中查询相应的数据。
        /// </summary>
        /// <param name="scCondition"></param>
        /// <returns>List<rasterTable/></returns>
        public static List<rasterTable> GetData(SearchCondition scCondition)
        {
            rasterDBEntities rsDbEntities = new rasterDBEntities();
            List<rasterTable> queryReaulTables=new List<rasterTable>();
            try
            {
                //查询条件使用三目运算符，如果用户输入的不为空，则进行查询，否则为true，不进行查询
                
                var resultQuery = from n in rsDbEntities.rasterTable
                    where
                        ((scCondition.SensorType != null) ? scCondition.SensorType == n.sensor : true) &&
                        (DateTime.Compare(scCondition.RsStarTime, n.rstime) <= 0) &&
                        (DateTime.Compare(scCondition.RsEndTime, n.rstime) >= 0) &&
                        ((scCondition.StartRowId != null) ? scCondition.StartRowId <= n.rowID : true) &&
                        ((scCondition.EndRowId != null) ? scCondition.EndRowId >= n.rowID : true) &&
                        ((scCondition.StartColId != null) ? scCondition.StartColId <= n.colID : true) &&
                        ((scCondition.EndColId != null) ? scCondition.EndColId >= n.colID : true) &&
                        ((scCondition.CloudAge != null) ? n.cloudage < scCondition.CloudAge/100 : true)
                    select n;

                queryReaulTables = resultQuery.ToList();
                return queryReaulTables;
            }
            catch (Exception e)
            {
                MessageBox.Show("查询出现错误:" + e.Message);
                return queryReaulTables;
            }
            finally
            {
                rsDbEntities.Dispose();
            }
            
        }

        //查询所有数据
        public static List<rasterTable> GetAllData()
        {
            rasterDBEntities rsDbEntities=new rasterDBEntities();
            List<rasterTable> queryTables=new List<rasterTable>();
            try
            {
                queryTables = (from n in rsDbEntities.rasterTable select n).ToList();
                return queryTables;
            }
            catch (Exception e)
            {
                MessageBox.Show("查询出现错误:" + e.Message);
                return queryTables;
            }
            finally
            {
                rsDbEntities.Dispose();
            }
        } 

       /// <summary>
       /// 添加
       /// </summary>
       /// <param name="imginfo"></param>
       /// <returns></returns>
        public static int  AddImgData(rasterTable imginfo)
        {
            rasterDBEntities rsDbEntities=new rasterDBEntities();
            int resultState = 0;
            try
            {
                rsDbEntities.rasterTable.Add(imginfo);
              resultState=  rsDbEntities.SaveChanges();
                return resultState;
            }
            catch (Exception e)
            {
                MessageBox.Show("添加数据发生异常:" + e.Message);
                return resultState;
            }
            finally
            {
                rsDbEntities.Dispose();
            }
           
           
        }

     /// <summary>
     /// 修改
     /// </summary>
     /// <param name="imgInfoTable"></param>
     /// <returns></returns>
        public static int ModifyData(rasterTable imgInfoTable)
        {
            rasterDBEntities rsDbEntities=new rasterDBEntities();
            int resultState = 0;
            try
            {
                //将实体附加到对象管理器中
                rsDbEntities.rasterTable.Attach(imgInfoTable);
                //把当前实体的状态改为Modified
                rsDbEntities.Entry(imgInfoTable).State = EntityState.Modified;
               resultState= rsDbEntities.SaveChanges();
                return resultState;
            }
            catch (Exception e)
            {
                MessageBox.Show("修改数据发生异常:" + e.Message);
                return resultState;
            }
            finally
            {
                rsDbEntities.Dispose();
            }
            
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="imgTable"></param>
        /// <returns></returns>
        public static int DeletData(rasterTable imgTable)
        {
            rasterDBEntities rsEntities=new rasterDBEntities();
            int resultState = 0;
            try
            {
                rsEntities.rasterTable.Attach(imgTable);
                rsEntities.rasterTable.Remove(imgTable);
                resultState = rsEntities.SaveChanges();
                return resultState;
            }
            catch (Exception e)
            {
                MessageBox.Show("删除出现错误:" + e.Message);
                return resultState;
            }
            finally
            {
                rsEntities.Dispose();
            }
        }
    }
}
