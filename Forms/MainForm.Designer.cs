namespace SydneyFrippiri.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            administrationToolStripMenuItem = new ToolStripMenuItem();
            createClerkToolStripMenuItem = new ToolStripMenuItem();
            inventoryControlToolStripMenuItem = new ToolStripMenuItem();
            viewItemToolStripMenuItem = new ToolStripMenuItem();
            modifyItemToolStripMenuItem = new ToolStripMenuItem();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            disposedItemsReportToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { administrationToolStripMenuItem, inventoryControlToolStripMenuItem, reportsToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1061, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // administrationToolStripMenuItem
            // 
            administrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createClerkToolStripMenuItem });
            administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            administrationToolStripMenuItem.Size = new Size(98, 20);
            administrationToolStripMenuItem.Text = "Administration";
            // 
            // createClerkToolStripMenuItem
            // 
            createClerkToolStripMenuItem.Name = "createClerkToolStripMenuItem";
            createClerkToolStripMenuItem.Size = new Size(134, 22);
            createClerkToolStripMenuItem.Text = "Create User";
            createClerkToolStripMenuItem.Click += createClerkToolStripMenuItem_Click;
            // 
            // inventoryControlToolStripMenuItem
            // 
            inventoryControlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewItemToolStripMenuItem, modifyItemToolStripMenuItem, addItemToolStripMenuItem });
            inventoryControlToolStripMenuItem.Name = "inventoryControlToolStripMenuItem";
            inventoryControlToolStripMenuItem.Size = new Size(112, 20);
            inventoryControlToolStripMenuItem.Text = "Inventory Control";
            // 
            // viewItemToolStripMenuItem
            // 
            viewItemToolStripMenuItem.Name = "viewItemToolStripMenuItem";
            viewItemToolStripMenuItem.Size = new Size(139, 22);
            viewItemToolStripMenuItem.Text = "View Item";
            viewItemToolStripMenuItem.Click += viewItemToolStripMenuItem_Click;
            // 
            // modifyItemToolStripMenuItem
            // 
            modifyItemToolStripMenuItem.Name = "modifyItemToolStripMenuItem";
            modifyItemToolStripMenuItem.Size = new Size(139, 22);
            modifyItemToolStripMenuItem.Text = "Modify Item";
            modifyItemToolStripMenuItem.Click += modifyItemToolStripMenuItem_Click;
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(139, 22);
            addItemToolStripMenuItem.Text = "Add Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disposedItemsReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // disposedItemsReportToolStripMenuItem
            // 
            disposedItemsReportToolStripMenuItem.Name = "disposedItemsReportToolStripMenuItem";
            disposedItemsReportToolStripMenuItem.Size = new Size(163, 22);
            disposedItemsReportToolStripMenuItem.Text = "Old Items Report";
            disposedItemsReportToolStripMenuItem.Click += disposedItemsReportToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 634);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Sydney Frippiri Inventory System";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administrationToolStripMenuItem;
        private ToolStripMenuItem inventoryControlToolStripMenuItem;
        private ToolStripMenuItem createClerkToolStripMenuItem;
        private ToolStripMenuItem modifyItemToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem disposedItemsReportToolStripMenuItem;
        private ToolStripMenuItem viewItemToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}