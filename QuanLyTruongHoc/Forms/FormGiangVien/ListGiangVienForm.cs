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
    internal class ListGiangVienForm : BaseListForm<GiangVien>
    {
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private BindingSource giangVienBindingSource1;
        private TextBox diaChiTextBox;
        private TextBox emailTextBox;
        private ComboBox gioiTinhComboBox;
        private TextBox hoTextBox;
        private TextBox maGVTextBox;
        private DateTimePicker ngaySinhDateTimePicker;
        private TextBox soDTTextBox;
        private TextBox tenTextBox;
        private TextBox tinhTrangTextBox;

        //private Button add_btn;
        private System.ComponentModel.IContainer components;
        public ListGiangVienForm() : base()
        {
            InitializeComponent();
            giangVienBindingSource1.DataSource = new GiangVien();
        }

        public override DataTable GetTable()
        {
            return MainForm.Manager.GiangVien.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maGVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label soDTLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maGVTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            this.giangVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maGVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            soDTLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.gioiTinhComboBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(maGVLabel);
            this.panel1.Controls.Add(this.maGVTextBox);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(soDTLabel);
            this.panel1.Controls.Add(this.soDTTextBox);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(828, 302);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.tinhTrangTextBox, 0);
            this.panel1.Controls.SetChildIndex(tinhTrangLabel, 0);
            this.panel1.Controls.SetChildIndex(this.tenTextBox, 0);
            this.panel1.Controls.SetChildIndex(tenLabel, 0);
            this.panel1.Controls.SetChildIndex(this.soDTTextBox, 0);
            this.panel1.Controls.SetChildIndex(soDTLabel, 0);
            this.panel1.Controls.SetChildIndex(this.ngaySinhDateTimePicker, 0);
            this.panel1.Controls.SetChildIndex(ngaySinhLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maGVTextBox, 0);
            this.panel1.Controls.SetChildIndex(maGVLabel, 0);
            this.panel1.Controls.SetChildIndex(this.hoTextBox, 0);
            this.panel1.Controls.SetChildIndex(hoLabel, 0);
            this.panel1.Controls.SetChildIndex(this.gioiTinhComboBox, 0);
            this.panel1.Controls.SetChildIndex(gioiTinhLabel, 0);
            this.panel1.Controls.SetChildIndex(this.emailTextBox, 0);
            this.panel1.Controls.SetChildIndex(emailLabel, 0);
            this.panel1.Controls.SetChildIndex(this.diaChiTextBox, 0);
            this.panel1.Controls.SetChildIndex(diaChiLabel, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(520, 237);
            this.search_btn.Size = new System.Drawing.Size(117, 35);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(417, 237);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Size = new System.Drawing.Size(87, 35);
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(31, 28);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(55, 17);
            diaChiLabel.TabIndex = 2;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(31, 56);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(31, 84);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(64, 17);
            gioiTinhLabel.TabIndex = 6;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(31, 115);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(30, 17);
            hoLabel.TabIndex = 8;
            hoLabel.Text = "Họ:";
            // 
            // maGVLabel
            // 
            maGVLabel.AutoSize = true;
            maGVLabel.Location = new System.Drawing.Point(31, 143);
            maGVLabel.Name = "maGVLabel";
            maGVLabel.Size = new System.Drawing.Size(100, 17);
            maGVLabel.TabIndex = 10;
            maGVLabel.Text = "Mã giảng viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(31, 172);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(75, 17);
            ngaySinhLabel.TabIndex = 12;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // soDTLabel
            // 
            soDTLabel.AutoSize = true;
            soDTLabel.Location = new System.Drawing.Point(31, 199);
            soDTLabel.Name = "soDTLabel";
            soDTLabel.Size = new System.Drawing.Size(95, 17);
            soDTLabel.TabIndex = 14;
            soDTLabel.Text = "Số điện thoại:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(31, 227);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(37, 17);
            tenLabel.TabIndex = 16;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(31, 255);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(77, 17);
            tinhTrangLabel.TabIndex = 18;
            tinhTrangLabel.Text = "Tình trạng:";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(137, 25);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 22);
            this.diaChiTextBox.TabIndex = 3;
            this.diaChiTextBox.TextChanged += new System.EventHandler(this.diaChiTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(137, 53);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "GioiTinh", true));
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Location = new System.Drawing.Point(137, 81);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(200, 24);
            this.gioiTinhComboBox.TabIndex = 7;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "Ho", true));
            this.hoTextBox.Location = new System.Drawing.Point(137, 112);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(200, 22);
            this.hoTextBox.TabIndex = 9;
            // 
            // maGVTextBox
            // 
            this.maGVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "MaGV", true));
            this.maGVTextBox.Location = new System.Drawing.Point(137, 140);
            this.maGVTextBox.Name = "maGVTextBox";
            this.maGVTextBox.Size = new System.Drawing.Size(200, 22);
            this.maGVTextBox.TabIndex = 11;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.giangVienBindingSource1, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(137, 168);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 13;
            // 
            // soDTTextBox
            // 
            this.soDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "SoDT", true));
            this.soDTTextBox.Location = new System.Drawing.Point(137, 196);
            this.soDTTextBox.Name = "soDTTextBox";
            this.soDTTextBox.Size = new System.Drawing.Size(200, 22);
            this.soDTTextBox.TabIndex = 15;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(137, 224);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenTextBox.TabIndex = 17;
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.giangVienBindingSource1, "TinhTrang", true));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(137, 252);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(200, 22);
            this.tinhTrangTextBox.TabIndex = 19;
            // 
            // giangVienBindingSource1
            // 
            this.giangVienBindingSource1.DataSource = typeof(QuanLyTruongHoc.DataObjects.GiangVien);
            // 
            // ListGiangVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListGiangVienForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource1)).EndInit();
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

        protected override GiangVien SearchObject()
        {
            return giangVienBindingSource1.Current as GiangVien;
        }

        private void diaChiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.giangVienBindingSource1.DataSource = new GiangVien();
        }
    }
}
