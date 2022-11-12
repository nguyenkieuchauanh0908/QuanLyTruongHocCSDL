
namespace QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuAdmin
{
    partial class FormHomeAdmin
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
            this.sv_btn = new System.Windows.Forms.Button();
            this.mh_btn = new System.Windows.Forms.Button();
            this.lh_btn = new System.Windows.Forms.Button();
            this.kyhoc_btn = new System.Windows.Forms.Button();
            this.gv_btn = new System.Windows.Forms.Button();
            this.khoa_btn = new System.Windows.Forms.Button();
            this.diem_btn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sv_btn);
            this.flowLayoutPanel1.Controls.Add(this.mh_btn);
            this.flowLayoutPanel1.Controls.Add(this.lh_btn);
            this.flowLayoutPanel1.Controls.Add(this.kyhoc_btn);
            this.flowLayoutPanel1.Controls.Add(this.gv_btn);
            this.flowLayoutPanel1.Controls.Add(this.khoa_btn);
            this.flowLayoutPanel1.Controls.Add(this.diem_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // sv_btn
            // 
            this.sv_btn.Location = new System.Drawing.Point(3, 3);
            this.sv_btn.Name = "sv_btn";
            this.sv_btn.Size = new System.Drawing.Size(223, 71);
            this.sv_btn.TabIndex = 0;
            this.sv_btn.Text = "Sinh Viên";
            this.sv_btn.UseVisualStyleBackColor = true;
            this.sv_btn.Click += new System.EventHandler(this.sv_btn_Click);
            // 
            // mh_btn
            // 
            this.mh_btn.Location = new System.Drawing.Point(232, 3);
            this.mh_btn.Name = "mh_btn";
            this.mh_btn.Size = new System.Drawing.Size(223, 71);
            this.mh_btn.TabIndex = 1;
            this.mh_btn.Text = "Môn học";
            this.mh_btn.UseVisualStyleBackColor = true;
            this.mh_btn.Click += new System.EventHandler(this.mh_btn_Click);
            // 
            // lh_btn
            // 
            this.lh_btn.Location = new System.Drawing.Point(461, 3);
            this.lh_btn.Name = "lh_btn";
            this.lh_btn.Size = new System.Drawing.Size(223, 71);
            this.lh_btn.TabIndex = 2;
            this.lh_btn.Text = "Lớp học";
            this.lh_btn.UseVisualStyleBackColor = true;
            this.lh_btn.Click += new System.EventHandler(this.lh_btn_Click);
            // 
            // kyhoc_btn
            // 
            this.kyhoc_btn.Location = new System.Drawing.Point(3, 80);
            this.kyhoc_btn.Name = "kyhoc_btn";
            this.kyhoc_btn.Size = new System.Drawing.Size(223, 71);
            this.kyhoc_btn.TabIndex = 3;
            this.kyhoc_btn.Text = "Kỳ học";
            this.kyhoc_btn.UseVisualStyleBackColor = true;
            this.kyhoc_btn.Click += new System.EventHandler(this.kyhoc_btn_Click);
            // 
            // gv_btn
            // 
            this.gv_btn.Location = new System.Drawing.Point(232, 80);
            this.gv_btn.Name = "gv_btn";
            this.gv_btn.Size = new System.Drawing.Size(223, 71);
            this.gv_btn.TabIndex = 4;
            this.gv_btn.Text = "Giảng viên";
            this.gv_btn.UseVisualStyleBackColor = true;
            this.gv_btn.Click += new System.EventHandler(this.gv_btn_Click);
            // 
            // khoa_btn
            // 
            this.khoa_btn.Location = new System.Drawing.Point(461, 80);
            this.khoa_btn.Name = "khoa_btn";
            this.khoa_btn.Size = new System.Drawing.Size(223, 71);
            this.khoa_btn.TabIndex = 5;
            this.khoa_btn.Text = "Khoa";
            this.khoa_btn.UseVisualStyleBackColor = true;
            this.khoa_btn.Click += new System.EventHandler(this.khoa_btn_Click);
            // 
            // diem_btn
            // 
            this.diem_btn.Location = new System.Drawing.Point(3, 157);
            this.diem_btn.Name = "diem_btn";
            this.diem_btn.Size = new System.Drawing.Size(223, 71);
            this.diem_btn.TabIndex = 6;
            this.diem_btn.Text = "Điểm";
            this.diem_btn.UseVisualStyleBackColor = true;
            this.diem_btn.Click += new System.EventHandler(this.diem_btn_Click);
            // 
            // FormHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormHomeAdmin";
            this.Text = "FormHomeAdmin";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button sv_btn;
        private System.Windows.Forms.Button mh_btn;
        private System.Windows.Forms.Button lh_btn;
        private System.Windows.Forms.Button kyhoc_btn;
        private System.Windows.Forms.Button gv_btn;
        private System.Windows.Forms.Button khoa_btn;
        private System.Windows.Forms.Button diem_btn;
    }
}