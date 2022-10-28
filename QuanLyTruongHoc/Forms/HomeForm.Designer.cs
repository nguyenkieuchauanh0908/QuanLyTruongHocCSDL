namespace QuanLyTruongHoc.Forms
{
    partial class HomeForm
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
            this.button_lophoc = new System.Windows.Forms.Button();
            this.button_sv = new System.Windows.Forms.Button();
            this.button_diem = new System.Windows.Forms.Button();
            this.button_gv = new System.Windows.Forms.Button();
            this.button_kyhoc = new System.Windows.Forms.Button();
            this.button_monhoc = new System.Windows.Forms.Button();
            this.button_khoa = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_lophoc);
            this.flowLayoutPanel1.Controls.Add(this.button_sv);
            this.flowLayoutPanel1.Controls.Add(this.button_diem);
            this.flowLayoutPanel1.Controls.Add(this.button_gv);
            this.flowLayoutPanel1.Controls.Add(this.button_kyhoc);
            this.flowLayoutPanel1.Controls.Add(this.button_monhoc);
            this.flowLayoutPanel1.Controls.Add(this.button_khoa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(642, 281);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_lophoc
            // 
            this.button_lophoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lophoc.Location = new System.Drawing.Point(3, 3);
            this.button_lophoc.Name = "button_lophoc";
            this.button_lophoc.Size = new System.Drawing.Size(207, 87);
            this.button_lophoc.TabIndex = 0;
            this.button_lophoc.Text = "Lớp học";
            this.button_lophoc.UseVisualStyleBackColor = true;
            this.button_lophoc.Click += new System.EventHandler(this.button_lophoc_Click);
            // 
            // button_sv
            // 
            this.button_sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sv.Location = new System.Drawing.Point(216, 3);
            this.button_sv.Name = "button_sv";
            this.button_sv.Size = new System.Drawing.Size(207, 87);
            this.button_sv.TabIndex = 1;
            this.button_sv.Text = "Sinh Viên";
            this.button_sv.UseVisualStyleBackColor = true;
            // 
            // button_diem
            // 
            this.button_diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_diem.Location = new System.Drawing.Point(429, 3);
            this.button_diem.Name = "button_diem";
            this.button_diem.Size = new System.Drawing.Size(207, 87);
            this.button_diem.TabIndex = 2;
            this.button_diem.Text = "Bảng điểm";
            this.button_diem.UseVisualStyleBackColor = true;
            // 
            // button_gv
            // 
            this.button_gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gv.Location = new System.Drawing.Point(3, 96);
            this.button_gv.Name = "button_gv";
            this.button_gv.Size = new System.Drawing.Size(207, 87);
            this.button_gv.TabIndex = 3;
            this.button_gv.Text = "Giảng viên";
            this.button_gv.UseVisualStyleBackColor = true;
            // 
            // button_kyhoc
            // 
            this.button_kyhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kyhoc.Location = new System.Drawing.Point(216, 96);
            this.button_kyhoc.Name = "button_kyhoc";
            this.button_kyhoc.Size = new System.Drawing.Size(207, 87);
            this.button_kyhoc.TabIndex = 4;
            this.button_kyhoc.Text = "Kỳ học";
            this.button_kyhoc.UseVisualStyleBackColor = true;
            // 
            // button_monhoc
            // 
            this.button_monhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_monhoc.Location = new System.Drawing.Point(429, 96);
            this.button_monhoc.Name = "button_monhoc";
            this.button_monhoc.Size = new System.Drawing.Size(207, 87);
            this.button_monhoc.TabIndex = 5;
            this.button_monhoc.Text = "Môn học";
            this.button_monhoc.UseVisualStyleBackColor = true;
            // 
            // button_khoa
            // 
            this.button_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_khoa.Location = new System.Drawing.Point(3, 189);
            this.button_khoa.Name = "button_khoa";
            this.button_khoa.Size = new System.Drawing.Size(207, 87);
            this.button_khoa.TabIndex = 6;
            this.button_khoa.Text = "Khoa";
            this.button_khoa.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 281);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_lophoc;
        private System.Windows.Forms.Button button_sv;
        private System.Windows.Forms.Button button_diem;
        private System.Windows.Forms.Button button_gv;
        private System.Windows.Forms.Button button_kyhoc;
        private System.Windows.Forms.Button button_monhoc;
        private System.Windows.Forms.Button button_khoa;
    }
}