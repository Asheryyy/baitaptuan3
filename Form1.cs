using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtDN.Text == "admin" && txtMK.Text == "admin") // thay admin = tai khoan tren database
            {
                MessageBox.Show("Đăng nhập thành công !");
                this.Hide();
                hienthi f = new hienthi();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu , vui lòng nhập lại");
            }
        }

        private void btnĐK_Click(object sender, EventArgs e)
        {
            dki f = new dki();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked)
            {
                txtMK.PasswordChar = '\0';
                picShow.Hide();
                picHide.Show();
            }
            else
            {
                txtMK.PasswordChar = '*';
                picShow.Show();
                picHide.Hide();
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
        }

        private void lblTK_Click(object sender, EventArgs e)
        {

        }

        private void lblMK_Click(object sender, EventArgs e)
        {

        }
    }
}
