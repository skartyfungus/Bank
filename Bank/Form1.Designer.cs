namespace Bank
{
    partial class Form1
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
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Location = new Point(337, 327);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 0;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += button1_Click;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(231, 258);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(100, 23);
            usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(231, 327);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(100, 23);
            passwordInput.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(231, 240);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(231, 309);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // loginPageButton
            // 
            loginPageButton.Location = new Point(337, 395);
            loginPageButton.Name = "loginPageButton";
            loginPageButton.Size = new Size(75, 23);
            loginPageButton.TabIndex = 5;
            loginPageButton.Text = "Go to login";
            loginPageButton.UseVisualStyleBackColor = true;
            loginPageButton.Click += loginPageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPageButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(registerButton);
            Name = "Form1";
            Text = "Form1";
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
    }
}
