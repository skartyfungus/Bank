using System.Diagnostics;

namespace Bank
{
    public partial class registerAccountForm : Form
    {
        public registerAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "" || passwordInput.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBAPI.Register(usernameInput.Text, passwordInput.Text);
            usernameInput.Text = "";
            passwordInput.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginPageButton_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Hide();
            login.Show();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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
