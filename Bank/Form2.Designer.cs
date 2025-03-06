namespace Bank
{
    partial class loginForm
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
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // registerPageButton
            // 
            registerPageButton.Location = new Point(403, 366);
            registerPageButton.Margin = new Padding(3, 4, 3, 4);
            registerPageButton.Name = "registerPageButton";
            registerPageButton.Size = new Size(168, 31);
            registerPageButton.TabIndex = 11;
            registerPageButton.Text = "Go to register";
            registerPageButton.UseVisualStyleBackColor = true;
            registerPageButton.Click += registerPageButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(282, 249);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(282, 157);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "Username";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(282, 273);
            passwordInput.Margin = new Padding(3, 4, 3, 4);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(114, 27);
            passwordInput.TabIndex = 8;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // usernameInput
            // 
            usernameInput.CharacterCasing = CharacterCasing.Lower;
            usernameInput.Location = new Point(282, 181);
            usernameInput.Margin = new Padding(3, 4, 3, 4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(114, 27);
            usernameInput.TabIndex = 7;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(403, 273);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(168, 31);
            loginButton.TabIndex = 6;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(282, 307);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Show/Hide";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(checkBox1);
            Controls.Add(registerPageButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(loginButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "loginForm";
            Text = "Log In";
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
        private CheckBox checkBox1;
    }
}