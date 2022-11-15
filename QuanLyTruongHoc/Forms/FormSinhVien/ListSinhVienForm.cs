using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers;
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
using QuanLyTruongHoc.Helpers;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class ListSinhVienForm : BaseListForm<SinhVien>
    {
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private BindingSource khoaBindingSource;
        private TextBox diaChiTextBox;
        private TextBox emailTextBox;
        private TextBox gioiTinhTextBox;
        private TextBox hoTextBox;
        private TextBox maKhoaTextBox;
        private TextBox maSVTextBox;
        private DateTimePicker ngaySinhDateTimePicker;
        private TextBox tenTextBox;
        private TextBox tinhTrangTextBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.ComponentModel.IContainer components;
        public ListSinhVienForm() : base()
        {
            InitializeComponent();
            sinhVienBindingSource.DataSource = new SinhVien();
            InitList();
        }


        public override DataTable GetTable()
        {
            return MainForm.Manager.SinhVien.Load();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label maSVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.gioiTinhTextBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(maKhoaLabel);
            this.panel1.Controls.Add(this.maKhoaTextBox);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangTextBox);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Size = new System.Drawing.Size(865, 340);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.tinhTrangTextBox, 0);
            this.panel1.Controls.SetChildIndex(tinhTrangLabel, 0);
            this.panel1.Controls.SetChildIndex(this.tenTextBox, 0);
            this.panel1.Controls.SetChildIndex(tenLabel, 0);
            this.panel1.Controls.SetChildIndex(this.ngaySinhDateTimePicker, 0);
            this.panel1.Controls.SetChildIndex(ngaySinhLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maSVTextBox, 0);
            this.panel1.Controls.SetChildIndex(maSVLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKhoaTextBox, 0);
            this.panel1.Controls.SetChildIndex(maKhoaLabel, 0);
            this.panel1.Controls.SetChildIndex(this.hoTextBox, 0);
            this.panel1.Controls.SetChildIndex(hoLabel, 0);
            this.panel1.Controls.SetChildIndex(this.gioiTinhTextBox, 0);
            this.panel1.Controls.SetChildIndex(gioiTinhLabel, 0);
            this.panel1.Controls.SetChildIndex(this.emailTextBox, 0);
            this.panel1.Controls.SetChildIndex(emailLabel, 0);
            this.panel1.Controls.SetChildIndex(this.diaChiTextBox, 0);
            this.panel1.Controls.SetChildIndex(diaChiLabel, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(237, 288);
            //this.search_btn.Click += new System.EventHandler(this.search_btn_Click_1);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(146, 288);
            this.add_btn.Size = new System.Drawing.Size(75, 27);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(22, 39);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(55, 17);
            diaChiLabel.TabIndex = 2;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(22, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(22, 95);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(64, 17);
            gioiTinhLabel.TabIndex = 6;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(22, 123);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(30, 17);
            hoLabel.TabIndex = 8;
            hoLabel.Text = "Họ:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Location = new System.Drawing.Point(22, 151);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(66, 17);
            maKhoaLabel.TabIndex = 10;
            maKhoaLabel.Text = "Mã khoa:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(22, 179);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(91, 17);
            maSVLabel.TabIndex = 12;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(22, 208);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(75, 17);
            ngaySinhLabel.TabIndex = 14;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(22, 235);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(37, 17);
            tenLabel.TabIndex = 16;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(22, 263);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(77, 17);
            tinhTrangLabel.TabIndex = 18;
            tinhTrangLabel.Text = "Tình trạng:";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.SinhVien);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.Khoa);
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(112, 36);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(200, 22);
            this.diaChiTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(112, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(112, 92);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 22);
            this.gioiTinhTextBox.TabIndex = 7;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Ho", true));
            this.hoTextBox.Location = new System.Drawing.Point(112, 120);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(200, 22);
            this.hoTextBox.TabIndex = 9;
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaKhoa", true));
            this.maKhoaTextBox.Location = new System.Drawing.Point(112, 148);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(200, 22);
            this.maKhoaTextBox.TabIndex = 11;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSV", true));
            this.maSVTextBox.Location = new System.Drawing.Point(112, 176);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(200, 22);
            this.maSVTextBox.TabIndex = 13;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinhVienBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(112, 204);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 15;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(112, 232);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenTextBox.TabIndex = 17;
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "TinhTrang", true));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(112, 260);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(200, 22);
            this.tinhTrangTextBox.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sinh viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ho";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TinhTrang";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MaKhoa";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã khoa";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // ListSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListSinhVienForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                SinhVien sv = ConverterHelper.ConvertDataRow<SinhVien>(row);
                ViewSinhVienForm viewSinhVienForm = new ViewSinhVienForm(sv);
                viewSinhVienForm.Show();
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào thêm vào");
            }
        }

        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                SinhVien sv = ConverterHelper.ConvertDataRow<SinhVien>(row);
                UpdateSinhVienForm updateSinhVienForm = new UpdateSinhVienForm(sv);
                updateSinhVienForm.Show();
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }

        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                SinhVien sv = ConverterHelper.ConvertDataRow<SinhVien>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xóa sinh viên", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOSinhVien sinhVien = MainForm.Manager.SinhVien;
                    if (sinhVien.Delete(sv))
                    {
                        MessageBox.Show("Xóa sinh viên thành công");
                        dataGridView.DataSource = sinhVien.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào được chọn");
            }
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddSinhVienForm addSinhVienForm = new AddSinhVienForm();
            addSinhVienForm.Show();
        }
        //private void search_btn_Click_1(object sender, EventArgs e)
        //{
        //    // convert datagridview to list<sinhvien>
        //    //List<SinhVien> sinhViens = new List<SinhVien>();
            
        //    //foreach (DataGridViewRow row in dataGridView.Rows)
        //    //{
        //    //    SinhVien sv = ConverterHelper.ConvertDataRow<SinhVien>(((DataRowView)row.DataBoundItem).Row);
        //    //    sinhViens.Add(sv);
        //    //}
        //    //// search
        //    //SinhVien svSearch = sinhVienBindingSource.Current as SinhVien;
        //    ////MessageBox.Show(svSearch.ToString());
        //    //List<SinhVien> result = Helpers.Search.SearchBy<SinhVien>(sinhViens, svSearch);
        //    //sinhVienDataGridView.DataSource = result;
        //}

        protected override SinhVien SearchObject()
        {
            return sinhVienBindingSource.Current as SinhVien;
        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.sinhVienBindingSource.DataSource = new SinhVien();
        }
    }
}
