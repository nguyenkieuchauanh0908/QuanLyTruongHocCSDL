using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOMonHoc : IADOObject
    {
        private ADOOperator adoOperator;
        public ADOMonHoc(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }
        public bool Add<T>(T obj) where T : IObject
        {
            string query = "dbo.InsertMonhoc";
            SqlParameter[] parameters = new SqlParameter[2];
           // parameters[0] = new SqlParameter("@ma_mon_hoc", (obj as MonHoc).MaMonHoc);
            parameters[0] = new SqlParameter("@ten_mon_hoc", (obj as MonHoc).TenMonHoc);
            parameters[1] = new SqlParameter("@so_tin_chi", (obj as MonHoc).SoTinhChi);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            string query = "execute XoaMonHoc @ma_mon_hoc";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ma_mon_hoc", (obj as MonHoc).MaMonHoc);
            return adoOperator.ExecuteNonQuery(query, parameters);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "select * from dbo.getMonHoc(@ma_mon_hoc)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ma_mon_hoc", (obj as MonHoc).MaMonHoc);
            return adoOperator.ExecuteQuery(query, parameters);
        }

        public DataTable Load()
        {
            string query = "select * from dbo.getAllMonHoc()";
            return adoOperator.ExecuteQuery(query);
        }

        public DataTable Search<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "dbo.UpdateMonhoc";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@ma_mon_hoc", (obj as MonHoc).MaMonHoc);
            parameters[1] = new SqlParameter("@ten_mon_hoc", (obj as MonHoc).TenMonHoc);
            parameters[2] = new SqlParameter("@so_tin_chi", (obj as MonHoc).SoTinhChi);
            parameters[3] = new SqlParameter("@da_xoa", (obj as MonHoc).TinhTrang);
            return adoOperator.ExecuteProcedure(query, parameters);
        }
    }
}
