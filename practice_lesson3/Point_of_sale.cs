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
    public partial class Point_of_sale : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        string InvoiceNo;
        double TotalAmount;
        double vat_tax;
        double VAT;
        public Point_of_sale()
        {
            InitializeComponent();
        }

        private void Point_of_sale_Load(object sender, EventArgs e)
        {
            loaddata();
            searchData("");
            vat_tax = (100 + VAT) / 100;
            //lbldate.Text = Format(Now, "MM/dd/yyyy");//d/m/yyyy
            lbldate.Text = DateTime.Now.ToString("yyyy-MM-dd");
           
        }
        //private void adddata()
        //{
            //Amount Due
          //  txttotalamountdue.Text = Convert.ToString(Convert.ToInt32(txtprice.Text) + Convert.ToInt32(txtvat12.Text) * Convert.ToInt32(txtqty.Text));
           // txtvat12.Text = ("16%");

      //  }
        private void clear()
        {
            //lbltotalamount.Text = "";
            txtID.Clear();
            txtname.Clear();
            txtprice.Clear();
            txtqty.Clear();
            //txtvat12.Clear();
            //txtDiscount.Clear();
            //txttotalamountdue.Clear();
            //txttotalamount.Clear();
           // txt_totalamount.Clear();
            textsearchValueToSearch.Clear();
            txtreceiptno.Clear();

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbltotalamount_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void lblready_Click(object sender, EventArgs e)
        {

        }

        private void lblarrow_Click(object sender, EventArgs e)
        {

        }

        private void lblbarcode_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalamountdue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void txtreceiptno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtamountdue_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdclose_Click(object sender, EventArgs e)
        {

        }

        private void txtvat12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void cmdclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataloadPOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataloadPOS.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtID.Text = row.Cells[1].Value.ToString();
                txtname.Text = row.Cells[2].Value.ToString();
                txtprice.Text = row.Cells[3].Value.ToString();
                txtqty.Text = row.Cells[5].Value.ToString();
            }
        }
        public void loaddata()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password="; //Set your MySQL connection string here.
            //string query = "select * from inventory_simple.inventory_table"; // set query to fetch data "Select * from tabelname"; 
            string query = "select product_code,product_name,price,quantity from inventory_simple.inventory_table ";
            using (MySqlConnection conn = new MySqlConnection(connectionString))//using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataloadPOS.DataSource = ds.Tables[0];
                }
            }

        }
        public void searchData(string valueToSearch)
        {
            //string query = "SELECT * FROM category_table WHERE CONCAT(`categoryNo`, `category_name`, `description_category`) like '%" + valueToSearch + "%'";
            string query = "select * from inventory_simple.inventory_table WHERE CONCAT(`product_code`, `product_name`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataloadPOS.DataSource = table;
        }

        private void GroupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void search_load_Click(object sender, EventArgs e)
        {
            string valueToSearch = textsearchValueToSearch.Text.ToString();
            searchData(valueToSearch);
        }

        private void txttotalamountdue_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtprice_TextChanged_1(object sender, EventArgs e)
        {
            //txttotalamountdue.Text = Convert.ToString(Convert.ToInt32(txtprice.Text) + Convert.ToInt32(txtvat12.Text) + Convert.ToInt32(txtqty.Text));
            if (!string.IsNullOrEmpty(txtprice.Text) && !string.IsNullOrEmpty(txtqty.Text) && !string.IsNullOrEmpty(txtvat12.Text))
                txttotalamountdue.Text = (Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text) * Convert.ToInt32(txtvat12.Text)).ToString();
        }

        private void txtvat12_TextChanged_1(object sender, EventArgs e)
        {
            //txtvat12.Text = ("16%");
            //txttotalamountdue.Text = Convert.ToString(Convert.ToInt32(txtprice.Text) + Convert.ToInt32(txtvat12.Text) + Convert.ToInt32(txtqty.Text));
        }

        private void txtqty_TextChanged_1(object sender, EventArgs e)
        {
            //txttotalamountdue.Text = Convert.ToString(Convert.ToInt32(txtprice.Text) + Convert.ToInt32(txtvat12.Text) + Convert.ToInt32(txtqty.Text));
           // if (!string.IsNullOrEmpty(txtprice.Text) && !string.IsNullOrEmpty(txtqty.Text))
              //  txttotalamountdue.Text = (Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text)).ToString();
            if (!string.IsNullOrEmpty(txtprice.Text) && !string.IsNullOrEmpty(txtqty.Text) && !string.IsNullOrEmpty(txtvat12.Text))
                txttotalamountdue.Text = (Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text) * Convert.ToInt32(txtvat12.Text)).ToString();
        }

        private void txtvat12_TextChanged_2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtprice.Text) && !string.IsNullOrEmpty(txtqty.Text) && !string.IsNullOrEmpty(txtvat12.Text))
                txttotalamountdue.Text = (Convert.ToInt32(txtprice.Text) * Convert.ToInt32(txtqty.Text) * Convert.ToInt32(txtvat12.Text)).ToString();
        }

        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttotalamount.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
                txt_totalamount.Text = (Convert.ToInt32(txttotalamount.Text) - Convert.ToInt32(txtDiscount.Text)).ToString();
        }

        private void txttotalamountdue_TextChanged_2(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txttotalamountdue.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
                //txttotalamount.Text = (Convert.ToInt32(txttotalamountdue.Text) - Convert.ToInt32(txtDiscount.Text)).ToString();
            txt_totalamount.Text = txttotalamountdue.Text;
            lbltotalamount.Text = txttotalamountdue.Text;
        }

        private void txttotalamount_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txttotalamount.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
               // txt_totalamount.Text = (Convert.ToInt32(txttotalamount.Text) - Convert.ToInt32(txtDiscount.Text)).ToString();
        }

        private void cmdAccept_Click_1(object sender, EventArgs e)
        {
            //string inserQuery = "INSERT into inventory_simple.sales_table(item_id,item_name,price,quantity,today_date) values('" + txtprice.Text + "','" + txtqty.Text + "','" + lbldate.Text + "')";
            string inserQuery = "INSERT into inventory_simple.sales_table(item_id,item_name,price,quantity,vat,discount,totalamountdue,	total_cash,today_date) values('" + txtID.Text + "','" + txtname.Text + "','" + txtprice.Text + "','" + txtqty.Text + "','" + txtvat12.Text + "','" + txtDiscount.Text + "','" + txttotalamountdue.Text + "','" + txt_totalamount.Text + "','" + lbldate.Text + "')";
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

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
