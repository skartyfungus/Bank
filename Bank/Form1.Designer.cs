namespace Bank
{
    partial class registerAccountForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registerButton = new Button();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginPageButton = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Location = new Point(405, 283);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(189, 31);
            registerButton.TabIndex = 0;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += button1_Click;
            // 
            // usernameInput
            // 
            usernameInput.CharacterCasing = CharacterCasing.Lower;
            usernameInput.Location = new Point(284, 191);
            usernameInput.Margin = new Padding(3, 4, 3, 4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(114, 27);
            usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(284, 283);
            passwordInput.Margin = new Padding(3, 4, 3, 4);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(114, 27);
            passwordInput.TabIndex = 2;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(284, 167);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(284, 259);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // loginPageButton
            // 
            loginPageButton.Location = new Point(405, 374);
            loginPageButton.Margin = new Padding(3, 4, 3, 4);
            loginPageButton.Name = "loginPageButton";
            loginPageButton.Size = new Size(189, 31);
            loginPageButton.TabIndex = 5;
            loginPageButton.Text = "Go to login";
            loginPageButton.UseVisualStyleBackColor = true;
            loginPageButton.Click += loginPageButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(284, 317);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show/Hide";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // registerAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(checkBox1);
            Controls.Add(loginPageButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(registerButton);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "registerAccountForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Register Account";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginPageButton;
        private CheckBox checkBox1;
    }
}
