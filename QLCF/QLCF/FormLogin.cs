using QLCF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login_function();
        }

        private void Login_function()
        {
            bool check = Employee.Login(txt_Email.Text, txt_password.Text);
            if (check == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Visible = false;
                FormMain form = new FormMain();
                form.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //protected override bool ProcessDialogKey(Keys keyData)
        //{
        //    if (keyData == Keys.Enter)
        //    {
        //        Login_function();
        //        return true;
        //    }
        //    else return false;
        //}

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_function();
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_function();
            }
        }
    }
}