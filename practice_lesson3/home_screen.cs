using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace practice_lesson3
{
    public partial class home_screen : Form
    {
        private int childFormNumber = 0;

        public home_screen()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            report.Visible = true;
            btnReport.Visible = true;
            product_button.Visible = true;
            suppliers_button.Visible = true;
            adduser_button.Visible = true;
            sales_button.Visible = true;
            products_labels.Visible = true;
            Sales_label.Visible = true;
            suppliers_label.Visible = true;
            add_users_label.Visible = true;
            dashboard.Visible = true;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void products_Click(object sender, EventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            product_guidebutton.Visible = true;
            cateoryguide.Visible = true;
            productguide.Visible = true;

        }

        private void suppliers_button_Click(object sender, EventArgs e)
        {
            supplier_guidebutton.Visible = true;
            supplierguide.Visible = true;
        }

        private void adduser_button_Click(object sender, EventArgs e)
        {
            Adduser_guidebutton.Visible = true;
            User_settingsbutton.Visible = true;
            Account_type_guide.Visible = true;
            adduserguide.Visible = true;
            
        }

        private void sales_button_Click(object sender, EventArgs e)
        {
            sales_sales sales_sales = new sales_sales();
            sales_sales.Show();
        }

        private void product_guidebutton_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.Show();
            product_guidebutton.Visible = false;
            cateoryguide.Visible = false;
            productguide.Visible = false;
            
        }

        private void supplier_guidebutton_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier();
            supplier.Show();
            supplier_guidebutton.Visible = false;
            supplierguide.Visible = false;

        }

        private void Adduser_guidebutton_Click(object sender, EventArgs e)
        {
            Add_user Add_user = new Add_user();
            Add_user.Show();
            Adduser_guidebutton.Visible = false;
            User_settingsbutton.Visible = false;
            Account_type_guide.Visible = false;
            adduserguide.Visible = false;
        }

        private void sale_guidebutton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            
        }

        private void picClose_Click(object sender, EventArgs e)
        {
  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("A you sure you want to exit");
           // {
               // Application.Exit();
           // }
            DialogResult iExit;
            iExit = MessageBox.Show("A you sure you want to exit" , "system down" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void cateory_Click(object sender, EventArgs e)
        {
            categoty categoty = new categoty();
            categoty.Show();
            product_guidebutton.Visible = false;
            cateoryguide.Visible = false;
            productguide.Visible = false;


        }

        private void Account_type_guide_Click(object sender, EventArgs e)
        {
            account_type account_type = new account_type();
            account_type.Show();
            Adduser_guidebutton.Visible = false;
            User_settingsbutton.Visible = false;
            Account_type_guide.Visible = false;
            adduserguide.Visible = false;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            Point_of_sale Point_of_sale = new Point_of_sale();
            Point_of_sale.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            salesreports salesreports = new salesreports();
            salesreports.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = DateTime.Now.ToString();
            lbltime.Text = System.DateTime.Now.ToString();
        }

        private void home_screen_Load(object sender, EventArgs e)
        {
            lbltime.Text = System.DateTime.Now.ToString();
            lblday.Text = System.DateTime.Now.DayOfWeek.ToString();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }   
    }
}
