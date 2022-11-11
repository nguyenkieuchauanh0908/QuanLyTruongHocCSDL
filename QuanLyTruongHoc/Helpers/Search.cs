using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Helpers
{
    internal class Search
    {
        public static DataTable SearchBy<T>(DataTable table,T objSearch)
        {
            List<T> list = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                T item = ConverterHelper.ConvertDataRow<T>(row);
                list.Add(item);
            }

            List<T> result = new List<T>();

            foreach (var item in list)
            {
                bool check = true;
                foreach (var property in item.GetType().GetProperties())
                {
                    var value = property.GetValue(objSearch, null);
                    if (value != null)
                    {
                        if (property.GetValue(item).ToString() != value.ToString())
                        {
                            check = false;
                            break;
                        }
                    }
                }
                if(check)
                {
                    result.Add(item);
                }
            }
            return ConverterHelper.ConvertListToDataTable<T>(result, table.Clone());
        }
    }
}
