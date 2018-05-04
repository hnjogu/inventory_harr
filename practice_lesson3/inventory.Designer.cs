namespace practice_lesson3
{
    partial class inventory
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
            this.label2 = new System.Windows.Forms.Label();
            this.product_code = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.entry_date = new System.Windows.Forms.DateTimePicker();
            this.dataload_inventory = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.suplier = new System.Windows.Forms.TextBox();
            this.Expiry_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.product_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.add_supplier = new System.Windows.Forms.Button();
            this.product_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataload_inventory)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // product_code
            // 
            this.product_code.Location = new System.Drawing.Point(93, 57);
            this.product_code.Name = "product_code";
            this.product_code.Size = new System.Drawing.Size(74, 20);
            this.product_code.TabIndex = 2;
            this.product_code.TextChanged += new System.EventHandler(this.product_code_TextChanged);
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(93, 96);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(74, 20);
            this.productname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(236, 96);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(74, 20);
            this.price.TabIndex = 5;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkGreen;
            this.Submit.Location = new System.Drawing.Point(34, 427);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(73, 25);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(799, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(58, 28);
            this.close.TabIndex = 9;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkGreen;
            this.update.Location = new System.Drawing.Point(126, 427);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(73, 25);
            this.update.TabIndex = 10;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // entry_date
            // 
            this.entry_date.CustomFormat = "yyyy-MM-dd";
            this.entry_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entry_date.Location = new System.Drawing.Point(197, 57);
            this.entry_date.Name = "entry_date";
            this.entry_date.Size = new System.Drawing.Size(113, 20);
            this.entry_date.TabIndex = 11;
            // 
            // dataload_inventory
            // 
            this.dataload_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataload_inventory.Location = new System.Drawing.Point(15, 159);
            this.dataload_inventory.Name = "dataload_inventory";
            this.dataload_inventory.Size = new System.Drawing.Size(842, 262);
            this.dataload_inventory.TabIndex = 12;
            this.dataload_inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataload_CellContentClick_1);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.DarkGreen;
            this.refresh.Location = new System.Drawing.Point(208, 427);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(73, 25);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(408, 57);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(74, 20);
            this.quantity.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Suplier_Code";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // suplier
            // 
            this.suplier.Location = new System.Drawing.Point(408, 100);
            this.suplier.Name = "suplier";
            this.suplier.Size = new System.Drawing.Size(74, 20);
            this.suplier.TabIndex = 17;
            this.suplier.TextChanged += new System.EventHandler(this.suplier_TextChanged);
            // 
            // Expiry_date
            // 
            this.Expiry_date.CustomFormat = "yyyy-MM-dd";
            this.Expiry_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Expiry_date.Location = new System.Drawing.Point(542, 54);
            this.Expiry_date.Name = "Expiry_date";
            this.Expiry_date.Size = new System.Drawing.Size(113, 20);
            this.Expiry_date.TabIndex = 18;
            this.Expiry_date.ValueChanged += new System.EventHandler(this.Expiry_date_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Expiry_date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "purchase_date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Manufacturer";
            // 
            // manufacturer
            // 
            this.manufacturer.Location = new System.Drawing.Point(564, 103);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(91, 20);
            this.manufacturer.TabIndex = 22;
            // 
            // company
            // 
            this.company.Location = new System.Drawing.Point(762, 54);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(95, 20);
            this.company.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(705, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Company";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Product_Category";
            // 
            // product_category
            // 
            this.product_category.FormattingEnabled = true;
            this.product_category.Location = new System.Drawing.Point(762, 100);
            this.product_category.Name = "product_category";
            this.product_category.Size = new System.Drawing.Size(95, 21);
            this.product_category.TabIndex = 27;
            this.product_category.SelectedIndexChanged += new System.EventHandler(this.product_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(270, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product Entry";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(60, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(647, 31);
            this.Panel1.TabIndex = 31;
            // 
            // add_supplier
            // 
            this.add_supplier.BackgroundImage = global::practice_lesson3.Properties.Resources.button_plus_blue;
            this.add_supplier.Location = new System.Drawing.Point(488, 91);
            this.add_supplier.Name = "add_supplier";
            this.add_supplier.Size = new System.Drawing.Size(50, 36);
            this.add_supplier.TabIndex = 32;
            this.add_supplier.UseVisualStyleBackColor = true;
            this.add_supplier.Click += new System.EventHandler(this.add_supplier_Click);
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.Location = new System.Drawing.Point(90, 143);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(0, 13);
            this.product_id.TabIndex = 33;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(882, 455);
            this.ControlBox = false;
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.add_supplier);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.product_category);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.company);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Expiry_date);
            this.Controls.Add(this.suplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataload_inventory);
            this.Controls.Add(this.entry_date);
            this.Controls.Add(this.update);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.product_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataload_inventory)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_code;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DateTimePicker entry_date;
        private System.Windows.Forms.DataGridView dataload_inventory;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox suplier;
        private System.Windows.Forms.DateTimePicker Expiry_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.TextBox company;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox product_category;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button add_supplier;
        private System.Windows.Forms.Label product_id;
    }
}

