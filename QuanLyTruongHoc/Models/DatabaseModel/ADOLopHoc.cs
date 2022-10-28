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
    internal class ADOLopHoc : IADOObject
    {
        private ADOOperator adoOperator;
        public ADOLopHoc(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }

        public bool Add<T>(T obj) where T : IObject
        {
            string query = "dbo.insertLopHoc";
            SqlParameter[] parameters = new SqlParameter[3];
            // parameters[0] = new SqlParameter("@ma_mon_hoc", (obj as MonHoc).MaMonHoc);
            parameters[0] = new SqlParameter("@ma_ky_hoc", (obj as LopHoc).MaKyHoc);
            parameters[1] = new SqlParameter("@ma_mon_hoc", (obj as LopHoc).MaMonHoc);
            parameters[2] = new SqlParameter("@ma_giang_vien", (obj as LopHoc).MaGiangVien);
            return adoOperator.ExecuteProcedure(query, parameters);
            //string query = "dbo.insertLopHoc";
            //SqlParameter[] parameters = new SqlParameter[3];
            //parameters[0] = new SqlParameter("@ma_ky_hoc", (obj as LopHoc).MaKyHoc);
            //parameters[1] = new SqlParameter("@ma_mon_hoc", (obj as LopHoc).MaMonHoc);
            //parameters[2] = new SqlParameter("@ma_giang_vien", (obj as LopHoc).MaGiangVien);
            ////parameters[3] = new SqlParameter("@ma_lop_hoc", (obj as LopHoc).MaLop);
            //return adoOperator.ExecuteProcedure(query, parameters);

        }

        public bool Delete<T>(T obj) where T : IObject
        {
            string query = "dbo.xoaLopHoc";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ma_lop_hoc", (obj as LopHoc).MaLop);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "select * from dbo.getLopHoc(@ma_lop_hoc)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ma_lop_hoc", (obj as LopHoc).MaLop);
            return adoOperator.ExecuteQuery(query, parameters);

        }

        public DataTable Load()
        {
            string query = "select * from dbo.getAllLopHoc()";
            return adoOperator.ExecuteQuery(query);
        }
        public DataTable Search<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "execute dbo.updateLopHoc @ma_ky_hoc, @ma_mon_hoc, @ma_giang_vien,@ma_lop_hoc, @da_xoa";
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@ma_ky_hoc", (obj as LopHoc).MaKyHoc);
            parameters[1] = new SqlParameter("@ma_mon_hoc", (obj as LopHoc).MaMonHoc);
            parameters[2] = new SqlParameter("@ma_giang_vien", (obj as LopHoc).MaGiangVien);
            parameters[3] = new SqlParameter("@ma_lop_hoc", (obj as LopHoc).MaLop);
            parameters[4] = new SqlParameter("@da_xoa", (obj as LopHoc).DaXoa);
            return adoOperator.ExecuteNonQuery(query, parameters);
        }
    }
}
