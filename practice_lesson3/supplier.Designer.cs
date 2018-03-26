namespace practice_lesson3
{
    partial class supplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.supplier_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Contact_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.company_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataload_supplier = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.lblsuppliercode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textsearchValueToSearch = new System.Windows.Forms.TextBox();
            this.search_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataload_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier_Code:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // supplier_name
            // 
            this.supplier_name.Location = new System.Drawing.Point(218, 41);
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Size = new System.Drawing.Size(82, 20);
            this.supplier_name.TabIndex = 3;
            this.supplier_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier_Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(218, 76);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(134, 74);
            this.address.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address:";
            // 
            // manufacturer
            // 
            this.manufacturer.Location = new System.Drawing.Point(497, 72);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(82, 20);
            this.manufacturer.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manufacturer:";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(497, 41);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(82, 20);
            this.location.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Location:";
            // 
            // Contact_No
            // 
            this.Contact_No.Location = new System.Drawing.Point(497, 7);
            this.Contact_No.Name = "Contact_No";
            this.Contact_No.Size = new System.Drawing.Size(82, 20);
            this.Contact_No.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contact_No:";
            // 
            // company_Name
            // 
            this.company_Name.Location = new System.Drawing.Point(497, 105);
            this.company_Name.Name = "company_Name";
            this.company_Name.Size = new System.Drawing.Size(82, 20);
            this.company_Name.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Company_Name:";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.refresh.Location = new System.Drawing.Point(372, 418);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(73, 25);
            this.refresh.TabIndex = 21;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkGreen;
            this.update.Location = new System.Drawing.Point(268, 418);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(73, 25);
            this.update.TabIndex = 20;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkGreen;
            this.Submit.Location = new System.Drawing.Point(164, 418);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(73, 25);
            this.Submit.TabIndex = 19;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkGreen;
            this.delete.Location = new System.Drawing.Point(476, 418);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(73, 25);
            this.delete.TabIndex = 22;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataload_supplier
            // 
            this.dataload_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataload_supplier.Location = new System.Drawing.Point(36, 192);
            this.dataload_supplier.Name = "dataload_supplier";
            this.dataload_supplier.Size = new System.Drawing.Size(711, 204);
            this.dataload_supplier.TabIndex = 23;
            this.dataload_supplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataload_supplier_CellContentClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(588, 416);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(58, 27);
            this.close.TabIndex = 24;
            this.close.Text = "Cancel";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lblsuppliercode
            // 
            this.lblsuppliercode.BackColor = System.Drawing.Color.White;
            this.lblsuppliercode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsuppliercode.Location = new System.Drawing.Point(218, 9);
            this.lblsuppliercode.Name = "lblsuppliercode";
            this.lblsuppliercode.Size = new System.Drawing.Size(82, 22);
            this.lblsuppliercode.TabIndex = 25;
            this.lblsuppliercode.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Enter Search Criteria";
            // 
            // textsearchValueToSearch
            // 
            this.textsearchValueToSearch.Location = new System.Drawing.Point(432, 166);
            this.textsearchValueToSearch.Name = "textsearchValueToSearch";
            this.textsearchValueToSearch.Size = new System.Drawing.Size(101, 20);
            this.textsearchValueToSearch.TabIndex = 27;
            // 
            // search_data
            // 
            this.search_data.BackColor = System.Drawing.Color.DarkGreen;
            this.search_data.Location = new System.Drawing.Point(664, 416);
            this.search_data.Name = "search_data";
            this.search_data.Size = new System.Drawing.Size(73, 25);
            this.search_data.TabIndex = 28;
            this.search_data.Text = "Search";
            this.search_data.UseVisualStyleBackColor = false;
            this.search_data.Click += new System.EventHandler(this.search_data_Click);
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(759, 444);
            this.ControlBox = false;
            this.Controls.Add(this.search_data);
            this.Controls.Add(this.textsearchValueToSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblsuppliercode);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataload_supplier);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Contact_No);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.company_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplier_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataload_supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplier_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Contact_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox company_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataload_supplier;
        private System.Windows.Forms.Button close;
        internal System.Windows.Forms.Label lblsuppliercode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textsearchValueToSearch;
        private System.Windows.Forms.Button search_data;
    }
}