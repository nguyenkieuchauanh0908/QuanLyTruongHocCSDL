namespace QuanLyTruongHoc
{
    partial class MainForm
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
            this.sign_in_role = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sign_in_qtv = new System.Windows.Forms.RadioButton();
            this.sign_in_teacher = new System.Windows.Forms.RadioButton();
            this.sign_in_student = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sign_in_role.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_in_role
            // 
            this.sign_in_role.AutoSize = true;
            this.sign_in_role.Controls.Add(this.flowLayoutPanel1);
            this.sign_in_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_role.Location = new System.Drawing.Point(8, 91);
            this.sign_in_role.Name = "sign_in_role";
            this.sign_in_role.Size = new System.Drawing.Size(235, 159);
            this.sign_in_role.TabIndex = 0;
            this.sign_in_role.TabStop = false;
            this.sign_in_role.Text = "Bạn là";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.sign_in_qtv);
            this.flowLayoutPanel1.Controls.Add(this.sign_in_teacher);
            this.flowLayoutPanel1.Controls.Add(this.sign_in_student);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 128);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // sign_in_qtv
            // 
            this.sign_in_qtv.AutoSize = true;
            this.sign_in_qtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_qtv.Location = new System.Drawing.Point(3, 3);
            this.sign_in_qtv.Name = "sign_in_qtv";
            this.sign_in_qtv.Size = new System.Drawing.Size(156, 30);
            this.sign_in_qtv.TabIndex = 1;
            this.sign_in_qtv.TabStop = true;
            this.sign_in_qtv.Text = "Quản trị viên";
            this.sign_in_qtv.UseVisualStyleBackColor = true;
            // 
            // sign_in_teacher
            // 
            this.sign_in_teacher.AutoSize = true;
            this.sign_in_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_teacher.Location = new System.Drawing.Point(3, 39);
            this.sign_in_teacher.Name = "sign_in_teacher";
            this.sign_in_teacher.Size = new System.Drawing.Size(125, 30);
            this.sign_in_teacher.TabIndex = 0;
            this.sign_in_teacher.TabStop = true;
            this.sign_in_teacher.Text = "Giáo viên";
            this.sign_in_teacher.UseVisualStyleBackColor = true;
            // 
            // sign_in_student
            // 
            this.sign_in_student.AutoSize = true;
            this.sign_in_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_student.Location = new System.Drawing.Point(3, 75);
            this.sign_in_student.Name = "sign_in_student";
            this.sign_in_student.Size = new System.Drawing.Size(123, 30);
            this.sign_in_student.TabIndex = 2;
            this.sign_in_student.TabStop = true;
            this.sign_in_student.Text = "Sinh viên";
            this.sign_in_student.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // input_username
            // 
            this.input_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_username.Location = new System.Drawing.Point(274, 6);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(235, 32);
            this.input_username.TabIndex = 3;
            // 
            // input_password
            // 
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.Location = new System.Drawing.Point(274, 48);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '*';
            this.input_password.Size = new System.Drawing.Size(235, 32);
            this.input_password.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.sign_in_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.input_password);
            this.panel1.Controls.Add(this.sign_in_role);
            this.panel1.Controls.Add(this.input_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(278, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 254);
            this.panel1.TabIndex = 5;
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.Location = new System.Drawing.Point(337, 188);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(147, 36);
            this.sign_in_btn.TabIndex = 5;
            this.sign_in_btn.Text = "Đăng nhập";
            this.sign_in_btn.UseVisualStyleBackColor = true;
            this.sign_in_btn.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ TRƯỜNG HỌC";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sign_in_role.ResumeLayout(false);
            this.sign_in_role.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sign_in_role;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton sign_in_qtv;
        private System.Windows.Forms.RadioButton sign_in_teacher;
        private System.Windows.Forms.RadioButton sign_in_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.Button button1;
    }
}

