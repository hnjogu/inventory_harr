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
    public partial class account_type : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public account_type()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear()
        {
            txtAccountname.Clear();
            txtDescription.Clear();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string inserQuery = "INSERT into inventory_simple.account_type_table(account_name,description) values('" + txtAccountname.Text + "','" + txtDescription.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(inserQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data have been inserted");
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
    }
}
