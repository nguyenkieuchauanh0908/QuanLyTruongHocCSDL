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


namespace QuanLyTruongHoc.Forms.FormMonHoc
{
     internal class ListMonHocForm : BaseListForm
    {
        private BindingSource monHocBindingSource;
        private System.ComponentModel.IContainer components;

        public ListMonHocForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.MonHoc.Load();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 220);
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.MonHoc);
            // 
            // ListMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ListMonHocForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                MonHoc mh = ConverterHelper.ConvertDataRow<MonHoc>(row);
                ViewMonHocForm viewMonHocForm = new ViewMonHocForm(mh);
                viewMonHocForm.Show();

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
                MonHoc lh = ConverterHelper.ConvertDataRow<MonHoc>(row);
                ViewMonHocForm viewMonHocForm = new ViewMonHocForm(lh);
                viewMonHocForm.Show();

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
                MonHoc lh = Helpers.Convert.ConverterHelper.ConvertDataRow<MonHoc>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOMonHoc MonHoc = MainForm.Manager.MonHoc;
                    if (MonHoc.Delete(lh))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView.DataSource = MonHoc.Load();
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
            AddMonHocForm addMonHocForm = new AddMonHocForm();
            addMonHocForm.Show();
        }
    }
}
