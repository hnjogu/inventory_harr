namespace practice_lesson3
{
    partial class home_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_screen));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dashboard = new System.Windows.Forms.ListView();
            this.products_labels = new System.Windows.Forms.Label();
            this.suppliers_label = new System.Windows.Forms.Label();
            this.add_users_label = new System.Windows.Forms.Label();
            this.Sales_label = new System.Windows.Forms.Label();
            this.product_guidebutton = new System.Windows.Forms.Button();
            this.supplier_guidebutton = new System.Windows.Forms.Button();
            this.Adduser_guidebutton = new System.Windows.Forms.Button();
            this.cateoryguide = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.User_settingsbutton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sale_guidebutton = new System.Windows.Forms.Button();
            this.productguide = new System.Windows.Forms.ListView();
            this.supplierguide = new System.Windows.Forms.ListView();
            this.adduserguide = new System.Windows.Forms.ListView();
            this.salesguide = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.sales_button = new System.Windows.Forms.Button();
            this.adduser_button = new System.Windows.Forms.Button();
            this.suppliers_button = new System.Windows.Forms.Button();
            this.product_button = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dashboard.Location = new System.Drawing.Point(231, 62);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(640, 355);
            this.dashboard.TabIndex = 12;
            this.dashboard.UseCompatibleStateImageBehavior = false;
            // 
            // products_labels
            // 
            this.products_labels.AutoSize = true;
            this.products_labels.Location = new System.Drawing.Point(262, 201);
            this.products_labels.Name = "products_labels";
            this.products_labels.Size = new System.Drawing.Size(48, 13);
            this.products_labels.TabIndex = 13;
            this.products_labels.Text = "products";
            // 
            // suppliers_label
            // 
            this.suppliers_label.AutoSize = true;
            this.suppliers_label.Location = new System.Drawing.Point(465, 201);
            this.suppliers_label.Name = "suppliers_label";
            this.suppliers_label.Size = new System.Drawing.Size(48, 13);
            this.suppliers_label.TabIndex = 14;
            this.suppliers_label.Text = "suppliers";
            // 
            // add_users_label
            // 
            this.add_users_label.AutoSize = true;
            this.add_users_label.Location = new System.Drawing.Point(680, 201);
            this.add_users_label.Name = "add_users_label";
            this.add_users_label.Size = new System.Drawing.Size(57, 13);
            this.add_users_label.TabIndex = 15;
            this.add_users_label.Text = "Add_users";
            // 
            // Sales_label
            // 
            this.Sales_label.AutoSize = true;
            this.Sales_label.Location = new System.Drawing.Point(262, 404);
            this.Sales_label.Name = "Sales_label";
            this.Sales_label.Size = new System.Drawing.Size(33, 13);
            this.Sales_label.TabIndex = 16;
            this.Sales_label.Text = "Sales";
            // 
            // product_guidebutton
            // 
            this.product_guidebutton.BackColor = System.Drawing.Color.DarkGreen;
            this.product_guidebutton.Location = new System.Drawing.Point(877, 104);
            this.product_guidebutton.Name = "product_guidebutton";
            this.product_guidebutton.Size = new System.Drawing.Size(73, 25);
            this.product_guidebutton.TabIndex = 20;
            this.product_guidebutton.Text = "Products";
            this.product_guidebutton.UseVisualStyleBackColor = false;
            this.product_guidebutton.Visible = false;
            this.product_guidebutton.Click += new System.EventHandler(this.product_guidebutton_Click);
            // 
            // supplier_guidebutton
            // 
            this.supplier_guidebutton.BackColor = System.Drawing.Color.DarkGreen;
            this.supplier_guidebutton.Location = new System.Drawing.Point(877, 189);
            this.supplier_guidebutton.Name = "supplier_guidebutton";
            this.supplier_guidebutton.Size = new System.Drawing.Size(73, 25);
            this.supplier_guidebutton.TabIndex = 21;
            this.supplier_guidebutton.Text = "Supplier";
            this.supplier_guidebutton.UseVisualStyleBackColor = false;
            this.supplier_guidebutton.Visible = false;
            this.supplier_guidebutton.Click += new System.EventHandler(this.supplier_guidebutton_Click);
            // 
            // Adduser_guidebutton
            // 
            this.Adduser_guidebutton.BackColor = System.Drawing.Color.DarkGreen;
            this.Adduser_guidebutton.Location = new System.Drawing.Point(877, 277);
            this.Adduser_guidebutton.Name = "Adduser_guidebutton";
            this.Adduser_guidebutton.Size = new System.Drawing.Size(73, 25);
            this.Adduser_guidebutton.TabIndex = 22;
            this.Adduser_guidebutton.Text = "Add_User";
            this.Adduser_guidebutton.UseVisualStyleBackColor = false;
            this.Adduser_guidebutton.Visible = false;
            this.Adduser_guidebutton.Click += new System.EventHandler(this.Adduser_guidebutton_Click);
            // 
            // cateoryguide
            // 
            this.cateoryguide.BackColor = System.Drawing.Color.DarkGreen;
            this.cateoryguide.Location = new System.Drawing.Point(968, 104);
            this.cateoryguide.Name = "cateoryguide";
            this.cateoryguide.Size = new System.Drawing.Size(73, 25);
            this.cateoryguide.TabIndex = 23;
            this.cateoryguide.Text = "category";
            this.cateoryguide.UseVisualStyleBackColor = false;
            this.cateoryguide.Visible = false;
            this.cateoryguide.Click += new System.EventHandler(this.cateory_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGreen;
            this.button4.Location = new System.Drawing.Point(968, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 25);
            this.button4.TabIndex = 24;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // User_settingsbutton
            // 
            this.User_settingsbutton.BackColor = System.Drawing.Color.DarkGreen;
            this.User_settingsbutton.Location = new System.Drawing.Point(968, 277);
            this.User_settingsbutton.Name = "User_settingsbutton";
            this.User_settingsbutton.Size = new System.Drawing.Size(86, 25);
            this.User_settingsbutton.TabIndex = 25;
            this.User_settingsbutton.Text = "User_Settings";
            this.User_settingsbutton.UseVisualStyleBackColor = false;
            this.User_settingsbutton.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGreen;
            this.button6.Location = new System.Drawing.Point(968, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 25);
            this.button6.TabIndex = 28;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // sale_guidebutton
            // 
            this.sale_guidebutton.BackColor = System.Drawing.Color.DarkGreen;
            this.sale_guidebutton.Location = new System.Drawing.Point(877, 360);
            this.sale_guidebutton.Name = "sale_guidebutton";
            this.sale_guidebutton.Size = new System.Drawing.Size(73, 25);
            this.sale_guidebutton.TabIndex = 27;
            this.sale_guidebutton.Text = "Sales";
            this.sale_guidebutton.UseVisualStyleBackColor = false;
            this.sale_guidebutton.Visible = false;
            this.sale_guidebutton.Click += new System.EventHandler(this.sale_guidebutton_Click);
            // 
            // productguide
            // 
            this.productguide.Location = new System.Drawing.Point(877, 92);
            this.productguide.Name = "productguide";
            this.productguide.Size = new System.Drawing.Size(177, 60);
            this.productguide.TabIndex = 30;
            this.productguide.UseCompatibleStateImageBehavior = false;
            this.productguide.Visible = false;
            // 
            // supplierguide
            // 
            this.supplierguide.Location = new System.Drawing.Point(877, 170);
            this.supplierguide.Name = "supplierguide";
            this.supplierguide.Size = new System.Drawing.Size(177, 58);
            this.supplierguide.TabIndex = 31;
            this.supplierguide.UseCompatibleStateImageBehavior = false;
            this.supplierguide.Visible = false;
            // 
            // adduserguide
            // 
            this.adduserguide.Location = new System.Drawing.Point(877, 259);
            this.adduserguide.Name = "adduserguide";
            this.adduserguide.Size = new System.Drawing.Size(177, 58);
            this.adduserguide.TabIndex = 32;
            this.adduserguide.UseCompatibleStateImageBehavior = false;
            this.adduserguide.Visible = false;
            // 
            // salesguide
            // 
            this.salesguide.Location = new System.Drawing.Point(877, 345);
            this.salesguide.Name = "salesguide";
            this.salesguide.Size = new System.Drawing.Size(177, 56);
            this.salesguide.TabIndex = 33;
            this.salesguide.UseCompatibleStateImageBehavior = false;
            this.salesguide.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(342, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 34);
            this.label4.TabIndex = 39;
            this.label4.Text = "Simple Inventory System ";
            // 
            // report
            // 
            this.report.AutoSize = true;
            this.report.Location = new System.Drawing.Point(465, 404);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(44, 13);
            this.report.TabIndex = 41;
            this.report.Text = "Reports";
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = global::practice_lesson3.Properties.Resources.minimixe;
            this.minimize.Location = new System.Drawing.Point(968, 25);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(42, 24);
            this.minimize.TabIndex = 46;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancel
            // 
            this.cancel.BackgroundImage = global::practice_lesson3.Properties.Resources.cancel4;
            this.cancel.Location = new System.Drawing.Point(1027, 25);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(27, 28);
            this.cancel.TabIndex = 45;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Location = new System.Drawing.Point(468, 296);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(120, 110);
            this.btnReport.TabIndex = 40;
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // sales_button
            // 
            this.sales_button.BackColor = System.Drawing.Color.White;
            this.sales_button.BackgroundImage = global::practice_lesson3.Properties.Resources.discount;
            this.sales_button.Location = new System.Drawing.Point(265, 296);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(120, 110);
            this.sales_button.TabIndex = 38;
            this.sales_button.Text = "Sales";
            this.sales_button.UseVisualStyleBackColor = false;
            this.sales_button.Click += new System.EventHandler(this.sales_button_Click);
            // 
            // adduser_button
            // 
            this.adduser_button.BackColor = System.Drawing.Color.White;
            this.adduser_button.BackgroundImage = global::practice_lesson3.Properties.Resources.user_add_icon;
            this.adduser_button.Location = new System.Drawing.Point(673, 92);
            this.adduser_button.Name = "adduser_button";
            this.adduser_button.Size = new System.Drawing.Size(120, 110);
            this.adduser_button.TabIndex = 37;
            this.adduser_button.Text = "Add_user";
            this.adduser_button.UseVisualStyleBackColor = false;
            this.adduser_button.Click += new System.EventHandler(this.adduser_button_Click);
            // 
            // suppliers_button
            // 
            this.suppliers_button.BackColor = System.Drawing.Color.White;
            this.suppliers_button.BackgroundImage = global::practice_lesson3.Properties.Resources.delivery;
            this.suppliers_button.Location = new System.Drawing.Point(468, 92);
            this.suppliers_button.Name = "suppliers_button";
            this.suppliers_button.Size = new System.Drawing.Size(120, 110);
            this.suppliers_button.TabIndex = 36;
            this.suppliers_button.Text = "Suppliers";
            this.suppliers_button.UseVisualStyleBackColor = false;
            this.suppliers_button.Click += new System.EventHandler(this.suppliers_button_Click);
            // 
            // product_button
            // 
            this.product_button.BackColor = System.Drawing.Color.White;
            this.product_button.BackgroundImage = global::practice_lesson3.Properties.Resources.products;
            this.product_button.Location = new System.Drawing.Point(265, 92);
            this.product_button.Name = "product_button";
            this.product_button.Size = new System.Drawing.Size(120, 110);
            this.product_button.TabIndex = 34;
            this.product_button.Text = "Products";
            this.product_button.UseVisualStyleBackColor = false;
            this.product_button.BackColorChanged += new System.EventHandler(this.CutToolStripMenuItem_Click);
            this.product_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // home_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 453);
            this.ControlBox = false;
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.report);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sales_button);
            this.Controls.Add(this.adduser_button);
            this.Controls.Add(this.suppliers_button);
            this.Controls.Add(this.product_button);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.sale_guidebutton);
            this.Controls.Add(this.salesguide);
            this.Controls.Add(this.User_settingsbutton);
            this.Controls.Add(this.Adduser_guidebutton);
            this.Controls.Add(this.adduserguide);
            this.Controls.Add(this.supplier_guidebutton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.supplierguide);
            this.Controls.Add(this.cateoryguide);
            this.Controls.Add(this.product_guidebutton);
            this.Controls.Add(this.productguide);
            this.Controls.Add(this.Sales_label);
            this.Controls.Add(this.add_users_label);
            this.Controls.Add(this.suppliers_label);
            this.Controls.Add(this.products_labels);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.statusStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home_screen";
            this.Text = "home_screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ListView dashboard;
        private System.Windows.Forms.Label products_labels;
        private System.Windows.Forms.Label suppliers_label;
        private System.Windows.Forms.Label add_users_label;
        private System.Windows.Forms.Label Sales_label;
        private System.Windows.Forms.Button product_guidebutton;
        private System.Windows.Forms.Button supplier_guidebutton;
        private System.Windows.Forms.Button Adduser_guidebutton;
        private System.Windows.Forms.Button cateoryguide;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button User_settingsbutton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button sale_guidebutton;
        private System.Windows.Forms.ListView productguide;
        private System.Windows.Forms.ListView supplierguide;
        private System.Windows.Forms.ListView adduserguide;
        private System.Windows.Forms.ListView salesguide;
        private System.Windows.Forms.Button product_button;
        private System.Windows.Forms.Button suppliers_button;
        private System.Windows.Forms.Button adduser_button;
        private System.Windows.Forms.Button sales_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label report;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button minimize;
    }
}



