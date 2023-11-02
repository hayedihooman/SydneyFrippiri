using Microsoft.Data.SqlClient;
using SydneyFrippiri.Classes;
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
    public partial class ModifyItem : Form
    {
        public ModifyItem()
        {
            InitializeComponent();
        }

        private int getComboBoxValue(ComboBox cb)
        {
            return ((dynamic)cb.SelectedItem).ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (AuxFunctions.IsNumberOrDecimal(textBox_TAGID.Text.Trim()) == false)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please enter a TAG ID");
                textBox_TAGID.Focus();
                return;
            }

            if (AuxFunctions.IsNumberOrDecimal(textBox_Price.Text.Trim()) == false)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please enter a valid price");
                textBox_Price.Focus();
                return;
            }

            string ItemName = textBox_Name.Text.Trim();
            ItemName = ItemName.Replace("'", "''");
            string ItemDescription = textBox_Desc.Text.Trim();
            ItemDescription = ItemDescription.Replace("'", "''");
            decimal ItemPrice = decimal.Parse(textBox_Price.Text.Trim());
            int ItemStatusID = getComboBoxValue(comboBox_Status);
            int ItemGenderID = getComboBoxValue(comboBox_Gender);
            int ItemVendorID = getComboBoxValue(comboBox_Vendor);
            string color = textBox_Color.Text.Trim();
            color = color.Replace("'", "''");
            int ItemCategoryID = getComboBoxValue(comboBox_Category);
            bool IsSpecial = checkBox_isSpecial.Checked;
            int TAG_ID = int.Parse(textBox_TAGID.Text.Trim());

            if (ItemName.Length == 0)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please enter a name");
                textBox_Name.Focus();
                return;
            }

            if (ItemName.Length > 50)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Name must be less than 50 characters");
                textBox_Name.Focus();
                return;
            }
            if (ItemDescription.Length > 1000)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Description must be less than 1000 characters");
                textBox_Desc.Focus();
                return;
            }

            if (color.Length > 50)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Color must be less than 50 characters");
                textBox_Color.Focus();
                return;
            }

            if (ItemDescription.Length == 0)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please enter a description");
                textBox_Desc.Focus();

                return;
            }

            if (color.Length == 0)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please enter a color");
                textBox_Color.Focus();

                return;
            }

            string sql = $"update tbl_items set ItemVendorID = {ItemVendorID},  ItemCategoryID={ItemCategoryID}, ItemColor='{color}',   ItemName='{ItemName}', ItemDescription='{ItemDescription}', ItemPrice={ItemPrice}, ItemGenderID={ItemGenderID}, ItemStatusID={ItemStatusID}, IsSpecial='{IsSpecial}' where TAG_ID={TAG_ID}";

            try
            {
                AuxFunctions.executeSQLQuery(sql);
                AuxFunctions.showSuccessDialog("Item updated successfully.");
            }
            catch (SqlException ex)
            {
                AuxFunctions.showDatabaseErrorDialog(ex.Message);
                return;
            }
        }

        private void ModifyItem_Load(object sender, EventArgs e)
        {

            // checkBox_isSpecial.Enabled = true;
            checkBox_isSpecial.Visible = GLOBALS.isOwner;

            DataTable? dt = null;

            try
            {
                dt = AuxFunctions.executeSQLQuery("select * from tbl_lkp_gender");
                List<Gender> l = dt.AsEnumerable().Select(x => new Gender()
                {
                    GenderName = x.Field<string>("Gender"),
                    ID = x.Field<int>("ID")
                }).ToList();
                comboBox_Gender.DataSource = l;
                comboBox_Gender.DisplayMember = "GenderName";
                comboBox_Gender.ValueMember = "ID";
            }

            catch (SqlException ex)
            {
                AuxFunctions.showDatabaseErrorDialog(ex.Message);
                return;
            }

            try
            {
                dt = AuxFunctions.executeSQLQuery("select * from tbl_lkp_status");
                // create a list of Category from the dataTable dt
                List<Status> l = dt.AsEnumerable().Select(x => new Status()
                {
                    StatusName = x.Field<string>("Status"),
                    ID = x.Field<int>("ID")
                }).ToList();
                comboBox_Status.DataSource = l;
                comboBox_Status.DisplayMember = "StatusName";
                comboBox_Status.ValueMember = "ID";
            }

            catch (SqlException ex)
            {

                AuxFunctions.showDatabaseErrorDialog(ex.Message);
                return;
            }

            try
            {
                dt = AuxFunctions.executeSQLQuery("select * from tbl_lkp_category");
                // create a list of Category from the dataTable dt
                List<Category> l = dt.AsEnumerable().Select(x => new Category()
                {
                    CategoryName = x.Field<string>("Category"),
                    ID = x.Field<int>("ID")
                }).ToList();
                comboBox_Category.DataSource = l;
                comboBox_Category.DisplayMember = "CategoryName";
                comboBox_Category.ValueMember = "ID";
            }

            catch (SqlException ex)
            {

                AuxFunctions.showDatabaseErrorDialog(ex.Message);
                return;
            }

            try
            {
                dt = AuxFunctions.executeSQLQuery("select * from tbl_lkp_vendors");
                // create a list of Category from the dataTable dt
                List<Vendor> l = dt.AsEnumerable().Select(x => new Vendor()
                {
                    VendorName = x.Field<string>("VendorName"),
                    ID = x.Field<int>("ID")
                }).ToList();

                comboBox_Vendor.DataSource = l;
                comboBox_Vendor.DisplayMember = "VendorName";
                comboBox_Vendor.ValueMember = "ID";
            }

            catch (SqlException ex)
            {

                AuxFunctions.showDatabaseErrorDialog(ex.Message);
                return;
            }
        }

        private void setComboBoxToValue(ComboBox cb, int x)
        {

            for (int i = 0; i < cb.Items.Count; i++)
            {
                if (((dynamic)cb.Items[i]).ID == x)
                {
                    cb.SelectedIndex = i;
                    return;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (AuxFunctions.IsNumberOrDecimal(textBox_TAGID.Text.Trim()) == false)
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please enter a TAG ID");
                return;
            }


            string sql = "select * from tbl_items where TAG_ID=" + textBox_TAGID.Text.Trim();

            DataTable? dt = AuxFunctions.executeSQLQuery(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    AuxFunctions.showGeneralErrorDialog("Error: Item not found");
                    textBox_Name.Text = "";
                    textBox_Name.Enabled = false;
                    textBox_Desc.Enabled = false;
                    textBox_Price.Enabled = false;
                    comboBox_Vendor.Enabled = false;
                    comboBox_Vendor.SelectedIndex = -1;
                    textBox_Desc.Text = "";
                    textBox_Price.Text = "";
                    comboBox_Gender.SelectedIndex = -1;
                    comboBox_Status.SelectedIndex = -1;
                    comboBox_Gender.Enabled = false;
                    comboBox_Status.Enabled = false;
                    textBox_Color.Text = "";
                    textBox_Color.Enabled = false;
                    comboBox_Category.SelectedIndex = -1;
                    comboBox_Category.Enabled = false;
                    return;
                }
                else
                {

                    textBox_Name.Enabled = true;
                    textBox_Desc.Enabled = true;
                    textBox_Price.Enabled = true;
                    textBox_Color.Enabled = true;
                    comboBox_Category.Enabled = true;
                    comboBox_Vendor.Enabled = true;
                    textBox_Name.Text = (string)dt.Rows[0]["ItemName"];
                    textBox_Desc.Text = (string)dt.Rows[0]["ItemDescription"];
                    textBox_Price.Text = ((decimal)dt.Rows[0]["ItemPrice"]).ToString();
                    textBox_Color.Text = (string)dt.Rows[0]["ItemColor"];

                    int genderID = (int)dt.Rows[0]["ItemGenderID"];
                    int statusID = (int)dt.Rows[0]["ItemStatusID"];
                    bool isSpecial = (bool)dt.Rows[0]["IsSpecial"];
                    int CatID = (int)dt.Rows[0]["ItemCategoryID"];
                    int vendorID = (int)dt.Rows[0]["ItemVendorID"];
                    checkBox_isSpecial.Checked = isSpecial;
                    comboBox_Gender.Enabled = true;
                    comboBox_Status.Enabled = true;
                    setComboBoxToValue(comboBox_Gender, genderID);
                    setComboBoxToValue(comboBox_Category, CatID);
                    setComboBoxToValue(comboBox_Status, statusID);
                    setComboBoxToValue(comboBox_Vendor, vendorID);
                }
            }
        }
    }
}
