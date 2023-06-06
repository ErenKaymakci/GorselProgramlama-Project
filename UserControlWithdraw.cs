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
            string sql = "SELECT * from Accounts WHERE tc=@tc";

            SQLiteParameter param1 = new SQLiteParameter("tc", User.userTC);
            SQLiteParameter[] param = { param1 };

            dt = dbOperations.accessSQLdata(sql, param);
            comboBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["account_name"].ToString());
            }

        }

        public void withdraw()
        {
            string choosenAccName = comboBox1.GetItemText(comboBox1.SelectedItem);
            int val = 0;
            try {
                val = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception e) {
                MessageBox.Show("Miktar yanlış.");
            }

            DataRow[] filteredRows = dt.Select("account_name ='" + choosenAccName + "'");

            string choosenID = filteredRows[0]["account_id"].ToString();
            int totalAmount = Convert.ToInt32(filteredRows[0]["account_balance"]);
            int newVal = totalAmount - val;

            string sql = "UPDATE Accounts SET account_balance=@newAmount WHERE account_id=@id";

            SQLiteParameter amountParam = new SQLiteParameter("newAmount", newVal);
            SQLiteParameter idParam = new SQLiteParameter("id", choosenID);

            SQLiteParameter[] parameters = { idParam, amountParam };
            dbOperations.executeSQL(sql, parameters);

            string query = "INSERT INTO Transactionn(transaction_date, transaction_type, targetIBAN, amount, nextBalance, account_id) VALUES(@date, @type,@iban ,@amount, @balance, @id)";

            DateTime date = DateTime.Now;
            SQLiteParameter paramName = new SQLiteParameter("date", date);
            SQLiteParameter paramType = new SQLiteParameter("type", "Para Çekme");
            SQLiteParameter paramIban = new SQLiteParameter("iban", filteredRows[0]["iban"].ToString());
            SQLiteParameter paramAmount = new SQLiteParameter("amount", totalAmount);
            SQLiteParameter paramBalance = new SQLiteParameter("balance", totalAmount - val);
            SQLiteParameter paramId = new SQLiteParameter("id", choosenID);


            SQLiteParameter[] prms = { paramName, paramType, paramIban, paramAmount, paramBalance, paramId };

            if (dbOperations.executeSQL(query, prms)) {
                Form1 myParent = (Form1)this.Parent;
                myParent.hideAll();
                myParent.userControlIslemBitisEkrani1.Show();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız");
            }


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
            textBox1.Text = "150";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "200";
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlAccounts1.Show();
            //string sqlNextBalance= "SELECT nextBalance FROM Transactionn ORDER BY transaction_date DESC LIMIT 1";
            myParent.userControlAccounts1.getAllofAccounts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "50";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "500";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1000";
        }

      
    }
}