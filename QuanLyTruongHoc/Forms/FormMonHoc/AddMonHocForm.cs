using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormMonHoc
{
    internal class AddMonHocForm : DetailInfoForm<MonHoc>
    {
        private TextBox maMonHocTextBox;
        private TextBox soTinhChiTextBox;
        private TextBox tenMonHocTextBox;
        private Button add_button;
        private CheckBox tinhTrangCheckBox;

        public AddMonHocForm() : base()
        {
            InitializeComponent();
            //this.LoadDataFromObject(diem);
            //tinhTrangTextBox.Text = "Dang giang day";
            tinhTrangCheckBox.Enabled = false;
            Init();
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
            this.add_button = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.add_button);
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
            maMonHocLabel.Location = new System.Drawing.Point(210, 130);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(89, 17);
            maMonHocLabel.TabIndex = 0;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // soTinhChiLabel
            // 
            soTinhChiLabel.AutoSize = true;
            soTinhChiLabel.Location = new System.Drawing.Point(210, 158);
            soTinhChiLabel.Name = "soTinhChiLabel";
            soTinhChiLabel.Size = new System.Drawing.Size(70, 17);
            soTinhChiLabel.TabIndex = 2;
            soTinhChiLabel.Text = "Số tín chỉ:";
            // 
            // tenMonHocLabel
            // 
            tenMonHocLabel.AutoSize = true;
            tenMonHocLabel.Location = new System.Drawing.Point(210, 186);
            tenMonHocLabel.Name = "tenMonHocLabel";
            tenMonHocLabel.Size = new System.Drawing.Size(95, 17);
            tenMonHocLabel.TabIndex = 4;
            tenMonHocLabel.Text = "Tên môn học:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(210, 216);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(56, 17);
            tinhTrangLabel.TabIndex = 6;
            tinhTrangLabel.Text = "Đã xóa:";
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(311, 127);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.maMonHocTextBox.TabIndex = 1;
            // 
            // soTinhChiTextBox
            // 
            this.soTinhChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "SoTinhChi", true));
            this.soTinhChiTextBox.Location = new System.Drawing.Point(311, 155);
            this.soTinhChiTextBox.Name = "soTinhChiTextBox";
            this.soTinhChiTextBox.Size = new System.Drawing.Size(104, 22);
            this.soTinhChiTextBox.TabIndex = 3;
            // 
            // tenMonHocTextBox
            // 
            this.tenMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TenMonHoc", true));
            this.tenMonHocTextBox.Location = new System.Drawing.Point(311, 183);
            this.tenMonHocTextBox.Name = "tenMonHocTextBox";
            this.tenMonHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.tenMonHocTextBox.TabIndex = 5;
            // 
            // tinhTrangCheckBox
            // 
            this.tinhTrangCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource, "TinhTrang", true));
            this.tinhTrangCheckBox.Location = new System.Drawing.Point(311, 211);
            this.tinhTrangCheckBox.Name = "tinhTrangCheckBox";
            this.tinhTrangCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tinhTrangCheckBox.TabIndex = 7;
            this.tinhTrangCheckBox.Text = "checkBox1";
            this.tinhTrangCheckBox.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.Control;
            this.add_button.Location = new System.Drawing.Point(84, 439);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 82);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Name = "AddMonHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.MaMonHoc = int.Parse(maMonHocTextBox.Text);
            //mh.MaMonHoc = convert.toint32(maMonHocTextBox.Text);
            mh.SoTinhChi = Int16.Parse(maMonHocTextBox.Text);
            mh.TenMonHoc= tenMonHocTextBox.Text;
            mh.TinhTrang = tinhTrangCheckBox.Checked;
           
        
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

            if (MainForm.Manager.MonHoc.Add(mh))
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
