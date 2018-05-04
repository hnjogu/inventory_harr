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
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public supplier()
        {
            InitializeComponent();
        }
        public void searchData(string valueToSearch)
        {
            //string query = "SELECT * FROM category_table WHERE CONCAT(`categoryNo`, `category_name`, `description_category`) like '%" + valueToSearch + "%'";
            string query = "select * from inventory_simple.supplier_table  WHERE CONCAT(`supplier_code`, `supplier_name`, `address`, `Contact_No`, `location`, `manufacturer`, `company_name`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataload_supplier.DataSource = table;
        }
        private void supplier_Load(object sender, EventArgs e)
        {
            loaddata();
            searchData("");
            clear();
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
            lblsuppliercode.Text = "";
            supplier_name.Clear();
            address.Clear();
            Contact_No.Clear();
            location.Clear();
            manufacturer.Clear();
            company_Name.Clear();

        }
        public void loaddata()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
            string query = "select supplier_code,supplier_name,address,Contact_No,location,manufacturer,company_name from inventory_simple.supplier_table ";
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
            string inserQuery = "INSERT into inventory_simple.supplier_table(supplier_name,address,Contact_No,location,manufacturer,company_name) values('" + supplier_name.Text + "','" + address.Text + "','" + Contact_No.Text + "','" + location.Text + "','" + manufacturer.Text + "','" + company_Name.Text + "')";
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

        private void update_Click(object sender, EventArgs e)
        {
            string Query = "update inventory_simple.supplier_table set 	supplier_code='" + this.lblsuppliercode.Text + "', supplier_name='" + this.supplier_name.Text + "', address='" + this.address.Text + "', Contact_No='" + this.Contact_No.Text + "',location='" + this.location.Text + "',manufacturer='" + this.manufacturer.Text + "',company_name='" + this.company_Name.Text + "' where 	supplier_code='" + this.lblsuppliercode.Text + "';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(Query, connection);

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

        private void refresh_Click(object sender, EventArgs e)
        {
            clear();
            loaddata();
        }

        private void dataload_supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataload_supplier.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lblsuppliercode.Text = row.Cells[0].Value.ToString();
                supplier_name.Text = row.Cells[1].Value.ToString();
                address.Text = row.Cells[2].Value.ToString();
                Contact_No.Text = row.Cells[3].Value.ToString();
                location.Text = row.Cells[4].Value.ToString();
                manufacturer.Text = row.Cells[5].Value.ToString();
                company_Name.Text = row.Cells[6].Value.ToString();
            }
        }

        private void search_data_Click(object sender, EventArgs e)
        {
            string valueToSearch = textsearchValueToSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string Query = "delete from inventory_simple.supplier_table where supplier_code='" + this.lblsuppliercode.Text + "';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(Query, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data have been deleted");
                    loaddata();
                    clear();
                }
                else
                {
                    MessageBox.Show("Data not deleted Please check your Data again before you delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            connection.Close(); 
        }

        private void textsearchValueToSearch_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
