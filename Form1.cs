﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelismisATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControlAccountDetails1.Hide();
        }

        private void HesapDetaylariClicked(object sender, EventArgs e)
        {
            userControlAccountDetails1.Show();
            userControlAccountDetails1.BringToFront();
        }
    }
}