using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SydneyFrippiri.Forms
{
    public partial class OldItemsReport : Form
    {
        public OldItemsReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfWeekBack = comboBox_weeks.SelectedIndex;
            int numberOfDays = 0;
            if (numberOfWeekBack == 0)
            {
                numberOfDays = 1 * 30;
            }
            else
            {
                numberOfDays = (numberOfWeekBack + 1) * 30;
            }

            DateTime currentDate = DateTime.Now;
            DateTime cutOffDate = currentDate.AddDays(-numberOfDays);
            string formattedDate = cutOffDate.ToString("yyyy-MM-dd");
            string sql = $"Select tbl_items.TAG_ID as 'TAG ID' , tbl_items.ItemName as 'Item Name', tbl_items.ItemDescription as 'Description', tbl_items.ItemColor as 'Color', tbl_items.ItemEntryDate as 'Entry Date', tbl_lkp_status.Status as Status,  tbl_items.isSpecial as 'Is Special Item', tbl_lkp_category.Category as 'Category', tbl_lkp_gender.Gender as 'Gender', tbl_items.ItemPrice as 'Price' From tbl_items Inner Join tbl_lkp_category On tbl_items.ItemCategoryID = tbl_lkp_category.ID Inner Join tbl_lkp_gender On tbl_items.ItemGenderID = tbl_lkp_gender.ID Inner Join tbl_lkp_status On tbl_items.ItemStatusID = tbl_lkp_status.ID Inner Join tbl_lkp_vendors On tbl_items.ItemVendorID = tbl_lkp_vendors.ID Where tbl_items.ItemStatusID NOT IN (3,4) AND  tbl_items.ItemEntryDate < '{formattedDate}' Order By tbl_items.ItemEntryDate";

            DataTable dt = AuxFunctions.executeSQLQuery(sql);
            if (dt.Rows.Count == 0)
            {
                lbl_NO_DATA_FOUND.Visible = true;
                lbl_NO_DATA_FOUND.Text = "No items found.";
                dataGridView1.Visible = false;
            }
            else
            {
                lbl_NO_DATA_FOUND.Visible = false;
                dataGridView1.Visible = true;
                dataGridView1.DataSource = dt;
            }
        }

        private void OldItemsReport_Load(object sender, EventArgs e)
        {
            comboBox_weeks.SelectedIndex = 5;
            lbl_NO_DATA_FOUND.Visible = true;
            dataGridView1.Visible = false;
        }
    }
}
