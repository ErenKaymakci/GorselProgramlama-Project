using System.Data.SQLite;


namespace GelismisATM
{
    public class Connection
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=C:\\Users\\Eren\\Documents\\trying.db3;Version=3");
    }
}