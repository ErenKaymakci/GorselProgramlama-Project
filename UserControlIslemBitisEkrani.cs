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
    public partial class UserControlIslemBitisEkrani : UserControl
    {
        public UserControlIslemBitisEkrani()
        {
            InitializeComponent();
            pictureBox1.ImageLocation =
                "https://openclipart.org/image/2400px/svg_to_png/167549/Kliponious-green-tick.png";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlAccounts1.Show();
            //string sqlNextBalance= "SELECT nextBalance FROM Transactionn ORDER BY transaction_date DESC LIMIT 1";
            myParent.userControlAccounts1.getAllofAccounts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
