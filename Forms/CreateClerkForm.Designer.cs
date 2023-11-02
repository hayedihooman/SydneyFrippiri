namespace SydneyFrippiri.Forms
{
    partial class CreateClerkForm
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
            label1 = new Label();
            textBox_FName = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            textBox_LName = new TextBox();
            checkBox_IsActive = new CheckBox();
            textBox_email = new TextBox();
            comboBox_Role = new ComboBox();
            textBox_PWD = new TextBox();
            label9 = new Label();
            label12 = new Label();
            textBox_Login = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 21);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Add User";
            // 
            // textBox_FName
            // 
            textBox_FName.Location = new Point(161, 87);
            textBox_FName.Name = "textBox_FName";
            textBox_FName.Size = new Size(158, 23);
            textBox_FName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 90);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "User First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 217);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 169);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 7;
            label7.Text = "EMail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 122);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 8;
            label8.Text = "User Last Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(107, 212);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 11;
            label11.Text = "Role";
            // 
            // textBox_LName
            // 
            textBox_LName.Location = new Point(161, 124);
            textBox_LName.Name = "textBox_LName";
            textBox_LName.Size = new Size(158, 23);
            textBox_LName.TabIndex = 2;
            // 
            // checkBox_IsActive
            // 
            checkBox_IsActive.AutoSize = true;
            checkBox_IsActive.Location = new Point(390, 213);
            checkBox_IsActive.Name = "checkBox_IsActive";
            checkBox_IsActive.Size = new Size(70, 19);
            checkBox_IsActive.TabIndex = 7;
            checkBox_IsActive.Text = "Is Active";
            checkBox_IsActive.UseVisualStyleBackColor = true;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(161, 169);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(476, 23);
            textBox_email.TabIndex = 5;
            // 
            // comboBox_Role
            // 
            comboBox_Role.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Role.FormattingEnabled = true;
            comboBox_Role.Items.AddRange(new object[] { "Clerk", "Administrator" });
            comboBox_Role.Location = new Point(161, 209);
            comboBox_Role.Name = "comboBox_Role";
            comboBox_Role.Size = new Size(156, 23);
            comboBox_Role.TabIndex = 6;
            // 
            // textBox_PWD
            // 
            textBox_PWD.Location = new Point(479, 122);
            textBox_PWD.Name = "textBox_PWD";
            textBox_PWD.Size = new Size(158, 23);
            textBox_PWD.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(390, 125);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 18;
            label9.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(390, 93);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 17;
            label12.Text = "Login ID";
            // 
            // textBox_Login
            // 
            textBox_Login.Location = new Point(479, 85);
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(158, 23);
            textBox_Login.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(267, 269);
            button1.Name = "button1";
            button1.Size = new Size(180, 36);
            button1.TabIndex = 20;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateClerkForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 328);
            Controls.Add(button1);
            Controls.Add(textBox_PWD);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(textBox_Login);
            Controls.Add(comboBox_Role);
            Controls.Add(textBox_email);
            Controls.Add(checkBox_IsActive);
            Controls.Add(textBox_LName);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(textBox_FName);
            Controls.Add(label1);
            Name = "CreateClerkForm";
            Text = "Create User";
            TopMost = true;
            Load += CreateClerkForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox_FName;
        private Label label11;
        private CheckBox checkBox_IsActive;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label9;
        private Label label12;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox_LName;
        private TextBox textBox_email;
        private ComboBox comboBox_Role;
        private TextBox textBox_PWD;
        private TextBox textBox_Login;
    }
}