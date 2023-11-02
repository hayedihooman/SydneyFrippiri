namespace SydneyFrippiri.Forms
{
    partial class ModifyItem
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
            textBox_TAGID = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBox_Vendor = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            textBox_Color = new TextBox();
            comboBox_Category = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            checkBox_isSpecial = new CheckBox();
            comboBox_Gender = new ComboBox();
            textBox_Desc = new TextBox();
            textBox_Name = new TextBox();
            button2 = new Button();
            textBox_Price = new TextBox();
            label10 = new Label();
            comboBox_Status = new ComboBox();
            label9 = new Label();
            label_Gender = new Label();
            label7 = new Label();
            label_Desc = new Label();
            label5 = new Label();
            label_Name = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(207, 32);
            button1.Name = "button1";
            button1.Size = new Size(102, 25);
            button1.TabIndex = 20;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_TAGID
            // 
            textBox_TAGID.Location = new Point(90, 32);
            textBox_TAGID.Name = "textBox_TAGID";
            textBox_TAGID.Size = new Size(100, 23);
            textBox_TAGID.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_TAGID);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(27, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search For Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 37);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "TAG ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 3;
            label1.Text = "Modify Item";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox_Vendor);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox_Color);
            groupBox2.Controls.Add(comboBox_Category);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(checkBox_isSpecial);
            groupBox2.Controls.Add(comboBox_Gender);
            groupBox2.Controls.Add(textBox_Desc);
            groupBox2.Controls.Add(textBox_Name);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox_Price);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(comboBox_Status);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label_Gender);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label_Desc);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label_Name);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(27, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 341);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Item";
            // 
            // comboBox_Vendor
            // 
            comboBox_Vendor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Vendor.FormattingEnabled = true;
            comboBox_Vendor.Location = new Point(107, 241);
            comboBox_Vendor.Name = "comboBox_Vendor";
            comboBox_Vendor.Size = new Size(163, 23);
            comboBox_Vendor.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(110, 242);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 244);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 21;
            label12.Text = "Vendor";
            // 
            // textBox_Color
            // 
            textBox_Color.Location = new Point(107, 212);
            textBox_Color.Name = "textBox_Color";
            textBox_Color.Size = new Size(162, 23);
            textBox_Color.TabIndex = 7;
            // 
            // comboBox_Category
            // 
            comboBox_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Location = new Point(107, 181);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(163, 23);
            comboBox_Category.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 215);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 17;
            label4.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 182);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 184);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Category";
            // 
            // checkBox_isSpecial
            // 
            checkBox_isSpecial.AutoSize = true;
            checkBox_isSpecial.Location = new Point(27, 280);
            checkBox_isSpecial.Name = "checkBox_isSpecial";
            checkBox_isSpecial.Size = new Size(101, 19);
            checkBox_isSpecial.TabIndex = 9;
            checkBox_isSpecial.Text = "Is Special Item";
            checkBox_isSpecial.UseVisualStyleBackColor = true;
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.ItemHeight = 15;
            comboBox_Gender.Location = new Point(106, 89);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(163, 23);
            comboBox_Gender.TabIndex = 3;
            // 
            // textBox_Desc
            // 
            textBox_Desc.Location = new Point(106, 60);
            textBox_Desc.Name = "textBox_Desc";
            textBox_Desc.Size = new Size(165, 23);
            textBox_Desc.TabIndex = 2;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(106, 31);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(165, 23);
            textBox_Name.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(121, 305);
            button2.Name = "button2";
            button2.Size = new Size(86, 27);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(106, 151);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(163, 23);
            textBox_Price.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 154);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 8;
            label10.Text = "Price";
            // 
            // comboBox_Status
            // 
            comboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Status.FormattingEnabled = true;
            comboBox_Status.Location = new Point(106, 120);
            comboBox_Status.Name = "comboBox_Status";
            comboBox_Status.Size = new Size(165, 23);
            comboBox_Status.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 123);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 6;
            label9.Text = "Status";
            // 
            // label_Gender
            // 
            label_Gender.AutoSize = true;
            label_Gender.Location = new Point(109, 90);
            label_Gender.Name = "label_Gender";
            label_Gender.Size = new Size(0, 15);
            label_Gender.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 90);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 4;
            label7.Text = "Gender";
            // 
            // label_Desc
            // 
            label_Desc.AutoSize = true;
            label_Desc.Location = new Point(109, 62);
            label_Desc.Name = "label_Desc";
            label_Desc.Size = new Size(0, 15);
            label_Desc.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 62);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 2;
            label5.Text = "Description";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(109, 34);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(0, 15);
            label_Name.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 34);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Name:";
            // 
            // ModifyItem
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 525);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "ModifyItem";
            Text = "Modify Item";
            Load += ModifyItem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_TAGID;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label_Name;
        private Label label3;
        private ComboBox comboBox_Status;
        private Label label9;
        private Label label_Gender;
        private Label label7;
        private Label label_Desc;
        private Label label5;
        private Button button2;
        private TextBox textBox_Price;
        private Label label10;
        private ComboBox comboBox_Gender;
        private TextBox textBox_Desc;
        private TextBox textBox_Name;
        private CheckBox checkBox_isSpecial;
        private ComboBox comboBox_Category;
        private Label label4;
        private Label label6;
        private Label label8;
        private TextBox textBox_Color;
        private ComboBox comboBoxVendor;
        private Label label11;
        private Label label12;
        private ComboBox comboBox_Vendor;
    }
}