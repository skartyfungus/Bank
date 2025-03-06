using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class loginForm : Form
    {


        int currUserId;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (DBAPI.Login(usernameInput.Text, passwordInput.Text))
            {
                dashboardForm dashboard = new dashboardForm();
                Debug.WriteLine(usernameInput.Text);
                dashboard.Show();

                this.Hide();

            }
            Debug.WriteLine(DBAPI.CurrentUserId);
        }

        public void HideIt()
        {
            this.Close();
        }

        private void registerPageButton_Click(object sender, EventArgs e)
        {
            registerAccountForm register = new registerAccountForm();
            register.Show();
            this.Hide();


        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                passwordInput.UseSystemPasswordChar = false;
            }
            else
            {
                passwordInput.UseSystemPasswordChar = true;
            }
        }
    }

}
