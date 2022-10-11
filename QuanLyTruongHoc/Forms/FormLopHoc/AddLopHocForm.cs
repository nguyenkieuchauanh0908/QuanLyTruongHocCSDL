using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormLopHoc
{
    internal class AddLopHocForm : DetailInfoForm<LopHoc>
    {
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private System.Windows.Forms.TextBox maGiangVienTextBox;
        private System.Windows.Forms.TextBox maKyHocTextBox;
        private System.Windows.Forms.TextBox maLopTextBox;
        private System.Windows.Forms.TextBox maMonHocTextBox;
        private System.ComponentModel.IContainer components;

        public AddLopHocForm() : base()
        {
            Init();
        }

        protected override void Init()
        {
            this.Text = "Thêm Chau Em";
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maGiangVienLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maMonHocLabel;
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            maGiangVienLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maMonHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(maGiangVienLabel);
            this.panel1.Controls.Add(this.maGiangVienTextBox);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.SinhVien);
            // 
            // maGiangVienLabel
            // 
            maGiangVienLabel.AutoSize = true;
            maGiangVienLabel.Location = new System.Drawing.Point(262, 134);
            maGiangVienLabel.Name = "maGiangVienLabel";
            maGiangVienLabel.Size = new System.Drawing.Size(94, 16);
            maGiangVienLabel.TabIndex = 0;
            maGiangVienLabel.Text = "Mã giảng viên:";
            // 
            // maGiangVienTextBox
            // 
            this.maGiangVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaGiangVien", true));
            this.maGiangVienTextBox.Location = new System.Drawing.Point(362, 131);
            this.maGiangVienTextBox.Name = "maGiangVienTextBox";
            this.maGiangVienTextBox.Size = new System.Drawing.Size(100, 22);
            this.maGiangVienTextBox.TabIndex = 1;
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(262, 162);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(71, 16);
            maKyHocLabel.TabIndex = 2;
            maKyHocLabel.Text = "Mã kỳ học:";
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Location = new System.Drawing.Point(362, 159);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.maKyHocTextBox.TabIndex = 3;
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(262, 190);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(76, 16);
            maLopLabel.TabIndex = 4;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaLop", true));
            this.maLopTextBox.Location = new System.Drawing.Point(362, 187);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(100, 22);
            this.maLopTextBox.TabIndex = 5;
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Location = new System.Drawing.Point(262, 218);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(83, 16);
            maMonHocLabel.TabIndex = 6;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(362, 215);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.maMonHocTextBox.TabIndex = 7;
            // 
            // AddLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Name = "AddLopHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
