using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    class MethodClass
    {
        public SqlConnection sc;
        public SqlCommand cmd;
        public SqlDataAdapter adp;

        //pattern for Quantity , R_price, W_price text box
        public string a = @"^[0-9]+$";
        //for alphabet
        public string b = @"^[A-Z a-z 0-9 -]+$";
       



        public void ConnectionMethod()
        {
            //asghar
            //SqlConnection sc = new SqlConnection("Data Source=;user id=sa;password=;database=Inventory Management System");
        //ibad
           sc = new SqlConnection("Data Source=IBADAHMED;user id=sa;password=ghufran;database=Inventory Management System");

        }
        
        
    }
}
