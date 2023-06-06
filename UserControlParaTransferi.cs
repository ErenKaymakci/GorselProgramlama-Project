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
    public partial class UserControlParaTransferi : UserControl
    {
        public UserControlParaTransferi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void configureComboBox()
        {
            string sql = "SELECT * from Accounts WHERE tc=@tc";

            SQLiteParameter param1 = new SQLiteParameter("tc", User.userTC);
            SQLiteParameter[] param = { param1 };

            DataTable dt = dbOperations.accessSQLdata(sql, param);
            comboBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["account_type"].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlslemOzeti1.Show();

            string tc = Convert.ToString(myParent.userControlLogin1.textBox1.Text);
            string sqlc = "select currency from Users, Accounts where Users.tc = Accounts.tc and Accounts.tc = @tcgc";//para birimi

            SQLiteParameter tcgc = new SQLiteParameter("tcgc", tc);
            SQLiteParameter[] param6 = { tcgc };
            DataTable dt3 = dbOperations.accessSQLdata(sqlc, param6);

            //girilen bilgilerin Islem Ozeti ekranına aktarılması
            myParent.userControlslemOzeti1.textBox1.Text = textBox1.Text;
            myParent.userControlslemOzeti1.textBox3.Text = maskedTextBox1.Text;
            myParent.userControlslemOzeti1.textBox2.Text = comboBox2.Text;
           
            try
            {
                string sqlAcc = "select * from Accounts where tc= @p5 and account_type=@p6";
                string account_type = comboBox1.GetItemText(myParent.userControlParaTransferi1.comboBox1.SelectedItem);

                SQLiteParameter tc2 = new SQLiteParameter("p5", tc);
                SQLiteParameter account_type2 = new SQLiteParameter("p6", account_type);

                SQLiteParameter[] param3 = { tc2, account_type2 };

                DataTable dt = dbOperations.accessSQLdata(sqlAcc, param3);
                int a = Convert.ToInt32(dt.Rows[0]["account_balance"]);
                int miktar = int.Parse(myParent.userControlParaTransferi1.textBox1.Text);

                if (a - miktar >= 0)
                    myParent.userControlslemOzeti1.textBox5.Text = (a - miktar).ToString();
                else
                    myParent.userControlslemOzeti1.textBox5.Text = "0";
            }
            catch (IndexOutOfRangeException ex)
            {
                myParent.userControlslemOzeti1.textBox5.Text = "";
                myParent.userControlslemOzeti1.textBox1.Text = "";
                myParent.userControlslemOzeti1.textBox2.Text = "";
                myParent.userControlslemOzeti1.textBox3.Text = "";
                myParent.userControlslemOzeti1.textBox4.Text = "";
                MessageBox.Show("Geçerli IBAN bilgisi giriniz .", ex.Message);
               
                myParent.hideAll();
                myParent.userControlParaTransferi1.Show();
                myParent.userControlParaTransferi1.Show();
                myParent.userControlParaTransferi1.textBox1.Text = "";
                myParent.userControlParaTransferi1.maskedTextBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox2.Text = "";

            }
            catch (FormatException ex2)
            {
                myParent.userControlslemOzeti1.textBox5.Text = "";
                myParent.userControlslemOzeti1.textBox1.Text = "";
                myParent.userControlslemOzeti1.textBox2.Text = "";
                myParent.userControlslemOzeti1.textBox3.Text = "";
                myParent.userControlslemOzeti1.textBox4.Text = "";
                MessageBox.Show("Geçerli miktar giriniz .", ex2.Message);
                
                myParent.hideAll();
                myParent.userControlParaTransferi1.Show();
                myParent.userControlParaTransferi1.Show();
                myParent.userControlParaTransferi1.textBox1.Text = "";
                myParent.userControlParaTransferi1.maskedTextBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox2.Text = "";
            }
            try
            {
                //Transfer yapılacak hesabın kullanıcı ismi
                string sqlisimb = "select name, surname from Users, Accounts where Users.tc = Accounts.tc and Accounts.iban=@parameteriban";
                string iban = (myParent.userControlParaTransferi1.maskedTextBox1.Text).ToString();

                
                SQLiteParameter parameteriban = new SQLiteParameter("parameteriban", iban);
                SQLiteParameter[] param0 = { parameteriban };
                DataTable dt2 = dbOperations.accessSQLdata(sqlisimb, param0);
                myParent.userControlslemOzeti1.textBox4.Text = dt2.Rows[0]["name"].ToString() + " " + dt2.Rows[0]["surname"].ToString();
            }
            catch (IndexOutOfRangeException ex3)
            {
                myParent.userControlslemOzeti1.textBox4.Text = "";
                myParent.userControlslemOzeti1.textBox5.Text = "";
                myParent.userControlslemOzeti1.textBox1.Text = "";
                myParent.userControlslemOzeti1.textBox2.Text = "";
                myParent.userControlslemOzeti1.textBox3.Text = "";
                MessageBox.Show("Kullanıcı bilgisi geçersiz  ya da sisteme kayıtlı degil.", ex3.Message);

                myParent.hideAll();
                myParent.userControlParaTransferi1.Show();
                myParent.userControlParaTransferi1.textBox1.Text = "";
                myParent.userControlParaTransferi1.maskedTextBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox2.Text = "";
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlAccounts1.Show();
            //string sqlNextBalance= "SELECT nextBalance FROM Transactionn ORDER BY transaction_date DESC LIMIT 1";
            myParent.userControlAccounts1.getAllofAccounts();
        }
    }
}
