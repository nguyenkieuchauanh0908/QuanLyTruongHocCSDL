using QuanLyTruongHoc.Forms.FormLopHoc;
using QuanLyTruongHoc.Forms.FormMonHoc;
﻿using QuanLyTruongHoc.Forms.FormGiangVien;
﻿using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms;
using QuanLyTruongHoc.Forms.FormSinhVien;

using QuanLyTruongHoc.Forms.FormKhoa;
using QuanLyTruongHoc.Forms.FormKyHoc;

using QuanLyTruongHoc.Helpers;

using QuanLyTruongHoc.Models.DatabaseModel;
using QuanLyTruongHoc.Forms.FormDiem;
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
using QuanLyTruongHoc.Forms.FormChucNangGV;
using QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuSV;
using QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuAdmin;
using QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuGV;

namespace QuanLyTruongHoc
{
    internal partial class MainForm : Form
    {
        private static ADOManager adoManager;


        public static ADOManager Manager { get => adoManager;}

        //string connectionString = @"Data Source=DESKTOP-7IT3958;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True";
        //string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True";
        string connectionString = @"Data Source=DESKTOP-7CJHVGV\SQLEXPRESS;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public MainForm()
        {
            InitializeComponent();
            adoManager = new ADOManager(connectionString);
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
                switch (role)
                {
                    case VAITRO.SINHVIEN:
                        FormHomeSV formHomeSV = new FormHomeSV();
                        formHomeSV.Show();
                        break;
                    case VAITRO.GIANGVIEN:
                        //FormHomeGV formHomeGV = new FormHomeGV();
                        //formHomeGV.Show();
                        ListDanhSachLop listDanhSachLop = new ListDanhSachLop();
                        listDanhSachLop.Show();
                        break;
                    case VAITRO.ADMIN:
                        FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
                        formHomeAdmin.Show();
                        break;
                }
                //HomeForm home = new HomeForm();
                //home.Show();
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ListSinhVienForm listSinhVienForm = new ListSinhVienForm();
            //listSinhVienForm.Show();
            //ListLopHocForm listLopHocForm = new ListLopHocForm();
            //listLopHocForm.Show();

            //ListGiangVienForm listGiangVienForm = new ListGiangVienForm();
            //listGiangVienForm.Show();
            //ListDiemForm listDiemForm = new ListDiemForm();
            //listDiemForm.Show();

            //ListMonHocForm listMonHocForm = new ListMonHocForm();
            //listMonHocForm.Show();
            //ListKhoaForm listKhoaForm = new ListKhoaForm();
            //listKhoaForm.Show();

            //ListKyHocForm listKyHocForm = new ListKyHocForm();
            //listKyHocForm.Show();

            FormChamDiem formChamDiem = new FormChamDiem();
            formChamDiem.Show();
        }
    }
}

