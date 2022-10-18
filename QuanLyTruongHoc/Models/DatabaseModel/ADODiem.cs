using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADODiem : IADOObject
    {
        private ADOOperator adoOperator;
        public ADODiem(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }
        public DataTable Load()
        {
            string query = "execute dbo.getAllBD";
            return adoOperator.ExecuteQuery(query);
        }
        public bool Add<T>(T obj) where T : IObject
        {
            string query = "execute addDiem @maLop,@maSV,@diem_giua_ky,@diem_cuoi_ky";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@maLop", (obj as Diem).maLop);
            parameters[1] = new SqlParameter("@maSV", (obj as Diem).maSV);
            parameters[2] = new SqlParameter("@diem_giua_ky", (obj as Diem).diem_giua_ky);
            parameters[3] = new SqlParameter("@diem_cuoi_ky", (obj as Diem).diem_cuoi_ky);
            return adoOperator.ExecuteNonQuery(query, parameters);
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            string query = "execute deleteDiem @maLop,@maSV";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@maLop", (obj as Diem).maLop);
            parameters[1] = new SqlParameter("@maSV", (obj as Diem).maSV);
            return adoOperator.ExecuteNonQuery(query, parameters);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "execute getDiemById @maLop,@maSV";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@maLop", (obj as Diem).maLop);
            parameters[1] = new SqlParameter("@maSV", (obj as Diem).maSV);
            return adoOperator.ExecuteQuery(query, parameters);
        }


        public DataTable Search<T>(T obj) where T : IObject
        {
            return null;
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "execute updateDiem @maLop,@maSV,@diem_giua_ky,@diem_cuoi_ky";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@maLop", (obj as Diem).maLop);
            parameters[1] = new SqlParameter("@maSV", (obj as Diem).maSV);
            parameters[2] = new SqlParameter("@diem_giua_ky", (obj as Diem).diem_giua_ky);
            parameters[3] = new SqlParameter("@diem_cuoi_ky", (obj as Diem).diem_cuoi_ky);

            return adoOperator.ExecuteNonQuery(query, parameters);
        }
    }
}
