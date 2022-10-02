using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class ListSinhVienForm : BaseListForm
    {
        string connectionString = @"Data Source=DESKTOP-7IT3958;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True";
        ADOManager manager;
        public ListSinhVienForm()
        {
            manager = new ADOManager(connectionString);
            ADOSinhVien sinhVien = new ADOSinhVien(manager);
            dataGridView.DataSource = sinhVien.Load();
        }
    }
}
