using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Inventory_Management_System
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data source=IbadAhmed; user id=sa;password=ghufran;database=Inventory Management System");

        static string encryptpassword(string value)
        {
            using (MD5CryptoServiceProvider mcsp = new MD5CryptoServiceProvider())
            {
                UTF8Encoding ut = new UTF8Encoding();
                byte[] data = mcsp.ComputeHash(ut.GetBytes(value));
                return Convert.ToBase64String(data);

            }

        }
       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Mainfrom mainfrom = new Mainfrom();
            mainfrom.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtusrcontct.Text != "" && txtusrpswrd.Text != "" && MessageBox.Show("Are you sure to to add user", "Add User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("insertusertable", sc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtusername.Text);
                cmd.Parameters.AddWithValue("@email", txtusremail.Text);
                cmd.Parameters.AddWithValue("@contact", txtusrcontct.Text);
                cmd.Parameters.AddWithValue("@address", txtusraddres.Text);
                cmd.Parameters.AddWithValue("@password", encryptpassword(txtusrpswrd.Text));
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
                txtusername.Text = txtusraddres.Text = txtusrcontct.Text = txtusremail.Text = txtusrpswrd.Text = null;
            }
            else
            {
                MessageBox.Show("Required Fileds are empty or cancel this", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                sc.Close();
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Mainfrom mainfrm = new Mainfrom();
            mainfrm.Show();
            this.Dispose();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
