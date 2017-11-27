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
        public Login_Trail()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");
        public void updategrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Trail", sc);
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
            SqlCommand cmd = new SqlCommand("delete  from Trail", sc);
      
            sc.Open();
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("Successfully delete");
            updategrid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Mainfrom mainfrm = new Mainfrom();
            mainfrm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            manfrmshow.showfrm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
