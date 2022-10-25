using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormDiem
{
    internal class AddDiemForm : DetailInfoForm<Diem>
    {
        private TextBox diem_cuoi_kyTextBox;
        private TextBox diem_giua_kyTextBox;
        private TextBox maLopTextBox;
        private Button add_btn;
        private TextBox maSVTextBox;

        public AddDiemForm() : base()
        {
            InitializeComponent();
            //this.LoadDataFromObject(diem);
            Init();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.Label diem_cuoi_kyLabel;
            System.Windows.Forms.Label diem_giua_kyLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maSVLabel;
            this.diem_cuoi_kyTextBox = new System.Windows.Forms.TextBox();
            this.diem_giua_kyTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            diem_cuoi_kyLabel = new System.Windows.Forms.Label();
            diem_giua_kyLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(diem_cuoi_kyLabel);
            this.panel1.Controls.Add(this.diem_cuoi_kyTextBox);
            this.panel1.Controls.Add(diem_giua_kyLabel);
            this.panel1.Controls.Add(this.diem_giua_kyTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Controls.Add(this.maSVTextBox);
            // 
            // diem_cuoi_kyLabel
            // 
            diem_cuoi_kyLabel.AutoSize = true;
            diem_cuoi_kyLabel.Location = new System.Drawing.Point(256, 92);
            diem_cuoi_kyLabel.Name = "diem_cuoi_kyLabel";
            diem_cuoi_kyLabel.Size = new System.Drawing.Size(92, 17);
            diem_cuoi_kyLabel.TabIndex = 0;
            diem_cuoi_kyLabel.Text = "Điểm cuối kỳ:";
            // 
            // diem_giua_kyLabel
            // 
            diem_giua_kyLabel.AutoSize = true;
            diem_giua_kyLabel.Location = new System.Drawing.Point(256, 120);
            diem_giua_kyLabel.Name = "diem_giua_kyLabel";
            diem_giua_kyLabel.Size = new System.Drawing.Size(93, 17);
            diem_giua_kyLabel.TabIndex = 2;
            diem_giua_kyLabel.Text = "Điểm giữa kỳ:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(256, 148);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(81, 17);
            maLopLabel.TabIndex = 4;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(256, 176);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(91, 17);
            maSVLabel.TabIndex = 6;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // diem_cuoi_kyTextBox
            // 
            this.diem_cuoi_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diem_cuoi_ky", true));
            this.diem_cuoi_kyTextBox.Location = new System.Drawing.Point(355, 89);
            this.diem_cuoi_kyTextBox.Name = "diem_cuoi_kyTextBox";
            this.diem_cuoi_kyTextBox.Size = new System.Drawing.Size(100, 22);
            this.diem_cuoi_kyTextBox.TabIndex = 1;
            // 
            // diem_giua_kyTextBox
            // 
            this.diem_giua_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diem_giua_ky", true));
            this.diem_giua_kyTextBox.Location = new System.Drawing.Point(355, 117);
            this.diem_giua_kyTextBox.Name = "diem_giua_kyTextBox";
            this.diem_giua_kyTextBox.Size = new System.Drawing.Size(100, 22);
            this.diem_giua_kyTextBox.TabIndex = 3;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maLop", true));
            this.maLopTextBox.Location = new System.Drawing.Point(355, 145);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(100, 22);
            this.maLopTextBox.TabIndex = 5;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maSV", true));
            this.maSVTextBox.Location = new System.Drawing.Point(355, 173);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(100, 22);
            this.maSVTextBox.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(508, 172);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // AddDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Name = "AddDiemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //Diem diem = bindingSource.Current as Diem;
            Diem diem = new Diem();
            diem.maLop = int.Parse(maLopTextBox.Text);
            diem.maSV = int.Parse(maSVTextBox.Text);
            diem.diem_cuoi_ky = int.Parse(diem_cuoi_kyTextBox.Text);
            diem.diem_giua_ky = int.Parse(diem_giua_kyTextBox.Text);
            if (diem == null) return;

            ValidationContext context = new ValidationContext(diem, null, null);
            IList<ValidationResult> validationResults = new List<ValidationResult>();

            if (!Validator.TryValidateObject(diem, context, validationResults, true))
            {
                foreach (var item in validationResults)
                {
                    MessageBox.Show(item.ErrorMessage);
                    return;
                }
            }

            if (MainForm.Manager.Diem.Add(diem))
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
