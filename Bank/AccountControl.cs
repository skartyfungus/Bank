using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AccountControl : Form
    {
        public AccountControl()
        {
            InitializeComponent();
            usernameLabel.Text = DBAPI.GetUserInfo(DBAPI.CurrentUserId, null);
            currUserIdLabel.Text = DBAPI.CurrentUserId.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill in your current password aswell as your new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (DBAPI.Login(DBAPI.GetUserInfo(DBAPI.CurrentUserId, null), textBox1.Text))
            {
                DialogResult confirmBoxResult = MessageBox.Show("Are you sure you want to change your password?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmBoxResult == DialogResult.No)
                {
                    return;
                }
                DBAPI.ChangePassword(DBAPI.CurrentUserId, textBox2.Text);
                AccountControl reload = new();
                reload.Show();
                this.Hide();

            }
            else
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill in your current password aswell as your new username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DBAPI.Login(DBAPI.GetUserInfo(DBAPI.CurrentUserId, null), textBox1.Text))
            {
                DialogResult confirmBoxResult = MessageBox.Show("Are you sure you want to change your username?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmBoxResult == DialogResult.No)
                {
                    return;
                }
                DBAPI.ChangeUsername(DBAPI.CurrentUserId, textBox3.Text);
                AccountControl reload = new();
                reload.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboardForm dashboard = new();
            dashboard.Show();
            this.Hide();
        }
    }
}
