using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Forms.FormKhoa;
using QuanLyTruongHoc.Forms.FormSinhVien;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruongHoc.Forms.FormKyHoc
{
    internal class ListKyHocForm : BaseListForm<KyHoc>
    {
        private BindingSource kyHocBindingSource;
        private BindingSource khoaBindingSource;
        private TextBox hocPhiTextBox;
        private TextBox kyHocTextBox;
        private TextBox maKyHocTextBox;
        private TextBox namHocTextBox;
        private System.ComponentModel.IContainer components;

        public ListKyHocForm()
        {
            InitializeComponent();
            kyHocBindingSource.DataSource = new KyHoc();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.KyHoc.Load()
;        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hocPhiLabel;
            System.Windows.Forms.Label kyHocLabel;
            System.Windows.Forms.Label maKyHocLabel;
            System.Windows.Forms.Label namHocLabel;
            this.hocPhiTextBox = new System.Windows.Forms.TextBox();
            this.kyHocTextBox = new System.Windows.Forms.TextBox();
            this.maKyHocTextBox = new System.Windows.Forms.TextBox();
            this.namHocTextBox = new System.Windows.Forms.TextBox();
            this.kyHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            hocPhiLabel = new System.Windows.Forms.Label();
            kyHocLabel = new System.Windows.Forms.Label();
            maKyHocLabel = new System.Windows.Forms.Label();
            namHocLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Size = new System.Drawing.Size(800, 262);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.namHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(namHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maKyHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(maKyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.kyHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(kyHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.hocPhiTextBox, 0);
            this.panel1.Controls.SetChildIndex(hocPhiLabel, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(442, 125);
            this.search_btn.Size = new System.Drawing.Size(134, 52);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(323, 125);
            this.add_btn.Size = new System.Drawing.Size(75, 52);
            // 
            // hocPhiLabel
            // 
            hocPhiLabel.AutoSize = true;
            hocPhiLabel.Location = new System.Drawing.Point(69, 77);
            hocPhiLabel.Name = "hocPhiLabel";
            hocPhiLabel.Size = new System.Drawing.Size(61, 17);
            hocPhiLabel.TabIndex = 2;
            hocPhiLabel.Text = "Học Phí:";
            // 
            // kyHocLabel
            // 
            kyHocLabel.AutoSize = true;
            kyHocLabel.Location = new System.Drawing.Point(69, 105);
            kyHocLabel.Name = "kyHocLabel";
            kyHocLabel.Size = new System.Drawing.Size(57, 17);
            kyHocLabel.TabIndex = 4;
            kyHocLabel.Text = "Kỳ Học:";
            // 
            // maKyHocLabel
            // 
            maKyHocLabel.AutoSize = true;
            maKyHocLabel.Location = new System.Drawing.Point(69, 133);
            maKyHocLabel.Name = "maKyHocLabel";
            maKyHocLabel.Size = new System.Drawing.Size(80, 17);
            maKyHocLabel.TabIndex = 6;
            maKyHocLabel.Text = "Mã Kỳ Học:";
            // 
            // namHocLabel
            // 
            namHocLabel.AutoSize = true;
            namHocLabel.Location = new System.Drawing.Point(69, 161);
            namHocLabel.Name = "namHocLabel";
            namHocLabel.Size = new System.Drawing.Size(70, 17);
            namHocLabel.TabIndex = 8;
            namHocLabel.Text = "Năm Học:";
            // 
            // hocPhiTextBox
            // 
            this.hocPhiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kyHocBindingSource, "HocPhi", true));
            this.hocPhiTextBox.Location = new System.Drawing.Point(155, 74);
            this.hocPhiTextBox.Name = "hocPhiTextBox";
            this.hocPhiTextBox.Size = new System.Drawing.Size(100, 22);
            this.hocPhiTextBox.TabIndex = 3;
            // 
            // kyHocTextBox
            // 
            this.kyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kyHocBindingSource, "kyHoc", true));
            this.kyHocTextBox.Location = new System.Drawing.Point(155, 102);
            this.kyHocTextBox.Name = "kyHocTextBox";
            this.kyHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.kyHocTextBox.TabIndex = 5;
            // 
            // maKyHocTextBox
            // 
            this.maKyHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kyHocBindingSource, "MaKyHoc", true));
            this.maKyHocTextBox.Location = new System.Drawing.Point(155, 130);
            this.maKyHocTextBox.Name = "maKyHocTextBox";
            this.maKyHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.maKyHocTextBox.TabIndex = 7;
            // 
            // namHocTextBox
            // 
            this.namHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kyHocBindingSource, "NamHoc", true));
            this.namHocTextBox.Location = new System.Drawing.Point(155, 158);
            this.namHocTextBox.Name = "namHocTextBox";
            this.namHocTextBox.Size = new System.Drawing.Size(100, 22);
            this.namHocTextBox.TabIndex = 9;
            // 
            // kyHocBindingSource
            // 
            this.kyHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.KyHoc);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.Khoa);
            // 
            // ListKyHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListKyHocForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kyHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc ky = ConverterHelper.ConvertDataRow<KyHoc>(row);
                ViewKyHocForm viewKyHocForm = new ViewKyHocForm(ky);
                viewKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                KyHoc kyHoc = ConverterHelper.ConvertDataRow<KyHoc>(row);
                UpdateKyHocForm updateKyHocForm = new UpdateKyHocForm(kyHoc);
                updateKyHocForm.Show();
            }
            else
            {
                MessageBox.Show("Không có kỳ học nào được chọn");
            }
        }
        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddKyHocForm addKyHocForm = new AddKyHocForm();
            addKyHocForm.Show();
        }
        protected override KyHoc SearchObject()
        {
            return kyHocBindingSource.Current as KyHoc;
        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.kyHocBindingSource.DataSource = new KyHoc();
        }
    }
}
