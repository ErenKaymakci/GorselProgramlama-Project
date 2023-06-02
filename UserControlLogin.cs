using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GelismisATM
{
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void UserControlLogin_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void authorizeLogin()
        {
            string sql = "SELECT * FROM Users WHERE name=@kadi AND password=@pass";

            SQLiteParameter username = new SQLiteParameter("kadi", textBox1.Text);
            SQLiteParameter password = new SQLiteParameter("pass", textBox2.Text);

            SQLiteParameter[] param = { username, password };

            DataTable dt = dbOperations.accessSQLdata(sql, param);
            
            
            if (dt.Rows.Count > 0)
            {
                string userr = dt.Rows[0]["name"].ToString();
                
                Form1 myParent = (Form1)this.Parent;
                myParent.lblMenuUsername.Text = userr;
                if (userr == "admin")
                {
                    myParent.hideAll();
                    myParent.userControlAdminPage1.Show();
                }
                else
                {
                    myParent.hideAll();
                    myParent.userControlAccountDetails1.Show();

                }
                myParent.setVisibleBtns(true);

            }
            else
            {
                label4.Text = "Kullanıcı adı veya parola hatalı!";
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorizeLogin();

        }

    }
}