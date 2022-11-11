using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Helpers.Convert
{
    internal class ConverterHelper
    {
        public static T ConvertDataRow<T>(DataRow row)
        {
            T item = GetItem<T>(row);
            return item;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    var property = pro.GetCustomAttributes<DataNameAttribute>(false).FirstOrDefault();
                    if (property != null)
                    {
                        if (property.ValueNames[0] == column.ColumnName)
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        else
                            continue;
                    }
                }
            }
            return obj;
        }

        public static DataTable ConvertListToDataTable<T>(List<T> list, DataTable table)
        {
            DataTable result = table;
            foreach (var item in list)
            {
                DataRow row = result.NewRow();
                
                foreach (var property in item.GetType().GetProperties())
                {

                    if (property.GetCustomAttributes<DataNameAttribute>(false).FirstOrDefault() != null)
                    {
                        string columnName = property.GetCustomAttributes<DataNameAttribute>(false).FirstOrDefault().ValueNames[0];
                        row[columnName] = property.GetValue(item);
                    }
                    else
                    {
                        row[property.Name] = property.GetValue(item);
                    }
                }
                result.Rows.Add(row);
            }
            return result;
        }
    }
}
