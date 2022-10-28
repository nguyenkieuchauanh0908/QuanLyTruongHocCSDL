using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormGiangVien
{
    internal class ListGiangVienForm : BaseListForm
    {
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        //private Button add_btn;
        private System.ComponentModel.IContainer components;
        public ListGiangVienForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.GiangVien.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(828, 218);
            // 
            // add_btn
            // 
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // ListGiangVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Name = "ListGiangVienForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                
                GiangVien gv = Helpers.Convert.ConverterHelper.ConvertDataRow<GiangVien>(row);
                ViewGiangVienForm viewGiangVienForm = new ViewGiangVienForm (gv);
                viewGiangVienForm.Show();
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            //if (row != null)
            //{
            //    GiangVien gv = ConverterHelper.ConvertDataRow<GiangVien>(row);
            //    UpdateGiangVienForm updateGiangVienForm = new UpdateGiangVienForm(gv);
            //    updateGiangVienForm.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Không có giảng viên nào được chọn");
            //}
        }

        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                GiangVien gv = Helpers.Convert.ConverterHelper.ConvertDataRow<GiangVien>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giang vien này không?", "Xóa giang vien", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOGiangVien giangVien = MainForm.Manager.GiangVien;
                    if (giangVien.Delete(gv))
                    {
                        MessageBox.Show("Xóa giảng viên thành công");
                        dataGridView.DataSource = giangVien.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa giảng viên thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            AddGiangVienForm addGiangVienForm = new AddGiangVienForm();
            addGiangVienForm.Show();
        }
    }
}
