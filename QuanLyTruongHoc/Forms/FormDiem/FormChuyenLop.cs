using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormDiem
{
    public partial class FormChuyenLop : Form
    {
        Diem diem;
        public FormChuyenLop(Diem diem)
        {
            InitializeComponent();
            this.diem = diem;

            this.textBox1.Enabled = false;
            this.textBox1.Text = diem.maLop.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int maLopMoi =  Convert.ToInt32(this.textBox2.Text);
                MessageBox.Show(diem.maSV + " " + diem.maLop + " " + maLopMoi);
                // Goi den ham chuyen lop
                MainForm.Manager.Diem.MoveSV(diem.maSV ?? 0, diem.maLop ?? 0, maLopMoi);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FormChuyenLop_Load(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false;
        }
    }
}
