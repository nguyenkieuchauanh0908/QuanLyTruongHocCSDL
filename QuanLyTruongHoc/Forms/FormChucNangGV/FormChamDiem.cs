using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormChucNangGV
{
    internal class FormChamDiem : DetailInfoForm<DanhSachLop>
    {
        private TextBox diemCKTextBox;
        private TextBox diemGKTextBox;
        private TextBox hoTextBox;
        private TextBox maLopTextBox;
        private TextBox maSVTextBox;
        private TextBox tenTextBox;
        private Button update_btn;

        public FormChamDiem() : base()
        {
            InitializeComponent();
        }
        public FormChamDiem(DanhSachLop danhSachLop) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(danhSachLop);
            Init();
        }
        protected override void Init()
        {
            this.maLopTextBox.Enabled = false;
            this.maSVTextBox.Enabled = false;
            this.hoTextBox.Enabled = false;
            this.tenTextBox.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label diemCKLabel;
            System.Windows.Forms.Label diemGKLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maSVLabel;
            System.Windows.Forms.Label tenLabel;
            this.update_btn = new System.Windows.Forms.Button();
            this.diemCKTextBox = new System.Windows.Forms.TextBox();
            this.diemGKTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            diemCKLabel = new System.Windows.Forms.Label();
            diemGKLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(diemCKLabel);
            this.panel1.Controls.Add(this.diemCKTextBox);
            this.panel1.Controls.Add(diemGKLabel);
            this.panel1.Controls.Add(this.diemGKTextBox);
            this.panel1.Controls.Add(hoLabel);
            this.panel1.Controls.Add(this.hoTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Controls.Add(tenLabel);
            this.panel1.Controls.Add(this.tenTextBox);
            this.panel1.Size = new System.Drawing.Size(816, 608);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update_btn);
            this.panel2.Location = new System.Drawing.Point(0, 608);
            this.panel2.Size = new System.Drawing.Size(816, 162);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Controls.SetChildIndex(this.update_btn, 0);
            // 
            // diemCKLabel
            // 
            diemCKLabel.AutoSize = true;
            diemCKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diemCKLabel.Location = new System.Drawing.Point(104, 479);
            diemCKLabel.Name = "diemCKLabel";
            diemCKLabel.Size = new System.Drawing.Size(168, 30);
            diemCKLabel.TabIndex = 0;
            diemCKLabel.Text = "Điểm cuối kỳ:";
            // 
            // diemGKLabel
            // 
            diemGKLabel.AutoSize = true;
            diemGKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diemGKLabel.Location = new System.Drawing.Point(104, 405);
            diemGKLabel.Name = "diemGKLabel";
            diemGKLabel.Size = new System.Drawing.Size(169, 30);
            diemGKLabel.TabIndex = 2;
            diemGKLabel.Text = "Điểm giữa kỳ:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoLabel.Location = new System.Drawing.Point(104, 244);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(53, 30);
            hoLabel.TabIndex = 4;
            hoLabel.Text = "Họ:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maLopLabel.Location = new System.Drawing.Point(104, 90);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(97, 30);
            maLopLabel.TabIndex = 6;
            maLopLabel.Text = "Mã lớp:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSVLabel.Location = new System.Drawing.Point(104, 174);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(164, 30);
            maSVLabel.TabIndex = 8;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLabel.Location = new System.Drawing.Point(104, 326);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(64, 30);
            tenLabel.TabIndex = 10;
            tenLabel.Text = "Tên:";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(237, 20);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(100, 37);
            this.update_btn.TabIndex = 1;
            this.update_btn.Text = "Cập nhật";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // diemCKTextBox
            // 
            this.diemCKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diemCK", true));
            this.diemCKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemCKTextBox.Location = new System.Drawing.Point(293, 479);
            this.diemCKTextBox.Name = "diemCKTextBox";
            this.diemCKTextBox.Size = new System.Drawing.Size(437, 37);
            this.diemCKTextBox.TabIndex = 1;
            // 
            // diemGKTextBox
            // 
            this.diemGKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diemGK", true));
            this.diemGKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemGKTextBox.Location = new System.Drawing.Point(293, 405);
            this.diemGKTextBox.Name = "diemGKTextBox";
            this.diemGKTextBox.Size = new System.Drawing.Size(437, 37);
            this.diemGKTextBox.TabIndex = 3;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ho", true));
            this.hoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTextBox.Location = new System.Drawing.Point(293, 244);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(437, 37);
            this.hoTextBox.TabIndex = 5;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maLop", true));
            this.maLopTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLopTextBox.Location = new System.Drawing.Point(293, 87);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(437, 37);
            this.maLopTextBox.TabIndex = 7;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maSV", true));
            this.maSVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSVTextBox.Location = new System.Drawing.Point(293, 167);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(437, 37);
            this.maSVTextBox.TabIndex = 9;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Ten", true));
            this.tenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTextBox.Location = new System.Drawing.Point(293, 323);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(437, 37);
            this.tenTextBox.TabIndex = 11;
            // 
            // FormChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 770);
            this.Name = "FormChamDiem";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DanhSachLop danhSachLop = bindingSource.Current as DanhSachLop;
            if (danhSachLop == null) return;

            ValidationContext context = new ValidationContext(danhSachLop, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(danhSachLop, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.GiangVien.ChamDiem(danhSachLop))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }
    }
}
