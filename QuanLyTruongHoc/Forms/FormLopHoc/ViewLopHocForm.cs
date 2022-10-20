using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    internal class ViewLopHocForm : DetailInfoForm<LopHoc>
    {
        private System.Windows.Forms.TextBox maGiangVienTextBox;
        private System.Windows.Forms.TextBox maKyHocTextBox;
        private System.Windows.Forms.TextBox maLopTextBox;
        private System.Windows.Forms.Button update_btn;
        private CheckBox daXoaCheckBox;
        private System.Windows.Forms.TextBox maMonHocTextBox;

        public ViewLopHocForm(LopHoc lh) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(lh);
            Init();
        }

        public ViewLopHocForm() : base()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            this.maGiangVienTextBox.Enabled = true;
            this.maKyHocTextBox.Enabled = true;
            this.maLopTextBox.Enabled = false;
            this.maMonHocTextBox.Enabled = true;
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.Label maGiangVienLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maMonHocLabel;
            System.Windows.Forms.Label daXoaLabel;
            this.maGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.daXoaCheckBox = new System.Windows.Forms.CheckBox();
            maGiangVienLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maMonHocLabel = new System.Windows.Forms.Label();
            daXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaCheckBox);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(maGiangVienLabel);
            this.panel1.Controls.Add(this.maGiangVienTextBox);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            // 
            // maGiangVienLabel
            // 
            maGiangVienLabel.AutoSize = true;
            maGiangVienLabel.Location = new System.Drawing.Point(192, 161);
            maGiangVienLabel.Name = "maGiangVienLabel";
            maGiangVienLabel.Size = new System.Drawing.Size(100, 17);
            maGiangVienLabel.TabIndex = 0;
            maGiangVienLabel.Text = "Mã giảng viên:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(192, 189);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(76, 17);
            maKyHocLabel.TabIndex = 2;
            maKyHocLabel.Text = "Mã kỳ học:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(192, 217);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(81, 17);
            maLopLabel.TabIndex = 4;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Location = new System.Drawing.Point(192, 245);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(89, 17);
            maMonHocLabel.TabIndex = 6;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Location = new System.Drawing.Point(229, 294);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(56, 17);
            daXoaLabel.TabIndex = 9;
            daXoaLabel.Text = "Đã xóa:";
            // 
            // maGiangVienTextBox
            // 
            this.maGiangVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaGiangVien", true));
            this.maGiangVienTextBox.Location = new System.Drawing.Point(298, 158);
            this.maGiangVienTextBox.Name = "maGiangVienTextBox";
            this.maGiangVienTextBox.Size = new System.Drawing.Size(100, 22);
            this.maGiangVienTextBox.TabIndex = 1;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Location = new System.Drawing.Point(298, 186);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.maKyHocTextBox.TabIndex = 3;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaLop", true));
            this.maLopTextBox.Location = new System.Drawing.Point(298, 214);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(100, 22);
            this.maLopTextBox.TabIndex = 5;
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(298, 242);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.maMonHocTextBox.TabIndex = 7;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(466, 311);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(101, 28);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "Cập Nhật";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // daXoaCheckBox
            // 
            this.daXoaCheckBox.Checked = true;
            this.daXoaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.daXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource, "DaXoa", true));
            this.daXoaCheckBox.Location = new System.Drawing.Point(291, 289);
            this.daXoaCheckBox.Name = "daXoaCheckBox";
            this.daXoaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.daXoaCheckBox.TabIndex = 10;
            this.daXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Name = "ViewLopHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            LopHoc lh = bindingSource.Current as LopHoc;
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

            if (MainForm.Manager.LopHoc.Update(lh))
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
