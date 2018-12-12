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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployee form = new FormEmployee();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btn_EmployeeManagement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormEmployee form = new FormEmployee();
            form.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormBranch form = new FormBranch();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btn_Branch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormBranch form = new FormBranch();
            form.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormFood form = new FormFood();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormFood form = new FormFood();
            form.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormDrink form = new FormDrink();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btn_Drink_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormDrink form = new FormDrink();
            form.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormRevenue form = new FormRevenue();
            form.ShowDialog();
            this.Visible = true;
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormRevenue form = new FormRevenue();
            form.ShowDialog();
            this.Visible = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_realTime.Text = DateTime.Now.ToString();
        }
    }
}
