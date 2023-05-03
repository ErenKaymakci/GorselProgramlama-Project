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
    public partial class IslemOzeti : Form
    {
        public IslemOzeti()
        {
            InitializeComponent();
        }

        private void classButton5_Click(object sender, EventArgs e)
        {
            IslemBitisEkrani islemBitis = new IslemBitisEkrani();
            islemBitis.Show();
            this.Hide();
            this.Close();
        }

        private void classButton3_Click(object sender, EventArgs e)
        {
            ParaTransferi paraTransferi = new ParaTransferi();
            this.Close();
            paraTransferi.Show();
        }

        private void IslemOzeti_Load(object sender, EventArgs e)
        {
            userControlTextBoxYatirilanMiktar.Texts=ParaTransferi.tutarInformation.ToString();
            userControlTextBox1.Texts=ParaTransferi.IBANinformation.ToString();
            userControlTextBoxOdemeTipi.Texts=ParaTransferi.odemeTipiInformation.ToString();    
           
        }

        private void userControlTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
