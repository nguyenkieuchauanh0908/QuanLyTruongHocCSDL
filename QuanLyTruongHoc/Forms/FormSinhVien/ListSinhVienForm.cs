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

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class ListSinhVienForm : BaseListForm
    {
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.ComponentModel.IContainer components;
        public ListSinhVienForm()
        {
            InitializeComponent();
            
            switch(MainForm.Manager.VaiTroHienTai())
            {
                case VAITRO.ADMIN:
                    dataGridView.DataSource = MainForm.Manager.SinhVien.Load();
                    break;
                case VAITRO.GIANGVIEN:
                    //dataGridView.DataSource = MainForm.Manager.SinhVien
                    break;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(828, 238);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.SinhVien);
            // 
            // ListSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Name = "ListSinhVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                SinhVien sv = ConverterHelper.ConvertDataRow<SinhVien>(row);
                ViewSinhVienForm viewSinhVienForm = new ViewSinhVienForm(sv);
                viewSinhVienForm.Show();
            }
            else
            {
                MessageBox.Show("Khum có sinh viên nào thêm vào");
            }
        }

        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                SinhVien sv = ConverterHelper.ConvertDataRow<SinhVien>(row);
                UpdateSinhVienForm updateSinhVienForm = new UpdateSinhVienForm(sv);
                updateSinhVienForm.Show();
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }

        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                SinhVien sv = ConverterHelper.ConvertDataRow<SinhVien>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xóa sinh viên", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOSinhVien sinhVien = MainForm.Manager.SinhVien;
                    if (sinhVien.Delete(sv))
                    {
                        MessageBox.Show("Xóa sinh viên thành công");
                        dataGridView.DataSource = sinhVien.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }

    }
}
