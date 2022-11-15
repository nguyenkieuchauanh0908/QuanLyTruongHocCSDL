using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormSinhVien
{
    internal class AddSinhVienForm : ViewSinhVienForm
    {
        protected System.Windows.Forms.Button add_button;
        
        public AddSinhVienForm(SinhVien sv) : base(sv)
        {
            InitializeComponent();
            bindingSource.DataSource = new SinhVien();
        }
        
        public AddSinhVienForm() : base()
        {
            InitializeComponent();
            this.maSVTextBox.Enabled = false;
        }

        private void InitializeComponent()
        {
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(255, 511);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(255, 372);
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.Location = new System.Drawing.Point(255, 274);
            // 
            // hoTextBox
            // 
            this.hoTextBox.Location = new System.Drawing.Point(255, 227);
            // 
            // maKhoaComboBox
            // 
            this.maKhoaComboBox.Location = new System.Drawing.Point(255, 420);
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.Location = new System.Drawing.Point(255, 145);
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(255, 466);
            // 
            // tenTextBox
            // 
            this.tenTextBox.Location = new System.Drawing.Point(255, 186);
            // 
            // tinhTrangComboBox
            // 
            this.tinhTrangComboBox.Location = new System.Drawing.Point(255, 322);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(615, 637);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Size = new System.Drawing.Size(615, 51);
            this.panel2.Controls.SetChildIndex(this.add_button, 0);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(233, 16);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddSinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(615, 688);
            this.Name = "AddSinhVienForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            SinhVien sv = bindingSource.Current as SinhVien; // Chuyển về data object (ngôn ngữ chung để nói chuyện với nhau)
            //MessageBox.Show(sv.ToString());
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

            if (MainForm.Manager.SinhVien.Add(sv))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
