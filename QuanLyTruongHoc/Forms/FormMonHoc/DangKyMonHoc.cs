using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormLopHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormMonHoc
{
    public partial class DangKyMonHoc : Form
    {
        public DangKyMonHoc()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = MainForm.Manager.MonHoc.Load();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mo form load tat ca lop hoc co mon hoc nay con trong
            if (e.RowIndex >= 0)
            {
                int maMonHoc = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                ListLopHocCoTheDK listLopHocCoTheDK = new ListLopHocCoTheDK(maMonHoc);
                listLopHocCoTheDK.Show();
            }
        }
    }
}
