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
    public partial class ParaTransferi : Form
    {
        //Diğer forma aktarılacak bilgiler
        public static string tutarInformation="";
        public static string IBANinformation = "";
        public static string odemeTipiInformation="";
        

        public ParaTransferi()
        {
            InitializeComponent();
        }

        private void classButton1_Click(object sender, EventArgs e)
        {
            tutarInformation = Convert.ToString(userControlTextBoxTutar.Texts);
            IBANinformation = Convert.ToString(userControlTextBoxIBAN1.Texts);
            odemeTipiInformation=Convert.ToString(classComboBoxOdemeTipi.Texts);

            IslemOzeti islemozeti= new IslemOzeti();
            this.Close();
            islemozeti.Show();
         
            
        }

        private void classButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParaTransferi_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
