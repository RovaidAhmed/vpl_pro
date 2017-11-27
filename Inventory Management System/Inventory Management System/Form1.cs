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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginAsCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginfrm loginform = new Loginfrm();
            loginform.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
