using Bacchus.Model;
using Bacchus.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.DAO
{
    class FamilleDAO
    {
        SQLiteConnection Connection;
        public FamilleDAO()
        {
            this.Connection = ConnectionDB.GetConnection();
        }

        public int Insert(Famille Famille)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            InsertCommand.CommandText = "SELECT MAX(RefFamille) FROM Familles";
            var Scalar = InsertCommand.ExecuteScalar();
            Famille.Ref_Famille = Scalar.ToString().Equals("") ? 0 : Convert.ToInt32(Scalar) + 1;

            using (SQLiteTransaction Transaction = Connection.BeginTransaction())
            {
                InsertCommand.CommandText = "INSERT INTO Familles (RefFamille, Nom) VALUES (:RefFamille, :Nom)";
                InsertCommand.Parameters.AddWithValue("RefFamille", Famille.Ref_Famille);
                InsertCommand.Parameters.AddWithValue("Nom", Famille.Nom);

                Count = InsertCommand.ExecuteNonQuery();
                Transaction.Commit();
                InsertCommand.Dispose();
            }
            return Count;

        }
    }
}
