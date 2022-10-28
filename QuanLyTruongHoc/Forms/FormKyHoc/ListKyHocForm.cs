using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormKhoa;
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

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class ListKyHocForm : BaseListForm
    {
        private BindingSource kyHocBindingSource;
        private System.ComponentModel.IContainer components;

        public ListKyHocForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.KyHoc.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kyHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kyHocBindingSource
            // 
            this.kyHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.KyHoc);
            // 
            // ListKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Name = "ListKyHocForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc ky = ConverterHelper.ConvertDataRow<KyHoc>(row);
                ViewKyHocForm viewKyHocForm = new ViewKyHocForm(ky);
                viewKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc kyHoc = ConverterHelper.ConvertDataRow<KyHoc>(row);
                UpdateKyHocForm updateKyHocForm = new UpdateKyHocForm(kyHoc);
                updateKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKyHocForm addKyHocForm = new AddKyHocForm();
            addKyHocForm.Show();
        }
    }
}
