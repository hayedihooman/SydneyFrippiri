using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Logging;
using SydneyFrippiri.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SydneyFrippiri.Forms
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        bool isAdding = true;


        private void resetFormData()
        {
            textBox_Name.Text = "";
            textBox_Desc.Text = "";
            textBox_Price.Text = "";

            textBox_Color.Text = "";
            comboBox_Category.SelectedIndex = 0;
            comboBox_Vendor.SelectedIndex = 0;
            comboBox_Gender.SelectedIndex = 0;
            label_TAG_ID.Text = "";
        }

        private void toggleForm(bool x)
        {

            textBox_Color.Enabled = x;
            textBox_Desc.Enabled = x;
            textBox_Name.Enabled = x;
            textBox_Price.Enabled = x;
            comboBox_Category.Enabled = x;
            comboBox_Vendor.Enabled = x;
            comboBox_Gender.Enabled = x;
            checkBox_isSpecial.Enabled = x;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (isAdding)
            {
                string name = textBox_Name.Text;
                string desc = textBox_Desc.Text;
                string price = textBox_Price.Text;
                string color = textBox_Color.Text;
                int catID = (int)comboBox_Category.SelectedValue;
                int venID = (int)comboBox_Vendor.SelectedValue;
                int genID = (int)comboBox_Gender.SelectedValue;
                double outPrice;
                bool isSpecial = checkBox_isSpecial.Checked;

                if (name.Equals(""))
                {
                    AuxFunctions.showGeneralErrorDialog("Name cannot be empty");
                    textBox_Name.Focus();
                    return;
                }


                if (price.Equals(""))
                {
                    AuxFunctions.showGeneralErrorDialog("Price cannot be empty");
                    textBox_Price.Focus();
                    return;
                }

                double.TryParse(price, out outPrice);

                if (outPrice == 0)
                {
                    AuxFunctions.showGeneralErrorDialog("This is not a valid price for an item.");
                    textBox_Price.Focus();
                    return;
                }

                if (name.Equals(""))
                {
                    AuxFunctions.showGeneralErrorDialog("Name cannot be empty");
                    textBox_Name.Focus();
                    return;
                }
                if (desc.Trim().Equals(""))
                {
                    AuxFunctions.showGeneralErrorDialog("Description cannot be blank");
                    textBox_Desc.Focus();
                    return;
                }

                if (color.Trim().Equals(""))
                {
                    AuxFunctions.showGeneralErrorDialog("Color cannot be blank");
                    textBox_Color.Focus();
                    return;
                }

                name = name.Replace("'", "''");
                desc = desc.Replace("'", "''");
                color = color.Replace("'", "''");

                if (name.Length > 50)
                {
                    AuxFunctions.showGeneralErrorDialog("Name cannot be longer than 50 characters");
                    textBox_Name.Focus();
                    return;
                }
                if (desc.Length > 1000) { 
                    AuxFunctions.showGeneralErrorDialog("Description cannot be longer than 1000 characters");   
                    textBox_Desc.Focus();
                    return;
                
                } 
                if (color.Length > 50)
                {
                    AuxFunctions.showGeneralErrorDialog("Color cannot be longer than 50 characters");
                    textBox_Color.Focus();
                    return;
                }


                DateTime now = DateTime.Now;
                string sql = "";
                sql += "INSERT INTO tbl_items (ItemStatusID, LastStatusChangeByLoginID, isSpecial, ItemEntryDate, ItemName, ItemDescription, ItemPrice, ItemColor, ItemCategoryID, ItemVendorID, ItemGenderID) VALUES (";
                sql += "'1" + "',";
                sql += "'" + GLOBALS.login.ToString() + "',";
                sql += "'" + isSpecial.ToString() + "',";
                sql += "'" + now.ToString("yyyy-MM-dd") + "',";
                sql += "'" + name + "',";
                sql += "'" + desc + "',";
                sql += "'" + outPrice + "',";
                sql += "'" + color + "',";
                sql += "" + catID + ",";
                sql += "" + venID + ",";
                sql += "" + genID + "";
                sql += ")";

                try
                {
                    int x = AuxFunctions.executeSingleNonQuery(sql, AuxFunctions.DB_CRUD_TYPE.INSERT);
                    AuxFunctions.showSuccessDialog("Item added successfully. TAG_NUMBER: " + x.ToString());
                    label_TAG_ID.Text = x.ToString();
                    toggleForm(false);
                    isAdding = false;
                    button1.Text = "Reset Form";
                }
                catch (SqlException ex)
                {
                    AuxFunctions.showGeneralErrorDialog("There was an error adding the item." + ex.Message);
                }
            }
            else
            {
                isAdding = true;
                toggleForm(true);
                resetFormData();
                button1.Text = "Add Item";
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            DataTable? dt;
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
                AuxFunctions.showGeneralErrorDialog("There was an error loading the vendors." + ex.Message);
                return;
            }

            try
            {
                dt = AuxFunctions.executeSQLQuery("select * from tbl_lkp_gender");
                // create a list of Category from the dataTable dt

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
                AuxFunctions.showGeneralErrorDialog("There was an error loading the categories." + ex.Message);
                return;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
