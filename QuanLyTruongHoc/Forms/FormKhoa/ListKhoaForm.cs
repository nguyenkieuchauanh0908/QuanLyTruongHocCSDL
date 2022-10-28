using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormSinhVien;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class ListKhoaForm : BaseListForm
    {
        private BindingSource khoaBindingSource;
        private System.ComponentModel.IContainer components;

        public ListKhoaForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.Khoa.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.Khoa);
            // 
            // ListKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Name = "ListKhoaForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa khoa = ConverterHelper.ConvertDataRow<Khoa>(row);
                ViewKhoaForm viewKhoaForm = new ViewKhoaForm(khoa);
                viewKhoaForm.Show();
            }
            else
            {
                MessageBox.Show("Không có khoa nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa khoa = ConverterHelper.ConvertDataRow<Khoa>(row);
                UpdateKhoaForm updateKhoaForm = new UpdateKhoaForm(khoa);
                updateKhoaForm.Show();
            }
            else
            {
                MessageBox.Show("Không có khoa nào được chọn");
            }
        }
        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Khoa kh = ConverterHelper.ConvertDataRow<Khoa>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?", "Xóa khoa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOKhoa khoa = MainForm.Manager.Khoa;
                    if (khoa.Delete(kh))
                    {
                        MessageBox.Show("Xóa khoa thành công");
                        dataGridView.DataSource = khoa.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKhoaForm addKhoaForm = new AddKhoaForm();
            addKhoaForm.Show();
        }
    }
}
