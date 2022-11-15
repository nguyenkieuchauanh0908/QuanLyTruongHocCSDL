using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers.Convert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class UpdateKyHocForm : DetailInfoForm<KyHoc>
    {
        private TextBox hocPhiTextBox;
        private TextBox kyHocTextBox;
        private TextBox maKyHocTextBox;
        private Button update_button;
        private TextBox namHocTextBox;

        public UpdateKyHocForm() : base()
        {
            InitializeComponent();
        }
        public UpdateKyHocForm(KyHoc kyHoc) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(kyHoc);
            Init();
        }
        protected override void Init()
        {
            this.maKyHocTextBox.Enabled = true;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label hocPhiLabel;
            System.Windows.Forms.Label kyHocLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label namHocLabel;
            this.hocPhiTextBox = new System.Windows.Forms.TextBox();
            this.kyHocTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.namHocTextBox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            hocPhiLabel = new System.Windows.Forms.Label();
            kyHocLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            namHocLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(hocPhiLabel);
            this.panel1.Controls.Add(this.hocPhiTextBox);
            this.panel1.Controls.Add(kyHocLabel);
            this.panel1.Controls.Add(this.kyHocTextBox);
            this.panel1.Controls.Add(maKyHocLabel);
            this.panel1.Controls.Add(this.maKyHocTextBox);
            this.panel1.Controls.Add(namHocLabel);
            this.panel1.Controls.Add(this.namHocTextBox);
            this.panel1.Size = new System.Drawing.Size(816, 550);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Location = new System.Drawing.Point(0, 550);
            this.panel2.Size = new System.Drawing.Size(816, 128);
            this.panel2.Controls.SetChildIndex(this.update_button, 0);
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hocPhiLabel.Location = new System.Drawing.Point(106, 121);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(110, 30);
            hocPhiLabel.TabIndex = 0;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kyHocLabel.Location = new System.Drawing.Point(106, 192);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(103, 30);
            kyHocLabel.TabIndex = 2;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKyHocLabel.Location = new System.Drawing.Point(106, 263);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(146, 30);
            maKyHocLabel.TabIndex = 4;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namHocLabel.Location = new System.Drawing.Point(106, 335);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(128, 30);
            namHocLabel.TabIndex = 6;
            namHocLabel.Text = "Năm Học:";
            // 
            // hocPhiTextBox
            // 
            this.hocPhiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "HocPhi", true));
            this.hocPhiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocPhiTextBox.Location = new System.Drawing.Point(284, 121);
            this.hocPhiTextBox.Name = "hocPhiTextBox";
            this.hocPhiTextBox.Size = new System.Drawing.Size(405, 37);
            this.hocPhiTextBox.TabIndex = 1;
            // 
            // kyHocTextBox
            // 
            this.kyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "kyHoc", true));
            this.kyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyHocTextBox.Location = new System.Drawing.Point(284, 192);
            this.kyHocTextBox.Name = "kyHocTextBox";
            this.kyHocTextBox.Size = new System.Drawing.Size(405, 37);
            this.kyHocTextBox.TabIndex = 3;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKyHocTextBox.Location = new System.Drawing.Point(284, 260);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(405, 37);
            this.maKyHocTextBox.TabIndex = 5;
            // 
            // namHocTextBox
            // 
            this.namHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "NamHoc", true));
            this.namHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namHocTextBox.Location = new System.Drawing.Point(284, 332);
            this.namHocTextBox.Name = "namHocTextBox";
            this.namHocTextBox.Size = new System.Drawing.Size(405, 37);
            this.namHocTextBox.TabIndex = 7;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(254, 20);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(100, 32);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Cập nhật";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // UpdateKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 678);
            this.Name = "UpdateKyHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            KyHoc ky = bindingSource.Current as KyHoc;
            if (ky == null) return;

            ValidationContext context = new ValidationContext(ky, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(ky, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.KyHoc.Update(ky))
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
