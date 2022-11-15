using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using QuanLyTruongHoc.Models.DatabaseModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongHoc.Helpers.Convert;

namespace QuanLyTruongHoc.Forms.FormChucNangGV
{
    internal class ListDanhSachSv : BaseListForm<SinhVien>
    {
        private BindingSource danhSachLopBindingSource;
        private TextBox textBox1;
        private System.ComponentModel.IContainer components;
        private ThongTinLopHoc thongTin;
        public ListDanhSachSv(ThongTinLopHoc thongTinLopHoc) : base()
        {
            InitializeComponent();
            thongTin = thongTinLopHoc;
            InitList();
        }


        public override DataTable GetTable()
        {
            return MainForm.Manager.GiangVien.GetDanhSachSV(thongTin);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.danhSachLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.textBox1, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(762, 212);
            this.search_btn.Size = new System.Drawing.Size(111, 38);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(609, 212);
            this.add_btn.Size = new System.Drawing.Size(122, 38);
            this.add_btn.Text = "Chấm điểm";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // danhSachLopBindingSource
            // 
            this.danhSachLopBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.DanhSachLop);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // ListDanhSachSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Name = "ListDanhSachSv";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                DanhSachLop danhSachLop = ConverterHelper.ConvertDataRow<DanhSachLop>(row);

                FormChamDiem formChamDiem = new FormChamDiem(danhSachLop);
                formChamDiem.Show();
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }
        
    }
}
