using QuanLyTruongHoc.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKhoa
{
    internal class AddKhoaForm : DetailInfoForm<Khoa>
    {
        private CheckBox daXoaCheckBox;
        private TextBox maKhoaTextBox;
        private Button add_button;
        private TextBox tenKhoaTextBox;

        public AddKhoaForm() : base()
        {
            InitializeComponent();
            bindingSource.DataSource = new Khoa();
            Init();
        }
        public AddKhoaForm(Khoa khoa) : base()
        {
            InitializeComponent();
            
            
        }
        protected override void Init()
        {
            this.daXoaCheckBox.Enabled = false;
            this.maKhoaTextBox.Enabled = false;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.Label daXoaLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.Windows.Forms.Label tenKhoaLabel;
            this.daXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.tenKhoaTextBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            daXoaLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            tenKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(daXoaLabel);
            this.panel1.Controls.Add(this.daXoaCheckBox);
            this.panel1.Controls.Add(maKhoaLabel);
            this.panel1.Controls.Add(this.maKhoaTextBox);
            this.panel1.Controls.Add(tenKhoaLabel);
            this.panel1.Controls.Add(this.tenKhoaTextBox);
            this.panel1.Size = new System.Drawing.Size(816, 581);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.add_button);
            this.panel2.Location = new System.Drawing.Point(0, 581);
            this.panel2.Size = new System.Drawing.Size(816, 158);
            this.panel2.Controls.SetChildIndex(this.add_button, 0);
            // 
            // daXoaLabel
            // 
            daXoaLabel.AutoSize = true;
            daXoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            daXoaLabel.Location = new System.Drawing.Point(61, 275);
            daXoaLabel.Name = "daXoaLabel";
            daXoaLabel.Size = new System.Drawing.Size(105, 30);
            daXoaLabel.TabIndex = 0;
            daXoaLabel.Text = "Đã Xóa:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maKhoaLabel.Location = new System.Drawing.Point(61, 339);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(122, 30);
            maKhoaLabel.TabIndex = 2;
            maKhoaLabel.Text = "Mã Khoa:";
            // 
            // tenKhoaLabel
            // 
            tenKhoaLabel.AutoSize = true;
            tenKhoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKhoaLabel.Location = new System.Drawing.Point(61, 414);
            tenKhoaLabel.Name = "tenKhoaLabel";
            tenKhoaLabel.Size = new System.Drawing.Size(130, 30);
            tenKhoaLabel.TabIndex = 4;
            tenKhoaLabel.Text = "Tên Khoa:";
            // 
            // daXoaCheckBox
            // 
            this.daXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource, "DaXoa", true));
            this.daXoaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daXoaCheckBox.Location = new System.Drawing.Point(198, 270);
            this.daXoaCheckBox.Name = "daXoaCheckBox";
            this.daXoaCheckBox.Size = new System.Drawing.Size(426, 42);
            this.daXoaCheckBox.TabIndex = 1;
            this.daXoaCheckBox.Text = "checkBox1";
            this.daXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaKhoa", true));
            this.maKhoaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKhoaTextBox.Location = new System.Drawing.Point(198, 339);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.Size = new System.Drawing.Size(426, 37);
            this.maKhoaTextBox.TabIndex = 3;
            // 
            // tenKhoaTextBox
            // 
            this.tenKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TenKhoa", true));
            this.tenKhoaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKhoaTextBox.Location = new System.Drawing.Point(198, 411);
            this.tenKhoaTextBox.Name = "tenKhoaTextBox";
            this.tenKhoaTextBox.Size = new System.Drawing.Size(426, 37);
            this.tenKhoaTextBox.TabIndex = 5;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(254, 19);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(97, 31);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Thêm";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(816, 739);
            this.Name = "AddKhoaForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Khoa khoa = bindingSource.Current as Khoa;
            if (khoa == null) return;
            ValidationContext context = new ValidationContext(khoa, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(khoa, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.Khoa.Add(khoa))
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
