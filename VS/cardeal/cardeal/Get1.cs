﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardeal
{
    public partial class Get1 : Form
    {
        public Get1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Buypanel b = new Buypanel();
            b.TopLevel = false;
            panelb.Controls.Add(b);
            b.BringToFront();
            b.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            CheckOut ck = new CheckOut();
            ck.Hide();
            ck.Show();
        }
    }
}