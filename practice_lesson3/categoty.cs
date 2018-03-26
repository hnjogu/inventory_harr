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
    public partial class categoty : Form

    {
         MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
         MySqlCommand command;
         MySqlDataAdapter adapter;
         DataTable table;
        public categoty()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
        private void clear()
        {
            //product_code.Clear();
            txtCatName.Text = "";
            txtDescription.Text = "";


        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string inserQuery = "INSERT into inventory_simple.category_table(category_name,description_category) values('" + txtCatName.Text + "','" + txtDescription.Text + "')";
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
        public void loaddata()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
            string query = "select 	categoryNo,category_name,description_category from inventory_simple.category_table ";
            using (MySqlConnection conn = new MySqlConnection(connectionString))//using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    datasearch.DataSource = ds.Tables[0];
                }
            }

        }
        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueToSearch = textsearchValueToSearch.Text.ToString();
            searchData(valueToSearch);
        }
        public void searchData(string valueToSearch)
        {
            //string query = "SELECT * FROM category_table WHERE CONCAT(`categoryNo`, `category_name`, `description_category`) like '%" + valueToSearch + "%'";
            string query = "select * from inventory_simple.category_table WHERE CONCAT(`categoryNo`, `category_name`, `description_category`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            datasearch.DataSource = table;
       }
        private void datasearch_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.datasearch.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                lblCategoryNo.Text = row.Cells[0].Value.ToString();
                txtCatName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
            }
        }

        private void categoty_Load(object sender, EventArgs e)
        {
            
            loaddata();
            searchData("");
            clear();
            
        }

        private void searchload_Click(object sender, EventArgs e)
        {
            string valueToSearch = textsearchValueToSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void update_data_Click(object sender, EventArgs e)
        {
            string Query = "update inventory_simple.category_table set 	categoryNo='" + this.lblCategoryNo.Text + "', category_name='" + this.txtCatName.Text + "',description_category='" + this.txtDescription.Text + "' where categoryNo='" + this.lblCategoryNo.Text + "';";
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

        private void textsearchValueToSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
