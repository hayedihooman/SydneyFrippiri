using SydneyFrippiri.Forms;
using System.Data;

namespace SydneyFrippiri
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_login.Text.Trim().Equals(""))
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please provide a login name");
                textBox_login.Focus();
                return;
            }

            if (textBox_pwd.Text.Trim().Equals(""))
            {
                AuxFunctions.showGeneralErrorDialog("Error: Please provide a password name");
                textBox_pwd.Focus();
                return;
            }


            // ' OR '1'='1'; --



            string sql = "select * from tbl_users where login='" + textBox_login.Text.Trim() + "' and pwd='" + textBox_pwd.Text.Trim() + "' and isActive=1";

            DataTable? dt = null;
            try
            {
                dt = AuxFunctions.executeSQLQuery(sql);
            }
            catch (Exception ex)
            {
                AuxFunctions.showDatabaseErrorDialog(ex.Message);
                return;
            }
            if (dt.Rows.Count == 0)
            {
                AuxFunctions.showGeneralErrorDialog("Error: User not found. Please provide a valid login \\ password combination");
                return;
            }
            else
            {
                //   AuxFunctions.showSuccessDialog("User found.");
                GLOBALS.login = (string)dt.Rows[0]["login"];
                GLOBALS.isOwner = (bool)dt.Rows[0]["isOwner"];
                GLOBALS.userFirstName = (string)dt.Rows[0]["userFirstName"];
                GLOBALS.userLastName = (string)dt.Rows[0]["userLastName"];
                MainForm mf = new();
                mf.Text = "Syndney's Inventory System - Welcome " + GLOBALS.userFirstName.Trim() + " " + GLOBALS.userLastName.Trim();
                mf.Show();
                this.Hide();
            }

        }
    }
}