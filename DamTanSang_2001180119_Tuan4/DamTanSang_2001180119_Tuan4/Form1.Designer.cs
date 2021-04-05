namespace DamTanSang_2001180119_Tuan4
{
    partial class Form1
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
            this.lb_tennguoidung = new System.Windows.Forms.Label();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tennguoidung
            // 
            this.lb_tennguoidung.AutoSize = true;
            this.lb_tennguoidung.Location = new System.Drawing.Point(152, 16);
            this.lb_tennguoidung.Name = "lb_tennguoidung";
            this.lb_tennguoidung.Size = new System.Drawing.Size(86, 13);
            this.lb_tennguoidung.TabIndex = 0;
            this.lb_tennguoidung.Text = "Tên Người Dùng";
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Location = new System.Drawing.Point(154, 70);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(53, 13);
            this.lb_matkhau.TabIndex = 1;
            this.lb_matkhau.Text = "Mật Khẩu";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(155, 36);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(166, 20);
            this.txt_Ten.TabIndex = 2;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(155, 94);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(166, 20);
            this.txt_MatKhau.TabIndex = 3;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_DangNhap.Location = new System.Drawing.Point(155, 138);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Huy.Location = new System.Drawing.Point(246, 138);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(351, 186);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.lb_matkhau);
            this.Controls.Add(this.lb_tennguoidung);
            this.Name = "Form1";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tennguoidung;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Huy;
    }
}

