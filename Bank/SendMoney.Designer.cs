namespace Bank
{
    partial class SendMoney
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
            button2 = new Button();
            balanceLabel = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            usernameLabel = new Label();
            logoutButton = new Button();
            currUserIdLabel = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(448, 283);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(242, 46);
            button2.TabIndex = 22;
            button2.Text = "Transfer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 14F);
            balanceLabel.Location = new Point(335, 223);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(72, 25);
            balanceLabel.TabIndex = 21;
            balanceLabel.Text = "0 $RZD";
            balanceLabel.Click += balanceLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(247, 223);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 20;
            label3.Text = "Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 19;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 20);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 18;
            label2.Text = "Your ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(76, 5);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(18, 304);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(141, 23);
            logoutButton.TabIndex = 14;
            logoutButton.Text = "Return to dashboard";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // currUserIdLabel
            // 
            currUserIdLabel.AutoSize = true;
            currUserIdLabel.Location = new Point(76, 20);
            currUserIdLabel.Name = "currUserIdLabel";
            currUserIdLabel.Size = new Size(85, 15);
            currUserIdLabel.TabIndex = 13;
            currUserIdLabel.Text = "Current user id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 306);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 289);
            label4.Name = "label4";
            label4.Size = new Size(169, 15);
            label4.TabIndex = 24;
            label4.Text = "Enter amount of $RZD to send:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(5, 47);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 199);
            listBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Lower;
            textBox2.Location = new Point(5, 250);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 26;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 272);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 27;
            label5.Text = "Search for user:";
            // 
            // SendMoney
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(balanceLabel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(usernameLabel);
            Controls.Add(logoutButton);
            Controls.Add(currUserIdLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SendMoney";
            Text = "SendMoney";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label balanceLabel;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label usernameLabel;
        private Button logoutButton;
        private Label currUserIdLabel;
        private TextBox textBox1;
        private Label label4;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label label5;
    }
}