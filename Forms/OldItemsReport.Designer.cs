namespace SydneyFrippiri.Forms
{
    partial class OldItemsReport
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
            comboBox_weeks = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            lbl_NO_DATA_FOUND = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox_weeks
            // 
            comboBox_weeks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_weeks.FormattingEnabled = true;
            comboBox_weeks.Items.AddRange(new object[] { "1 Month", "2 Months", "3 Months", "4 Months", "5 Months", "6 Months", "7 Months", "8 Months", "9 Months", "10 Months", "11 Months", "12 Months" });
            comboBox_weeks.Location = new Point(479, 83);
            comboBox_weeks.Name = "comboBox_weeks";
            comboBox_weeks.Size = new Size(98, 23);
            comboBox_weeks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 40);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 47);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 86);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 3;
            label3.Text = "Display Item Older Than:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(38, 27);
            label4.Name = "label4";
            label4.Size = new Size(266, 40);
            label4.TabIndex = 4;
            label4.Text = "Older Item Report";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 156);
            dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(604, 83);
            button1.Name = "button1";
            button1.Size = new Size(98, 23);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_NO_DATA_FOUND
            // 
            lbl_NO_DATA_FOUND.AutoSize = true;
            lbl_NO_DATA_FOUND.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NO_DATA_FOUND.Location = new Point(298, 205);
            lbl_NO_DATA_FOUND.Name = "lbl_NO_DATA_FOUND";
            lbl_NO_DATA_FOUND.Size = new Size(301, 40);
            lbl_NO_DATA_FOUND.TabIndex = 7;
            lbl_NO_DATA_FOUND.Text = "NO DATA RETRIEVED";
            // 
            // OldItemsReport
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 377);
            Controls.Add(lbl_NO_DATA_FOUND);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_weeks);
            Name = "OldItemsReport";
            Text = "Old Items Report";
            Load += OldItemsReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_weeks;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button1;
        private Label lbl_NO_DATA_FOUND;
    }
}