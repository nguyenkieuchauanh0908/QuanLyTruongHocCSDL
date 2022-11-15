
namespace QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuGV
{
    partial class FormHomeGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dslop_btn = new System.Windows.Forms.Button();
            this.dsSV_btn = new System.Windows.Forms.Button();
            this.chamdiem_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dslop_btn);
            this.flowLayoutPanel1.Controls.Add(this.dsSV_btn);
            this.flowLayoutPanel1.Controls.Add(this.chamdiem_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dslop_btn
            // 
            this.dslop_btn.Location = new System.Drawing.Point(3, 3);
            this.dslop_btn.Name = "dslop_btn";
            this.dslop_btn.Size = new System.Drawing.Size(234, 119);
            this.dslop_btn.TabIndex = 0;
            this.dslop_btn.Text = "Các lớp học";
            this.dslop_btn.UseVisualStyleBackColor = true;
            this.dslop_btn.Click += new System.EventHandler(this.dslop_btn_Click);
            // 
            // dsSV_btn
            // 
            this.dsSV_btn.Location = new System.Drawing.Point(243, 3);
            this.dsSV_btn.Name = "dsSV_btn";
            this.dsSV_btn.Size = new System.Drawing.Size(234, 119);
            this.dsSV_btn.TabIndex = 1;
            this.dsSV_btn.Text = "Danh Sách Sinh Viên";
            this.dsSV_btn.UseVisualStyleBackColor = true;
            this.dsSV_btn.Click += new System.EventHandler(this.dsSV_btn_Click);
            // 
            // chamdiem_btn
            // 
            this.chamdiem_btn.Location = new System.Drawing.Point(483, 3);
            this.chamdiem_btn.Name = "chamdiem_btn";
            this.chamdiem_btn.Size = new System.Drawing.Size(234, 119);
            this.chamdiem_btn.TabIndex = 2;
            this.chamdiem_btn.Text = "Chấm điểm";
            this.chamdiem_btn.UseVisualStyleBackColor = true;
            this.chamdiem_btn.Click += new System.EventHandler(this.chamdiem_btn_Click);
            // 
            // FormHomeGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormHomeGV";
            this.Text = "FormHomeGV";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button dslop_btn;
        private System.Windows.Forms.Button dsSV_btn;
        private System.Windows.Forms.Button chamdiem_btn;
    }
}