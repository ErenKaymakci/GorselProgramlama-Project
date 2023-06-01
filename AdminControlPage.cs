using System.Windows.Forms;

namespace GelismisATM
{
    public partial class AdminControlPage : UserControl
    {
        public AdminControlPage()
        {
            InitializeComponent();
            showAllDB();
        }

        void showAllDB()
        {
            string sqlCommand = "SELECT * FROM Accounts";
            dataGridView1.DataSource = dbOperations.accessSQLdata(sqlCommand);
        }
    }
}