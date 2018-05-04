using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace practice_lesson3
{
    public partial class salesreports : Form
    {
        public salesreports()
        {
            InitializeComponent();
        }

        private void cancel_sales_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GVReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loaddata()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
           // string query = "select supplier_code,supplier_name,address,Contact_No,location,manufacturer,company_name from inventory_simple.supplier_table ";
            string query = "Select item_id,item_name,price,quantity,vat,discount,totalamountdue,today_date from inventory_simple.sales_table";
            using (MySqlConnection conn = new MySqlConnection(connectionString))//using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    sales_Reports.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnsalesreports_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
            // string query = "select supplier_code,supplier_name,address,Contact_No,location,manufacturer,company_name from inventory_simple.supplier_table ";
            //string query = "select *from Tickets WHERE TicketNO='" & Textselect.Text & "'";
            string query = "Select item_id,item_name,price,quantity,vat,discount,totalamountdue,today_date from inventory_simple.sales_table where today_date='" + this.sales_reportdate.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))//using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    sales_Reports.DataSource = ds.Tables[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
            // string query = "select supplier_code,supplier_name,address,Contact_No,location,manufacturer,company_name from inventory_simple.supplier_table ";
            //string query = "select *from Tickets WHERE TicketNO='" & Textselect.Text & "'";
            string query = "Select item_id,item_name,price,quantity,vat,discount,totalamountdue,today_date from inventory_simple.sales_table where today_date='" + this.sale_report_start.Text + "',today_date='" + this.sale_report_end.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))//using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    sales_Reports.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
