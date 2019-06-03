
using System.Data;
using System.Data.SQLite;


namespace Bacchus.Utils
{
    class ConnectionDB
    {
        private static SQLiteConnection Connection = null;
        private ConnectionDB() { }

        /// <summary>
        /// get database connection
        /// </summary>
        /// <returns>Connection object</returns>
        public static SQLiteConnection GetConnection()
        {
            string Path = "Data Source=Bacchus.SQLite";

            if (Connection == null)
            {
                Connection = new SQLiteConnection(Path);
                if (Connection.State == ConnectionState.Closed)
                    Connection.Open();
                return Connection;
            }
            else
            {
                return Connection;
            }

        }
    }
}
