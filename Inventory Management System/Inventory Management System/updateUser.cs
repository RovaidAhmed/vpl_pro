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
using System.IO;

namespace Inventory_Management_System
{
    public partial class updateUser : Form
    {
        public updateUser()
        {
            InitializeComponent();
        }
        //   SqlConnection sc = new SqlConnection("Data source=ASGHAR;user id=sa;password=125;database=Inventory Management System");

        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");
        public void updategrid()
        {
            SqlCommand cmd = new SqlCommand("select_user", sc);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
      
     
        private void updateUser_Load(object sender, EventArgs e)
        {
            updategrid();
            
        }
       
    

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update_user", sc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            cmd.Parameters.AddWithValue("@name", txtusrname.Text);
            cmd.Parameters.AddWithValue("@email", txtusreml.Text);
            cmd.Parameters.AddWithValue("@contctno", txtusrcntct.Text);
            cmd.Parameters.AddWithValue("@addres", txtusraddrs.Text);
        //    cmd.Parameters.AddWithValue("@password", encryptpassword(txtusrpswrd.Text));
            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Successfully Updated");
            updategrid();
            txtid.Text = txtusrname.Text = txtusreml.Text = txtusrcntct.Text = txtusraddrs.Text = null;
          //  updategridcell();
        }
        void updategridcell()
        {
            dataGridView1.CurrentRow.Cells[0].Value= txtid.Text;
            dataGridView1.CurrentRow.Cells[1].Value=txtusrname.Text;
            dataGridView1.CurrentRow.Cells[2].Value = txtusreml.Text;
            dataGridView1.CurrentRow.Cells[3].Value = txtusrcntct.Text;
            dataGridView1.CurrentRow.Cells[4].Value = txtusraddrs.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtusrname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtusreml.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtusrcntct.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtusraddrs.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            manfrmshow.showfrm();
        }
    }
}
