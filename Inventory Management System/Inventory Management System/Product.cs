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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        //    SqlConnection sc = new SqlConnection("Data source=ASGHAR;user id=sa;password=125;database=Inventory Management System");

        SqlConnection sc = new SqlConnection("Data source=DESKTOP-KKE19MU\\SQLEXPRESS;integrated security=true;database=Inventory management System");
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Mainfrom mfrm = new Mainfrom();
            mfrm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label8.Text = dt.ToLongTimeString();
            label10.Text = dt.ToShortDateString();
        }
        public void comboboxfill()
        {
            SqlCommand cmd = new SqlCommand("select VendorID,VendorName from Vendor", sc);
            sc.Open();
          //  SqlCommand sc = new SqlCommand("select customerid,contactname from customers", conn);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            
            dt.Load(reader);
            comboBox1.SelectedIndex = 0;
            comboBox1.ValueMember = "VendorID";
            comboBox1.DisplayMember = "VendorName";
             comboBox1.DataSource = dt;
            sc.Close();
            

        }
        private void gridfill()
        {
            
            SqlDataAdapter sd = new SqlDataAdapter("select_product", sc);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Product_Load(object sender, EventArgs e)
        {
            gridfill();
            comboboxfill();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtprdctname.Text != "" && txtprdctquantity.Text != "" && comboBox1.Text != "" && txtprodctpurchseprice.Text != "" && txtsaleprice.Text != "")
            {
                int purchseprice = int.Parse(txtprodctpurchseprice.Text);
                int saleprice = int.Parse(txtsaleprice.Text);
                if (purchseprice < saleprice)
                {

                    SqlCommand cmd = new SqlCommand("insert_product", sc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vname", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@pname", txtprdctname.Text);
                    cmd.Parameters.AddWithValue("@pcat", txtprdctcate.Text);

                    cmd.Parameters.AddWithValue("@ppurchaseprice", txtprodctpurchseprice.Text);
                    cmd.Parameters.AddWithValue("@psaleprice", txtsaleprice.Text);
                    cmd.Parameters.AddWithValue("@pquan", txtprdctquantity.Text);
                    cmd.Parameters.AddWithValue("@ptax", prdcttax.Text);
                    cmd.Parameters.AddWithValue("@pcompn", prdctcompny.Text);
                    cmd.Parameters.AddWithValue("@ptime", label8.Text);
                    cmd.Parameters.AddWithValue("@pdate", label10.Text);
                    sc.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfull");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
