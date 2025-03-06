namespace Bank
{
    partial class AccountControl
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            usernameLabel = new Label();
            currUserIdLabel = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 0;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(493, 94);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show/Hide";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(238, 232);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(105, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Show/Hide";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 71);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "Current Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 6;
            label3.Text = "New Password";
            // 
            // button1
            // 
            button1.Location = new Point(12, 262);
            button1.Name = "button1";
            button1.Size = new Size(220, 29);
            button1.TabIndex = 7;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(460, 262);
            button2.Name = "button2";
            button2.Size = new Size(220, 29);
            button2.TabIndex = 11;
            button2.Text = "Change Username";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 206);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 10;
            label2.Text = "New Username";
            // 
            // textBox3
            // 
            textBox3.CharacterCasing = CharacterCasing.Lower;
            textBox3.Location = new Point(460, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 337);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 15;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(308, 357);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 14;
            label5.Text = "Your ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(371, 337);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 13;
            usernameLabel.Text = "Username";
            // 
            // currUserIdLabel
            // 
            currUserIdLabel.AutoSize = true;
            currUserIdLabel.Location = new Point(371, 357);
            currUserIdLabel.Name = "currUserIdLabel";
            currUserIdLabel.Size = new Size(105, 20);
            currUserIdLabel.TabIndex = 12;
            currUserIdLabel.Text = "Current user id";
            // 
            // button3
            // 
            button3.Location = new Point(584, 385);
            button3.Name = "button3";
            button3.Size = new Size(166, 29);
            button3.TabIndex = 16;
            button3.Text = "Return to dashboard";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AccountControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(usernameLabel);
            Controls.Add(currUserIdLabel);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AccountControl";
            Text = "Account Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label usernameLabel;
        private Label currUserIdLabel;
        private Button button3;
    }
}