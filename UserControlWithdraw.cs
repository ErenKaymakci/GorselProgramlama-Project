using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace GelismisATM
{
    public partial class UserControlWithdraw : UserControl
    {
        private DataTable dt;
        public UserControlWithdraw()
        {
            InitializeComponent();
            
        }

        public void configureComboBox()
        {
            string[] ids = User.userAccountsIDs.Split(Convert.ToChar(","));
            string sql = "SELECT * from Accounts WHERE tc=@tc";

            SQLiteParameter param1 = new SQLiteParameter("tc", User.userTC);
            SQLiteParameter[] param = { param1 };

            dt = dbOperations.accessSQLdata(sql, param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["account_name"].ToString());
            }

        }

        public void withdraw()
        {
            string choosenAccName = comboBox1.GetItemText(comboBox1.SelectedItem);
            int val = Convert.ToInt32(textBox1.Text);

            DataRow[] filteredRows = dt.Select("account_name ='" + choosenAccName + "'");

            string choosenID = filteredRows[0]["account_id"].ToString();
            int totalAmount = Convert.ToInt32(filteredRows[0]["account_balance"]);
            int newVal = totalAmount - val; 
            
            string sql = "UPDATE Accounts SET account_balance=@newAmount WHERE account_id=@id";

            SQLiteParameter amountParam = new SQLiteParameter("newAmount", newVal);
            SQLiteParameter idParam = new SQLiteParameter("id", choosenID);

            SQLiteParameter[] parameters = { idParam, amountParam };
            dbOperations.executeSQL(sql, parameters);


        }
        private void button8_Click(object sender, EventArgs e)
        {
            withdraw();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}