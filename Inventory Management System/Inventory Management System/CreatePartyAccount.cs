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
    public partial class CreatePartyAccount : Form
    {
        MethodClass MethodClassObj = new MethodClass();

        public CreatePartyAccount()
        {
            InitializeComponent();
            MethodClassObj.ConnectionMethod();
        }

        public void refresh()
        {
            PartyNameTextbox.Text = "";
            PersonNameTextBox.Text = "";
            ShopAddressTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            MobileNumberTextBox.Text = "";
            PhoneNumber_Validate_Label.Text = "*";
            MobileNumber_Validate_Label.Text = "*";
            DateTextBox.Text = "";
        }



        private void CreatePartyAccount_Load(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(PartyNameTextbox.Text))
                {
                    var today = DateTime.Today.ToString("dd/MM/yyyy");
                    MethodClassObj.cmd = new SqlCommand("insert into CreatePartyAccount values('" + PartyNameTextbox.Text + "','" + PersonNameTextBox.Text + "','" + ShopAddressTextBox.Text + "','" + MobileNumberTextBox.Text + "','" + PhoneNumberTextBox.Text + "','" + DateTextBox.Text + "')", MethodClassObj.sc);
                    MethodClassObj.sc.Open();
                    MethodClassObj.cmd.ExecuteNonQuery();
                    MethodClassObj.sc.Close();
                    MessageBox.Show("inserted");
                    refresh();
                }

                else
                {
                    MessageBox.Show(" party name is required"); 
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(" party name already exist");    
            }





        }

        private void MobileNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(MobileNumberTextBox.Text, MethodClassObj.a))
            {
                //string a=@"^[0-9]";
                MobileNumber_Validate_Label.Text = "valid";
            }

            else 
            {
                MobileNumber_Validate_Label.Text = "invalid";
            }
                        
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //string a = @"^[0-9]+$";
            if(Regex.IsMatch(PhoneNumberTextBox.Text, MethodClassObj.a))
            {
                PhoneNumber_Validate_Label.Text = "valid";
            }
            else
            {
                PhoneNumber_Validate_Label.Text = "invalid";
            }


        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Mainfrom mfrm = new Mainfrom();
            mfrm.Show();
        
        }
    }
}
