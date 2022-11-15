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
    internal class ListKhoaForm : BaseListForm<Khoa>
    {
        private BindingSource khoaBindingSource;
        private CheckBox daXoaCheckBox;
        private TextBox maKhoaTextBox;
        private TextBox tenKhoaTextBox;
        private System.ComponentModel.IContainer components;

        public ListKhoaForm():base()
        {
            InitializeComponent();
            dataGridView.DataSource = GetTable();
            khoaBindingSource.DataSource = new Khoa();
            InitList();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.Khoa.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.tenKhoaTextBox = new System.Windows.Forms.TextBox();
            daXoaLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaCheckBox);
            this.panel1.Controls.Add(maKhoaLabel);
            this.panel1.Controls.Add(this.maKhoaTextBox);
            this.panel1.Controls.Add(tenKhoaLabel);
            this.panel1.Controls.Add(this.tenKhoaTextBox);
            this.panel1.Size = new System.Drawing.Size(800, 220);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.tenKhoaTextBox, 0);
            this.panel1.Controls.SetChildIndex(tenKhoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKhoaTextBox, 0);
            this.panel1.Controls.SetChildIndex(maKhoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.daXoaCheckBox, 0);
            this.panel1.Controls.SetChildIndex(daXoaLabel, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(677, 167);
            this.search_btn.Size = new System.Drawing.Size(99, 33);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(579, 167);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.Khoa);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(117, 68);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(59, 17);
            daXoaLabel.TabIndex = 2;
            daXoaLabel.Text = "Đã Xóa:";
            // 
            // daXoaCheckBox
            // 
            this.daXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.khoaBindingSource, "DaXoa", true));
            this.daXoaCheckBox.Location = new System.Drawing.Point(197, 63);
            this.daXoaCheckBox.Name = "daXoaCheckBox";
            this.daXoaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.daXoaCheckBox.TabIndex = 3;
            this.daXoaCheckBox.Text = "checkBox1";
            this.daXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(117, 96);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(68, 17);
            maKhoaLabel.TabIndex = 4;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "MaKhoa", true));
            this.maKhoaTextBox.Location = new System.Drawing.Point(197, 93);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(104, 22);
            this.maKhoaTextBox.TabIndex = 5;
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Location = new System.Drawing.Point(117, 124);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(74, 17);
            tenKhoaLabel.TabIndex = 6;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // tenKhoaTextBox
            // 
            this.tenKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoaBindingSource, "TenKhoa", true));
            this.tenKhoaTextBox.Location = new System.Drawing.Point(197, 121);
            this.tenKhoaTextBox.Name = "tenKhoaTextBox";
            this.tenKhoaTextBox.Size = new System.Drawing.Size(104, 22);
            this.tenKhoaTextBox.TabIndex = 7;
            // 
            // ListKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListKhoaForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        protected override Khoa SearchObject()
        {
            return khoaBindingSource.Current as Khoa;
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKhoaForm addKhoaForm = new AddKhoaForm();
            addKhoaForm.Show();
        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.khoaBindingSource.DataSource = new Khoa();
        }
    }
}
