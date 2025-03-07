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
    public partial class SendMoney : Form
    {
        decimal bal = -1;
        string username;
        public SendMoney()
        {
            
            InitializeComponent();
            listBox1.Items.AddRange(DBAPI.GetAllUsernames().ToArray());

            foreach(string user in listBox1.Items)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                listBox1.Items.AddRange(DBAPI.GetAllUsernames().ToArray());
                return;
            }
            else
            {
                try
                {
                    int searchedId = int.Parse(textBox2.Text);
                    foreach (string user in listBox1.Items)
                    {
                        //search for users
                        if (user == "admin" || user == DBAPI.GetUserInfo(DBAPI.CurrentUserId, null))
                        {
                            listBox1.Items.Remove(user);
                            continue;
                        }
                        if(!DBAPI.GetUserInfo(null, user).ToString().Contains(searchedId.ToString()))
                        {
                            listBox1.Items.Remove(user);
                            continue;
                        }
                    }
                }
                catch
                {
                    foreach (string user in listBox1.Items)
                    {
                        //search for users
                        if (!user.Contains(textBox2.Text) || user == "admin" || user == DBAPI.GetUserInfo(DBAPI.CurrentUserId, null))
                        {
                            listBox1.Items.Remove(user);
                            continue;
                        }
                    }
                }
            }

        }
    }
}
