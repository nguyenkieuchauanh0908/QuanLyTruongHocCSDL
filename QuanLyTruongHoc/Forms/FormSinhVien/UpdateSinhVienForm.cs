using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class UpdateSinhVienForm : ViewSinhVienForm
    {
        private System.Windows.Forms.Button update_button;

        public UpdateSinhVienForm(SinhVien sv) : base(sv)
        {

            SinhVien newSv = ConverterHelper.ConvertDataRow<SinhVien>(MainForm.Manager.SinhVien.Get(sv).Rows[0]);
            InitializeComponent();
            this.LoadDataFromObject(newSv);
        }

        protected override void Init()
        {
            this.maSVTextBox.Enabled = false;
        }

        private void InitializeComponent()
        {
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.SetChildIndex(this.tinhTrangComboBox, 0);
            this.panel1.Controls.SetChildIndex(this.tenTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.ngaySinhDateTimePicker, 0);
            this.panel1.Controls.SetChildIndex(this.maSVTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.maKhoaComboBox, 0);
            this.panel1.Controls.SetChildIndex(this.hoTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.gioiTinhTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.emailTextBox, 0);
            this.panel1.Controls.SetChildIndex(this.diaChiTextBox, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Controls.SetChildIndex(this.update_button, 0);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(223, 16);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "Cập nhật";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // UpdateSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(498, 688);
            this.Name = "UpdateSinhVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            SinhVien sv = bindingSource.Current as SinhVien;
            if (sv == null) return;
            
            ValidationContext context = new ValidationContext(sv, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(sv, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.SinhVien.Update(sv))
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
