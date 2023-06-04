using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace GelismisATM
{
    public partial class UserControlAccounts : UserControl
    {
        
        public UserControlAccounts()
        {
            InitializeComponent();
        }

        public void getAllofAccounts()
        {
            string sql = "SELECT * FROM Accounts WHERE tc=@tc";

            SQLiteParameter currentTC = new SQLiteParameter("tc", User.userTC);
            //lblbalance1.Text = User.userName;
            //lbliban1.Text = User.userID;

            Label[] lbls =
                { lblaccType1, lbliban1, lblbalance1, lblaccType2, lbliban2, lblbalance2, lblaccType3, lbliban3, lblbalance3, lblaccType4, lbliban4, lblbalance4 };

            Button[] btns = { BtnDetail1, BtnDetail2, BtnDetail3, BtnDetail4 };
            
            SQLiteParameter[] param = { currentTC };

            DataTable dt = dbOperations.accessSQLdata(sql, param);

            string[] accIDS;

            if (dt.Rows.Count > 0)
            {
                
                for (int i = 0; i < dt.Rows.Count; i+=1)
                {
                    lbls[i * 3].Text = dt.Rows[i]["account_type"].ToString();
                    lbls[i *3 + 1].Text = dt.Rows[i]["iban"].ToString();
                    lbls[i *3 + 2].Text = "Bakiye : " + dt.Rows[i]["account_balance"].ToString();

                    User.userAccountsIDs += dt.Rows[i]["account_id"].ToString() + ","; 
                    //string idx = dt.Rows[i]["account_id"].ToString();
                    //User.userAccountsIDs.Add(idx);
                    
                    btns[i].Visible = true;

                }
            }
            else
            {
                MessageBox.Show("Aktif Hesabınız bulunmamaktadır.");
            }

            //lbliban4.Text = User.userAccountsIDs;
        }

        public void navigateAccountDetails(int accountID)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            User.currentAccountID = accountID;
            myParent.userControlAccountDetails1.getAccountData();
            myParent.userControlAccountDetails1.Show();
        }

        private void BtnDetail1_Click(object sender, EventArgs e)
        {
            navigateAccountDetails(1);
        }

        private void BtnDetail2_Click(object sender, EventArgs e)
        {
            navigateAccountDetails(1);
        }

        private void BtnDetail3_Click(object sender, EventArgs e)
        {
            navigateAccountDetails(1);
        }

        private void BtnDetail4_Click(object sender, EventArgs e)
        {
            navigateAccountDetails(1);
        }
    }
}