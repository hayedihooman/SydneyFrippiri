using Microsoft.Data.SqlClient;
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
    public partial class CreateClerkForm : Form
    {
        public CreateClerkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fn = textBox_FName.Text;
            string ln = textBox_LName.Text;
            string email = textBox_email.Text;
            bool isActive = checkBox_IsActive.Checked;
            string login = textBox_Login.Text;
            string pwd = textBox_PWD.Text;
            bool isOwner;

            if (fn == string.Empty || fn.Trim().Length == 0 || fn.Trim() == "")
            {
                AuxFunctions.showGeneralErrorDialog("Please provide a First Name of the new user.");
                textBox_FName.Focus();
                return;
            }

            if (email == string.Empty || email.Trim().Length == 0 || email.Trim() == "" || AuxFunctions.IsValidEmail(email) == false)
            {
                AuxFunctions.showGeneralErrorDialog("Please provide a proper email for the user.");
                textBox_email.Focus();
                return;
            }


            if (ln == string.Empty || ln.Trim().Length == 0 || ln.Trim() == "")
            {
                AuxFunctions.showGeneralErrorDialog("Please provide a Last Name for the user.");
                textBox_LName.Focus();
                return;
            }

            if (login == string.Empty || login.Trim().Length == 0 || login.Trim() == "")
            {
                AuxFunctions.showGeneralErrorDialog("Please provide a Login for the user.");
                textBox_Login.Focus();
                return;
            }

            if (pwd == string.Empty || pwd.Trim().Length == 0 || pwd.Trim() == "")
            {
                AuxFunctions.showGeneralErrorDialog("Please provide a password for the user.");
                textBox_PWD.Focus();
                return;
            }

            if (comboBox_Role.SelectedIndex == 0)
            {
                isOwner = false;
            }
            else
            {
                isOwner = true;
            }
            string sql = "insert into tbl_users (login, pwd, isOwner, userFirstName, userLastName, email, isActive) values (";
            sql += "'" + login + "','" + pwd + "','" + isOwner.ToString() + "','" + fn + "','" + ln + "','" + email + "','" + isActive.ToString() + "'";
            sql += ");";


            try
            {

                int x = AuxFunctions.executeSingleNonQuery(sql, AuxFunctions.DB_CRUD_TYPE.INSERT_NO_AUTO);
                if (x == 0)
                {
                    AuxFunctions.showDatabaseErrorDialog("Insert error:  Please check your data");
                }
                else
                {
                    AuxFunctions.showSuccessDialog("User Created Successfully.");
                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    AuxFunctions.showDatabaseErrorDialog("ERROR: This login already exist...");
                }
                else
                {
                    AuxFunctions.showDatabaseErrorDialog(ex.Number.ToString());
                }
            }

            catch (Exception ex)
            {

                AuxFunctions.showDatabaseErrorDialog("Database Exception:" + ex.Message);
            }

        }

        private void CreateClerkForm_Load(object sender, EventArgs e)
        {
            comboBox_Role.SelectedIndex = 0;
        }
    }
}
