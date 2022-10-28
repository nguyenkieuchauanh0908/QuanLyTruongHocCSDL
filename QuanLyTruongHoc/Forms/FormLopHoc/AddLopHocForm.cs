using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    internal class AddLopHocForm : DetailInfoForm<LopHoc>
    {

        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.TextBox maGiangVienTextBox;
        private System.Windows.Forms.TextBox maKyHocTextBox;
        private System.Windows.Forms.TextBox maMonHocTextBox;
        private System.Windows.Forms.Button add_button;
        private System.ComponentModel.IContainer components;

        //public AddLopHocForm(LopHoc lh) : base()
        //{
        //    InitializeComponent();
        //    bindingSource.DataSource = new LopHoc();
        //}
        public AddLopHocForm(LopHoc lh) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(lh);
            Init();
        } 
        public AddLopHocForm() : base()
        {
            InitializeComponent();
            Init();

        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maGiangVienLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label maMonHocLabel;
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            maGiangVienLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            maMonHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(maGiangVienLabel);
            this.panel1.Controls.Add(this.maGiangVienTextBox);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            // 
            // maGiangVienLabel
            // 
            maGiangVienLabel.AutoSize = true;
            maGiangVienLabel.Location = new System.Drawing.Point(196, 109);
            maGiangVienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maGiangVienLabel.Name = "maGiangVienLabel";
            maGiangVienLabel.Size = new System.Drawing.Size(77, 13);
            maGiangVienLabel.TabIndex = 0;
            maGiangVienLabel.Text = "Mã giảng viên:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(196, 132);
            maKyHocLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(60, 13);
            maKyHocLabel.TabIndex = 2;
            maKyHocLabel.Text = "Mã kỳ học:";
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Location = new System.Drawing.Point(196, 177);
            maMonHocLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(69, 13);
            maMonHocLabel.TabIndex = 6;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.SinhVien);
            // 
            // maGiangVienTextBox
            // 
            this.maGiangVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaGiangVien", true));
            this.maGiangVienTextBox.Location = new System.Drawing.Point(272, 106);
            this.maGiangVienTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maGiangVienTextBox.Name = "maGiangVienTextBox";
            this.maGiangVienTextBox.Size = new System.Drawing.Size(76, 20);
            this.maGiangVienTextBox.TabIndex = 1;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Location = new System.Drawing.Point(272, 129);
            this.maKyHocTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(76, 20);
            this.maKyHocTextBox.TabIndex = 3;
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(272, 175);
            this.maMonHocTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(76, 20);
            this.maMonHocTextBox.TabIndex = 7;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(96, 254);
            this.add_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(105, 29);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(544, 559);
            this.Name = "AddLopHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        private void add_button_Click(object sender, EventArgs e)
        {
           
            LopHoc lh = new LopHoc();
            lh.MaGiangVien = int.Parse(maGiangVienTextBox.Text);
            lh.MaKyHoc = Int16.Parse(maKyHocTextBox.Text);
            //lh.MaLop = Int32.Parse(maLopTextBox.Text);
            lh.MaMonHoc = Int32.Parse(maMonHocTextBox.Text);
           // lh.DaXoa = daXoaCheckBox.Enabled;

            if (lh == null) return;
            ValidationContext context = new ValidationContext(lh, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(lh, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.LopHoc.Add(lh))
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
