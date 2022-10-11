using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADODiem : IADOObject
    {
        public bool Add<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public DataTable Load()
        {
            throw new NotImplementedException();
        }

        public DataTable Search<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }
    }
}
