using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace GelismisATM
{
    public partial class UserControlAdminPage : UserControl
    {
        Form1 myParent;

        public UserControlAdminPage()
        {
            InitializeComponent();
        }

        void showAllDB()
        {
            string sqlCommand = "SELECT * FROM " + comboBox1.GetItemText(comboBox1.SelectedItem);
            //SQLiteParameter param1 = new SQLiteParameter("comboBoxValue);
            SQLiteParameter[] param = { };
            dataGridView1.DataSource = dbOperations.accessSQLdata(sqlCommand, param);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAllDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 myParent = (Form1)this.Parent;
            myParent.hideAll();
            myParent.userControlAdminAdd1.Show();

        }

        private void delete(string columnName)
        {
            int choosenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[columnName].Value.ToString());
            string query = "DELETE FROM " + comboBox1.GetItemText(comboBox1.SelectedItem) + " WHERE "+ columnName +"=@id";

            SQLiteParameter param = new SQLiteParameter("id", choosenID);
            SQLiteParameter[] prms = { param };
            if (dbOperations.executeSQL(query, prms))
            {
                showAllDB();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Secili kayıt silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Users")
                {
                    delete("user_id");
                }
                else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Accounts")
                {
                    delete("account_id");
                }
                else if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Transactionn")
                {
                    delete("transact_id");
                }
            }
        }
    }
}