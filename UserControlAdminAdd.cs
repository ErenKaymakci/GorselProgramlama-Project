using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GelismisATM
{
    public partial class UserControlAdminAdd : UserControl
    {
        public UserControlAdminAdd()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnUsersAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Accounts(tc, name, surname, password) VALUES(@tc, @name, @surname,@pass)";

            SQLiteParameter paramTC = new SQLiteParameter("tc", textBoxUsersTC.Text);
            SQLiteParameter paramName = new SQLiteParameter("name", textBoxUsersName.Text);
            SQLiteParameter paramSurname = new SQLiteParameter("surname", textBoxUsersSurname);
            SQLiteParameter paramPass = new SQLiteParameter("pass", textBoxUsersPass);


            SQLiteParameter[] prms = { paramTC, paramName, paramSurname, paramPass };

            if (dbOperations.executeSQL(sql, prms))
            {
                MessageBox.Show("Ekleme basari ile gerceklesti.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlAdminPage1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Accounts(account_name, account_type, iban, currency, account_balance, tc) VALUES(@name, @type,@iban, @currency, @balance, @tc)";

            SQLiteParameter paramName = new SQLiteParameter("name", textBoxAccName.Text);
            SQLiteParameter paramType = new SQLiteParameter("type", textBoxAccType.Text);
            SQLiteParameter paramIban = new SQLiteParameter("iban", textBoxAccIban.Text);
            SQLiteParameter paramCurr = new SQLiteParameter("currency", textBoxAccCurrency.Text);
            SQLiteParameter paramBalance = new SQLiteParameter("balance", Convert.ToInt32(textBoxAccBalance.Text));
            SQLiteParameter paramTC = new SQLiteParameter("tc", textBoxAccTC.Text);



            SQLiteParameter[] prms = { paramTC, paramName, paramType, paramIban, paramCurr, paramBalance };

            if (dbOperations.executeSQL(sql, prms))
            {
                MessageBox.Show("Ekleme basari ile gerceklesti.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Transactionn(transaction_date, transaction_type, targetIBAN, amount, nextBalance, account_id) VALUES(@date, @type,@iban, @amount, @balance, @id)";

            SQLiteParameter paramName = new SQLiteParameter("date", textBoxTrDate.Text);
            SQLiteParameter paramType = new SQLiteParameter("type", textBoxTrType.Text);
            SQLiteParameter paramIban = new SQLiteParameter("iban", textBoxTrIBAN.Text);
            SQLiteParameter paramAmount = new SQLiteParameter("amount", Convert.ToInt32(textBoxTrAmount.Text));
            SQLiteParameter paramBalance = new SQLiteParameter("balance", Convert.ToInt32(textBoxTrBalance.Text));
            SQLiteParameter paramId = new SQLiteParameter("id", Convert.ToInt32(textBoxTrID.Text));



            SQLiteParameter[] prms = { paramName, paramType, paramIban, paramAmount, paramBalance, paramId };

            if (dbOperations.executeSQL(sql, prms))
            {
                MessageBox.Show("Ekleme basari ile gerceklesti.");
            }
        }
        
    }
    }
    
