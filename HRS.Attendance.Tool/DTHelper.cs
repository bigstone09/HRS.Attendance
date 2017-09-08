using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HRS.Attendance.Tool
{
    public static class DTHelper
    {
        #region 私有方法

        /// <summary>
        /// 将DataTable转换为list
        /// </summary>
        /// <typeparam name="T">Model類型</typeparam>
        /// <param name="dt">行</param>
        /// <returns>ListModel</returns>
        public static List<T> DataTableToList<T>(DataTable dt)
        {
            if (dt == null)
            {
                return null;
            }
            List<T> list = new List<T>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(DataRowToModel<T>(dt.Rows[i]));
            }
            return list;
        }

        /// <summary>
        /// 一行數據轉換為Model
        /// </summary>
        /// <typeparam name="T">Mode類型</typeparam>
        /// <param name="drow">行</param>
        /// <returns>Model</returns>
        public static T DataRowToModel<T>(DataRow dr)
        {
            T model = (T)Activator.CreateInstance(typeof(T));
            System.Reflection.PropertyInfo[] propertys = model.GetType().GetProperties();

            if (dr.Table.Columns.Count > 0)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < dr.Table.Columns.Count; i++)
                {
                    list.Add(dr.Table.Columns[i].ColumnName.ToLower());
                }
                foreach (System.Reflection.PropertyInfo pi in propertys)
                {
                    string colName = pi.Name;
                    if (list.Contains(colName.ToLower()))
                    {
                        object colValue = dr[colName];
                        if (pi.PropertyType.Name == "Guid")
                        {
                            colValue = Guid.Parse(colValue.ToString());
                        }
                        pi.SetValue(NullFromDB(colValue), null);
                    }
                }
            }
            return model;
        }

        #endregion 私有方法

        /// <summary>
        /// 數據庫 null值 轉 C# null值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object NullFromDB(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        ///  C# null值 轉 數據庫 null值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object NullToDB(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }
    }
}