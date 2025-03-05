namespace Bank
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registerPageButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // registerPageButton
            // 
            registerPageButton.Location = new Point(379, 306);
            registerPageButton.Name = "registerPageButton";
            registerPageButton.Size = new Size(95, 23);
            registerPageButton.TabIndex = 11;
            registerPageButton.Text = "Go to register";
            registerPageButton.UseVisualStyleBackColor = true;
            registerPageButton.Click += registerPageButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(273, 218);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(273, 149);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "Username";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(273, 236);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(100, 23);
            passwordInput.TabIndex = 8;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(273, 167);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(100, 23);
            usernameInput.TabIndex = 7;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(379, 236);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerPageButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(loginButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerPageButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordInput;
        private TextBox usernameInput;
        private Button loginButton;
    }
}