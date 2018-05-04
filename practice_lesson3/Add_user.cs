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
    public partial class Add_user : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        public Add_user()
        {
            InitializeComponent();
        }

        private void cmdupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection connection_1 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            string inserQuery = "INSERT into inventory_simple.employee_table(last_name,first_name,middle_name,address,phone,username,password,confirm,account_type) values('" + txtlname.Text + "','" + txtfname.Text + "','" + txtmname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtconfirm.Text + "','" + accounttype.Text + "')";
            connection_1.Open();
            MySqlCommand command = new MySqlCommand(inserQuery, connection_1);

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



            connection_1.Close();

        }
        private void clear()
        {
            //product_code.Clear();
           txtlname.Clear();
           txtfname.Clear();
           txtmname.Clear();
           txtmname.Clear();
           txtaddress.Clear();
           txtcontact.Clear();
           txtusername.Clear();
           txtpassword.Clear();
           txtconfirm.Clear();

        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM inventory_simple.account_type_table";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    accounttype.Items.Add(reader.GetString("account_name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clear();
        }

        private void accounttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
