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
using Microsoft.VisualBasic;

namespace Bank
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {

            InitializeComponent();
            currUserIdLabel.Text = DBAPI.CurrentUserId.ToString();
            balanceLabel.Text = DBAPI.GetUserBalance(DBAPI.CurrentUserId, null).ToString() + " R$";

            if (DBAPI.CurrentUserId == -1)
            {
                MessageBox.Show("You are not logged in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                loginForm login = new loginForm();
                login.Show();
                this.Hide();
                return;

            }
            string currUsername = DBAPI.GetUserInfo(DBAPI.CurrentUserId, null);
            if (currUsername != null)
            {
                usernameLabel.Text = currUsername;
            }
            else
            {
                usernameLabel.Text = "Username not found";
            }
            if (currUsername == "admin")
            {
                adminPageButton.Visible = true;
            }
            else
            {
                adminPageButton.Visible = false;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DBAPI.CurrentUserId = -1;
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("Form3 closed");

        }


        private void adminPageButton_Click(object sender, EventArgs e)
        {
            AdminPage admin = new AdminPage();
            admin.Show();
            this.Hide();
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountControl accountControl = new();
            accountControl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal depositAmount = Convert.ToDecimal(Interaction.InputBox("How much do you wish to deposit?", "Deposit", "Enter amount:"));
                DBAPI.AlterBalance(DBAPI.CurrentUserId, null, depositAmount);
                balanceLabel.Text = DBAPI.GetUserBalance(DBAPI.CurrentUserId, null).ToString() + " R$";
            }
            catch
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
