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
            button2.Location = new Point(512, 377);
            button2.Name = "button2";
            button2.Size = new Size(276, 61);
            button2.TabIndex = 22;
            button2.Text = "Transfer";
            button2.UseVisualStyleBackColor = true;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 38.2F);
            balanceLabel.Location = new Point(588, 241);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(200, 86);
            balanceLabel.TabIndex = 21;
            balanceLabel.Text = "0 RZ$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 38.2F);
            label3.Location = new Point(313, 241);
            label3.Name = "label3";
            label3.Size = new Size(269, 86);
            label3.TabIndex = 20;
            label3.Text = "Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 19;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 27);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 18;
            label2.Text = "Your ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(87, 7);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 15;
            usernameLabel.Text = "Username";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(21, 406);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(161, 31);
            logoutButton.TabIndex = 14;
            logoutButton.Text = "Return to dashboard";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // currUserIdLabel
            // 
            currUserIdLabel.AutoSize = true;
            currUserIdLabel.Location = new Point(87, 27);
            currUserIdLabel.Name = "currUserIdLabel";
            currUserIdLabel.Size = new Size(105, 20);
            currUserIdLabel.TabIndex = 13;
            currUserIdLabel.Text = "Current user id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 408);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 385);
            label4.Name = "label4";
            label4.Size = new Size(213, 20);
            label4.TabIndex = 24;
            label4.Text = "Enter amount of $RZD to send:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(269, 264);
            listBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Lower;
            textBox2.Location = new Point(6, 333);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 27);
            textBox2.TabIndex = 26;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 363);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 27;
            label5.Text = "Search for user:";
            // 
            // SendMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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