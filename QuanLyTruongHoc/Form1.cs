using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms;
using QuanLyTruongHoc.Forms.FormLopHoc;
using QuanLyTruongHoc.Forms.FormSinhVien;
using QuanLyTruongHoc.Helpers;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc
{
    internal partial class MainForm : Form
    {
        private static ADOManager adoManager;

        public static ADOManager Manager { get => adoManager;} 
        
        string connectionString = @"Data Source=DESKTOP-7IT3958;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            adoManager = new ADOManager(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListSinhVienForm listLopHocForm = new ListSinhVienForm();
            listLopHocForm.Show();
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            string username = input_username.Text;
            string password = input_password.Text;
            VAITRO role = VAITRO.GIANGVIEN;

            if (sign_in_student.Checked)
            {
                role = VAITRO.SINHVIEN;
            }
            else if (sign_in_qtv.Checked)
            {
                role = VAITRO.ADMIN;
            }

            Login login = new Login();
            login.tenTaiKhoan = username;
            login.matKhau = password;
            login.vaiTro = role;

            if (Manager.CheckDangNhap(login))
            {
                MessageBox.Show("Đăng nhập thành công");
                HomeForm home = new HomeForm();
                home.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}

