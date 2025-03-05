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
    public partial class Form2 : Form
    {


        int currUserId;
        public Form2()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (DBAPI.Login(usernameInput.Text, passwordInput.Text))
            {
                Form3 form3 = new Form3();
                form3.Show();
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();


        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            Form3 form3 = new Form3();
            if (!form1.Visible && !form3.Visible)
            {
                Application.Exit();
            }
            
        }
    }

}
