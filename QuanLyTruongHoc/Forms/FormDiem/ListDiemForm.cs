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

namespace QuanLyTruongHoc.Forms.FormDiem
{
    internal class ListDiemForm : BaseListForm
    {
        private System.Windows.Forms.BindingSource diemBindingSource;
        private BindingSource diemBindingSource1;
        private Button add_btn;
        private System.ComponentModel.IContainer components;
        public ListDiemForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.Diem.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.diemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(616, 69);
            // 
            // diemBindingSource1
            // 
            this.diemBindingSource1.DataSource = typeof(QuanLyTruongHoc.DataObjects.Diem);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(207, -10);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(113, 42);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
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

        protected void add_btn_Click(object sender, EventArgs e)
        {
            AddDiemForm addDiemForm = new AddDiemForm();
            addDiemForm.Show();
        }
    }
}
