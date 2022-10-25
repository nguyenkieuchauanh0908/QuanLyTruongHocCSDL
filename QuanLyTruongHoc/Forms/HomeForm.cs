using QuanLyTruongHoc.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button_lophoc_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // disable all button
            button_lophoc.Enabled = false;
            button_sv.Enabled = false;
            button_gv.Enabled = false;
            button_monhoc.Enabled = false;
            button_diem.Enabled = false;
            button_khoa.Enabled = false;
            button_kyhoc.Enabled = false;

            switch (MainForm.Manager.VaiTroHienTai())
            {
                case VAITRO.ADMIN:
                    button_lophoc.Enabled = true;
                    button_sv.Enabled = true;
                    button_gv.Enabled = true;
                    button_monhoc.Enabled = true;
                    button_diem.Enabled = true;
                    button_khoa.Enabled = true;
                    button_kyhoc.Enabled = true;
                    break;
                case VAITRO.SINHVIEN:
                    button_diem.Enabled = true;
                    break;
                case VAITRO.GIANGVIEN:
                    button_lophoc.Enabled = true;
                    button_sv.Enabled = true;
                    button_diem.Enabled = true;
                    break;
            }
        }
    }
}
