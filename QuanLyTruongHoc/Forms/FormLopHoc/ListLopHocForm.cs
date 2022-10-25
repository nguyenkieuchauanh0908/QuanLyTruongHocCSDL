using QuanLyTruongHoc.DataObjects;
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

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    internal class ListLopHocForm : BaseListForm
    {
        private System.Windows.Forms.BindingSource lopHocBindingSource;
        private System.ComponentModel.IContainer components;




        //public ListLopHocForm() : base() {}
    

        public ListLopHocForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.LopHoc.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 232);
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.LopHoc);
            // 
            // ListLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ListLopHocForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                LopHoc lh = ConverterHelper.ConvertDataRow<LopHoc>(row);
                ViewLopHocForm viewLopHocForm = new ViewLopHocForm(lh);
                viewLopHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có lớp học nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                LopHoc lh = ConverterHelper.ConvertDataRow<LopHoc>(row);
                ViewLopHocForm viewLopHocForm = new ViewLopHocForm(lh);
                viewLopHocForm.Show();

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
                LopHoc lh= Helpers.Convert.ConverterHelper.ConvertDataRow<LopHoc>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOLopHoc LopHoc = MainForm.Manager.LopHoc;
                    if (LopHoc.Delete(lh))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView.DataSource = LopHoc.Load();
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

        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddLopHocForm addLopHocForm = new AddLopHocForm();
            addLopHocForm.Show();
        }
    }
}
