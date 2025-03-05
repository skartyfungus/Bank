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
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
            currUserIdLabel.Text = DBAPI.CurrentUserId.ToString();
            if (DBAPI.CurrentUserId == -1)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }     
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DBAPI.CurrentUserId = -1;
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            if (!form1.Visible && !form2.Visible)
            {
                Application.Exit();
            }

        }
    }
}
