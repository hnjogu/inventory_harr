namespace practice_lesson3
{
    partial class salesreports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sales_Reports = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnitemsearch = new System.Windows.Forms.Button();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalesreports = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel_sales = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.sales_reportdate = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sale_report_start = new System.Windows.Forms.DateTimePicker();
            this.sale_report_end = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sales_Reports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sales_Reports
            // 
            this.sales_Reports.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sales_Reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sales_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sales_Reports.DefaultCellStyle = dataGridViewCellStyle2;
            this.sales_Reports.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.sales_Reports.Location = new System.Drawing.Point(12, 178);
            this.sales_Reports.Name = "sales_Reports";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            this.sales_Reports.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.sales_Reports.Size = new System.Drawing.Size(853, 305);
            this.sales_Reports.TabIndex = 10;
            this.sales_Reports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVReports_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.GroupBox3);
            this.groupBox1.Controls.Add(this.btnitemsearch);
            this.groupBox1.Controls.Add(this.txtiname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsalesreports);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Report";
            // 
            // btnitemsearch
            // 
            this.btnitemsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemsearch.Location = new System.Drawing.Point(98, 89);
            this.btnitemsearch.Name = "btnitemsearch";
            this.btnitemsearch.Size = new System.Drawing.Size(100, 28);
            this.btnitemsearch.TabIndex = 15;
            this.btnitemsearch.Text = "Search";
            this.btnitemsearch.UseVisualStyleBackColor = true;
            // 
            // txtiname
            // 
            this.txtiname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtiname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtiname.BackColor = System.Drawing.Color.Honeydew;
            this.txtiname.Location = new System.Drawing.Point(98, 55);
            this.txtiname.Multiline = true;
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(100, 28);
            this.txtiname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Item Name :";
            // 
            // btnsalesreports
            // 
            this.btnsalesreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsalesreports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalesreports.Location = new System.Drawing.Point(98, 18);
            this.btnsalesreports.Name = "btnsalesreports";
            this.btnsalesreports.Size = new System.Drawing.Size(113, 28);
            this.btnsalesreports.TabIndex = 12;
            this.btnsalesreports.Text = "Sales_reports";
            this.btnsalesreports.UseVisualStyleBackColor = false;
            this.btnsalesreports.Click += new System.EventHandler(this.btnsalesreports_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Load sales :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Location = new System.Drawing.Point(110, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(693, 37);
            this.Panel1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(234, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "SALES REPORT";
            // 
            // cancel_sales
            // 
            this.cancel_sales.BackColor = System.Drawing.Color.DarkGreen;
            this.cancel_sales.BackgroundImage = global::practice_lesson3.Properties.Resources.cancel5;
            this.cancel_sales.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_sales.Location = new System.Drawing.Point(816, 489);
            this.cancel_sales.Name = "cancel_sales";
            this.cancel_sales.Size = new System.Drawing.Size(49, 29);
            this.cancel_sales.TabIndex = 119;
            this.cancel_sales.Text = "&";
            this.cancel_sales.UseVisualStyleBackColor = false;
            this.cancel_sales.Click += new System.EventHandler(this.cancel_sales_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(132, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 29);
            this.button3.TabIndex = 47;
            this.button3.Text = "&Load Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.button3);
            this.GroupBox3.Controls.Add(this.sales_reportdate);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(217, 10);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(253, 105);
            this.GroupBox3.TabIndex = 48;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Select by Date :";
            // 
            // sales_reportdate
            // 
            this.sales_reportdate.CustomFormat = "yyyy-MM-dd";
            this.sales_reportdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sales_reportdate.Location = new System.Drawing.Point(96, 29);
            this.sales_reportdate.Name = "sales_reportdate";
            this.sales_reportdate.Size = new System.Drawing.Size(138, 22);
            this.sales_reportdate.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 35);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 14);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Select Date :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sale_report_end);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.sale_report_start);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(476, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 105);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select by Date from A certain Period  :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(132, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 47;
            this.button1.Text = "&Load Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sale_report_start
            // 
            this.sale_report_start.CustomFormat = "yyyy-MM-dd";
            this.sale_report_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sale_report_start.Location = new System.Drawing.Point(20, 27);
            this.sale_report_start.Name = "sale_report_start";
            this.sale_report_start.Size = new System.Drawing.Size(138, 22);
            this.sale_report_start.TabIndex = 4;
            // 
            // sale_report_end
            // 
            this.sale_report_end.CustomFormat = "yyyy-MM-dd";
            this.sale_report_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sale_report_end.Location = new System.Drawing.Point(209, 27);
            this.sale_report_end.Name = "sale_report_end";
            this.sale_report_end.Size = new System.Drawing.Size(138, 22);
            this.sale_report_end.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 49;
            this.label1.Text = "To";
            // 
            // salesreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 513);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_sales);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.sales_Reports);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "salesreports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salesreports";
            ((System.ComponentModel.ISupportInitialize)(this.sales_Reports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sales_Reports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnitemsearch;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalesreports;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button cancel_sales;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.DateTimePicker sales_reportdate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DateTimePicker sale_report_end;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DateTimePicker sale_report_start;
        private System.Windows.Forms.Label label1;
    }
}