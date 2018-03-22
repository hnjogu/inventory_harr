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
        public Add_user()
        {
            InitializeComponent();
        }

        private void cmdupdate_Click(object sender, EventArgs e)
        {
            string inserQuery = "INSERT into inventory_simple.employee_table(last_name,first_name,middle_name,address,phone,username,password,confirm,account_type) values('" + txtlname.Text + "','" + txtfname.Text + "','" + txtmname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtconfirm.Text + "','" + accounttype.Text + "')";
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
    }
}
