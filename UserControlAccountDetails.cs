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
    public partial class UserControlAccountDetails : UserControl
    {
        public UserControlAccountDetails()
        {
            InitializeComponent();

            userControlMenu.Hide();
            userControlMenu.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            userControlMenu.Show();
            userControlMenu.Enabled = true;
            
        }
    }
}
