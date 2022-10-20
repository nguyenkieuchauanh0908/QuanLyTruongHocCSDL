using QuanLyTruongHoc.Forms.FormLopHoc;
using QuanLyTruongHoc.Forms.FormMonHoc;
using QuanLyTruongHoc.Forms.FormSinhVien;
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
        
        string connectionString = @"Data Source=DESKTOP-S151P30\SQLEXPRESS;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            adoManager = new ADOManager(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ListSinhVienForm listLopHocForm = new ListSinhVienForm();
            //listLopHocForm.Show();

            ListLopHocForm listLopHocForm = new ListLopHocForm();
            //listLopHocForm.Show();

            //ViewLopHocForm viewLopHocForm = new ViewLopHocForm();
            //viewLopHocForm.Show();

            //ViewSinhVienForm viewSinhVienForm = new ViewSinhVienForm();
            //viewSinhVienForm.Show();

            //ViewLopHocForm viewLopHocForm = new ViewLopHocForm();
            //viewLopHocForm.Show();

            AddLopHocForm addLopHocForm = new AddLopHocForm();
            addLopHocForm.Show();

            //ListMonHocForm listMonHocForm = new ListMonHocForm();
            //listMonHocForm.Show();

            //AddMonHocForm addMonHocForm = new AddMonHocForm();
            //addMonHocForm.Show();

        }
    }
}

