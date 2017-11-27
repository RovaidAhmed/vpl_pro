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
    public partial class updatevendor : Form
    {
        public updatevendor()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtvendrid.Text!="" && txtvndrname.Text != "" && txtvndrcontctnumbr.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update_vendor", sc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", txtvendrid.Text);
                cmd.Parameters.AddWithValue("@name", txtvndrname.Text);
                cmd.Parameters.AddWithValue("@company", txtvndrcompny.Text);
                cmd.Parameters.AddWithValue("@contact", txtvndrcontctnumbr.Text);
                cmd.Parameters.AddWithValue("@email", txtvndremail.Text);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("Successfull");
                gridfill();
             txtvendrid.Text=txtvndrname.Text = txtvndrcompny.Text = txtvndrcontctnumbr.Text = txtvndremail.Text = null;
            }
            else
            {

                MessageBox.Show("Data is not update", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvendrid.Text=txtvndrname.Text = txtvndrcompny.Text = txtvndrcontctnumbr.Text = txtvndremail.Text = null;
            }
        }
        public void gridfill()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Vendor", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void updatevendor_Load(object sender, EventArgs e)
        {
            gridfill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtvendrid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtvndrname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtvndrcompny.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtvndrcontctnumbr.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtvndremail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
