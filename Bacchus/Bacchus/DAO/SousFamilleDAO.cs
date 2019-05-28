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
    class SousFamilleDAO
    {
        SQLiteConnection Connection;
        public SousFamilleDAO()
        {
            this.Connection = ConnectionDB.GetConnection();
        }

        public int Insert(SousFamille SousFamille)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            InsertCommand.CommandText = "SELECT MAX(RefSousFamille) FROM SousFamilles";
            var Scalar = InsertCommand.ExecuteScalar();
            SousFamille.Ref_SousFamille = Scalar.ToString().Equals("") ? 0 : Convert.ToInt32(Scalar) + 1;

            using (SQLiteTransaction Transaction = Connection.BeginTransaction())
            {
                InsertCommand.CommandText = "INSERT INTO SousFamilles (RefSousFamille, RefFamille, Nom) VALUES (:RefSousFamille, :RefFamille, :Nom)";
                InsertCommand.Parameters.AddWithValue("RefSousFamille", SousFamille.Ref_SousFamille);
                InsertCommand.Parameters.AddWithValue("RefFamille", SousFamille.Ref_Famille);
                InsertCommand.Parameters.AddWithValue("Nom", SousFamille.Nom);

                Count = InsertCommand.ExecuteNonQuery();
                Transaction.Commit();
                InsertCommand.Dispose();
            }
            return Count;

        }
    }
}
