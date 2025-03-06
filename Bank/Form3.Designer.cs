namespace Bank
{
    partial class dashboardForm
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
            currUserIdLabel = new Label();
            logoutButton = new Button();
            usernameLabel = new Label();
            adminPageButton = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            balanceLabel = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // currUserIdLabel
            // 
            currUserIdLabel.AutoSize = true;
            currUserIdLabel.Location = new Point(146, 79);
            currUserIdLabel.Name = "currUserIdLabel";
            currUserIdLabel.Size = new Size(105, 20);
            currUserIdLabel.TabIndex = 0;
            currUserIdLabel.Text = "Current user id";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(90, 364);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(161, 31);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(146, 59);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // adminPageButton
            // 
            adminPageButton.Location = new Point(91, 402);
            adminPageButton.Name = "adminPageButton";
            adminPageButton.Size = new Size(160, 29);
            adminPageButton.TabIndex = 3;
            adminPageButton.Text = "Admin Page";
            adminPageButton.UseVisualStyleBackColor = true;
            adminPageButton.Click += adminPageButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(91, 328);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 4;
            button1.Text = "Account control";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 59);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 79);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Your ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 38.2F);
            label3.Location = new Point(90, 171);
            label3.Name = "label3";
            label3.Size = new Size(269, 86);
            label3.TabIndex = 7;
            label3.Text = "Balance:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 38.2F);
            balanceLabel.Location = new Point(365, 171);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(163, 86);
            balanceLabel.TabIndex = 8;
            balanceLabel.Text = "0 R$";
            // 
            // button2
            // 
            button2.Location = new Point(365, 296);
            button2.Name = "button2";
            button2.Size = new Size(276, 61);
            button2.TabIndex = 9;
            button2.Text = "Deposit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(365, 364);
            button3.Name = "button3";
            button3.Size = new Size(276, 61);
            button3.TabIndex = 10;
            button3.Text = "Withdraw";
            button3.UseVisualStyleBackColor = true;
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(balanceLabel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(adminPageButton);
            Controls.Add(usernameLabel);
            Controls.Add(logoutButton);
            Controls.Add(currUserIdLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "dashboardForm";
            Text = "Dashboard";
            Load += dashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currUserIdLabel;
        private Button logoutButton;
        private Label usernameLabel;
        private Button adminPageButton;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label balanceLabel;
        private Button button2;
        private Button button3;
    }
}