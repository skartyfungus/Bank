namespace Bank
{
    partial class AdminPage
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            toDashboardForm = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            amountToAdd = new TextBox();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 289);
            button1.Name = "button1";
            button1.Size = new Size(234, 29);
            button1.TabIndex = 0;
            button1.Text = "Clear transactions";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(62, 254);
            button2.Name = "button2";
            button2.Size = new Size(234, 29);
            button2.TabIndex = 1;
            button2.Text = "Clear all users";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(62, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(62, 12);
            button3.Name = "button3";
            button3.Size = new Size(150, 30);
            button3.TabIndex = 3;
            button3.Text = "Delete selected user";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // toDashboardForm
            // 
            toDashboardForm.Location = new Point(62, 360);
            toDashboardForm.Name = "toDashboardForm";
            toDashboardForm.Size = new Size(234, 29);
            toDashboardForm.TabIndex = 4;
            toDashboardForm.Text = "Return to dashboard";
            toDashboardForm.UseVisualStyleBackColor = true;
            toDashboardForm.Click += toDashboardForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 57);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 5;
            label1.Text = "User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 77);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 77);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 7;
            label3.Text = "No user selected";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 57);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 8;
            label4.Text = "No user selected";
            // 
            // amountToAdd
            // 
            amountToAdd.Location = new Point(222, 100);
            amountToAdd.Name = "amountToAdd";
            amountToAdd.Size = new Size(185, 27);
            amountToAdd.TabIndex = 9;
            amountToAdd.TextChanged += amountToAdd_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(222, 132);
            button4.Name = "button4";
            button4.Size = new Size(185, 29);
            button4.TabIndex = 10;
            button4.Text = "Add amount";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(222, 167);
            button5.Name = "button5";
            button5.Size = new Size(185, 29);
            button5.TabIndex = 11;
            button5.Text = "Subtract amount";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(amountToAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toDashboardForm);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminPage";
            Text = "AdminPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button toDashboardForm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox amountToAdd;
        private Button button4;
        private Button button5;
    }
}