namespace practice_lesson3
{
    partial class account_type
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccountname = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.close_account = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.close_account);
            this.GroupBox1.Controls.Add(this.Submit);
            this.GroupBox1.Controls.Add(this.txtAccountname);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtDescription);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(3, 66);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(299, 167);
            this.GroupBox1.TabIndex = 29;
            this.GroupBox1.TabStop = false;
            // 
            // txtAccountname
            // 
            this.txtAccountname.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccountname.Location = new System.Drawing.Point(109, 32);
            this.txtAccountname.Name = "txtAccountname";
            this.txtAccountname.Size = new System.Drawing.Size(174, 21);
            this.txtAccountname.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 13);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescription.Location = new System.Drawing.Point(109, 58);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(174, 67);
            this.txtDescription.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Account Name :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(299, 56);
            this.Panel1.TabIndex = 30;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(44, 18);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(155, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Account Type";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkGreen;
            this.Submit.Location = new System.Drawing.Point(109, 131);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(73, 25);
            this.Submit.TabIndex = 24;
            this.Submit.Text = "Save";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // close_account
            // 
            this.close_account.BackColor = System.Drawing.Color.DarkGreen;
            this.close_account.Location = new System.Drawing.Point(188, 131);
            this.close_account.Name = "close_account";
            this.close_account.Size = new System.Drawing.Size(73, 25);
            this.close_account.TabIndex = 25;
            this.close_account.Text = "Close";
            this.close_account.UseVisualStyleBackColor = false;
            this.close_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // account_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 245);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "account_type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account_type";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtAccountname;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button close_account;
        private System.Windows.Forms.Button Submit;
    }
}