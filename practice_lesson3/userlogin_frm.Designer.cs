namespace practice_lesson3
{
    partial class userlogin_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userlogin_frm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdcancel = new System.Windows.Forms.Button();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.PictureBox2);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(144, 26);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(240, 20);
            this.txtusername.TabIndex = 60;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(144, 55);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(240, 20);
            this.txtpassword.TabIndex = 59;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(64, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 57;
            this.Label2.Text = "Password :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(63, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 16);
            this.Label1.TabIndex = 56;
            this.Label1.Text = "Username :";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(5, 20);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(54, 55);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 58;
            this.PictureBox2.TabStop = false;
            // 
            // cmdcancel
            // 
            this.cmdcancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdcancel.Image")));
            this.cmdcancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdcancel.Location = new System.Drawing.Point(308, 244);
            this.cmdcancel.Name = "cmdcancel";
            this.cmdcancel.Size = new System.Drawing.Size(94, 35);
            this.cmdcancel.TabIndex = 50;
            this.cmdcancel.Text = "&Cancel";
            this.cmdcancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdcancel.UseVisualStyleBackColor = true;
            this.cmdcancel.Click += new System.EventHandler(this.cmdcancel_Click);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Image = ((System.Drawing.Image)(resources.GetObject("cmdLogin.Image")));
            this.cmdLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdLogin.Location = new System.Drawing.Point(198, 244);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(93, 35);
            this.cmdLogin.TabIndex = 49;
            this.cmdLogin.Text = "&Login";
            this.cmdLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::practice_lesson3.Properties.Resources.mainlogo_n12;
            this.PictureBox1.Location = new System.Drawing.Point(3, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(418, 127);
            this.PictureBox1.TabIndex = 54;
            this.PictureBox1.TabStop = false;
            // 
            // userlogin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 283);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cmdcancel);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userlogin_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userlogin_frm";
            this.Load += new System.EventHandler(this.userlogin_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button cmdcancel;
        internal System.Windows.Forms.Button cmdLogin;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}