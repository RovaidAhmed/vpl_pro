namespace Inventory_Management_System
{
    partial class Mainfrom
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashierRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iteamInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStockItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPartyAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productViewToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productViewToolStripMenuItem
            // 
            this.productViewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.productViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.productViewToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productViewToolStripMenuItem.Name = "productViewToolStripMenuItem";
            this.productViewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.productViewToolStripMenuItem.Text = "Settings";
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManageToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.iteamInfoToolStripMenuItem,
            this.checkStockItemToolStripMenuItem,
            this.checkVendorToolStripMenuItem,
            this.manageProductToolStripMenuItem,
            this.createPartyAccountToolStripMenuItem});
            this.manageToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // userManageToolStripMenuItem
            // 
            this.userManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.userManageToolStripMenuItem.Name = "userManageToolStripMenuItem";
            this.userManageToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.userManageToolStripMenuItem.Text = "User Manage";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashierRecordToolStripMenuItem,
            this.salesRecordToolStripMenuItem,
            this.trailToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // cashierRecordToolStripMenuItem
            // 
            this.cashierRecordToolStripMenuItem.Name = "cashierRecordToolStripMenuItem";
            this.cashierRecordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cashierRecordToolStripMenuItem.Text = "Cashier Record";
            // 
            // salesRecordToolStripMenuItem
            // 
            this.salesRecordToolStripMenuItem.Name = "salesRecordToolStripMenuItem";
            this.salesRecordToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salesRecordToolStripMenuItem.Text = "Sales Record";
            // 
            // trailToolStripMenuItem
            // 
            this.trailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginTrailToolStripMenuItem,
            this.auditTrailToolStripMenuItem});
            this.trailToolStripMenuItem.Name = "trailToolStripMenuItem";
            this.trailToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.trailToolStripMenuItem.Text = "Trail";
            // 
            // loginTrailToolStripMenuItem
            // 
            this.loginTrailToolStripMenuItem.Name = "loginTrailToolStripMenuItem";
            this.loginTrailToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loginTrailToolStripMenuItem.Text = "LoginTrail";
            this.loginTrailToolStripMenuItem.Click += new System.EventHandler(this.loginTrailToolStripMenuItem_Click);
            // 
            // auditTrailToolStripMenuItem
            // 
            this.auditTrailToolStripMenuItem.Name = "auditTrailToolStripMenuItem";
            this.auditTrailToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.auditTrailToolStripMenuItem.Text = "AuditTrail";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // iteamInfoToolStripMenuItem
            // 
            this.iteamInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIteamToolStripMenuItem,
            this.updateItemToolStripMenuItem,
            this.deletItemToolStripMenuItem});
            this.iteamInfoToolStripMenuItem.Name = "iteamInfoToolStripMenuItem";
            this.iteamInfoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.iteamInfoToolStripMenuItem.Text = "Item Info";
            // 
            // addIteamToolStripMenuItem
            // 
            this.addIteamToolStripMenuItem.Name = "addIteamToolStripMenuItem";
            this.addIteamToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addIteamToolStripMenuItem.Text = "Add Item";
            // 
            // updateItemToolStripMenuItem
            // 
            this.updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            this.updateItemToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.updateItemToolStripMenuItem.Text = "Update Item";
            // 
            // deletItemToolStripMenuItem
            // 
            this.deletItemToolStripMenuItem.Name = "deletItemToolStripMenuItem";
            this.deletItemToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deletItemToolStripMenuItem.Text = "Delet Item";
            // 
            // checkStockItemToolStripMenuItem
            // 
            this.checkStockItemToolStripMenuItem.Name = "checkStockItemToolStripMenuItem";
            this.checkStockItemToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.checkStockItemToolStripMenuItem.Text = "Check Stock Item";
            // 
            // checkVendorToolStripMenuItem
            // 
            this.checkVendorToolStripMenuItem.Name = "checkVendorToolStripMenuItem";
            this.checkVendorToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.checkVendorToolStripMenuItem.Text = "Check Vendor";
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.updateProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // updateProductToolStripMenuItem
            // 
            this.updateProductToolStripMenuItem.Name = "updateProductToolStripMenuItem";
            this.updateProductToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.updateProductToolStripMenuItem.Text = "Update Product";
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            // 
            // createPartyAccountToolStripMenuItem
            // 
            this.createPartyAccountToolStripMenuItem.Name = "createPartyAccountToolStripMenuItem";
            this.createPartyAccountToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.createPartyAccountToolStripMenuItem.Text = "Create Party Account";
            this.createPartyAccountToolStripMenuItem.Click += new System.EventHandler(this.createPartyAccountToolStripMenuItem_Click);
            // 
            // Mainfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_Management_System.Properties.Resources.maindisplayadmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 347);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainfrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainfrom";
            this.Load += new System.EventHandler(this.Mainfrom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashierRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iteamInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStockItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPartyAccountToolStripMenuItem;
    }
}