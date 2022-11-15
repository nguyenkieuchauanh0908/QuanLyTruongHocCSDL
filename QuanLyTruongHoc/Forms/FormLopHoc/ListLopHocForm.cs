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
    internal class ListLopHocForm : BaseListForm<LopHoc>
    {
        private BindingSource thongTinLopHocBindingSource;
        private BindingSource lopHocBindingSource;
        private CheckBox daXoaCheckBox;
        private TextBox maGiangVienTextBox;
        private TextBox maKyHocTextBox;
        private TextBox maLopTextBox;
        private TextBox maMonHocTextBox;
        private System.ComponentModel.IContainer components;

        public ListLopHocForm() : base()
        {
            InitializeComponent();
            lopHocBindingSource.DataSource = new LopHoc();
            //dataGridView.DataSource = MainForm.Manager.LopHoc.Load();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.LopHoc.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maGiangVienLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maMonHocLabel;
            this.thongTinLopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.maGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            daXoaLabel = new System.Windows.Forms.Label();
            maGiangVienLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maMonHocLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaCheckBox);
            this.panel1.Controls.Add(maGiangVienLabel);
            this.panel1.Controls.Add(this.maGiangVienTextBox);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Size = new System.Drawing.Size(800, 291);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.maMonHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(maMonHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maLopTextBox, 0);
            this.panel1.Controls.SetChildIndex(maLopLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKyHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(maKyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maGiangVienTextBox, 0);
            this.panel1.Controls.SetChildIndex(maGiangVienLabel, 0);
            this.panel1.Controls.SetChildIndex(this.daXoaCheckBox, 0);
            this.panel1.Controls.SetChildIndex(daXoaLabel, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(667, 164);
            this.search_btn.Size = new System.Drawing.Size(105, 33);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(547, 164);
            this.add_btn.Size = new System.Drawing.Size(97, 33);
            // 
            // thongTinLopHocBindingSource
            // 
            this.thongTinLopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.ThongTinLopHoc);
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.LopHoc);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(139, 62);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(56, 17);
            daXoaLabel.TabIndex = 2;
            daXoaLabel.Text = "Đã xóa:";
            // 
            // daXoaCheckBox
            // 
            this.daXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lopHocBindingSource, "DaXoa", true));
            this.daXoaCheckBox.Location = new System.Drawing.Point(245, 57);
            this.daXoaCheckBox.Name = "daXoaCheckBox";
            this.daXoaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.daXoaCheckBox.TabIndex = 3;
            this.daXoaCheckBox.Text = "checkBox1";
            this.daXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // maGiangVienLabel
            // 
            maGiangVienLabel.AutoSize = true;
            maGiangVienLabel.Location = new System.Drawing.Point(139, 90);
            maGiangVienLabel.Name = "maGiangVienLabel";
            maGiangVienLabel.Size = new System.Drawing.Size(100, 17);
            maGiangVienLabel.TabIndex = 4;
            maGiangVienLabel.Text = "Mã giảng viên:";
            // 
            // maGiangVienTextBox
            // 
            this.maGiangVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaGiangVien", true));
            this.maGiangVienTextBox.Location = new System.Drawing.Point(245, 87);
            this.maGiangVienTextBox.Name = "maGiangVienTextBox";
            this.maGiangVienTextBox.Size = new System.Drawing.Size(104, 22);
            this.maGiangVienTextBox.TabIndex = 5;
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(139, 118);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(76, 17);
            maKyHocLabel.TabIndex = 6;
            maKyHocLabel.Text = "Mã kỳ học:";
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Location = new System.Drawing.Point(245, 115);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.maKyHocTextBox.TabIndex = 7;
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(139, 146);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(81, 17);
            maLopLabel.TabIndex = 8;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaLop", true));
            this.maLopTextBox.Location = new System.Drawing.Point(245, 143);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(104, 22);
            this.maLopTextBox.TabIndex = 9;
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Location = new System.Drawing.Point(139, 174);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(89, 17);
            maMonHocLabel.TabIndex = 10;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopHocBindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(245, 171);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.maMonHocTextBox.TabIndex = 11;
            // 
            // ListLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ListLopHocForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinLopHocBindingSource)).EndInit();
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
        protected override LopHoc SearchObject()
        {
            return lopHocBindingSource.Current as LopHoc;
        }

        private void maLopTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maKyHocTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.lopHocBindingSource.DataSource = new LopHoc();
        }
    }
}
