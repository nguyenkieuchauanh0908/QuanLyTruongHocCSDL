using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormLopHoc;
using QuanLyTruongHoc.Forms.FormMonHoc;
using QuanLyTruongHoc.Forms.FormSinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuSV
{
    public partial class FormHomeSV : Form
    {
        public FormHomeSV()
        {
            InitializeComponent();
        }

        private void monDaDk_Click(object sender, EventArgs e)
        {
            CacLopHocDaThamGia daThamGia = new CacLopHocDaThamGia();
            daThamGia.Show();
        }

        private void dangky_Click(object sender, EventArgs e)
        {
            DangKyMonHoc dangKyMonHoc = new DangKyMonHoc();
            dangKyMonHoc.Show();
        }

        private void thongtincanhan_Click(object sender, EventArgs e)
        {
            SinhVien svInfo = new SinhVien();
            svInfo.MaSV = MainForm.Manager.CurrentLogin.id;
            SinhVien sv = Helpers.Convert.ConvertToObject.ToSinhVien(MainForm.Manager.SinhVien.Get(svInfo).Rows[0]);
            ViewSinhVienForm viewSinhVienForm = new ViewSinhVienForm(sv);
            viewSinhVienForm.Show();
        }
    }
}
