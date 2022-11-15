using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using QuanLyTruongHoc.Models.DatabaseModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormChucNangGV
{
    internal class ListDanhSachLop : BaseListForm<LopHoc>
    {
        private BindingSource thongTinLopHocBindingSource;
        private System.ComponentModel.IContainer components;
        private int id;

        public ListDanhSachLop() : base()
        {
            InitializeComponent();
            InitList();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.GiangVien.GetDanhSachLop(MainForm.Manager.CurrentLogin);
        }

        public ListDanhSachLop(int id)
        {
            this.id = id;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.thongTinLopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(776, 213);
            this.search_btn.Size = new System.Drawing.Size(97, 42);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(606, 213);
            this.add_btn.Size = new System.Drawing.Size(131, 42);
            this.add_btn.Text = "Kết thúc lớp";
            // 
            // thongTinLopHocBindingSource
            // 
            this.thongTinLopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.ThongTinLopHoc);
            // 
            // ListDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Name = "ListDanhSachLop";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                ThongTinLopHoc thongTinLopHoc = Helpers.Convert.ConverterHelper.ConvertDataRow<ThongTinLopHoc>(row);
                MessageBox.Show(thongTinLopHoc.maLop.ToString());
                ListDanhSachSv listDanhSachSv = new ListDanhSachSv(thongTinLopHoc);
                listDanhSachSv.Show();
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void add_btn_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {

                ThongTinLopHoc thongTinLopHoc = Helpers.Convert.ConverterHelper.ConvertDataRow<ThongTinLopHoc>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc lớp này không?", "Kết thúc lớp", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (MainForm.Manager.GiangVien.KetThucLop(thongTinLopHoc))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    
                }    
                  
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

    }
}
