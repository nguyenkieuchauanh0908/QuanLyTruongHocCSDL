using QuanLyTruongHoc.DataObjects;
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


namespace QuanLyTruongHoc.Forms.FormMonHoc
{
     internal class ListMonHocForm : BaseListForm<MonHoc>
    {
        private BindingSource monHocBindingSource;
        private TextBox maMonHocTextBox;
        private TextBox soTinhChiTextBox;
        private TextBox tenMonHocTextBox;
        private CheckBox tinhTrangCheckBox;
        private System.ComponentModel.IContainer components;

        public ListMonHocForm()
        {
            InitializeComponent();
            
            monHocBindingSource.DataSource = new MonHoc();
        }
        public override DataTable GetTable()
        {
            return MainForm.Manager.MonHoc.Load();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maMonHocLabel;
            System.Windows.Forms.Label soTinhChiLabel;
            System.Windows.Forms.Label tenMonHocLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maMonHocTextBox = new System.Windows.Forms.TextBox();
            this.soTinhChiTextBox = new System.Windows.Forms.TextBox();
            this.tenMonHocTextBox = new System.Windows.Forms.TextBox();
            this.tinhTrangCheckBox = new System.Windows.Forms.CheckBox();
            maMonHocLabel = new System.Windows.Forms.Label();
            soTinhChiLabel = new System.Windows.Forms.Label();
            tenMonHocLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(maMonHocLabel);
            this.panel1.Controls.Add(this.maMonHocTextBox);
            this.panel1.Controls.Add(soTinhChiLabel);
            this.panel1.Controls.Add(this.soTinhChiTextBox);
            this.panel1.Controls.Add(tenMonHocLabel);
            this.panel1.Controls.Add(this.tenMonHocTextBox);
            this.panel1.Controls.Add(tinhTrangLabel);
            this.panel1.Controls.Add(this.tinhTrangCheckBox);
            this.panel1.Size = new System.Drawing.Size(800, 220);
            this.panel1.Controls.SetChildIndex(this.search_btn, 0);
            this.panel1.Controls.SetChildIndex(this.add_btn, 0);
            this.panel1.Controls.SetChildIndex(this.tinhTrangCheckBox, 0);
            this.panel1.Controls.SetChildIndex(tinhTrangLabel, 0);
            this.panel1.Controls.SetChildIndex(this.tenMonHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(tenMonHocLabel, 0);
            this.panel1.Controls.SetChildIndex(this.soTinhChiTextBox, 0);
            this.panel1.Controls.SetChildIndex(soTinhChiLabel, 0);
            this.panel1.Controls.SetChildIndex(this.maMonHocTextBox, 0);
            this.panel1.Controls.SetChildIndex(maMonHocLabel, 0);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(522, 135);
            this.search_btn.Size = new System.Drawing.Size(101, 35);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(432, 135);
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataSource = typeof(QuanLyTruongHoc.DataObjects.MonHoc);
            // 
            // maMonHocLabel
            // 
            maMonHocLabel.AutoSize = true;
            maMonHocLabel.Location = new System.Drawing.Point(161, 65);
            maMonHocLabel.Name = "maMonHocLabel";
            maMonHocLabel.Size = new System.Drawing.Size(89, 17);
            maMonHocLabel.TabIndex = 2;
            maMonHocLabel.Text = "Mã môn học:";
            // 
            // maMonHocTextBox
            // 
            this.maMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monHocBindingSource, "MaMonHoc", true));
            this.maMonHocTextBox.Location = new System.Drawing.Point(262, 62);
            this.maMonHocTextBox.Name = "maMonHocTextBox";
            this.maMonHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.maMonHocTextBox.TabIndex = 3;
            // 
            // soTinhChiLabel
            // 
            soTinhChiLabel.AutoSize = true;
            soTinhChiLabel.Location = new System.Drawing.Point(161, 93);
            soTinhChiLabel.Name = "soTinhChiLabel";
            soTinhChiLabel.Size = new System.Drawing.Size(70, 17);
            soTinhChiLabel.TabIndex = 4;
            soTinhChiLabel.Text = "Số tín chỉ:";
            // 
            // soTinhChiTextBox
            // 
            this.soTinhChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monHocBindingSource, "SoTinhChi", true));
            this.soTinhChiTextBox.Location = new System.Drawing.Point(262, 90);
            this.soTinhChiTextBox.Name = "soTinhChiTextBox";
            this.soTinhChiTextBox.Size = new System.Drawing.Size(104, 22);
            this.soTinhChiTextBox.TabIndex = 5;
            // 
            // tenMonHocLabel
            // 
            tenMonHocLabel.AutoSize = true;
            tenMonHocLabel.Location = new System.Drawing.Point(161, 121);
            tenMonHocLabel.Name = "tenMonHocLabel";
            tenMonHocLabel.Size = new System.Drawing.Size(95, 17);
            tenMonHocLabel.TabIndex = 6;
            tenMonHocLabel.Text = "Tên môn học:";
            // 
            // tenMonHocTextBox
            // 
            this.tenMonHocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monHocBindingSource, "TenMonHoc", true));
            this.tenMonHocTextBox.Location = new System.Drawing.Point(262, 118);
            this.tenMonHocTextBox.Name = "tenMonHocTextBox";
            this.tenMonHocTextBox.Size = new System.Drawing.Size(104, 22);
            this.tenMonHocTextBox.TabIndex = 7;
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(161, 151);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(56, 17);
            tinhTrangLabel.TabIndex = 8;
            tinhTrangLabel.Text = "Đã xóa:";
            // 
            // tinhTrangCheckBox
            // 
            this.tinhTrangCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.monHocBindingSource, "TinhTrang", true));
            this.tinhTrangCheckBox.Location = new System.Drawing.Point(262, 146);
            this.tinhTrangCheckBox.Name = "tinhTrangCheckBox";
            this.tinhTrangCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tinhTrangCheckBox.TabIndex = 9;
            this.tinhTrangCheckBox.Text = "checkBox1";
            this.tinhTrangCheckBox.UseVisualStyleBackColor = true;
            // 
            // ListMonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ListMonHocForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        protected override void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                MonHoc mh = ConverterHelper.ConvertDataRow<MonHoc>(row);
                ViewMonHocForm viewMonHocForm = new ViewMonHocForm(mh);
                viewMonHocForm.Show();

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
                MonHoc lh = ConverterHelper.ConvertDataRow<MonHoc>(row);
                ViewMonHocForm viewMonHocForm = new ViewMonHocForm(lh);
                viewMonHocForm.Show();

            }
            else
            {
                MessageBox.Show("Không có giảng viên nào được chọn");
            }
        }

        protected override void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row;
            if (row != null)
            {
                MonHoc lh = Helpers.Convert.ConverterHelper.ConvertDataRow<MonHoc>(row);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ADOMonHoc MonHoc = MainForm.Manager.MonHoc;
                    if (MonHoc.Delete(lh))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView.DataSource = MonHoc.Load();
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
        }

        protected override void add_btn_Click(object sender, EventArgs e)
        {
            AddMonHocForm addMonHocForm = new AddMonHocForm();
            addMonHocForm.Show();
        }
        protected override MonHoc SearchObject()
        {
            return monHocBindingSource.Current as MonHoc;
        }

        protected override void search_btn_Click(object sender, EventArgs e)
        {
            base.search_btn_Click(sender, e);
            this.monHocBindingSource.DataSource = new MonHoc();
        }
    }
}
