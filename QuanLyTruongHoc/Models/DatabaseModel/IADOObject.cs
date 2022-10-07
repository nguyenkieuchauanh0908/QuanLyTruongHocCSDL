using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    public interface IADOObject
    {
        DataTable Load();
        DataTable Get<T>(T obj) where T : IObject;

        bool Add<T>(T obj) where T : IObject;

        bool Update<T>(T obj) where T : IObject;
        bool Delete<T>(T obj) where T : IObject;
        DataTable Search<T>(T obj) where T : IObject;
    }
}
