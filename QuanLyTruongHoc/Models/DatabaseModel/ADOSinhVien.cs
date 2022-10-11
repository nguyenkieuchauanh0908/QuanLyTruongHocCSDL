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
            string query = "select * from SinhVien";
            return adoOperator.ExecuteQuery(query);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "SELECT * FROM SinhVien WHERE id = @maSV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maSV", (obj as SinhVien).MaSV);
            return adoOperator.ExecuteQuery(query, parameters);
        }

        public bool Add<T>(T obj) where T : IObject
        {
            string query = "INSERT INTO SinhVien VALUES(@ten, @ho, @email, @gioiTinh, @diaChi, @ngaySinh, @tinhTrang, @maKhoa)";
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@ten", (obj as SinhVien).Ten);
            parameters[1] = new SqlParameter("@ho", (obj as SinhVien).Ho);
            parameters[2] = new SqlParameter("@email", (obj as SinhVien).Email);
            parameters[3] = new SqlParameter("@gioiTinh", (obj as SinhVien).GioiTinh);
            parameters[4] = new SqlParameter("@diaChi", (obj as SinhVien).DiaChi);
            parameters[5] = new SqlParameter("@ngaySinh", (obj as SinhVien).NgaySinh);
            parameters[6] = new SqlParameter("@tinhTrang", (obj as SinhVien).TinhTrang);
            parameters[7] = new SqlParameter("@maKhoa", (obj as SinhVien).MaKhoa);
            return adoOperator.ExecuteNonQuery(query, parameters);
        }

        public bool Update<T>(T obj) where T : IObject
        {
            string query = "UPDATE SinhVien SET ten = @ten, ho = @ho, email = @email, gioi_tinh = @gioiTinh, dia_chi = @diaChi, ngay_sinh = @ngaySinh, tinh_trang = @tinhTrang, ma_khoa = @maKhoa WHERE id = @maSV";
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
            return adoOperator.ExecuteNonQuery(query, parameters);
        }

        public bool Delete<T>(T obj) where T : IObject
        {
            string query = "DELETE FROM SinhVien WHERE id = @maSV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maSV", (obj as SinhVien).MaSV);
            return adoOperator.ExecuteNonQuery(query, parameters);
        }

        public DataTable Search<T>(T obj) where T : IObject
        {
            throw new NotImplementedException();
        }
    }
}
