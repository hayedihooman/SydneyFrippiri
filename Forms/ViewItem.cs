using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SydneyFrippiri.Forms
{
    public partial class ViewItem : Form
    {
        public ViewItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   string sql = "select * from tbl_items where TAG_ID=" + textBox_TAGID.Text.Trim();

            if (AuxFunctions.IsNumberOrDecimal(textBox_TAGID.Text.Trim()) == false)
            {
                AuxFunctions.showGeneralErrorDialog("Error: TAG ID must be a number");
                return;
            }





            string sql = "Select ";
            sql += "tbl_items.ItemName, tbl_items.ItemColor, tbl_items.ItemEntryDate,  ";
            sql += "tbl_items.ItemDescription, ";
            sql += "tbl_items.ItemColor, ";
            sql += "tbl_items.ItemPrice, ";
            sql += "tbl_items.ItemEntryDate, ";
            sql += "tbl_items.isSpecial, ";
            sql += "tbl_lkp_vendors.VendorName, ";
            sql += "tbl_lkp_category.Category, ";
            sql += "tbl_lkp_status.Status, ";
            sql += "tbl_lkp_gender.Gender, ";
            sql += "tbl_items.TAG_ID ";
            sql += "From tbl_items Inner Join tbl_lkp_category On tbl_items.ItemCategoryID = tbl_lkp_category.ID Inner Join tbl_lkp_gender On tbl_items.ItemGenderID = tbl_lkp_gender.ID Inner Join  tbl_lkp_status On tbl_items.ItemStatusID = tbl_lkp_status.ID Inner Join tbl_lkp_vendors On tbl_items.ItemVendorID = tbl_lkp_vendors.ID Where tbl_items.TAG_ID = " + textBox_TAGID.Text.Trim();

            DataTable? dt = AuxFunctions.executeSQLQuery(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                {
                    AuxFunctions.showGeneralErrorDialog("Error: Item not found");
                    textBox_Name_1.Text = "";
                    textBox_Desc_1.Text = "";
                    textBox_Price_1.Text = "";
                    lbl_isSpecial.Text = "";
                    comboBox_Gender_1.Text = "";
                    comboBox_Status_1.Text = "";
                    comboBox_Vendor_1.Text = "";
                    comboBox_Category_1.Text = "";
                    lbl_Color.Text = "";
                    lbl_dateAdded.Text = "";

                    return;
                }
                else
                {
                    textBox_Name_1.Text = (string)dt.Rows[0]["ItemName"];
                    textBox_Desc_1.Text = (string)dt.Rows[0]["ItemDescription"];
                    textBox_Price_1.Text = ((decimal)dt.Rows[0]["ItemPrice"]).ToString();
                    bool isSpecial = (bool)dt.Rows[0]["IsSpecial"];
                    lbl_Color.Text = (string)dt.Rows[0]["ItemColor"];
                    lbl_dateAdded.Text = ((DateTime)dt.Rows[0]["ItemEntryDate"]).ToString("dd/MM/yyyy");

                    if (isSpecial)
                    {

                        lbl_isSpecial.Text = "SPECIAL";
                    }
                    else
                    {
                        lbl_isSpecial.Text = "REGULAR";
                    }

                    // checkBox_isSpecial.Checked = isSpecial;
                    // checkBox_isSpecial.Enabled = false;
                    comboBox_Gender_1.Text = (string)dt.Rows[0]["Gender"];
                    comboBox_Status_1.Text = (string)dt.Rows[0]["Status"];
                    comboBox_Vendor_1.Text = (string)dt.Rows[0]["VendorName"];
                    comboBox_Category_1.Text = (string)dt.Rows[0]["Category"];
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
