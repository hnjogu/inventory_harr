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
    public partial class userlogin_frm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        int i;
        public userlogin_frm()
        {
            InitializeComponent();
        }

        private void userlogin_frm_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {

            i = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM inventory_simple.employee_table WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("You have entered invalid username and password");
            }
            else
            {
                this.Hide();
                home_screen fm = new home_screen();
                fm.Show();

            }
            connection.Close();
                
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
