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
        private System.Windows.Forms.TextBox maGiangVienTextBox;
        private System.Windows.Forms.BindingSource lopHocBindingSource;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TextBox maKyHocTextBox;
        private System.Windows.Forms.TextBox maLopTextBox;
        private TextBox daXoaTextBox;
        private System.Windows.Forms.TextBox maMonHocTextBox;




        //public ListLopHocForm() : base() {}
    

        public ListLopHocForm()
        {
            InitializeComponent();
            dataGridView.DataSource = MainForm.Manager.LopHoc.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maGiangVienLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maMonHocLabel;
            System.Windows.Forms.Label daXoaLabel;
            this.maGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.daXoaTextBox = new System.Windows.Forms.TextBox();
            maGiangVienLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maMonHocLabel = new System.Windows.Forms.Label();
            daXoaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaTextBox);
            this.panel1.Controls.Add(maGiangVienLabel);
            this.panel1.Controls.Add(this.maGiangVienTextBox);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Size = new System.Drawing.Size(800, 232);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.maMonHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(maMonHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maLopTextBox, 0);
            this.panel1.Controls.SetChildIndex(maLopLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKyHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(maKyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maGiangVienTextBox, 0);
            this.panel1.Controls.SetChildIndex(maGiangVienLabel, 0);
            this.panel1.Controls.SetChildIndex(this.daXoaTextBox, 0);
            this.panel1.Controls.SetChildIndex(daXoaLabel, 0);
            // 
            // maGiangVienLabel
            // 
            maGiangVienLabel.AutoSize = true;
            maGiangVienLabel.Location = new System.Drawing.Point(164, 71);
            maGiangVienLabel.Name = "maGiangVienLabel";
            maGiangVienLabel.Size = new System.Drawing.Size(100, 17);
            maGiangVienLabel.TabIndex = 2;
            maGiangVienLabel.Text = "Mã giảng viên:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(164, 99);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(76, 17);
            maKyHocLabel.TabIndex = 4;
            maKyHocLabel.Text = "Mã kỳ học:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(164, 127);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(81, 17);
            maLopLabel.TabIndex = 6;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Location = new System.Drawing.Point(164, 155);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(89, 17);
            maMonHocLabel.TabIndex = 8;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(165, 193);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(56, 17);
            daXoaLabel.TabIndex = 10;
            daXoaLabel.Text = "Đã xóa:";
            // 
            // maGiangVienTextBox
            // 
            this.maGiangVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaGiangVien", true));
            this.maGiangVienTextBox.Location = new System.Drawing.Point(270, 68);
            this.maGiangVienTextBox.Name = "maGiangVienTextBox";
            this.maGiangVienTextBox.Size = new System.Drawing.Size(100, 22);
            this.maGiangVienTextBox.TabIndex = 3;
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.LopHoc);
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Location = new System.Drawing.Point(270, 96);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.maKyHocTextBox.TabIndex = 5;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaLop", true));
            this.maLopTextBox.Location = new System.Drawing.Point(270, 124);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(100, 22);
            this.maLopTextBox.TabIndex = 7;
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(270, 152);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.maMonHocTextBox.TabIndex = 9;
            // 
            // daXoaTextBox
            // 
            this.daXoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "DaXoa", true));
            this.daXoaTextBox.Location = new System.Drawing.Point(227, 190);
            this.daXoaTextBox.Name = "daXoaTextBox";
            this.daXoaTextBox.Size = new System.Drawing.Size(100, 22);
            this.daXoaTextBox.TabIndex = 11;
            // 
            // ListLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ListLopHocForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

        private void add_button_Click(object sender, EventArgs e)
        {
            AddLopHocForm addLopHocForm = new AddLopHocForm();
            addLopHocForm.Show();
        }

    }
}
