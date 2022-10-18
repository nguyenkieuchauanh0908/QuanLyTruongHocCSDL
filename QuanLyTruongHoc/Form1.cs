using QuanLyTruongHoc.Forms.FormGiangVien;
using QuanLyTruongHoc.Forms.FormLopHoc;
using QuanLyTruongHoc.Forms.FormSinhVien;
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

namespace QuanLyTruongHoc
{
    internal partial class MainForm : Form
    {
        private static ADOManager adoManager;

        public static ADOManager Manager { get => adoManager;}

        //string connectionString = @"Data Source=DESKTOP-7IT3958;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True";
        string connectionString = @"Data Source=DESKTOP-7CJHVGV\SQLEXPRESS;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//ChauAnh

        public MainForm()
        {
            InitializeComponent();
            adoManager = new ADOManager(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListSinhVienForm listSinhVienForm = new ListSinhVienForm();
            ListGiangVienForm listGiangVienForm = new ListGiangVienForm();
            ListDiemForm listDiemForm = new ListDiemForm();
            listDiemForm.Show();
        }
    }
}

