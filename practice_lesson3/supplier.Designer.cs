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
            this.supplier_code = new System.Windows.Forms.TextBox();
            this.supplier_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mobile_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telephone_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.company_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataload_supplier = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataload_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier_Code:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // supplier_code
            // 
            this.supplier_code.Location = new System.Drawing.Point(218, 34);
            this.supplier_code.Name = "supplier_code";
            this.supplier_code.Size = new System.Drawing.Size(82, 20);
            this.supplier_code.TabIndex = 1;
            this.supplier_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // supplier_name
            // 
            this.supplier_name.Location = new System.Drawing.Point(218, 69);
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Size = new System.Drawing.Size(82, 20);
            this.supplier_name.TabIndex = 3;
            this.supplier_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier_Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mobile_No
            // 
            this.mobile_No.Location = new System.Drawing.Point(497, 34);
            this.mobile_No.Name = "mobile_No";
            this.mobile_No.Size = new System.Drawing.Size(82, 20);
            this.mobile_No.TabIndex = 7;
            this.mobile_No.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile No:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(218, 102);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(134, 59);
            this.address.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address:";
            // 
            // manufacturer
            // 
            this.manufacturer.Location = new System.Drawing.Point(497, 100);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(82, 20);
            this.manufacturer.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manufacturer:";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(497, 65);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(82, 20);
            this.location.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Location:";
            // 
            // telephone_No
            // 
            this.telephone_No.Location = new System.Drawing.Point(218, 174);
            this.telephone_No.Name = "telephone_No";
            this.telephone_No.Size = new System.Drawing.Size(82, 20);
            this.telephone_No.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telephone No:";
            // 
            // company_Name
            // 
            this.company_Name.Location = new System.Drawing.Point(497, 141);
            this.company_Name.Name = "company_Name";
            this.company_Name.Size = new System.Drawing.Size(82, 20);
            this.company_Name.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 141);
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
            // 
            // dataload_supplier
            // 
            this.dataload_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataload_supplier.Location = new System.Drawing.Point(12, 200);
            this.dataload_supplier.Name = "dataload_supplier";
            this.dataload_supplier.Size = new System.Drawing.Size(735, 204);
            this.dataload_supplier.TabIndex = 23;
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
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(759, 444);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataload_supplier);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.telephone_No);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.company_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.manufacturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mobile_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.supplier_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplier_code);
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
        private System.Windows.Forms.TextBox supplier_code;
        private System.Windows.Forms.TextBox supplier_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mobile_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telephone_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox company_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataload_supplier;
        private System.Windows.Forms.Button close;
    }
}