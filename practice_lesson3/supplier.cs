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
    public partial class supplier : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public supplier()
        {
            InitializeComponent();
        }

        private void supplier_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            //product_code.Clear();
            supplier_code.Clear();
            supplier_name.Clear();
            address.Clear();
            telephone_No.Clear();
            mobile_No.Clear();
            location.Clear();
            manufacturer.Clear();
            company_Name.Clear();

        }
        public void loaddata()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
            string query = "select supplier_code,address,telephone_No,mobile_No,location,manufacturer,company_name from inventory_simple.supplier_table ";
            using (MySqlConnection conn = new MySqlConnection(connectionString))//using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataload_supplier.DataSource = ds.Tables[0];
                }
            }

        }


        private void Submit_Click(object sender, EventArgs e)
        {

            //string inserQuery = "INSERT into inventory_simple.inventory_table(barcode,product_name,price,date) values('" + barcode.Text + "','" + productname.Text + "','" + price.Text + "'," + dateTimePicker.Text + ")";
            string inserQuery = "INSERT into inventory_simple.supplier_table(supplier_code,address,telephone_No,mobile_No,location,manufacturer,company_name) values('" +supplier_code.Text + "','" + supplier_name.Text + "','" + address.Text + "','" + telephone_No.Text + "','" + mobile_No.Text + "','" + location.Text + "','" + manufacturer.Text + "','" + manufacturer.Text + "','" + company_Name.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(inserQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data have been inserted");
                    loaddata();
                    clear();
                }
                else
                {
                    MessageBox.Show("Data not inserted Please check your Data again before you save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            connection.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
