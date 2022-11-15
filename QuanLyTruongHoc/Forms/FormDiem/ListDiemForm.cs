using QuanLyTruongHoc.DataObjects;
using QuanLyTruongHoc.Helpers;
using QuanLyTruongHoc.Helpers.Convert;
using QuanLyTruongHoc.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongHoc.Helpers;

namespace QuanLyTruongHoc.Forms.FormDiem
{
    internal class ListDiemForm : BaseListForm<Diem>
    {
        private System.Windows.Forms.BindingSource diemBindingSource;
        private BindingSource diemBindingSource1;
        private TextBox diem_cuoi_kyTextBox;
        private TextBox diem_giua_kyTextBox;
        private TextBox maLopTextBox;
        private TextBox maSVTextBox;
        private Button button1;
        private System.ComponentModel.IContainer components;
        public ListDiemForm():base()
        {
            InitializeComponent();
            diemBindingSource1.DataSource = new Diem();
            InitList();

        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.Diem.Load();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label diem_cuoi_kyLabel;
            System.Windows.Forms.Label diem_giua_kyLabel;
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label maSVLabel;
            this.diem_cuoi_kyTextBox = new System.Windows.Forms.TextBox();
            this.diemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.diem_giua_kyTextBox = new System.Windows.Forms.TextBox();
            this.maLopTextBox = new System.Windows.Forms.TextBox();
            this.maSVTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            diem_cuoi_kyLabel = new System.Windows.Forms.Label();
            diem_giua_kyLabel = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(396, 115);
            this.search_btn.Size = new System.Drawing.Size(116, 33);
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click_1);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(271, 115);
            this.add_btn.Size = new System.Drawing.Size(100, 33);
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(527, 115);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(diem_cuoi_kyLabel);
            this.panel1.Controls.Add(this.diem_cuoi_kyTextBox);
            this.panel1.Controls.Add(diem_giua_kyLabel);
            this.panel1.Controls.Add(this.diem_giua_kyTextBox);
            this.panel1.Controls.Add(maLopLabel);
            this.panel1.Controls.Add(this.maLopTextBox);
            this.panel1.Controls.Add(maSVLabel);
            this.panel1.Controls.Add(this.maSVTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Size = new System.Drawing.Size(808, 182);
            this.panel1.Controls.SetChildIndex(this.refresh, 0);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.maSVTextBox, 0);
            this.panel1.Controls.SetChildIndex(maSVLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maLopTextBox, 0);
            this.panel1.Controls.SetChildIndex(maLopLabel, 0);
            this.panel1.Controls.SetChildIndex(this.diem_giua_kyTextBox, 0);
            this.panel1.Controls.SetChildIndex(diem_giua_kyLabel, 0);
            this.panel1.Controls.SetChildIndex(this.diem_cuoi_kyTextBox, 0);
            this.panel1.Controls.SetChildIndex(diem_cuoi_kyLabel, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            // 
            // diem_cuoi_kyLabel
            // 
            diem_cuoi_kyLabel.AutoSize = true;
            diem_cuoi_kyLabel.Location = new System.Drawing.Point(53, 41);
            diem_cuoi_kyLabel.Name = "diem_cuoi_kyLabel";
            diem_cuoi_kyLabel.Size = new System.Drawing.Size(92, 17);
            diem_cuoi_kyLabel.TabIndex = 2;
            diem_cuoi_kyLabel.Text = "Điểm cuối kỳ:";
            // 
            // diem_giua_kyLabel
            // 
            diem_giua_kyLabel.AutoSize = true;
            diem_giua_kyLabel.Location = new System.Drawing.Point(53, 69);
            diem_giua_kyLabel.Name = "diem_giua_kyLabel";
            diem_giua_kyLabel.Size = new System.Drawing.Size(93, 17);
            diem_giua_kyLabel.TabIndex = 4;
            diem_giua_kyLabel.Text = "Điểm giữa kỳ:";
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(53, 97);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(81, 17);
            maLopLabel.TabIndex = 6;
            maLopLabel.Text = "Mã lớp học:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(53, 125);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(91, 17);
            maSVLabel.TabIndex = 8;
            maSVLabel.Text = "Mã sinh viên:";
            // 
            // diem_cuoi_kyTextBox
            // 
            this.diem_cuoi_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diemBindingSource1, "diem_cuoi_ky", true));
            this.diem_cuoi_kyTextBox.Location = new System.Drawing.Point(152, 38);
            this.diem_cuoi_kyTextBox.Name = "diem_cuoi_kyTextBox";
            this.diem_cuoi_kyTextBox.Size = new System.Drawing.Size(100, 22);
            this.diem_cuoi_kyTextBox.TabIndex = 3;
            // 
            // diemBindingSource1
            // 
            this.diemBindingSource1.DataSource = typeof(QuanLyTruongHoc.DataObjects.Diem);
            this.diemBindingSource1.CurrentChanged += new System.EventHandler(this.diemBindingSource1_CurrentChanged);
            // 
            // diem_giua_kyTextBox
            // 
            this.diem_giua_kyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diemBindingSource1, "diem_giua_ky", true));
            this.diem_giua_kyTextBox.Location = new System.Drawing.Point(152, 66);
            this.diem_giua_kyTextBox.Name = "diem_giua_kyTextBox";
            this.diem_giua_kyTextBox.Size = new System.Drawing.Size(100, 22);
            this.diem_giua_kyTextBox.TabIndex = 5;
            // 
            // maLopTextBox
            // 
            this.maLopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diemBindingSource1, "maLop", true));
            this.maLopTextBox.Location = new System.Drawing.Point(152, 94);
            this.maLopTextBox.Name = "maLopTextBox";
            this.maLopTextBox.Size = new System.Drawing.Size(100, 22);
            this.maLopTextBox.TabIndex = 7;
            // 
            // maSVTextBox
            // 
            this.maSVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diemBindingSource1, "maSV", true));
            this.maSVTextBox.Location = new System.Drawing.Point(152, 122);
            this.maSVTextBox.Name = "maSVTextBox";
            this.maSVTextBox.Size = new System.Drawing.Size(100, 22);
            this.maSVTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chuyển lớp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(808, 694);
            this.Name = "ListDiemForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Diem diem = ConverterHelper.ConvertDataRow<Diem>(row);
                ViewDiemForm updateDiemForm = new ViewDiemForm(diem);
                updateDiemForm.Show();

            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }
        protected override void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Diem diem = ConverterHelper.ConvertDataRow<Diem>(row);
                ViewDiemForm updateDiemForm = new ViewDiemForm(diem);
                updateDiemForm.Show();

            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }
        /*protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Diem diem = Helpers.Convert.ConverterHelper.ConvertDataRow<Diem>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADODiem Diem = MainForm.Manager.Diem;
                    if (Diem.Delete(diem))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView.DataSource = Diem.Load();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có điểm nào được chọn");
            }
        }*/
        private void add_btn_Click(object sender, EventArgs e)
        {
            AddDiemForm addDiemForm = new AddDiemForm();
            addDiemForm.Show();
        }
        private void search_btn_Click_1(object sender, EventArgs e)
        {

        }
        protected override Diem SearchObject()
        {
            return diemBindingSource1.Current as Diem;
        }
        private void diemBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.diemBindingSource1.DataSource = new Diem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                Diem diem = ConverterHelper.ConvertDataRow<Diem>(row);
                FormChuyenLop form = new FormChuyenLop(diem);
                form.Show();
            }
        }
    }
}
