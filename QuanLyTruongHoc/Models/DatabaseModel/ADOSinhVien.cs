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
        private ADOManager manager;
        public ADOSinhVien(ADOManager manager)
        {
            this.manager = manager;
        }

        public DataTable Load()
        {
            string query = "select * from SinhVien";
            return manager.ExecuteQuery(query);
        }

        public DataTable Get<T>(T obj) where T : IObject
        {
            string query = "SELECT * FROM SinhVien WHERE id = @maSV";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@maSV", (obj as SinhVien).MaSV);
            return manager.ExecuteQuery(query, parameters);
        }
    }
}
