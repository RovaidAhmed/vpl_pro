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
using System.Text.RegularExpressions;


namespace Inventory_Management_System
{
    public partial class AddProduct : Form
    {
        MethodClass MethodClassObj = new MethodClass(); 
        public AddProduct()
        {
            MethodClassObj.ConnectionMethod();
            InitializeComponent();
           RetreivePartyNameintoComboBox();
        }

        public void refresh()
        {

            txtDate.Text = "";
            txtProductArticle.Text = "";
            txtProductColour.Text = "";
            txtProductCatogery.Text = "";
            txtProductDescription.Text = "";
            txtProductPurchasePrice.Text = "";
            txtProductSalePrice.Text = "";
            txtProductQuantity.Text = "";
            txtProductSize.Text = "";
            txtTotalPurchaePrice.Text = "";
            txtTotalSalePrice.Text = "";
            


        }

        public void RetreivePartyNameintoComboBox()
        {
            //asghar
            //ibad
            //string conString = @"Data Source=IBADAHMED;user id=sa;password=ghufran;database=Inventory Management System";
            ////MethodClassObj.ConnectionMethod();
            ////DataSet ds = new DataSet();
            string conString = @"Data Source=IBADAHMED;user id=sa;password=ghufran;database=Inventory Management System";
            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            try
            {

                ////MethodClassObj.sc.Open();
                ////MethodClassObj.cmd = new SqlCommand("select PartyName from CreatePartyAccount", MethodClassObj.sc);
                ////MethodClassObj.adp = new SqlDataAdapter();
                ////MethodClassObj.adp.SelectCommand = MethodClassObj.cmd;
                ////MethodClassObj.adp.Fill(ds);
                ////PartyNameComboBox.DisplayMember = "PartyName";
                ////PartyNameComboBox.DataSource = ds.Tables[0];
                conn.Open();
                MethodClassObj.cmd = new SqlCommand("select PartyName from CreatePartyAccount",conn);
                MethodClassObj.adp = new SqlDataAdapter();
                MethodClassObj.adp.SelectCommand = MethodClassObj.cmd;
                MethodClassObj.adp.Fill(ds);
                PartyNameComboBox.DisplayMember = "PartyName";
                PartyNameComboBox.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                ////MessageBox.Show(ex.Message);
            }
            finally
            {
                ////MethodClassObj.sc.Close();
                ////MethodClassObj.sc.Dispose();
                conn.Close();
                conn.Dispose();
            }

        }


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

        private void Product_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtTotalPurchaePrice.Enabled = false;
            txtTotalSalePrice.Enabled = false;


        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

            if(Regex.IsMatch(txtProductArticle.Text,MethodClassObj.b))
            {
                Article_Validate_Label.Text = "valid";           
            
            }
            else
            {
                Article_Validate_Label.Text = "invalid";

            }


        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {
            //string a = @"^[0-9]+$";
            if(Regex.IsMatch(txtProductQuantity.Text,MethodClassObj.a))
            {
                Quantity_Validate_Label.Text = "valid";
            }

            else
            {
                Quantity_Validate_Label.Text = "invalid";
            }

              try
            {
                //sale_Total ==Quantity text * sale_price text 
                if (!string.IsNullOrEmpty(txtProductQuantity.Text) && !string.IsNullOrEmpty(txtProductSalePrice.Text))
                {
                    txtTotalSalePrice.Text = (Convert.ToInt32(txtProductQuantity.Text) * Convert.ToInt32(txtProductSalePrice.Text)).ToString();
                }
            }

              catch (Exception ex)
              {
                  MessageBox.Show("use just number");
              }


              try
            {
                //purchase_Total ==Quantity text * purchase_price text 
                if (!string.IsNullOrEmpty(txtProductQuantity.Text) && !string.IsNullOrEmpty(txtTotalPurchaePrice.Text))
                {
                    txtTotalPurchaePrice.Text = (Convert.ToInt32(txtProductQuantity.Text) * Convert.ToInt32(txtTotalPurchaePrice.Text)).ToString();
                }
            }

              catch (Exception ex)
              {
                  MessageBox.Show("use just number");
              }
            
        }

        private void txtProductSalePrice_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtProductSalePrice.Text, MethodClassObj.a))
            {
                Sale_Validate_Label.Text = "valid";

            }

            else 
            {

                Sale_Validate_Label.Text = "invalid";
            }


            //sale Total ==Quantity text * sale price text 
            try
            {
                if (!string.IsNullOrEmpty(txtProductQuantity.Text) && !string.IsNullOrEmpty(txtProductSalePrice.Text))
                {
                    txtTotalSalePrice.Text = (Convert.ToInt32(txtProductQuantity.Text) * Convert.ToInt32(txtProductSalePrice.Text)).ToString();
                }
            
            }


            catch(Exception ex)
            {
            
            }
            
        }

        private void txtProductPurchasePrice_TextChanged(object sender, EventArgs e)
        {

            //string a = @"^[0-9]+$";
            if (Regex.IsMatch(txtProductPurchasePrice.Text, MethodClassObj.a))
            {
                PurchasePrice_Validate_Label.Text = "valid";
            }

            else
            {
                PurchasePrice_Validate_Label.Text = "invalid";
            }

            try
            {
                //purchase_Total ==Quantity text * purchase_price text 
                if (!string.IsNullOrEmpty(txtProductQuantity.Text) && !string.IsNullOrEmpty(txtProductPurchasePrice.Text))
                {
                    txtTotalPurchaePrice.Text = (Convert.ToInt32(txtProductQuantity.Text) * Convert.ToInt32(txtProductPurchasePrice.Text)).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("use just number");
            }
           
        }

        private void SaleBtn_Click(object sender, EventArgs e)
        {
            try
            {

                txtDate.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                if ((Article_Validate_Label.Text == "valid") && (Quantity_Validate_Label.Text == "valid") && (Sale_Validate_Label.Text == "valid") && (PurchasePrice_Validate_Label.Text == "valid"))
                {
                    //insert in product
                   // MethodClassObj.cmd = new SqlCommand("insert into Product values('" + txtProductArticle.Text + "','" + txtProductDescription.Text + "','" + txtProductColour.Text + "','" + txtProductCatogery.Text + "','" + txtProductSize.Text + "','" + txtProductQuantity.Text + "','" + txtProductPurchasePrice.Text + "','" + txtProductSalePrice.Text + "','" + PartyNameComboBox.Text + "','" + txtDate.Text + "','"+txtTotalPurchaePrice.Text+"','"+txtTotalSalePrice.Text+"')", MethodClassObj.sc);

                    MethodClassObj.cmd = new SqlCommand("insert into Product values('" + txtProductArticle.Text + "','" + txtProductDescription.Text + "','" + txtProductColour.Text + "','" + txtProductCatogery.Text + "','" + txtProductSize.Text + "','" + txtProductQuantity.Text + "','" + txtProductPurchasePrice.Text + "','" + txtProductSalePrice.Text + "','" + PartyNameComboBox.Text + "','" + txtDate.Text + "','" + txtTotalPurchaePrice.Text + "','" + txtTotalSalePrice.Text + "')", MethodClassObj.sc);
                    MethodClassObj.sc.Open();
                    MethodClassObj.cmd.ExecuteNonQuery();
                    MethodClassObj.sc.Close();



                    MessageBox.Show("addedd");

                     refresh();

                }

                else
                {
                    MessageBox.Show("all labels should be valid");
                }

            }
            catch(Exception ex)
            {

//                MessageBox.Show("you are doing something wrong");
                MessageBox.Show(ex.Message);
            }
            
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }        
    }
}
