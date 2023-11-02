using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SydneyFrippiri.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            administrationToolStripMenuItem.Visible = GLOBALS.isOwner;
            
     
        }

        private void createClerkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateClerkForm f = new();
            f.MdiParent = this;
            f.TopLevel = false;
            f.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddItem f = new AddItem();
            f.MdiParent = this;
            f.TopLevel = false;
            f.Show();



        }

        private void modifyItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyItem modifyItem = new();
            modifyItem.MdiParent = this;
            modifyItem.TopLevel = false;
            modifyItem.Show();
        }

        private void disposedItemsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OldItemsReport or = new();
            or.MdiParent = this;
            or.TopLevel = false;
            or.Show();
        }

        private void viewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewItem vi = new();
            vi.MdiParent = this;

            vi.TopLevel = false;
            vi.Show();


        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

          if (   MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                            
                LoginForm lf = new();
                lf.Show();
                this.Close();
          }
            else
            {
                return;
            }        
        }
    }
}
