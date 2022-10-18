using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormGiangVien
{
    internal class AddGiangVienForm : DetailInfoForm<GiangVien>
    {
        private TextBox diaChiTextBox;
        private TextBox emailTextBox;
        private ComboBox gioiTinhComboBox;
        private TextBox hoTextBox;
        private DateTimePicker ngaySinhDateTimePicker;
        private TextBox soDTTextBox;
        private TextBox tenTextBox;
        private TextBox tinhTrangTextBox;
        private Button add_btn;

        public AddGiangVienForm() : base()
        {
            InitializeComponent();
            //this.LoadDataFromObject(diem);
            tinhTrangTextBox.Text = "Dang giang day";
            tinhTrangTextBox.Enabled = false;
            Init();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label soDTLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soDTTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.tinhTrangTextBox = new System.Windows.Forms.TextBox();
            diaChiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            soDTLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangTextBox);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(gioiTinhLabel);
            this.panel1.Controls.Add(this.gioiTinhComboBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(ngaySinhLabel);
            this.panel1.Controls.Add(this.ngaySinhDateTimePicker);
            this.panel1.Controls.Add(soDTLabel);
            this.panel1.Controls.Add(this.soDTTextBox);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tenTextBox);
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(172, 197);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(55, 17);
            diaChiLabel.TabIndex = 0;
            diaChiLabel.Text = "Địa chỉ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(172, 141);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(172, 169);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(64, 17);
            gioiTinhLabel.TabIndex = 4;
            gioiTinhLabel.Text = "Giới tính:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(172, 80);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(30, 17);
            hoLabel.TabIndex = 6;
            hoLabel.Text = "Họ:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(172, 230);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(75, 17);
            ngaySinhLabel.TabIndex = 10;
            ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // soDTLabel
            // 
            soDTLabel.AutoSize = true;
            soDTLabel.Location = new System.Drawing.Point(172, 259);
            soDTLabel.Name = "soDTLabel";
            soDTLabel.Size = new System.Drawing.Size(95, 17);
            soDTLabel.TabIndex = 12;
            soDTLabel.Text = "Số điện thoại:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(172, 108);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(37, 17);
            tenLabel.TabIndex = 14;
            tenLabel.Text = "Tên:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(190, 293);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(77, 17);
            tinhTrangLabel.TabIndex = 18;
            tinhTrangLabel.Text = "Tình trạng:";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(278, 197);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(267, 22);
            this.diaChiTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(278, 138);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(267, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "GioiTinh", true));
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(278, 166);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(267, 24);
            this.gioiTinhComboBox.TabIndex = 5;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ho", true));
            this.hoTextBox.Location = new System.Drawing.Point(278, 75);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(267, 22);
            this.hoTextBox.TabIndex = 7;
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(278, 225);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(267, 22);
            this.ngaySinhDateTimePicker.TabIndex = 11;
            // 
            // soDTTextBox
            // 
            this.soDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "SoDT", true));
            this.soDTTextBox.Location = new System.Drawing.Point(278, 256);
            this.soDTTextBox.Name = "soDTTextBox";
            this.soDTTextBox.Size = new System.Drawing.Size(267, 22);
            this.soDTTextBox.TabIndex = 13;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ten", true));
            this.tenTextBox.Location = new System.Drawing.Point(278, 105);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(267, 22);
            this.tenTextBox.TabIndex = 15;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(470, 352);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 42);
            this.add_btn.TabIndex = 18;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // tinhTrangTextBox
            // 
            this.tinhTrangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TinhTrang", true));
            this.tinhTrangTextBox.Location = new System.Drawing.Point(278, 293);
            this.tinhTrangTextBox.Name = "tinhTrangTextBox";
            this.tinhTrangTextBox.Size = new System.Drawing.Size(267, 22);
            this.tinhTrangTextBox.TabIndex = 19;
            // 
            // AddGiangVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Name = "AddGiangVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            gv.Ho = hoTextBox.Text;
            gv.Ten = tenTextBox.Text;
            gv.Email = emailTextBox.Text;
            gv.GioiTinh = gioiTinhComboBox.Text;
            gv.SoDT = soDTTextBox.Text;
            gv.DiaChi = diaChiTextBox.Text;
            gv.NgaySinh = ngaySinhDateTimePicker.Value;
            gv.TinhTrang = tinhTrangTextBox.Text;
            if (gv == null) return;

            ValidationContext context = new ValidationContext(gv, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(gv, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.GiangVien.Add(gv))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
