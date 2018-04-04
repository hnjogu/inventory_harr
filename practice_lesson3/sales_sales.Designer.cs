namespace practice_lesson3
{
    partial class sales_sales
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
            this.listloadsales = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.load_sales = new System.Windows.Forms.Button();
            this.cancel_sales = new System.Windows.Forms.Button();
            this.refresh_sales = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listloadsales
            // 
            this.listloadsales.FullRowSelect = true;
            this.listloadsales.GridLines = true;
            this.listloadsales.Location = new System.Drawing.Point(3, 44);
            this.listloadsales.Name = "listloadsales";
            this.listloadsales.Size = new System.Drawing.Size(817, 337);
            this.listloadsales.TabIndex = 2;
            this.listloadsales.UseCompatibleStateImageBehavior = false;
            this.listloadsales.View = System.Windows.Forms.View.Details;
            this.listloadsales.SelectedIndexChanged += new System.EventHandler(this.listloadsales_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdclose);
            this.groupBox1.Location = new System.Drawing.Point(5, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.DarkGreen;
            this.cmdclose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.Location = new System.Drawing.Point(731, 8);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 29);
            this.cmdclose.TabIndex = 114;
            this.cmdclose.Text = "&Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "All Sales";
            // 
            // load_sales
            // 
            this.load_sales.BackColor = System.Drawing.Color.DarkGreen;
            this.load_sales.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_sales.Location = new System.Drawing.Point(137, 12);
            this.load_sales.Name = "load_sales";
            this.load_sales.Size = new System.Drawing.Size(75, 29);
            this.load_sales.TabIndex = 115;
            this.load_sales.Text = "&Load sales";
            this.load_sales.UseVisualStyleBackColor = false;
            this.load_sales.Click += new System.EventHandler(this.load_sales_Click);
            // 
            // cancel_sales
            // 
            this.cancel_sales.BackColor = System.Drawing.Color.DarkGreen;
            this.cancel_sales.BackgroundImage = global::practice_lesson3.Properties.Resources.cancel5;
            this.cancel_sales.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_sales.Location = new System.Drawing.Point(286, 12);
            this.cancel_sales.Name = "cancel_sales";
            this.cancel_sales.Size = new System.Drawing.Size(49, 29);
            this.cancel_sales.TabIndex = 117;
            this.cancel_sales.Text = "&";
            this.cancel_sales.UseVisualStyleBackColor = false;
            this.cancel_sales.Click += new System.EventHandler(this.cancel_sales_Click);
            // 
            // refresh_sales
            // 
            this.refresh_sales.BackColor = System.Drawing.Color.DarkGreen;
            this.refresh_sales.BackgroundImage = global::practice_lesson3.Properties.Resources.refresh1;
            this.refresh_sales.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_sales.Location = new System.Drawing.Point(230, 12);
            this.refresh_sales.Name = "refresh_sales";
            this.refresh_sales.Size = new System.Drawing.Size(33, 29);
            this.refresh_sales.TabIndex = 116;
            this.refresh_sales.Text = "&";
            this.refresh_sales.UseVisualStyleBackColor = false;
            this.refresh_sales.Click += new System.EventHandler(this.refresh_sales_Click);
            // 
            // sales_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 432);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_sales);
            this.Controls.Add(this.refresh_sales);
            this.Controls.Add(this.load_sales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listloadsales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sales_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales_sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView listloadsales;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button load_sales;
        internal System.Windows.Forms.Button refresh_sales;
        internal System.Windows.Forms.Button cancel_sales;

    }
}