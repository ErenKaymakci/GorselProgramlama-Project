using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace GelismisATM
{
    public partial class UserControlAccountDetails : UserControl
    {
        public UserControlAccountDetails()
        {
            InitializeComponent();
        }

        public void getAccountData()
        {
            Label[] lbls_transact =
                { labelTransaction1Date, labelTransaction1Title, labelTransaction1Amount, labelTransaction1Balance, labelTransaction2Date, labelTransaction2Title, labelTransaction2Amount, labelTransaction2Balance, labelTransaction3Date, labelTransaction3Title, labelTransaction3Amount, labelTransaction3Balance };
            Panel[] pnls =
                { panelTransaction1, panelTransaction2, panelTransaction3 };

            setVisible(false, pnls);
            labelTransactionNotFound.Visible = false;

            fillAccountData();
            fillTransactionData(pnls, lbls_transact);
        }

        private void fillTransactionData(Panel[] pnls, Label[] lbls)
        {
            string sql = "SELECT * FROM Transact WHERE Transact.account_id=@account_id ORDER BY Transact.transact_date DESC LIMIT 3";

            SQLiteParameter currentAccount = new SQLiteParameter("account_id", User.currentAccountID);
            SQLiteParameter[] param = { currentAccount };

            DataTable dt_transaction = dbOperations.accessSQLdata(sql, param);

            if (dt_transaction.Rows.Count > 0)
            {
                for (int i = 0; i < dt_transaction.Rows.Count; i += 1)
                {
                    String transaction_date = dt_transaction.Rows[i]["transact_date"].ToString();
                    DateTime dateTime = DateTime.Parse(transaction_date);
                    lbls[i * 4].Text = dateTime.ToString("dd MMM yyyy HH:mm");

                    string transaction_type = dt_transaction.Rows[i]["transact_type"].ToString();
                    lbls[i * 4 + 1].Text = transaction_type + "   " + dt_transaction.Rows[i]["targetIBAN"].ToString();

                    string transaction_amount = dt_transaction.Rows[i]["amount"].ToString();
                    if (transaction_type == "Para Transferi" | transaction_type == "Para Çekme")
                    {
                        lbls[i * 4 + 2].ForeColor = Color.Red;
                        lbls[i * 4 + 2].Text = "-" + transaction_amount + " " + labelCurrencyData.Text;
                    }
                    else
                    {
                        lbls[i * 4 + 2].ForeColor = Color.Green;
                        lbls[i * 4 + 2].Text = transaction_amount + " " + labelCurrencyData.Text;
                    }
                    
                    lbls[i * 4 + 3].Text = "Mevcut Bakiye: " + dt_transaction.Rows[i]["nextBalance"].ToString() + " " + labelCurrencyData.Text;

                    pnls[i].Visible = true;
                }
            }
            else
            {
                labelTransactionNotFound.Visible = true;
            }
        }
        private void fillAccountData()
        {
            string sql = "SELECT * FROM Accounts WHERE Accounts.account_id=@account_id";

            SQLiteParameter currentAccount = new SQLiteParameter("account_id", User.currentAccountID);
            SQLiteParameter[] param = { currentAccount };

            DataTable dt_account = dbOperations.accessSQLdata(sql, param);

            labelAccountNameData.Text = dt_account.Rows[0]["account_name"].ToString();
            labelAccountTypeData.Text = dt_account.Rows[0]["account_type"].ToString();
            labelCurrencyData.Text = dt_account.Rows[0]["currency"].ToString();
            labelBalanceData.Text = dt_account.Rows[0]["account_balance"].ToString() + " " + labelCurrencyData.Text;
            labelIbanData.Text = dt_account.Rows[0]["iban"].ToString();
            pictureBoxQRIban.ImageLocation = "https://api.qrserver.com/v1/create-qr-code/?size=130x130&data=" + labelIbanData.Text;
        }

        private void setVisible(bool property, Panel[] pnls)
        {
            for (int i = 0; i < pnls.Length; i++)
            {
                pnls[i].Visible = property;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlAccounts1.getAllofAccounts();
            myParent.userControlAccounts1.Show();
        }
    }
}
