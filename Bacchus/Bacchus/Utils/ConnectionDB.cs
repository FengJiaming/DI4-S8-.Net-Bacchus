
using System.Data;
using System.Data.SQLite;


namespace Bacchus.Utils
{
    ///<summary>
    ///Class: ConnectionDB
    ///Type: Utils
    ///Fonction: Utiliser System.Data.SQLite et Connecter la base de données
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
    class ConnectionDB
    {
        private static SQLiteConnection Connection = null;
        private ConnectionDB() { }

        /// <summary>
        /// obtenir la connexion de base de données
        /// </summary>
        /// <returns>Objet de connexion</returns>
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
