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
    public partial class DeleteUser : Form 
    {
        MethodClass MethodClassObj = new MethodClass();
        public DeleteUser()
        {
            InitializeComponent();
            MethodClassObj.ConnectionMethod();
        }
       // SqlConnection sc = new SqlConnection("Data Source=IBADAHMED;user id=sa;password=ghufran;database=Inventory Management System");




        public void updategrid()
        {
            SqlCommand cmd = new SqlCommand("select_user", MethodClassObj.sc);
            cmd.CommandType = CommandType.StoredProcedure;
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

                    SqlCommand cmd = new SqlCommand("delete_user", MethodClassObj.sc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MethodClassObj.sc.Open();
                    cmd.ExecuteNonQuery();
                    MethodClassObj.sc.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

            updategrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Mainfrom mainformObj = new Mainfrom();
            mainformObj.Show();
        }
    }
}
