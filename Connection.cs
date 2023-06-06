using System.Data.SQLite;


namespace GelismisATM
{
    public class Connection
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=C:\\Users\\iremm\\Downloads\\atmDatas.db;");
    }
}