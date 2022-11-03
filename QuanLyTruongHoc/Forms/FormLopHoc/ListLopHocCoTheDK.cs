using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
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
    public partial class ListLopHocCoTheDK : Form
    {
        public ListLopHocCoTheDK()
        {
            InitializeComponent();
        }

        public ListLopHocCoTheDK(int maMonHoc)
        {
            InitializeComponent();
            this.dataGridView1.DataSource = MainForm.Manager.LopHoc.LoadLopHocWithMonId(maMonHoc);
        }

        public object ConvertHelper { get; private set; }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //get the row index
                int rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    //select the row
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                    //show the context menu
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int maLopHoc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            int maHocSinh = MainForm.Manager.CurrentLogin.id;
            Diem diem = new Diem();
            diem.maSV = maHocSinh;
            diem.maLop = maLopHoc;
            diem.diem_cuoi_ky = 0;
            diem.diem_giua_ky = 0;
            MainForm.Manager.Diem.Add(diem);
            MessageBox.Show("Đăng ký thành công");
        }
    }
}
