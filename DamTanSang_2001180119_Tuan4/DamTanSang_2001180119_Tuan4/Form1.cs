using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamTanSang_2001180119_Tuan4
{
    public partial class Form1 : Form
    {
        QL_Nguoidung CauHinh = new QL_Nguoidung();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lb_tennguoidung.Text.ToLower());
                txt_Ten.Focus();
                return;

            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lb_matkhau.Text.ToLower());
                txt_MatKhau.Focus();
                return;
            }
            int kq = CauHinh.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuổi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }

        }
        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txt_Ten.Text, txt_MatKhau.Text);
            if (result == 10)
            {
                MessageBox.Show(" Sai " + lb_tennguoidung.Text + " Hoặc " + lb_matkhau.Text);
                return;
            }
            else if (result == 20)
            {
                MessageBox.Show("Tài Khoản bị khóa");
                return;
            }
            else
            {
                FormMain main = new FormMain();
                main.Show();
                this.Hide();
            }
        }
        public void ProcessConfig()
        {
            frCauHinh cauhinh = new frCauHinh();
            cauhinh.Show();
            this.Hide();
        }
    }
}
