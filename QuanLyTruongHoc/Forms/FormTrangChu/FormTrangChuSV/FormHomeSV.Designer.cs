namespace QuanLyTruongHoc.Forms.FormTrangChu.FormTrangChuSV
{
    partial class FormHomeSV
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
            this.monDaDk = new System.Windows.Forms.Button();
            this.dangky = new System.Windows.Forms.Button();
            this.thongtincanhan = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.monDaDk);
            this.flowLayoutPanel1.Controls.Add(this.dangky);
            this.flowLayoutPanel1.Controls.Add(this.thongtincanhan);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // monDaDk
            // 
            this.monDaDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monDaDk.Location = new System.Drawing.Point(3, 3);
            this.monDaDk.Name = "monDaDk";
            this.monDaDk.Size = new System.Drawing.Size(251, 83);
            this.monDaDk.TabIndex = 0;
            this.monDaDk.Text = "Danh sách lớp học đã đăng ký";
            this.monDaDk.UseVisualStyleBackColor = true;
            this.monDaDk.Click += new System.EventHandler(this.monDaDk_Click);
            // 
            // dangky
            // 
            this.dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky.Location = new System.Drawing.Point(260, 3);
            this.dangky.Name = "dangky";
            this.dangky.Size = new System.Drawing.Size(251, 83);
            this.dangky.TabIndex = 1;
            this.dangky.Text = "Đăng ký lớp học";
            this.dangky.UseVisualStyleBackColor = true;
            this.dangky.Click += new System.EventHandler(this.dangky_Click);
            // 
            // thongtincanhan
            // 
            this.thongtincanhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtincanhan.Location = new System.Drawing.Point(517, 3);
            this.thongtincanhan.Name = "thongtincanhan";
            this.thongtincanhan.Size = new System.Drawing.Size(251, 83);
            this.thongtincanhan.TabIndex = 2;
            this.thongtincanhan.Text = "Thông tin cá nhân";
            this.thongtincanhan.UseVisualStyleBackColor = true;
            this.thongtincanhan.Click += new System.EventHandler(this.thongtincanhan_Click);
            // 
            // FormHomeSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormHomeSV";
            this.Text = "FormHomeSV";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button monDaDk;
        private System.Windows.Forms.Button dangky;
        private System.Windows.Forms.Button thongtincanhan;
    }
}