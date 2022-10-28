using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOSinhVien : IADOObject
    {
        private ADOOperator adoOperator;
        public ADOSinhVien(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }

        public DataTable Load()
        {
            string query = "select * from dbo.GetAllSinhVien()";

            return adoOperator.ExecuteQuery(query);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "select * from dbo.GetSinhVien(@maSV)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maSV", (obj as SinhVien).MaSV);
            return adoOperator.ExecuteQuery(query, parameters);

            // ExecuteQuery: Những query không làm thay đổi lên database
            // ExeecuteNonQuery: Những query làm thay đổi lên database (
        }

        public bool Add<T>(T obj) where T : IObject
        {
            string query = "dbo.InsertSinhVien";
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@ten", (obj as SinhVien).Ten);
            parameters[1] = new SqlParameter("@ho", (obj as SinhVien).Ho);
            parameters[2] = new SqlParameter("@email", (obj as SinhVien).Email);
            parameters[3] = new SqlParameter("@gioiTinh", (obj as SinhVien).GioiTinh);
            parameters[4] = new SqlParameter("@diaChi", (obj as SinhVien).DiaChi);
            parameters[5] = new SqlParameter("@ngaySinh", (obj as SinhVien).NgaySinh);
            parameters[6] = new SqlParameter("@tinhTrang", (obj as SinhVien).TinhTrang);
            parameters[7] = new SqlParameter("@maKhoa", (obj as SinhVien).MaKhoa);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "dbo.UpdateSinhVien";
            SqlParameter[] parameters = new SqlParameter[9];
            parameters[0] = new SqlParameter("@ten", (obj as SinhVien).Ten);
            parameters[1] = new SqlParameter("@ho", (obj as SinhVien).Ho);
            parameters[2] = new SqlParameter("@email", (obj as SinhVien).Email);
            parameters[3] = new SqlParameter("@gioiTinh", (obj as SinhVien).GioiTinh);
            parameters[4] = new SqlParameter("@diaChi", (obj as SinhVien).DiaChi);
            parameters[5] = new SqlParameter("@ngaySinh", (obj as SinhVien).NgaySinh);
            parameters[6] = new SqlParameter("@tinhTrang", (obj as SinhVien).TinhTrang);
            parameters[7] = new SqlParameter("@maKhoa", (obj as SinhVien).MaKhoa);
            parameters[8] = new SqlParameter("@maSV", (obj as SinhVien).MaSV);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            string query = "dbo.DeleteSinhVien";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maSV", (obj as SinhVien).MaSV);
            return adoOperator.ExecuteProcedure(query, parameters);
        }

        public DataTable GetSinhVienHocGiangVien(int maGV)
        {
            string query = "select * from dbo.GetSinhVienHocGiangVien(@maGV)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maGV", maGV);
            return adoOperator.ExecuteQuery(query, parameters);
        }

        public DataTable Search<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }
    }
}
