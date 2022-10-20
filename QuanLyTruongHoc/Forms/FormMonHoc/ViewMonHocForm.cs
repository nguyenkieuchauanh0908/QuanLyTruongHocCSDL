using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormMonHoc
{
    internal class ViewMonHocForm : DetailInfoForm<MonHoc>
    {
        private System.Windows.Forms.TextBox maMonHocTextBox;
        private System.Windows.Forms.TextBox soTinhChiTextBox;
        private System.Windows.Forms.TextBox tenMonHocTextBox;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.CheckBox tinhTrangCheckBox;

        public ViewMonHocForm(MonHoc mh) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(mh);
            Init();
        }

        public ViewMonHocForm() : base()
        {
            InitializeComponent();
        }

        protected override void Init()
        {
            this.maMonHocTextBox.Enabled = false;
            this.soTinhChiTextBox.Enabled = true;
            this.tenMonHocTextBox.Enabled = true;
            this.update_button.Enabled = true;
            this.tinhTrangCheckBox.Enabled = true;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label maMonHocLabel;
            System.Windows.Forms.Label soTinhChiLabel;
            System.Windows.Forms.Label tenMonHocLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.soTinhChiTextBox = new System.Windows.Forms.TextBox();
            this.tenMonHocTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangCheckBox = new System.Windows.Forms.CheckBox();
            this.update_button = new System.Windows.Forms.Button();
            maMonHocLabel = new System.Windows.Forms.Label();
            soTinhChiLabel = new System.Windows.Forms.Label();
            tenMonHocLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Controls.Add(soTinhChiLabel);
            this.panel1.Controls.Add(this.soTinhChiTextBox);
            this.panel1.Controls.Add(tenMonHocLabel);
            this.panel1.Controls.Add(this.tenMonHocTextBox);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangCheckBox);
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Location = new System.Drawing.Point(230, 159);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(89, 17);
            maMonHocLabel.TabIndex = 0;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // soTinhChiLabel
            // 
            soTinhChiLabel.AutoSize = true;
            soTinhChiLabel.Location = new System.Drawing.Point(230, 187);
            soTinhChiLabel.Name = "soTinhChiLabel";
            soTinhChiLabel.Size = new System.Drawing.Size(70, 17);
            soTinhChiLabel.TabIndex = 2;
            soTinhChiLabel.Text = "Số tín chỉ:";
            // 
            // tenMonHocLabel
            // 
            tenMonHocLabel.AutoSize = true;
            tenMonHocLabel.Location = new System.Drawing.Point(230, 215);
            tenMonHocLabel.Name = "tenMonHocLabel";
            tenMonHocLabel.Size = new System.Drawing.Size(95, 17);
            tenMonHocLabel.TabIndex = 4;
            tenMonHocLabel.Text = "Tên môn học:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(230, 245);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(56, 17);
            tinhTrangLabel.TabIndex = 6;
            tinhTrangLabel.Text = "Đã xóa:";
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(331, 156);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.maMonHocTextBox.TabIndex = 1;
            // 
            // soTinhChiTextBox
            // 
            this.soTinhChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "SoTinhChi", true));
            this.soTinhChiTextBox.Location = new System.Drawing.Point(331, 184);
            this.soTinhChiTextBox.Name = "soTinhChiTextBox";
            this.soTinhChiTextBox.Size = new System.Drawing.Size(104, 22);
            this.soTinhChiTextBox.TabIndex = 3;
            // 
            // tenMonHocTextBox
            // 
            this.tenMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TenMonHoc", true));
            this.tenMonHocTextBox.Location = new System.Drawing.Point(331, 212);
            this.tenMonHocTextBox.Name = "tenMonHocTextBox";
            this.tenMonHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.tenMonHocTextBox.TabIndex = 5;
            // 
            // tinhTrangCheckBox
            // 
            this.tinhTrangCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource, "TinhTrang", true));
            this.tinhTrangCheckBox.Location = new System.Drawing.Point(331, 240);
            this.tinhTrangCheckBox.Name = "tinhTrangCheckBox";
            this.tinhTrangCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tinhTrangCheckBox.TabIndex = 7;
            this.tinhTrangCheckBox.Text = "checkBox1";
            this.tinhTrangCheckBox.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(481, 238);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(80, 24);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "Cập nhật ";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // ViewMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Name = "ViewMonHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            MonHoc mh = bindingSource.Current as MonHoc;
            if (mh == null) return;

            ValidationContext context = new ValidationContext(mh, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(mh, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.MonHoc.Update(mh))
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
