using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_lesson3
{
    public partial class sales : Form
    {
        public sales()
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
    }
}
