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
            this.label4 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.entry_date = new System.Windows.Forms.DateTimePicker();
            this.dataload_inventory = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataload_inventory)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(84, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Simple Inventory System ";
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
            this.entry_date.Size = new System.Drawing.Size(137, 20);
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
            this.refresh.Location = new System.Drawing.Point(217, 427);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(73, 25);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(882, 455);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataload_inventory);
            this.Controls.Add(this.entry_date);
            this.Controls.Add(this.update);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.product_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataload_inventory)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DateTimePicker entry_date;
        private System.Windows.Forms.DataGridView dataload_inventory;
        private System.Windows.Forms.Button refresh;
    }
}

