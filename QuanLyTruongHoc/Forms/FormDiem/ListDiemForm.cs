using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongHoc.Helpers;

namespace QuanLyTruongHoc.Forms.FormDiem
{
    internal class ListDiemForm : BaseListForm<Diem>
    {
        private System.Windows.Forms.BindingSource diemBindingSource;
        private BindingSource diemBindingSource1;
        private System.ComponentModel.IContainer components;
        public ListDiemForm()
        {
            InitializeComponent();
            
            //diemBindingSource.DataSource = new Diem();
            //switch (MainForm.Manager.VaiTroHienTai())
            //{
            //    case VAITRO.ADMIN:
            dataGridView.DataSource = MainForm.Manager.Diem.Load();
            //        break;
            //    case VAITRO.GIANGVIEN:
            //dataGridView.DataSource = MainForm.Manager.SinhVien
            //        break;
            //}
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.diemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 59);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(672, 13);
            this.search_btn.Size = new System.Drawing.Size(116, 33);
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click_1);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(566, 13);
            this.add_btn.Size = new System.Drawing.Size(100, 33);
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // diemBindingSource1
            // 
            this.diemBindingSource1.DataSource = typeof(QuanLyTruongHoc.DataObjects.Diem);
            // 
            // ListDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 694);
            this.Name = "ListDiemForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Diem diem = ConverterHelper.ConvertDataRow<Diem>(row);
                ViewDiemForm updateDiemForm = new ViewDiemForm(diem);
                updateDiemForm.Show();

            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Diem diem = ConverterHelper.ConvertDataRow<Diem>(row);
                ViewDiemForm updateDiemForm = new ViewDiemForm(diem);
                updateDiemForm.Show();

            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Diem diem = Helpers.Convert.ConverterHelper.ConvertDataRow<Diem>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADODiem Diem = MainForm.Manager.Diem;
                    if (Diem.Delete(diem))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView.DataSource = Diem.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có điểm nào được chọn");
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddDiemForm addDiemForm = new AddDiemForm();
            addDiemForm.Show();
        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {
            // convert datagridview to list<sinhvien>
            //List<Diem> diems = new List<Diem>();

            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    Diem diem = ConverterHelper.ConvertDataRow<Diem>(((DataRowView)row.DataBoundItem).Row);
            //    diems.Add(diem);
            //}
            //// search
            //Diem diemSearch = diemBindingSource.Current as Diem;
            //List<Diem> result = Helpers.Search.SearchBy<Diem>(diems, diemSearch);
            //dataGridView.DataSource = result;
        }
    }
}
