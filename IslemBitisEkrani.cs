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
    public partial class IslemBitisEkrani : Form
    {
        public IslemBitisEkrani()
        {
            InitializeComponent();
        }

        private void classButton2_Click(object sender, EventArgs e)
        {
            IslemOzeti ıslemOzeti = new IslemOzeti();
            this.Hide();
            ıslemOzeti.Show();
        }

        private void classButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void IslemBitisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
