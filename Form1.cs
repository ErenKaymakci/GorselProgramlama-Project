using System;
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

            userControlAccountDetails.Hide();
            userControlAccountDetails.Enabled = false;
            userControlMenu.Hide();
            userControlMenu.Enabled = false;
        }

        private void buttonAccountDetails_Click(object sender, EventArgs e)
        {
            userControlAccountDetails.Show();
            userControlAccountDetails.Enabled = true;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            userControlMenu.Show();
            userControlMenu.Enabled = true;
        }
    }
}