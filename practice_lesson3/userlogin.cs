﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_lesson3
{
    public partial class userlogin : UserControl
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
