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
        private Button add_btn;
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
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Size = new System.Drawing.Size(828, 238);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.GiangVien);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(583, 178);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddGiangVienForm addGiangVienForm = new AddGiangVienForm();
            addGiangVienForm.Show();
        }
    }
}
