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
    public partial class Real_Product_Info : Form
    {
        public Real_Product_Info()
        {
            InitializeComponent();
        }
        //     SqlConnection sc = new SqlConnection("Data source=ASGHAR;user id=sa;password=125;database=Inventory Management System");
        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            manfrmshow.showfrm();
        }
        private void fillgrid()
        {
            SqlDataAdapter sd = new SqlDataAdapter("select * from RProduct", sc);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Real_Product_Info_Load(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}
