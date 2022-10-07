using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Models.DatabaseModel
{
    internal class ADOManager
    {
        private ADOOperator adoOperator;
        private ADOSinhVien sinhVien;
        private ADOLopHoc lopHoc;

        public ADOSinhVien SinhVien { get => sinhVien; }
        public ADOLopHoc LopHoc { get => lopHoc; }
        

        public ADOManager(string connectionString)
        {
            adoOperator = new ADOOperator(connectionString);
            sinhVien = new ADOSinhVien(adoOperator);
            lopHoc = new ADOLopHoc(adoOperator);
        }
    }
}
