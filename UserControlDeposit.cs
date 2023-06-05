using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GelismisATM
{
    public partial class UserControlDeposit : UserControl
    {
        private DataTable dtAcc;
        public UserControlDeposit()
        {
            InitializeComponent();
        }
        public void configureComboBox()
        {
            string sql = "SELECT * from Accounts WHERE tc=@tc";

            SQLiteParameter param1 = new SQLiteParameter("tc", User.userTC);
            SQLiteParameter[] param = { param1 };
            dtAcc = dbOperations.accessSQLdata(sql, param);

            for (int i = 0; i < dtAcc.Rows.Count; i++)
            {
                comboBox1.Items.Add(dtAcc.Rows[i]["account_name"].ToString());
            }
        }          
        public void deposit(){
            string choosenAccName = comboBox1.GetItemText(comboBox1.SelectedItem);
            int val = Convert.ToInt32(textBox2.Text);

            DataRow[] filteredRows = dtAcc.Select("account_name ='" + choosenAccName + "'");

            string choosenID = filteredRows[0]["account_id"].ToString();
            int totalAmount = Convert.ToInt32(filteredRows[0]["account_balance"]);
            int newVal = totalAmount + val; 
            
            string sql = "UPDATE Accounts SET account_balance=@newAmount WHERE account_id=@id";

            SQLiteParameter amountParam = new SQLiteParameter("newAmount", newVal);
            SQLiteParameter idParam = new SQLiteParameter("id", choosenID);

            SQLiteParameter[] parameters = { idParam, amountParam };
            dbOperations.executeSQL(sql, parameters);


            string query = "INSERT INTO Transactionn(transaction_date, transaction_type, targetIBAN, amount, nextBalance, account_id) VALUES(@date, @type,@iban ,@amount, @balance, @id)";

   
            SQLiteParameter paramName = new SQLiteParameter("date", "17.03.2022");
            SQLiteParameter paramType = new SQLiteParameter("type", "para yatırma");
            SQLiteParameter paramIban = new SQLiteParameter("iban", filteredRows[0]["iban"].ToString());
            SQLiteParameter paramAmount = new SQLiteParameter("amount", totalAmount);
            SQLiteParameter paramBalance = new SQLiteParameter("balance", totalAmount + val);
            SQLiteParameter paramId = new SQLiteParameter("id", choosenID);

            label6.Text = filteredRows[0]["iban"].ToString();
            label1.Text = choosenID;
            label2.Text = (totalAmount + val).ToString();

            
            SQLiteParameter[] prms = { paramName, paramType, paramIban, paramAmount, paramBalance, paramId };
            
            dbOperations.executeSQL(query, prms);
            
            
        }    
        
        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deposit();
        }

     
    }
}