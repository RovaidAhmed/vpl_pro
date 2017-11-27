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
    public partial class DeleteVendor : Form
    {
        public DeleteVendor()
        {
            InitializeComponent();
        }
        //      SqlConnection sc = new SqlConnection("Data Source=ASGHAR;user id=sa;password=125;database=Inventory Management System");
        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            manfrmshow.showfrm();
        }

        public void updategrid()
        {
            SqlCommand cmd = new SqlCommand("select * from Vendor", sc);
           
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

            {

                if (MessageBox.Show("Are you sure to remove this Row", "Remove Row", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    SqlCommand cmd = new SqlCommand("delete_vendor", sc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    sc.Open();
                    cmd.ExecuteNonQuery();
                    sc.Close();
                    updategrid();
                    MessageBox.Show("Successfully Delete");

                }

            }
            else
            {
                MessageBox.Show("Select Row", "",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteVendor_Load(object sender, EventArgs e)
        {
            updategrid();
        }
    }
}
