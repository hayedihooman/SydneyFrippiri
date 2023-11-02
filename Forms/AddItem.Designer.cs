namespace SydneyFrippiri.Forms
{
    partial class AddItem
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBox_isSpecial = new CheckBox();
            label4 = new Label();
            label_TAG_ID = new Label();
            textBox_Name = new TextBox();
            textBox_Color = new TextBox();
            textBox_Price = new TextBox();
            textBox_Desc = new TextBox();
            comboBox_Category = new ComboBox();
            comboBox_Vendor = new ComboBox();
            comboBox_Gender = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(237, 45);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 176);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 210);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Vendor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 171);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(443, 132);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 6;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 137);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Color";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(443, 94);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 8;
            label9.Text = "Description";
            // 
            // checkBox_isSpecial
            // 
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.Location = new Point(443, 209);
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.Size = new Size(71, 19);
            checkBox_isSpecial.TabIndex = 8;
            checkBox_isSpecial.Text = "isSpecial";
            checkBox_isSpecial.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(545, 38);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 10;
            label4.Text = "TAG_ID:";
            label4.Click += label4_Click;
            // 
            // label_TAG_ID
            // 
            label_TAG_ID.AutoSize = true;
            label_TAG_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_TAG_ID.Location = new Point(619, 38);
            label_TAG_ID.Name = "label_TAG_ID";
            label_TAG_ID.Size = new Size(0, 21);
            label_TAG_ID.TabIndex = 13;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(127, 91);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(232, 23);
            textBox_Name.TabIndex = 1;
            // 
            // textBox_Color
            // 
            textBox_Color.Location = new Point(130, 129);
            textBox_Color.Name = "textBox_Color";
            textBox_Color.Size = new Size(100, 23);
            textBox_Color.TabIndex = 3;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(516, 129);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(87, 23);
            textBox_Price.TabIndex = 4;
            // 
            // textBox_Desc
            // 
            textBox_Desc.Location = new Point(516, 89);
            textBox_Desc.Name = "textBox_Desc";
            textBox_Desc.Size = new Size(241, 23);
            textBox_Desc.TabIndex = 2;
            // 
            // comboBox_Category
            // 
            comboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Location = new Point(130, 168);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(229, 23);
            comboBox_Category.Sorted = true;
            comboBox_Category.TabIndex = 5;
            // 
            // comboBox_Vendor
            // 
            comboBox_Vendor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Vendor.FormattingEnabled = true;
            comboBox_Vendor.Location = new Point(131, 207);
            comboBox_Vendor.Name = "comboBox_Vendor";
            comboBox_Vendor.Size = new Size(228, 23);
            comboBox_Vendor.TabIndex = 7;
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Location = new Point(517, 171);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(86, 23);
            comboBox_Gender.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(303, 266);
            button1.Name = "button1";
            button1.Size = new Size(185, 37);
            button1.TabIndex = 10;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddItem
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 339);
            Controls.Add(button1);
            Controls.Add(comboBox_Gender);
            Controls.Add(comboBox_Vendor);
            Controls.Add(comboBox_Category);
            Controls.Add(textBox_Desc);
            Controls.Add(textBox_Price);
            Controls.Add(textBox_Color);
            Controls.Add(textBox_Name);
            Controls.Add(label_TAG_ID);
            Controls.Add(label4);
            Controls.Add(checkBox_isSpecial);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddItem";
            Text = "Add Item";
            Load += AddItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBox_isSpecial;
        private Label label4;
        private Label label12;
        private TextBox textBox_Name;
        private TextBox textBox_Color;
        private TextBox textBox_Price;
        private TextBox textBox_Desc;
        private ComboBox comboBox_Category;
        private ComboBox comboBox_Vendor;
        private ComboBox comboBox_Gender;
        private Button button1;
        private Label label_TAG_ID;
    }
}