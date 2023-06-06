using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            hideAll();
            setVisibleBtns(false);
            userControlLogin1.Show();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            // hideAll();
            // setVisibleBtns(false);
            // userControlLogin1.Show();
            Environment.Exit(0);
        }

        public void hideAll()
        {
            userControlLogin1.Hide();
            userControlAccountDetails1.Hide();
            userControlAccounts1.Hide();
            userControlAdminPage1.Hide();
            userControlDeposit1.Hide();
            userControlWithdraw1.Hide();
            userControlslemOzeti1.Hide();
            userControlParaTransferi1.Hide();
            userControlIslemBitisEkrani1.Hide();
            userControlAdminAdd1.Hide();
        }

        public void setVisibleBtns(bool property)
        {
            btnMenuAccounts.Visible = property;
            btnMenuDeposit.Visible = property;
            btnMenuCurrency.Visible = property;
            btnMenuTransfer.Visible = property;
            btnMenuWitdraw.Visible = property;
            btnMenuStock.Visible = property;
            btnMenuSettings.Visible = property;
            lblMenuUsername.Visible = property;
        }
        
        private void btnMenuAccounts_Click(object sender, EventArgs e)
        {
            hideAll();
            userControlAccounts1.Show();
            userControlAccounts1.getAllofAccounts();
        }

        private void btnMenuWitdraw_Click(object sender, EventArgs e)
        {
            hideAll();
            userControlWithdraw1.configureComboBox();
            userControlWithdraw1.Show();
            userControlWithdraw1.textBox1.Text = "";
            userControlWithdraw1.comboBox1.Text = "";
        }

        private void btnMenuDeposit_Click(object sender, EventArgs e)
        {
            hideAll();
            userControlDeposit1.configureComboBox();
            userControlDeposit1.Show();
            userControlDeposit1.textBox2.Text = "";
            userControlDeposit1.comboBox1.Text = "";
        }

        private void btnMenuTransfer_Click(object sender, EventArgs e)
        {
            hideAll();
            userControlParaTransferi1.Show();
            userControlParaTransferi1.textBox1.Text = "";
            userControlParaTransferi1.maskedTextBox1.Text = "";
            userControlParaTransferi1.comboBox1.Text = "";
            userControlParaTransferi1.comboBox2.Text = "";
        }

        private void btnMenuCurrency_Click(object sender, EventArgs e)
        {
            hideAll();
            // Döviz İşlemleri Sayfası
        }

        private void btnMenuStock_Click(object sender, EventArgs e)
        {
            hideAll();
            // Hisse İşlemleri Sayfası
        }

        private void btnMenuSettings_Click(object sender, EventArgs e)
        {
            hideAll();
            // Kullanıcı Ayarları Sayfası
        }
    }
}