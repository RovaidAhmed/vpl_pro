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
    public partial class Addvendor : Form
    {
        public Addvendor()
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
            if (txtvndrname.Text != "" && txtvndrcontctnumbr.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert_vendor", sc);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtvndrname.Text);
                cmd.Parameters.AddWithValue("@company", txtvndrcompny.Text);
                cmd.Parameters.AddWithValue("@contact", txtvndrcontctnumbr.Text);
                cmd.Parameters.AddWithValue("@email", txtvndremail.Text);
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("Successfull");
                txtvndrname.Text = txtvndrcompny.Text = txtvndrcontctnumbr.Text = txtvndremail.Text = null;
            }
            else
            {

                MessageBox.Show("Data is not insert", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvndrname.Text = txtvndrcompny.Text = txtvndrcontctnumbr.Text = txtvndremail.Text = null;
            }
        }

        private void Addvendor_Load(object sender, EventArgs e)
        {

        }
    }
}
