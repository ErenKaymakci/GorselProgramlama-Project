using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        }

        public void getAccountData()
        {
            string sql = "SELECT * FROM Accounts WHERE account_id=@account_id";

            SQLiteParameter currentAccount = new SQLiteParameter("account_id", User.currentAccountID);
            SQLiteParameter[] param = { currentAccount };
            
            DataTable dt = dbOperations.accessSQLdata(sql, param);
            labelAccountTypeData.Text = dt.Rows[0]["account_type"].ToString();
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
