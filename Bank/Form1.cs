using System.Diagnostics;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAPI.Register(usernameInput.Text, passwordInput.Text);
            usernameInput.Text = "";
            passwordInput.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            if (!form2.Visible && !form3.Visible)
            {
                Application.Exit();
            }

        }
    }
}
