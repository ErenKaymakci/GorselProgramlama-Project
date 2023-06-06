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
    public partial class UserControlslemOzeti : UserControl
    {
        public UserControlslemOzeti()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlslemOzeti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //İslem Bitis Ekranı Açılıyor
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlIslemBitisEkrani1.Show();

            //Para Transferi işleminin veri tabanında Transactionn tablosuna eklenmesi
            int miktar = int.Parse(myParent.userControlParaTransferi1.textBox1.Text);//transfer edilecek para miktarı
            string tc = Convert.ToString(myParent.userControlLogin1.textBox1.Text);//sisteme giriş yapan kullanıcı tc
            string account_type = myParent.userControlParaTransferi1.comboBox1.Text;//transfer yapılacak hesap türü
        

            string sqlname = "select * from Accounts where tc= @p5 and account_type=@p6";
            SQLiteParameter tc2 = new SQLiteParameter("p5", tc);
            SQLiteParameter account_type2 = new SQLiteParameter("p6", account_type);
            SQLiteParameter[] param3 = { tc2, account_type2 };
            DataTable dt = dbOperations.accessSQLdata(sqlname, param3);
            myParent.userControlIslemBitisEkrani1.label4.Text = dt.Rows[0]["account_balance"].ToString();

            //Hesap bakiye kontrolü
            if (miktar > Convert.ToInt32(dt.Rows[0]["account_balance"]))//miktar:transfer edilmek istenen miktar
            {
                myParent.userControlslemOzeti1.textBox1.Text = "";
                myParent.userControlslemOzeti1.textBox3.Text = "";
                myParent.userControlslemOzeti1.textBox2.Text = "";
                myParent.userControlslemOzeti1.textBox5.Text = "";
                myParent.userControlslemOzeti1.textBox4.Text ="";
                myParent.hideAll();
                myParent.userControlslemOzeti1.Show();

                MessageBox.Show("yetersiz bakiye");
                
                myParent.userControlParaTransferi1.Show();
                myParent.userControlParaTransferi1.textBox1.Text = "";
                myParent.userControlParaTransferi1.maskedTextBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox1.Text = "";
                myParent.userControlParaTransferi1.comboBox2.Text = "";
            }
            else
            {
                //bakiye güncelleme
                string komut2 =
                    "update Accounts set account_balance=account_balance-@p1 where tc=@p2 and account_type=@p4";
                string komut3 = "update Accounts set account_balance=account_balance+@p3 where iban=@p5";
                // string tc3 = Convert.ToString(myParent.userControlLogin1.textBox1.Text);
                string account_type3 = myParent.userControlParaTransferi1.comboBox1.Text;
                SQLiteParameter p1 = new SQLiteParameter("p1", miktar);
                SQLiteParameter p2 = new SQLiteParameter("p2", tc); //giriş yapan kullanıcı tc
                SQLiteParameter p4 = new SQLiteParameter("p4", account_type3); //comboBox seçilen hesap türü

                string iban =
                    (myParent.userControlParaTransferi1.maskedTextBox1.Text).ToString(); //transfer yapılacak iban
                SQLiteParameter p3 = new SQLiteParameter("p3", miktar); //transfer yapılacak miktar
                SQLiteParameter p5 = new SQLiteParameter("p5", iban); //transfer yapılacak iban
                SQLiteParameter[] paramk2 = { p1, p2, p4 };
                SQLiteParameter[] paramk3 = { p3, p5 };

                dbOperations.executeSQL(komut2, paramk2);
                dbOperations.executeSQL(komut3, paramk3);


                //Transfer yapılan hesabın idsi;
                string sqlid = "Select * from Accounts where tc=@tc";
                SQLiteParameter param1 = new SQLiteParameter("tc", User.userTC);
                SQLiteParameter[] param = { param1 };

                DataTable dtAcc = dbOperations.accessSQLdata(sqlid, param);
                string choosenAccType =
                    myParent.userControlParaTransferi1.comboBox1.GetItemText(myParent.userControlParaTransferi1
                        .comboBox1.SelectedItem);
                DataRow[] filteredRows = dtAcc.Select("account_type= '" + choosenAccType + "'");


                string choosen_id = filteredRows[0]["account_id"].ToString(); //seçilen hesabın idsi

                //Girilen verilere göre veri tabanına ekleme yapılması(Transactionn Tablosu)
                string sql2 =
                    "INSERT INTO Transactionn (transaction_id,transaction_type,targetIBAN,amount,transaction_date,nextBalance,account_id) VALUES(@transaction_id,@transaction_type,@targetIBAN,@amount,@transaction_date,@nextBalance,@choosen_id)";
                DateTime dateTimeVariable = DateTime.Now; //işlem tarihi

                string guncelBakiye = myParent.userControlslemOzeti1.textBox5.Text; //işlem sonucu guncek bakiye


                SQLiteParameter targetIBAN =
                    new SQLiteParameter("targetIBAN", myParent.userControlParaTransferi1.maskedTextBox1.Text);
                SQLiteParameter amount =
                    new SQLiteParameter("amount", myParent.userControlParaTransferi1.textBox1.Text);
                SQLiteParameter transaction_type = new SQLiteParameter("transaction_type", "Para Transferi");
                SQLiteParameter transaction_id = new SQLiteParameter("transaction_id");
                SQLiteParameter transaction_date = new SQLiteParameter("transaction_date", dateTimeVariable);
                SQLiteParameter next_balance = new SQLiteParameter("nextBalance", guncelBakiye);
                SQLiteParameter choosen_idd = new SQLiteParameter("choosen_id", choosen_id);

                SQLiteParameter[] param2 =
                {
                    transaction_id, transaction_type, amount, targetIBAN, transaction_date, next_balance, choosen_idd
                };

                dbOperations.executeSQL(sql2, param2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            
                        myParent.hideAll();
                        myParent.userControlParaTransferi1.Show();
                        myParent.userControlParaTransferi1.textBox1.Text = "";
                        myParent.userControlParaTransferi1.maskedTextBox1.Text = "";
                        myParent.userControlParaTransferi1.comboBox1.Text = "";
                        myParent.userControlParaTransferi1.comboBox2.Text = "";
        }
    }
}
