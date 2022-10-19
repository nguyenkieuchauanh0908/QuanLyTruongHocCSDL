using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADODangNhap
    {
        private ADOOperator adoOperator;
        public ADODangNhap(ADOOperator adoOperator)
        {
            this.adoOperator = adoOperator;
        }

        public int CheckDangNhap(Login login)
        {
            string query = "";
            switch(login.vaiTro)
            {
                case VAITRO.SINHVIEN:
                    {
                        query = "SELECT * FROM TAIKHOANSINHVIEN WHERE TEN_TAI_KHOAN = @tenTaiKhoan AND MAT_KHAU = @matKhau";
                        break;
                    }
                case VAITRO.GIANGVIEN:
                    {
                        query = "SELECT * FROM TAIKHOANGIANGVIEN WHERE TEN_TAI_KHOAN = @tenTaiKhoan AND MAT_KHAU = @matKhau";
                        break;
                    }
                case VAITRO.ADMIN:
                    {
                        query = "SELECT * FROM TAIKHOANQTV WHERE TEN_TAI_KHOAN = @tenTaiKhoan AND MAT_KHAU = @matKhau";
                        break;
                    }
                default:
                    {
                        return -1;
                    }
            }

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@tenTaiKhoan", login.tenTaiKhoan),
                new SqlParameter("@matKhau", login.matKhau)
            };

            DataTable result = adoOperator.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
                return (Convert.ToInt16(result.Rows[0][0]));

            return -1;
        }
    }
}
