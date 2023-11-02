namespace SydneyFrippiri
{
    partial class LoginForm
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
            label1 = new Label();
            textBox_login = new TextBox();
            textBox_pwd = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 94);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(225, 91);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(149, 23);
            textBox_login.TabIndex = 1;
            // 
            // textBox_pwd
            // 
            textBox_pwd.Location = new Point(225, 120);
            textBox_pwd.Name = "textBox_pwd";
            textBox_pwd.PasswordChar = '*';
            textBox_pwd.Size = new Size(149, 23);
            textBox_pwd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(143, 153);
            button1.Name = "button1";
            button1.Size = new Size(231, 36);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(43, 23);
            label3.Name = "label3";
            label3.Size = new Size(486, 45);
            label3.TabIndex = 5;
            label3.Text = " Sydney's Friperie Inventory System";
            // 
            // LoginForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 223);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox_pwd);
            Controls.Add(label2);
            Controls.Add(textBox_login);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_login;
        private TextBox textBox_pwd;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}