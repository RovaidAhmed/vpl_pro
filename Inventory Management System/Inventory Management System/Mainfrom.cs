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
            AddProduct prodct = new AddProduct();
            prodct.Show();
        }

        private void Mainfrom_Load(object sender, EventArgs e)
        {

        }

        private void createPartyAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CreatePartyAccount cpa = new CreatePartyAccount();
            cpa.Show();

        }
    }
}
