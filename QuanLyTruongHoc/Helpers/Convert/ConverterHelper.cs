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
        public static T ConvertDataRow<T>(DataRow row) where T : IObject
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
    }
}
