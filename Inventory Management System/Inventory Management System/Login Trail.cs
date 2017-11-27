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


namespace Inventory_Management_System
{
    public partial class Login_Trail : Form
    {
        MethodClass MethodClassObj = new MethodClass();
        public Login_Trail()
        {
            InitializeComponent();
            MethodClassObj.ConnectionMethod();
        }
        //SqlConnection sc = new SqlConnection("Data Source=IBADAHMED;user id=sa;password=ghufran;database=Inventory Management System");
        public void updategrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Trail", MethodClassObj.sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        private void Login_Trail_Load(object sender, EventArgs e)
        {
           
            updategrid();

        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete  from Trail", MethodClassObj.sc);

            MethodClassObj.sc.Open();
            cmd.ExecuteNonQuery();
            MethodClassObj.sc.Close();
            MessageBox.Show("Successfully delete");
            updategrid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Mainfrom mainfrm = new Mainfrom();
            mainfrm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Mainfrom mainformObj = new Mainfrom();
            mainformObj.Show();
        }
    }
}
