using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class AddSinhVienForm : ViewSinhVienForm
    {

        public AddSinhVienForm () : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(758, 688);
            this.Name = "AddSinhVienForm";
            this.Load += new System.EventHandler(this.AddSinhVienForm_Load);
            this.Controls.SetChildIndex(this.tinhTrangComboBox, 0);
            this.Controls.SetChildIndex(this.tenTextBox, 0);
            this.Controls.SetChildIndex(this.ngaySinhDateTimePicker, 0);
            this.Controls.SetChildIndex(this.maSVTextBox, 0);
            this.Controls.SetChildIndex(this.maKhoaComboBox, 0);
            this.Controls.SetChildIndex(this.hoTextBox, 0);
            this.Controls.SetChildIndex(this.emailTextBox, 0);
            this.Controls.SetChildIndex(this.diaChiTextBox, 0);
            this.Controls.SetChildIndex(this.gioiTinhTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddSinhVienForm_Load(object sender, EventArgs e)
        {
            hoTextBox.Enabled = true;
            tenTextBox.Enabled = true;
            maSVTextBox.Enabled = true;
            maKhoaComboBox.Enabled = true;
            emailTextBox.Enabled = true;
            diaChiTextBox.Enabled = true;
            tinhTrangComboBox.Enabled = true;
            gioiTinhTextBox.Enabled = true;
            ngaySinhDateTimePicker.Enabled = true;
        }
    }
}
