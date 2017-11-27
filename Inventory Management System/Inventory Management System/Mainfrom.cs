using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Mainfrom : Form
    {
        public Mainfrom()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
            this.Dispose();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loginfrm loginpage = new Loginfrm();
            loginpage.Show();
            this.Dispose();
        }

        private void loginTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login_Trail logintrail = new Login_Trail();
            logintrail.Show();

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            updateUser updateuser = new updateUser();
            updateuser.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DeleteUser dltuser = new DeleteUser();
            dltuser.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Product prodct = new Product();
            prodct.Show();
        }

        private void vendorDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendor_Detail vd = new Vendor_Detail();
            vd.Show();
            this.Hide();
        }

        private void addVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Addvendor addvendor = new Addvendor();
            addvendor.Show();
        }

        private void updateVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            updatevendor updatevndr = new updatevendor();
            updatevndr.Show();
        }

        private void deleteVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DeleteVendor dltvndr = new DeleteVendor();
            dltvndr.Show();
        }

        private void addIteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Product prdct = new Product();
            prdct.Show();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UpdateProduct updateprodct = new UpdateProduct();
            updateprodct.Show();

        }

        private void realProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Real_Product_Info realproductinfo = new Real_Product_Info();
            realproductinfo.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            viewProduct viewprdct = new viewProduct();
            viewprdct.Show();
        }

        private void deletItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Delete_Product deleteproduct = new Delete_Product();
            deleteproduct.Show();
        }

        private void Mainfrom_Load(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            User_Detail usrdetal = new User_Detail();
            usrdetal.Show();
        }

        private void addUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

            AddUser usrdetal = new AddUser();
            usrdetal.Show();
        }

        private void updateUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

            updateUser usrdetal = new updateUser();
            usrdetal.Show();
        }

        private void deleteUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Dispose();

            DeleteUser usrdetal = new DeleteUser();
            usrdetal.Show();
        }

        private void realProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Real_Product_Info rprodct = new Real_Product_Info();
            rprodct.Show();
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Vendor_Detail vd = new Vendor_Detail();
            vd.Show();
        }

        private void addVendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Addvendor vd = new Addvendor();
            vd.Show();
        }

        private void deleteVendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            DeleteVendor vd = new DeleteVendor();
            vd.Show();
        }

        private void updateVendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            updatevendor vd = new updatevendor();
            vd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            viewProduct vprodct = new viewProduct();
            vprodct.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Product prodct = new Product();
            prodct.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            UpdateProduct prdct = new UpdateProduct();
            prdct.Show();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Delete_Product prdct = new Delete_Product();
            prdct.Show();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginTrailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Login_Trail lgntrl = new Login_Trail();
            lgntrl.Show();
                }
    }
}
