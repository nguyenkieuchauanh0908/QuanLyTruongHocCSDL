using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using QuanLyTruongHoc.DataObjects;
using System.Runtime.Remoting;
using System.Windows.Forms;
using QuanLyTruongHoc.Models.DatabaseModel;
using System.Data;
using QuanLyTruongHoc.Helpers.Convert;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class ViewSinhVienForm: DetailInfoForm
    {
        string connectionString = @"Data Source=DESKTOP-7IT3958;Initial Catalog=QUANLYTRUONGHOC;Integrated Security=True";
        ADOManager manager;


        protected System.Windows.Forms.BindingSource sinhVienBindingSource;
        protected TextBox diaChiTextBox;
        protected TextBox emailTextBox;
        protected TextBox gioiTinhTextBox;
        protected TextBox hoTextBox;
        protected ComboBox maKhoaComboBox;
        protected TextBox maSVTextBox;
        protected DateTimePicker ngaySinhDateTimePicker;
        protected TextBox tenTextBox;
        protected ComboBox tinhTrangComboBox;
        private Button cancel_button;
        private System.ComponentModel.IContainer components;

        public ViewSinhVienForm() : base()
        {
            InitializeComponent();
            manager = new ADOManager(connectionString);
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
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maKhoaComboBox = new System.Windows.Forms.ComboBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangComboBox = new System.Windows.Forms.ComboBox();
            this.cancel_button = new System.Windows.Forms.Button();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.Location = new System.Drawing.Point(67, 378);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(85, 26);
            diaChiLabel.TabIndex = 21;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(67, 432);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(74, 26);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhLabel.Location = new System.Drawing.Point(67, 258);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(98, 26);
            gioiTinhLabel.TabIndex = 25;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(67, 96);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(46, 26);
            hoLabel.TabIndex = 27;
            hoLabel.Text = "Họ:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoaLabel.Location = new System.Drawing.Point(67, 202);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(101, 26);
            maKhoaLabel.TabIndex = 29;
            maKhoaLabel.Text = "Mã khoa:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSVLabel.Location = new System.Drawing.Point(67, 44);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(140, 26);
            maSVLabel.TabIndex = 31;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.Location = new System.Drawing.Point(66, 313);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(115, 26);
            ngaySinhLabel.TabIndex = 33;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(67, 148);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(54, 26);
            tenLabel.TabIndex = 35;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tinhTrangLabel.Location = new System.Drawing.Point(67, 492);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(114, 26);
            tinhTrangLabel.TabIndex = 37;
            tinhTrangLabel.Text = "Tình trạng:";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.SinhVien);
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "DiaChi", true));
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(213, 378);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(499, 32);
            this.diaChiTextBox.TabIndex = 22;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(213, 432);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(499, 32);
            this.emailTextBox.TabIndex = 24;
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(213, 258);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(499, 32);
            this.gioiTinhTextBox.TabIndex = 26;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Ho", true));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(213, 96);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(499, 32);
            this.hoTextBox.TabIndex = 28;
            // 
            // maKhoaComboBox
            // 
            this.maKhoaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaKhoa", true));
            this.maKhoaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKhoaComboBox.FormattingEnabled = true;
            this.maKhoaComboBox.Location = new System.Drawing.Point(213, 200);
            this.maKhoaComboBox.Name = "maKhoaComboBox";
            this.maKhoaComboBox.Size = new System.Drawing.Size(499, 34);
            this.maKhoaComboBox.TabIndex = 30;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSV", true));
            this.maSVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTextBox.Location = new System.Drawing.Point(213, 44);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(499, 32);
            this.maSVTextBox.TabIndex = 32;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinhVienBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(212, 313);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(499, 32);
            this.ngaySinhDateTimePicker.TabIndex = 34;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Ten", true));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(213, 148);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(499, 32);
            this.tenTextBox.TabIndex = 36;
            // 
            // tinhTrangComboBox
            // 
            this.tinhTrangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "TinhTrang", true));
            this.tinhTrangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangComboBox.FormattingEnabled = true;
            this.tinhTrangComboBox.Location = new System.Drawing.Point(213, 490);
            this.tinhTrangComboBox.Name = "tinhTrangComboBox";
            this.tinhTrangComboBox.Size = new System.Drawing.Size(499, 34);
            this.tinhTrangComboBox.TabIndex = 38;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(593, 595);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(118, 37);
            this.cancel_button.TabIndex = 39;
            this.cancel_button.Text = "Thoát";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ViewSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(758, 688);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(this.gioiTinhTextBox);
            this.Controls.Add(hoLabel);
            this.Controls.Add(this.hoTextBox);
            this.Controls.Add(maKhoaLabel);
            this.Controls.Add(this.maKhoaComboBox);
            this.Controls.Add(maSVLabel);
            this.Controls.Add(this.maSVTextBox);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateTimePicker);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenTextBox);
            this.Controls.Add(tinhTrangLabel);
            this.Controls.Add(this.tinhTrangComboBox);
            this.Name = "ViewSinhVienForm";
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sinhVienBindingSource.EndEdit();
            //SinhVien sinhVien = sinhVienBindingSource.Current as SinhVien;
            //if(sinhVien != null)
            //{
            //    ValidationContext context = new ValidationContext(sinhVien, null, null);
            //    IList<ValidationResult> errors = new List<ValidationResult>();
            //    if(!Validator.TryValidateObject(sinhVien, context, errors, true))
            //    {
            //        foreach(ValidationResult result in errors)
            //        {
            //            MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Sinhvien null");
            //}
        }



        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            //sinhVienBindingSource.DataSource = new SinhVien();
            //foreach (var value in Enumeration.TrangThaiSV)
            //{
            //    this.tinhTrangComboBox.Items.Add(value);
            //}
            //this.tinhTrangComboBox.SelectedIndex = 0;

            hoTextBox.Enabled = false;
            tenTextBox.Enabled = false;
            maSVTextBox.Enabled = false;
            maKhoaComboBox.Enabled = false;
            emailTextBox.Enabled = false;
            diaChiTextBox.Enabled = false;
            tinhTrangComboBox.Enabled = false;
            gioiTinhTextBox.Enabled = false;
            ngaySinhDateTimePicker.Enabled = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
