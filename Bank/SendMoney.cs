using Bank;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class SendMoney : Form
    {
        decimal bal = -1;
        string username;
        public SendMoney()
        {

            InitializeComponent();
            listBox1.Items.AddRange(DBAPI.GetAllUsernames().ToArray());

            foreach (string user in listBox1.Items)
            {
                if (user == DBAPI.GetUserInfo(DBAPI.CurrentUserId, null) || user == "admin")
                {
                    listBox1.Items.Remove(user);
                    break;
                }
            }

            currUserIdLabel.Text = DBAPI.CurrentUserId.ToString();
            if (string.IsNullOrWhiteSpace(DBAPI.GetUserInfo(DBAPI.CurrentUserId, null)))
            {
                username = "Username not found";
            }

            usernameLabel.Text = username;
        }

        private async void textBox2_TextChanged(object sender, EventArgs e)
        {
            await SearchUsersAsync(textBox2.Text);
        }

        private async Task SearchUsersAsync(string searchQuery)
        {
            searchQuery = searchQuery.ToLower(); // Convert input to lowercase for case-insensitive search
            listBox1.Items.Clear();

            List<string> allUsers = await Task.Run(() =>
            {
                return DBAPI.GetAllUsernames()
                    .Where(user => user != "admin" && user != DBAPI.GetUserInfo(DBAPI.CurrentUserId, null)) // Exclude admin & current user
                    .Where(user =>
                            user.ToLower().Contains(searchQuery) ||
                            DBAPI.GetUserInfo(null, user).ToLower().Contains(searchQuery) // Search by username or user ID
                    )
                    .ToList();
            });

            listBox1.Items.AddRange(allUsers.ToArray());
        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            dashboardForm dash = new();
            dash.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}