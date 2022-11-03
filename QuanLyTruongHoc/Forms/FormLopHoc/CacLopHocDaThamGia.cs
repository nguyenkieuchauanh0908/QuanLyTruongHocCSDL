using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    public partial class CacLopHocDaThamGia : Form
    {
        public CacLopHocDaThamGia()
        {
            InitializeComponent();
        }
        public CacLopHocDaThamGia(int maSinhVien)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = MainForm.Manager.LopHoc.LoadLopHocWithSVId(maSinhVien);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //check right click on datagridview row
           
        }
    }
}
