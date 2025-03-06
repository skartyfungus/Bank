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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            listBox1.Items.AddRange(DBAPI.GetAllUsernames().ToArray());
            Debug.WriteLine(DBAPI.CurrentUserId);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Debug.WriteLine(listBox1.SelectedItem.ToString());
                label4.Text = DBAPI.GetUserInfo(null, listBox1.SelectedItem.ToString());
                label3.Text = DBAPI.GetUserBalance(null, listBox1.SelectedItem.ToString()).ToString();
            }
            else
            {
                label4.Text = "No user selected";
                label3.Text = "No user selected";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a user to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirmBoxResult = MessageBox.Show($"Do you realy want to remove user {listBox1.SelectedItem.ToString()}?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmBoxResult == DialogResult.No)
                {
                    return;
                }

                bool success = DBAPI.RemoveUser(listBox1.SelectedItem.ToString());
                if (success)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);

                    MessageBox.Show("Successfully removed user.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to remove user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            int delUsrIndex = 0;
            List<string> removedUsers = new List<string>();

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No users to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmBoxResult = MessageBox.Show("Do you realy want to remove ALL users?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmBoxResult == DialogResult.No)
            {
                return;
            }
            foreach (string username in listBox1.Items)
            {
                bool success = DBAPI.RemoveUser(username);
                if (success)
                {
                    removedUsers.Add(username);
                    delUsrIndex++;
                }
                else
                {
                    MessageBox.Show($"Failed to remove user {username}, press ok to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            foreach (string username in removedUsers)
            {
                listBox1.Items.Remove(username);
            }
            MessageBox.Show($"Successfully removed {delUsrIndex} users.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toDashboardForm_Click(object sender, EventArgs e)
        {


            if (DBAPI.CurrentUserId != -1)
            {
                dashboardForm dashboard = new dashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not logged in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button4_Click(object sender, EventArgs e) // Add
        {
            if (listBox1.SelectedItem != null)
            {
                if (string.IsNullOrEmpty(amountToAdd.Text) || float.Parse(amountToAdd.Text) <= 0)
                {
                    amountToAdd.Text = "";
                    return;
                }

                // Print a message for debugging
                Debug.WriteLine("Attempting to add balance.");

                // Update balance in database
                DBAPI.AlterBalance(int.Parse(DBAPI.GetUserInfo(null, listBox1.SelectedItem.ToString())), null, Convert.ToDecimal(amountToAdd.Text));

                // Clear the input text box
                amountToAdd.Text = "";

                // Fetch the updated balance from the database and update the label
                // Fetch the updated balance from the database
                decimal updatedBalance = DBAPI.GetUserBalance(null, listBox1.SelectedItem.ToString());
                Debug.WriteLine("Updated balance fetched from DB: " + updatedBalance);

                // Update the label with the latest balance
                label3.Text = updatedBalance.ToString();
                Debug.WriteLine("Updated balance: " + updatedBalance);
            }
        }


        private void amountToAdd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(amountToAdd.Text);
            }
            catch
            {
                amountToAdd.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e) // Add
        {
            if (listBox1.SelectedItem != null)
            {
                if (string.IsNullOrEmpty(amountToAdd.Text) || Convert.ToDecimal(amountToAdd.Text) <= 0)
                {
                    amountToAdd.Text = "";
                    return;
                }
                amountToAdd.Text = "-" + amountToAdd.Text;

                // Print a message for debugging
                Debug.WriteLine("Attempting to subtract balance.");

                // Update balance in database
                DBAPI.AlterBalance(int.Parse(DBAPI.GetUserInfo(null, listBox1.SelectedItem.ToString())), null, Convert.ToDecimal(amountToAdd.Text));

                // Clear the input text box
                amountToAdd.Text = "";

                // Fetch the updated balance from the database and update the label
                // Fetch the updated balance from the database
                decimal updatedBalance = DBAPI.GetUserBalance(null, listBox1.SelectedItem.ToString());
                Debug.WriteLine("Updated balance fetched from DB: " + updatedBalance);

                // Update the label with the latest balance
                label3.Text = updatedBalance.ToString();
                Debug.WriteLine("Updated balance: " + updatedBalance);
            }
        }
    }
}
