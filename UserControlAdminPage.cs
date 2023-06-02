using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GelismisATM
{
    public partial class UserControlAdminPage : UserControl
    {
        public UserControlAdminPage()
        {
            InitializeComponent();
        }
        
        void showAllDB()
        {
            string sqlCommand = "SELECT * FROM Accounts";
            SQLiteParameter[] param = { };
            dataGridView1.DataSource = dbOperations.accessSQLdata(sqlCommand, param);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAllDB();
        }
    }
}