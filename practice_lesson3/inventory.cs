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
    public partial class inventory : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        //String MyConnectionString = "Server=localhost;port=3306;username=root;password=";
        public inventory()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            //string inserQuery = "INSERT into inventory_simple.inventory_table(barcode,product_name,price,date) values('" + barcode.Text + "','" + productname.Text + "','" + price.Text + "'," + dateTimePicker.Text + ")";
            string inserQuery = "INSERT into inventory_simple.inventory_table(product_code,product_name,price,entry_date,quantity,suplier_code,expiry_date,manufacturer,company,product_category) values('" + product_code.Text + "','" + productname.Text + "','" + price.Text + "','" + entry_date.Text + "','" + quantity.Text + "','" + suplier.Text + "','" + Expiry_date.Text + "','" + manufacturer.Text + "','" + company.Text + "','" + product_category.Text + "')";
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
        private void clear()
        {
            //product_code.Clear();
            productname.Clear();
            price.Clear();
            quantity.Clear();
            suplier.Clear();
            manufacturer.Clear();
            company.Clear();
            	
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }
        //auto product number
                //static string IncrementID(string startValue, int numNonDigits)
              //  {
               //     string nonDigits = startValue.Substring(0, numNonDigits);
                  //  int len = startValue.Length - numNonDigits;
                //    int number = int.Parse(startValue.Substring(numNonDigits));
                //    number++;
                //    if (number >= Math.Pow(10, len)) number = 1; // start again at 1
                 //   return String.Format("{0}{1:D" + len.ToString() + "}", nonDigits, number);
                //}
        public static string IncrementID2(string startValue, int numNonDigits)
                {
                    int max = 999999999;
                    string[] parts = startValue.Split('/');
                    // is it safe to assume that the third splitted string is the number you're looking for?
                    int number;
                    if (Int32.TryParse(parts[2], out number))
                    {
                        number++;
                    }
                    else
                    {
                        //if the number doesn't parse correctly, set it to zero number = 0;
                    }
                    number = (number > max) ? 1 : number;
                    return string.Format("PC{0:D9}/POS", number);
                }
        private void Genarate_productcode()
        {
            //product_code.Text = IncrementID2("",9);



            //product_code.Text = IncrementID2("startValue",9);
           //product_code.Text = IncrementID2(" ", 9); // produces QIEpl/PO/0000010 // C00011 PCI0001
            //IncrementID2 = product_code;
           //product_code.Text = IncrementID2("startvalue" , 9);
            //product_code.Text = IncrementID2("", 9);
           
        } 

        public void loaddata()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
            string query = "select product_code,product_name,price,entry_date,expiry_date,manufacturer,company,product_category from inventory_simple.inventory_table ";
            using (MySqlConnection conn = new MySqlConnection(connectionString))//using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataload_inventory.DataSource = ds.Tables[0];
                }
            }

        }

        private void inventory_Load(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM inventory_simple.category_table";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product_category.Items.Add(reader.GetString("category_name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clear();
            Genarate_productcode();
            loaddata();

        }
        private void dataload_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //it checks if the row index of the cell is greater than or equal to zero
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataload_inventory.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                product_code.Text = row.Cells[0].Value.ToString();
                productname.Text = row.Cells[1].Value.ToString();
                price.Text = row.Cells[2].Value.ToString();
            }
 
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            clear();
            loaddata();
        }

        private void product_code_TextChanged(object sender, EventArgs e)
        {
            //IncrementID2();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string updateQuery = "update inventory_simple.inventory_table set product_code='" + this.product_code.Text + "',product_name='" + this.productname.Text+ "',entry_date='" + this.entry_date.Text + "',price='" + this.price.Text + "';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(updateQuery, connection);

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Expiry_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void suplier_TextChanged(object sender, EventArgs e)
        {
            //Form f = new Form();
            //f.ShowDialog(this);
            searchdialog_box searchdialog_box = new searchdialog_box();
            searchdialog_box.Show();
        }

        private void product_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
