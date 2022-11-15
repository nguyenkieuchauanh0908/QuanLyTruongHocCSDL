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
    internal class ViewDiemForm: DetailInfoForm<Diem>
    {
        private TextBox diem_cuoi_kyTextBox;
        private TextBox diem_giua_kyTextBox;
        private TextBox maLopTextBox;
        private Button update_btn;
        private TextBox maSVTextBox;

        public ViewDiemForm(Diem diem) : base()
        {
            InitializeComponent();
            this.LoadDataFromObject(diem);
            Init();

        }

        protected override void Init()
        {
            this.maLopTextBox.Enabled = false;
            this.maSVTextBox.Enabled = true;
            this.diem_giua_kyTextBox.Enabled = true;
            this.diem_cuoi_kyTextBox.Enabled = true;
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
            this.update_btn = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.update_btn);
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
            diem_cuoi_kyLabel.Location = new System.Drawing.Point(269, 101);
            diem_cuoi_kyLabel.Name = "diem_cuoi_kyLabel";
            diem_cuoi_kyLabel.Size = new System.Drawing.Size(92, 17);
            diem_cuoi_kyLabel.TabIndex = 0;
            diem_cuoi_kyLabel.Text = "Điểm cuối kỳ:";
            // 
            // diem_giua_kyLabel
            // 
            diem_giua_kyLabel.AutoSize = true;
            diem_giua_kyLabel.Location = new System.Drawing.Point(269, 129);
            diem_giua_kyLabel.Name = "diem_giua_kyLabel";
            diem_giua_kyLabel.Size = new System.Drawing.Size(93, 17);
            diem_giua_kyLabel.TabIndex = 2;
            diem_giua_kyLabel.Text = "Điểm giữa kỳ:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(269, 157);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(81, 17);
            maLopLabel.TabIndex = 4;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(269, 185);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(91, 17);
            maSVLabel.TabIndex = 6;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // diem_cuoi_kyTextBox
            // 
            this.diem_cuoi_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diem_cuoi_ky", true));
            this.diem_cuoi_kyTextBox.Location = new System.Drawing.Point(368, 98);
            this.diem_cuoi_kyTextBox.Name = "diem_cuoi_kyTextBox";
            this.diem_cuoi_kyTextBox.Size = new System.Drawing.Size(100, 22);
            this.diem_cuoi_kyTextBox.TabIndex = 1;
            // 
            // diem_giua_kyTextBox
            // 
            this.diem_giua_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "diem_giua_ky", true));
            this.diem_giua_kyTextBox.Location = new System.Drawing.Point(368, 126);
            this.diem_giua_kyTextBox.Name = "diem_giua_kyTextBox";
            this.diem_giua_kyTextBox.Size = new System.Drawing.Size(100, 22);
            this.diem_giua_kyTextBox.TabIndex = 3;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maLop", true));
            this.maLopTextBox.Location = new System.Drawing.Point(368, 154);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(100, 22);
            this.maLopTextBox.TabIndex = 5;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "maSV", true));
            this.maSVTextBox.Location = new System.Drawing.Point(368, 182);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(100, 22);
            this.maSVTextBox.TabIndex = 7;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(506, 183);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "Cập nhật";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // ViewDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Name = "ViewDiemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Diem diem = bindingSource.Current as Diem;
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

            if (MainForm.Manager.Diem.Update(diem))
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
