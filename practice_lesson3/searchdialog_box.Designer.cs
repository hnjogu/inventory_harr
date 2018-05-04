namespace practice_lesson3
{
    partial class searchdialog_box
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
            this.label9 = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.searchdata = new System.Windows.Forms.ListView();
            this.refresh_sales = new System.Windows.Forms.Button();
            this.cancel_sales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Supplier_Code";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(134, 6);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(118, 20);
            this.textsearch.TabIndex = 23;
            this.textsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchdata
            // 
            this.searchdata.Location = new System.Drawing.Point(12, 44);
            this.searchdata.Name = "searchdata";
            this.searchdata.Size = new System.Drawing.Size(260, 191);
            this.searchdata.TabIndex = 24;
            this.searchdata.UseCompatibleStateImageBehavior = false;
            this.searchdata.SelectedIndexChanged += new System.EventHandler(this.searchdata_SelectedIndexChanged);
            // 
            // refresh_sales
            // 
            this.refresh_sales.BackColor = System.Drawing.Color.DarkGreen;
            this.refresh_sales.BackgroundImage = global::practice_lesson3.Properties.Resources.refresh1;
            this.refresh_sales.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_sales.Location = new System.Drawing.Point(21, 248);
            this.refresh_sales.Name = "refresh_sales";
            this.refresh_sales.Size = new System.Drawing.Size(33, 29);
            this.refresh_sales.TabIndex = 117;
            this.refresh_sales.Text = "&";
            this.refresh_sales.UseVisualStyleBackColor = false;
            this.refresh_sales.Click += new System.EventHandler(this.refresh_sales_Click);
            // 
            // cancel_sales
            // 
            this.cancel_sales.BackColor = System.Drawing.Color.DarkGreen;
            this.cancel_sales.BackgroundImage = global::practice_lesson3.Properties.Resources.cancel5;
            this.cancel_sales.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_sales.Location = new System.Drawing.Point(78, 248);
            this.cancel_sales.Name = "cancel_sales";
            this.cancel_sales.Size = new System.Drawing.Size(49, 29);
            this.cancel_sales.TabIndex = 118;
            this.cancel_sales.Text = "&";
            this.cancel_sales.UseVisualStyleBackColor = false;
            this.cancel_sales.Click += new System.EventHandler(this.cancel_sales_Click);
            // 
            // searchdialog_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 289);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_sales);
            this.Controls.Add(this.refresh_sales);
            this.Controls.Add(this.searchdata);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchdialog_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchdialog_box";
            this.Load += new System.EventHandler(this.searchdialog_box_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.ListView searchdata;
        internal System.Windows.Forms.Button refresh_sales;
        internal System.Windows.Forms.Button cancel_sales;
    }
}