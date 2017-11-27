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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label8.Text = dt.ToLongTimeString();
            label10.Text = dt.ToShortDateString();
        }
        private void gridfill()
        {

            SqlDataAdapter sd = new SqlDataAdapter("select * from Product", sc);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtprdctname.Text != "" && txtprdctquantity.Text != "" && comboBox1.Text != "" && txtprodctpurchseprice.Text != "" && txtsaleprice.Text != "")
            {
                int purchseprice = int.Parse(txtprodctpurchseprice.Text);
                int saleprice = int.Parse(txtsaleprice.Text);
                if (purchseprice < saleprice)
                {

                    SqlCommand cmd = new SqlCommand("update_product", sc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.Parameters.AddWithValue("@vname", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@pname", txtprdctname.Text);
                    cmd.Parameters.AddWithValue("@pcat", txtprdctcate.Text);

                    cmd.Parameters.AddWithValue("@ppprcie", txtprodctpurchseprice.Text);
                    cmd.Parameters.AddWithValue("@psaleprice", txtsaleprice.Text);
                    cmd.Parameters.AddWithValue("@pqun", txtprdctquantity.Text);
                    cmd.Parameters.AddWithValue("@ptax", prdcttax.Text);
                    cmd.Parameters.AddWithValue("@pcompny", prdctcompny.Text);
                    cmd.Parameters.AddWithValue("@ptime", label8.Text);
                    cmd.Parameters.AddWithValue("@pdate", label10.Text);
                    sc.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated");
                    txtprdctcate.Text = txtprdctname.Text = txtprdctquantity.Text = txtprodctpurchseprice.Text = txtsaleprice.Text = prdctcompny.Text = prdcttax.Text = null;
                    gridfill();
                    //   MessageBox.Show("Required Fileds are empty or cancel this", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    sc.Close();
                }
                else
                {
                    MessageBox.Show("Sale price must be greater than purchase price", "Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtprdctcate.Text = txtprdctname.Text = txtprdctquantity.Text = txtprodctpurchseprice.Text = txtsaleprice.Text = prdctcompny.Text = prdcttax.Text = null;

                }
            }
            else
            {
                MessageBox.Show("Required Fileds are empty or cancel this", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                sc.Close();
            }

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            gridfill();
            timer1.Start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprdctname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtprdctcate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtprodctpurchseprice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsaleprice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            prdcttax.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtprdctquantity.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            prdctcompny.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            
        }
    }
}
