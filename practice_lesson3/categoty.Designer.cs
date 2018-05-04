namespace practice_lesson3
{
    partial class categoty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoty));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCategoryNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.update_data = new System.Windows.Forms.Button();
            this.searchload = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.textsearchValueToSearch = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.datasearch = new System.Windows.Forms.DataGridView();
            this.refresh_category = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasearch)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblCategoryNo);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtDescription);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtCatName);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(30, 91);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(668, 95);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Category Information";
            // 
            // lblCategoryNo
            // 
            this.lblCategoryNo.BackColor = System.Drawing.Color.White;
            this.lblCategoryNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoryNo.Location = new System.Drawing.Point(463, 23);
            this.lblCategoryNo.Name = "lblCategoryNo";
            this.lblCategoryNo.Size = new System.Drawing.Size(156, 22);
            this.lblCategoryNo.TabIndex = 5;
            this.lblCategoryNo.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category No. :";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(138, 56);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(441, 23);
            this.txtDescription.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Description :";
            // 
            // txtCatName
            // 
            this.txtCatName.BackColor = System.Drawing.Color.White;
            this.txtCatName.Location = new System.Drawing.Point(138, 22);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(198, 23);
            this.txtCatName.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Category Name :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(30, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 59);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(49, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add/Edit Category";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.refresh_category);
            this.GroupBox2.Controls.Add(this.update_data);
            this.GroupBox2.Controls.Add(this.searchload);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.textsearchValueToSearch);
            this.GroupBox2.Controls.Add(this.Cancel);
            this.GroupBox2.Controls.Add(this.Submit);
            this.GroupBox2.Location = new System.Drawing.Point(30, 192);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(668, 60);
            this.GroupBox2.TabIndex = 16;
            this.GroupBox2.TabStop = false;
            // 
            // update_data
            // 
            this.update_data.BackColor = System.Drawing.Color.DarkGreen;
            this.update_data.Location = new System.Drawing.Point(373, 10);
            this.update_data.Name = "update_data";
            this.update_data.Size = new System.Drawing.Size(73, 24);
            this.update_data.TabIndex = 21;
            this.update_data.Text = "update";
            this.update_data.UseVisualStyleBackColor = false;
            this.update_data.Click += new System.EventHandler(this.update_data_Click);
            // 
            // searchload
            // 
            this.searchload.BackgroundImage = global::practice_lesson3.Properties.Resources.search;
            this.searchload.Location = new System.Drawing.Point(322, 10);
            this.searchload.Name = "searchload";
            this.searchload.Size = new System.Drawing.Size(45, 37);
            this.searchload.TabIndex = 20;
            this.searchload.UseVisualStyleBackColor = true;
            this.searchload.Click += new System.EventHandler(this.searchload_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(5, 19);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(188, 13);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Enter search Criteria to search.:";
            // 
            // textsearchValueToSearch
            // 
            this.textsearchValueToSearch.Location = new System.Drawing.Point(199, 19);
            this.textsearchValueToSearch.Name = "textsearchValueToSearch";
            this.textsearchValueToSearch.Size = new System.Drawing.Size(92, 20);
            this.textsearchValueToSearch.TabIndex = 18;
            this.textsearchValueToSearch.TextChanged += new System.EventHandler(this.textsearchValueToSearch_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.DarkGreen;
            this.Cancel.Location = new System.Drawing.Point(551, 10);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 25);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkGreen;
            this.Submit.Location = new System.Drawing.Point(463, 10);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(73, 25);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "Save";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // datasearch
            // 
            this.datasearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasearch.Location = new System.Drawing.Point(104, 258);
            this.datasearch.Name = "datasearch";
            this.datasearch.Size = new System.Drawing.Size(395, 152);
            this.datasearch.TabIndex = 17;
            this.datasearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasearch_CellContentClick_1);
            // 
            // refresh_category
            // 
            this.refresh_category.BackColor = System.Drawing.Color.DarkGreen;
            this.refresh_category.BackgroundImage = global::practice_lesson3.Properties.Resources.refresh1;
            this.refresh_category.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_category.Location = new System.Drawing.Point(635, 10);
            this.refresh_category.Name = "refresh_category";
            this.refresh_category.Size = new System.Drawing.Size(33, 29);
            this.refresh_category.TabIndex = 117;
            this.refresh_category.Text = "&";
            this.refresh_category.UseVisualStyleBackColor = false;
            this.refresh_category.Click += new System.EventHandler(this.refresh_category_Click);
            // 
            // categoty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 413);
            this.ControlBox = false;
            this.Controls.Add(this.datasearch);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GroupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "categoty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoty";
            this.Load += new System.EventHandler(this.categoty_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCatName;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Submit;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox textsearchValueToSearch;
        private System.Windows.Forms.DataGridView datasearch;
        private System.Windows.Forms.Button searchload;
        private System.Windows.Forms.Button update_data;
        internal System.Windows.Forms.Label lblCategoryNo;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button refresh_category;

    }
}