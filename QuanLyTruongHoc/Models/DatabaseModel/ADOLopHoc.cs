using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOLopHoc : IADOObject
    {
        private ADOOperator adoOperator;
        public ADOLopHoc(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }
        
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
            string query = "SELECT * FROM THONGTINLOPHOC";
            return adoOperator.ExecuteQuery(query);
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
