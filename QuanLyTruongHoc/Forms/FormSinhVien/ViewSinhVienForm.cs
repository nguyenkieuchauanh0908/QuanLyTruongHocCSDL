using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class ViewSinhVienForm : DetailInfoForm<SinhVien>
    {
        protected System.Windows.Forms.TextBox diaChiTextBox;
        protected System.Windows.Forms.TextBox emailTextBox;
        protected System.Windows.Forms.TextBox gioiTinhTextBox;
        protected System.Windows.Forms.TextBox hoTextBox;
        protected System.Windows.Forms.ComboBox maKhoaComboBox;
        protected System.Windows.Forms.TextBox maSVTextBox;
        protected System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        protected System.Windows.Forms.TextBox tenTextBox;
        protected System.Windows.Forms.ComboBox tinhTrangComboBox;

        public ViewSinhVienForm(SinhVien sv) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(sv);
            Init();
        }

        public ViewSinhVienForm() : base()
        {
            InitializeComponent();
            this.bindingSource.DataSource = new SinhVien();
        }

        protected override void Init()
        {
            this.maSVTextBox.Enabled = false;
            this.hoTextBox.Enabled = false;
            this.tenTextBox.Enabled = false;
            this.emailTextBox.Enabled = false;
            this.gioiTinhTextBox.Enabled = false;
            this.diaChiTextBox.Enabled = false;
            this.ngaySinhDateTimePicker.Enabled = false;
            this.tinhTrangComboBox.Enabled = false;
            this.maKhoaComboBox.Enabled = false;
        }
        
        private void InitializeComponent()
        {
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label maSVLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maKhoaComboBox = new System.Windows.Forms.ComboBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangComboBox = new System.Windows.Forms.ComboBox();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.maKhoaComboBox);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangComboBox);
            this.panel1.Size = new System.Drawing.Size(654, 637);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(654, 51);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.Location = new System.Drawing.Point(111, 508);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(85, 26);
            diaChiLabel.TabIndex = 0;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(111, 369);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(74, 26);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhLabel.Location = new System.Drawing.Point(111, 271);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(98, 26);
            gioiTinhLabel.TabIndex = 4;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(111, 224);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(46, 26);
            hoLabel.TabIndex = 6;
            hoLabel.Text = "Họ:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoaLabel.Location = new System.Drawing.Point(111, 417);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(101, 26);
            maKhoaLabel.TabIndex = 8;
            maKhoaLabel.Text = "Mã khoa:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSVLabel.Location = new System.Drawing.Point(111, 142);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(140, 26);
            maSVLabel.TabIndex = 10;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhLabel.Location = new System.Drawing.Point(111, 464);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(115, 26);
            ngaySinhLabel.TabIndex = 12;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(111, 183);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(54, 26);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tinhTrangLabel.Location = new System.Drawing.Point(111, 319);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(114, 26);
            tinhTrangLabel.TabIndex = 16;
            tinhTrangLabel.Text = "Tình trạng:";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DiaChi", true));
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(287, 505);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(268, 32);
            this.diaChiTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(287, 366);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(268, 32);
            this.emailTextBox.TabIndex = 3;
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(287, 268);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(268, 32);
            this.gioiTinhTextBox.TabIndex = 5;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ho", true));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(287, 221);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(268, 32);
            this.hoTextBox.TabIndex = 7;
            // 
            // maKhoaComboBox
            // 
            this.maKhoaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKhoa", true));
            this.maKhoaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKhoaComboBox.FormattingEnabled = true;
            this.maKhoaComboBox.Location = new System.Drawing.Point(287, 414);
            this.maKhoaComboBox.Name = "maKhoaComboBox";
            this.maKhoaComboBox.Size = new System.Drawing.Size(268, 34);
            this.maKhoaComboBox.TabIndex = 9;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaSV", true));
            this.maSVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTextBox.Location = new System.Drawing.Point(287, 139);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(268, 32);
            this.maSVTextBox.TabIndex = 11;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(287, 460);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(268, 32);
            this.ngaySinhDateTimePicker.TabIndex = 13;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ten", true));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(287, 180);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(268, 32);
            this.tenTextBox.TabIndex = 15;
            // 
            // tinhTrangComboBox
            // 
            this.tinhTrangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TinhTrang", true));
            this.tinhTrangComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhTrangComboBox.FormattingEnabled = true;
            this.tinhTrangComboBox.Items.AddRange(new object[] {
            "Dang theo hoc",
            "Da thoi hoc",
            "Tam nghi hoc"});
            this.tinhTrangComboBox.Location = new System.Drawing.Point(287, 316);
            this.tinhTrangComboBox.Name = "tinhTrangComboBox";
            this.tinhTrangComboBox.Size = new System.Drawing.Size(268, 34);
            this.tinhTrangComboBox.TabIndex = 17;
            // 
            // ViewSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(654, 688);
            this.Name = "ViewSinhVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
