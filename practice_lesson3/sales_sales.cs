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
    public partial class sales_sales : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public sales_sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            listloadsales.GridLines = true;
            listloadsales.View = View.Details;

            listloadsales.Columns.Add("item_id", 150);
            listloadsales.Columns.Add("item_name", 150);
            listloadsales.Columns.Add("price", 150);
            listloadsales.Columns.Add("quantity", 150);
            listloadsales.Columns.Add("vat", 150);
            listloadsales.Columns.Add("discount", 150);
            listloadsales.Columns.Add("totalamountdue", 150);
            listloadsales.Columns.Add("today_date", 150);
         
        }

        private void load_sales_Click(object sender, EventArgs e)
        {
            string con1 = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection cnn = new MySqlConnection(con1);
            cnn.Open();
            //string sql = "Select * from inventory_simple.sales_table";
            string sql = "Select item_id,item_name,price,quantity,vat,discount,totalamountdue,today_date from inventory_simple.sales_table";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listloadsales.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
                lv.SubItems.Add(Reader.GetString(5));
                lv.SubItems.Add(Reader.GetString(6));
                lv.SubItems.Add(Reader.GetString(7));
                listloadsales.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            cnn.Close();

        }

        private void listloadsales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refresh_sales_Click(object sender, EventArgs e)
        {
            string con1 = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection cnn = new MySqlConnection(con1);
            cnn.Open();
            //string sql = "Select * from inventory_simple.sales_table";
            string sql = "Select item_id,item_name,price,quantity,vat,discount,totalamountdue,today_date from inventory_simple.sales_table";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listloadsales.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
                lv.SubItems.Add(Reader.GetString(5));
                lv.SubItems.Add(Reader.GetString(6));
                lv.SubItems.Add(Reader.GetString(7));
                listloadsales.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            cnn.Close();
        }

        private void cancel_sales_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
