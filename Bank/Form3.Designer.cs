namespace Bank
{
    partial class Form3
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
            SuspendLayout();
            // 
            // currUserIdLabel
            // 
            currUserIdLabel.AutoSize = true;
            currUserIdLabel.Location = new Point(226, 106);
            currUserIdLabel.Name = "currUserIdLabel";
            currUserIdLabel.Size = new Size(85, 15);
            currUserIdLabel.TabIndex = 0;
            currUserIdLabel.Text = "Current user id";
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(492, 326);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoutButton);
            Controls.Add(currUserIdLabel);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currUserIdLabel;
        private Button logoutButton;
    }
}