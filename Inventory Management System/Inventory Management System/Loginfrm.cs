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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        //        SqlConnection sc = new SqlConnection("Data source=ASGHAR;user id=sa;password=125;database=Inventory Management System");

        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtpassword.PasswordChar = '\0';
            else
                txtpassword.PasswordChar = '●';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label7.Text = dt.ToLongTimeString();
            label8.Text = dt.ToShortDateString();
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 frmmain = new Form1();
            frmmain.Show();
            
        }
        
        public   void insrt_trail()
        {
            SqlCommand cmd = new SqlCommand("insert_trail",sc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Description",txtUsername.Text + " has successfully Login !");
            cmd.Parameters.AddWithValue("@time", label7.Text);
            cmd.Parameters.AddWithValue("@date", label8.Text);
            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != "" && txtUsername.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select * from Admin where AdminName='" + txtUsername.Text + "'and AdminPassword='" + txtpassword.Text + "'", sc);
                sc.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    sc.Close();
                    MessageBox.Show("Well Come");
                    insrt_trail();
                    txtpassword.Text = txtUsername.Text = null;
                    label3.Visible = false;
                    label4.Visible = false;
                    Mainfrom mainfrom = new Mainfrom();
                    mainfrom.Show();
                    this.Dispose();
                   
                }
                else
                {
                    MessageBox.Show("User Name or Password  Does Not Exist", "Invalid User or Password", MessageBoxButtons.OK, MessageBoxIcon.None);

                    txtpassword.Text = txtUsername.Text = null;
                    label3.Visible = true;
                    label4.Visible = true;
                    sc.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Input User Name or Password","Fileds Empty", MessageBoxButtons.OK,MessageBoxIcon.None);
                if (txtUsername.Text == "" && txtpassword.Text=="")
                {
                    label3.Visible = true;
                    label4.Visible = true;
                }
                sc.Close();
              
            }
        }
    }
}
