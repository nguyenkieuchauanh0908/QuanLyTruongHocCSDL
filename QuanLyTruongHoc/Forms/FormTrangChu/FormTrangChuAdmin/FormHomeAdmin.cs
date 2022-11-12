using QuanLyTruongHoc.Forms.FormDiem;
using QuanLyTruongHoc.Forms.FormGiangVien;
using QuanLyTruongHoc.Forms.FormKhoa;
using QuanLyTruongHoc.Forms.FormKyHoc;
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

namespace QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuAdmin
{
    public partial class FormHomeAdmin : Form
    {
        public FormHomeAdmin()
        {
            InitializeComponent();
        }

        private void sv_btn_Click(object sender, EventArgs e)
        {
            ListSinhVienForm listSinhVienForm = new ListSinhVienForm();
            listSinhVienForm.Show();
        }

        private void mh_btn_Click(object sender, EventArgs e)
        {
            ListMonHocForm listMonHocForm = new ListMonHocForm();
            listMonHocForm.Show();
        }

        private void lh_btn_Click(object sender, EventArgs e)
        {
            ListLopHocForm listLopHocForm = new ListLopHocForm();
            listLopHocForm.Show();
        }

        private void kyhoc_btn_Click(object sender, EventArgs e)
        {
            ListKyHocForm listKyHocForm = new ListKyHocForm();
            listKyHocForm.Show();
        }

        private void gv_btn_Click(object sender, EventArgs e)
        {
            ListGiangVienForm listGiangVienForm = new ListGiangVienForm();
            listGiangVienForm.Show();
        }

        private void khoa_btn_Click(object sender, EventArgs e)
        {
            ListKhoaForm listKhoaForm = new ListKhoaForm();
            listKhoaForm.Show();
        }

        private void diem_btn_Click(object sender, EventArgs e)
        {
            ListDiemForm listDiemForm = new ListDiemForm();
            listDiemForm.Show();
        }
    }
}
