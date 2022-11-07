using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Helpers
{
    internal class Search
    {
        public static List<T> SearchBy<T>(List<T> list,T objSearch) where T : IObject
        {
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
            return result;
        }
    }
}
