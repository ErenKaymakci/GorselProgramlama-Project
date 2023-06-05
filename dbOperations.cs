using System.Data;
using System.Data.SQLite;

namespace GelismisATM
{
    public class dbOperations
    {
        static DataTable dt;

        public static DataTable accessSQLdata(string sql, SQLiteParameter[] parameters) // The function is doing get the data from database
        {
            dt = new DataTable();

            SQLiteCommand command = new SQLiteCommand(sql, Connection.connection);
            
            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }                
                
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(command);
            adtr.Fill(dt);
            
            return dt;
        }

        public static bool executeSQL(string sql, SQLiteParameter[] parameters) // The function is doing insertion, update and delete.
        {

            int correction = 0;
            
            SQLiteCommand command = new SQLiteCommand(sql, Connection.connection);

            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i]);
            }
            
            if (Connection.connection != null && Connection.connection.State == ConnectionState.Closed)
            {
                Connection.connection.Open();
            }
            
            correction = command.ExecuteNonQuery();
            
            if (correction == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}