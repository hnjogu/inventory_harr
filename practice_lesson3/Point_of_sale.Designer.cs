namespace practice_lesson3
{
    partial class Point_of_sale
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtreceiptno = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdAccept = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblready = new System.Windows.Forms.Label();
            this.lblarrow = new System.Windows.Forms.Label();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.dataloadPOS = new System.Windows.Forms.DataGridView();
            this.search_load = new System.Windows.Forms.Button();
            this.textsearchValueToSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvat12 = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txttotalamountdue = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataloadPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dataloadPOS);
            this.GroupBox2.Location = new System.Drawing.Point(1, 146);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(600, 157);
            this.GroupBox2.TabIndex = 111;
            this.GroupBox2.TabStop = false;
            // 
            // txtreceiptno
            // 
            this.txtreceiptno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreceiptno.Location = new System.Drawing.Point(104, 470);
            this.txtreceiptno.Name = "txtreceiptno";
            this.txtreceiptno.Size = new System.Drawing.Size(82, 22);
            this.txtreceiptno.TabIndex = 116;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(309, 83);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(125, 13);
            this.Label14.TabIndex = 122;
            this.Label14.Text = "TOTAL AMOUNT DUE :";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(364, 47);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 13);
            this.Label13.TabIndex = 120;
            this.Label13.Text = "DISCOUNT :";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.DarkGreen;
            this.cmdclose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.Location = new System.Drawing.Point(520, 446);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 29);
            this.cmdclose.TabIndex = 113;
            this.cmdclose.Text = "&Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click_1);
            // 
            // cmdAccept
            // 
            this.cmdAccept.BackColor = System.Drawing.Color.DarkGreen;
            this.cmdAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAccept.Location = new System.Drawing.Point(441, 446);
            this.cmdAccept.Name = "cmdAccept";
            this.cmdAccept.Size = new System.Drawing.Size(75, 29);
            this.cmdAccept.TabIndex = 112;
            this.cmdAccept.Text = "&Accept";
            this.cmdAccept.UseVisualStyleBackColor = false;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.White;
            this.txtprice.Location = new System.Drawing.Point(72, 57);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 113;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged_1);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(13, 83);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 13);
            this.Label4.TabIndex = 119;
            this.Label4.Text = "Quantity :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 42);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 13);
            this.Label2.TabIndex = 115;
            this.Label2.Text = "Item Name :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(72, 37);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(200, 20);
            this.txtname.TabIndex = 111;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(72, 79);
            this.txtqty.MaxLength = 5;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 22);
            this.txtqty.TabIndex = 118;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged_1);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lbltotalamount);
            this.Panel1.Controls.Add(this.lbldate);
            this.Panel1.Controls.Add(this.lblready);
            this.Panel1.Controls.Add(this.lblarrow);
            this.Panel1.Controls.Add(this.lblbarcode);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Location = new System.Drawing.Point(1, 2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(594, 94);
            this.Panel1.TabIndex = 110;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.BackColor = System.Drawing.Color.Black;
            this.lbltotalamount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.ForeColor = System.Drawing.Color.White;
            this.lbltotalamount.Location = new System.Drawing.Point(464, 36);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(66, 29);
            this.lbltotalamount.TabIndex = 103;
            this.lbltotalamount.Text = "0.00";
            this.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Black;
            this.lbldate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(480, 9);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 14);
            this.lbldate.TabIndex = 104;
            // 
            // lblready
            // 
            this.lblready.AutoSize = true;
            this.lblready.BackColor = System.Drawing.Color.Black;
            this.lblready.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblready.ForeColor = System.Drawing.Color.White;
            this.lblready.Location = new System.Drawing.Point(108, 38);
            this.lblready.Name = "lblready";
            this.lblready.Size = new System.Drawing.Size(95, 26);
            this.lblready.TabIndex = 102;
            this.lblready.Text = "Ready . . .";
            // 
            // lblarrow
            // 
            this.lblarrow.AutoSize = true;
            this.lblarrow.BackColor = System.Drawing.Color.Black;
            this.lblarrow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblarrow.Location = new System.Drawing.Point(19, 42);
            this.lblarrow.Name = "lblarrow";
            this.lblarrow.Size = new System.Drawing.Size(74, 19);
            this.lblarrow.TabIndex = 101;
            this.lblarrow.Text = ">>>>>";
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.BackColor = System.Drawing.Color.Black;
            this.lblbarcode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.ForeColor = System.Drawing.Color.White;
            this.lblbarcode.Location = new System.Drawing.Point(10, 7);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(0, 19);
            this.lblbarcode.TabIndex = 100;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Black;
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(6, 0);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(594, 92);
            this.TextBox1.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txttotalamountdue);
            this.GroupBox1.Controls.Add(this.txtDiscount);
            this.GroupBox1.Controls.Add(this.txtvat12);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.txtprice);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtname);
            this.GroupBox1.Controls.Add(this.txtqty);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtID);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Location = new System.Drawing.Point(1, 296);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(600, 118);
            this.GroupBox1.TabIndex = 114;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter_1);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(33, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(37, 13);
            this.Label5.TabIndex = 118;
            this.Label5.Text = "Price :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(22, 23);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 13);
            this.Label6.TabIndex = 119;
            this.Label6.Text = "Item ID :";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(72, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 110;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(365, 18);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(69, 13);
            this.Label10.TabIndex = 110;
            this.Label10.Text = "VAT - 12 % :";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(31, 474);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(73, 13);
            this.Label12.TabIndex = 115;
            this.Label12.Text = "Receipt No :";
            // 
            // dataloadPOS
            // 
            this.dataloadPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataloadPOS.Location = new System.Drawing.Point(6, 10);
            this.dataloadPOS.Name = "dataloadPOS";
            this.dataloadPOS.Size = new System.Drawing.Size(591, 141);
            this.dataloadPOS.TabIndex = 0;
            this.dataloadPOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataloadPOS_CellContentClick);
            // 
            // search_load
            // 
            this.search_load.BackColor = System.Drawing.Color.DarkGreen;
            this.search_load.Location = new System.Drawing.Point(520, 112);
            this.search_load.Name = "search_load";
            this.search_load.Size = new System.Drawing.Size(68, 28);
            this.search_load.TabIndex = 117;
            this.search_load.Text = "search";
            this.search_load.UseVisualStyleBackColor = false;
            this.search_load.Click += new System.EventHandler(this.search_load_Click);
            // 
            // textsearchValueToSearch
            // 
            this.textsearchValueToSearch.Location = new System.Drawing.Point(335, 117);
            this.textsearchValueToSearch.Name = "textsearchValueToSearch";
            this.textsearchValueToSearch.Size = new System.Drawing.Size(129, 20);
            this.textsearchValueToSearch.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 19);
            this.label1.TabIndex = 119;
            this.label1.Text = "Enter the product code for sale";
            // 
            // txtvat12
            // 
            this.txtvat12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvat12.Location = new System.Drawing.Point(456, 16);
            this.txtvat12.Name = "txtvat12";
            this.txtvat12.Size = new System.Drawing.Size(119, 24);
            this.txtvat12.TabIndex = 123;
            this.txtvat12.TextChanged += new System.EventHandler(this.txtvat12_TextChanged_2);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(456, 47);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(119, 24);
            this.txtDiscount.TabIndex = 124;
            // 
            // txttotalamountdue
            // 
            this.txttotalamountdue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txttotalamountdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalamountdue.Location = new System.Drawing.Point(455, 79);
            this.txttotalamountdue.Multiline = true;
            this.txttotalamountdue.Name = "txttotalamountdue";
            this.txttotalamountdue.Size = new System.Drawing.Size(120, 33);
            this.txttotalamountdue.TabIndex = 125;
            this.txttotalamountdue.Text = "0";
            // 
            // Point_of_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 494);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textsearchValueToSearch);
            this.Controls.Add(this.search_load);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtreceiptno);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.cmdAccept);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Point_of_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point_of_sale";
            this.Load += new System.EventHandler(this.Point_of_sale_Load);
            this.GroupBox2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataloadPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtreceiptno;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Button cmdclose;
        internal System.Windows.Forms.Button cmdAccept;
        internal System.Windows.Forms.TextBox txtprice;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.TextBox txtqty;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lbltotalamount;
        internal System.Windows.Forms.Label lbldate;
        internal System.Windows.Forms.Label lblready;
        internal System.Windows.Forms.Label lblarrow;
        internal System.Windows.Forms.Label lblbarcode;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label12;
        private System.Windows.Forms.DataGridView dataloadPOS;
        private System.Windows.Forms.Button search_load;
        private System.Windows.Forms.TextBox textsearchValueToSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalamountdue;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtvat12;

    }
}