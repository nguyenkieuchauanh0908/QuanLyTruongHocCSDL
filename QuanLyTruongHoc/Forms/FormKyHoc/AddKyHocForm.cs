using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class AddKyHocForm : DetailInfoForm<KyHoc>
    {
        private TextBox hocPhiTextBox;
        private TextBox kyHocTextBox;
        private TextBox maKyHocTextBox;
        private TextBox namHocTextBox;
        private Button add_button;

        public AddKyHocForm(KyHoc ky) : base()
        {
            InitializeComponent();

        }
        public AddKyHocForm() : base()
        {
            InitializeComponent();
            bindingSource.DataSource = new KyHoc();
            Init();
        }
        protected override void Init()
        {
            this.maKyHocTextBox.Enabled = false;
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
            this.add_button = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(816, 580);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Size = new System.Drawing.Size(816, 164);
            this.panel2.Controls.SetChildIndex(this.add_button, 0);
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hocPhiLabel.Location = new System.Drawing.Point(94, 163);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(110, 30);
            hocPhiLabel.TabIndex = 0;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kyHocLabel.Location = new System.Drawing.Point(94, 217);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(103, 30);
            kyHocLabel.TabIndex = 2;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKyHocLabel.Location = new System.Drawing.Point(94, 275);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(146, 30);
            maKyHocLabel.TabIndex = 4;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            namHocLabel.Location = new System.Drawing.Point(94, 331);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(128, 30);
            namHocLabel.TabIndex = 6;
            namHocLabel.Text = "Năm Học:";
            // 
            // hocPhiTextBox
            // 
            this.hocPhiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "HocPhi", true));
            this.hocPhiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocPhiTextBox.Location = new System.Drawing.Point(269, 160);
            this.hocPhiTextBox.Name = "hocPhiTextBox";
            this.hocPhiTextBox.Size = new System.Drawing.Size(446, 37);
            this.hocPhiTextBox.TabIndex = 1;
            // 
            // kyHocTextBox
            // 
            this.kyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "kyHoc", true));
            this.kyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kyHocTextBox.Location = new System.Drawing.Point(269, 214);
            this.kyHocTextBox.Name = "kyHocTextBox";
            this.kyHocTextBox.Size = new System.Drawing.Size(446, 37);
            this.kyHocTextBox.TabIndex = 3;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKyHocTextBox.Location = new System.Drawing.Point(269, 272);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(446, 37);
            this.maKyHocTextBox.TabIndex = 5;
            // 
            // namHocTextBox
            // 
            this.namHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "NamHoc", true));
            this.namHocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namHocTextBox.Location = new System.Drawing.Point(269, 328);
            this.namHocTextBox.Name = "namHocTextBox";
            this.namHocTextBox.Size = new System.Drawing.Size(446, 37);
            this.namHocTextBox.TabIndex = 7;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(254, 20);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(93, 31);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 744);
            this.Name = "AddKyHocForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
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

            if (MainForm.Manager.KyHoc.Add(ky))
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
