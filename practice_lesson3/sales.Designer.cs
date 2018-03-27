namespace practice_lesson3
{
    partial class sales
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
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 432);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listloadsales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales";
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

    }
}