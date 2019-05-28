using Bacchus.Model;
using Bacchus.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.DAO
{
    class MarqueDAO
    {
        SQLiteConnection Connection;
        public MarqueDAO()
        {
            this.Connection = ConnectionDB.GetConnection();
            
        }

        public int Insert(Marque Marque)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            InsertCommand.CommandText = "SELECT MAX(RefMarque) FROM Marques";
            var Scalar = InsertCommand.ExecuteScalar();
            Marque.Ref_Marque = Scalar.ToString().Equals("") ? 0 : Convert.ToInt32(Scalar) + 1;

            using (SQLiteTransaction Transaction = Connection.BeginTransaction())
            {
                InsertCommand.CommandText = "INSERT INTO Marques (RefMarque, Nom) VALUES (:RefMarque, :Nom)";
                InsertCommand.Parameters.AddWithValue("RefMarque", Marque.Ref_Marque);
                InsertCommand.Parameters.AddWithValue("Nom", Marque.Nom);
            
                Count = InsertCommand.ExecuteNonQuery();
                Transaction.Commit();
                InsertCommand.Dispose();
            }
            return Count;

        }
    }
}
