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
    public partial class Vendor_Detail : Form
    {
        public Vendor_Detail()
        {
            InitializeComponent();
        }
        //    SqlConnection sc = new SqlConnection("Data source=ASGHAR;user id=sa;password=125;database=Inventory Management System");
        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            manfrmshow.showfrm();
        }

        public void gridfill()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Vendor", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Vendor_Detail_Load(object sender, EventArgs e)
        {
            gridfill();
        }
    }
}
