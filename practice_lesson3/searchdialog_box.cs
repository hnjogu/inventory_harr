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
    public partial class searchdialog_box : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public searchdialog_box()
        {
            InitializeComponent();
        }

        private void searchdialog_box_Load(object sender, EventArgs e)
        {
            searchdata.GridLines = true;
            searchdata.View = View.Details;

            searchdata.Columns.Add("supplier_code", 150);
            searchdata.Columns.Add("supplier_name", 150);
            loaddata();

        }
        public void loaddata()
        {
            string con1 = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection cnn = new MySqlConnection(con1);
            cnn.Open();
            //string sql = "Select * from inventory_simple.sales_table";
            string sql = "Select supplier_code,supplier_name from inventory_simple.supplier_table";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader Reader = cmd.ExecuteReader();

            searchdata.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
               // lv.SubItems.Add(Reader.GetString(2));
                searchdata.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            cnn.Close();

        }

        private void searchdata_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in searchdata.Items)
            {
                item.BackColor = SystemColors.Window;
                item.ForeColor = SystemColors.WindowText;
            }
        }

        private void refresh_sales_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void cancel_sales_Click(object sender, EventArgs e)
        {
           // Application.Exit();
            this.Hide();
            inventory inventory = new inventory();
            inventory.Visible = true;
            inventory.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textsearch.Text != "")
            {
                for (int i = searchdata.Items.Count - 1; i >= 0; i--)
                {
                    var item = searchdata.Items[i];
                    if (item.Text.ToLower().Contains(textsearch.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        searchdata.Items.Remove(item);
                    }
                }
                if (searchdata.SelectedItems.Count == 1)
                {
                    searchdata.Focus();
                }
            }
            else
            {
                loaddata();
            }

        }

        private void searchme_Click(object sender, EventArgs e)
        {

        }
        
    }
}
