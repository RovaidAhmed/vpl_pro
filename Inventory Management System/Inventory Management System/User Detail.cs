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
    public partial class User_Detail : Form
    {
        public User_Detail()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            manfrmshow.showfrm();
        }
        private void fillgrid()
        {
            SqlDataAdapter sd = new SqlDataAdapter("select * from Usertbl", sc);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void User_Detail_Load(object sender, EventArgs e)
        {
            fillgrid();
        }
    }
}
