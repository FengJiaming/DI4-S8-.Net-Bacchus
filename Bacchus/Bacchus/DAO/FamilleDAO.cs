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
    public class FamilleDAO
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

        public void Update(Famille Famille)
        {
            var Command = new SQLiteCommand("UPDATE Familles SET Nom = :nom WHERE RefFamille = :refFamille", Connection);
            Command.Parameters.AddWithValue("nom", Famille.Nom);
            Command.Parameters.AddWithValue("refFamille", Famille.Ref_Famille);
            Command.ExecuteNonQuery();
        }
        public void Delete(Famille Famille)
        {
            var Command = new SQLiteCommand("DELETE FROM Familles WHERE RefFamille = :refFamille", Connection);
            Command.Parameters.AddWithValue("refFamille", Famille.Ref_Famille);
            Command.ExecuteNonQuery();

        }

        public List<Famille> GetAllFamilles()
        {
            var Familles = new List<Famille>();

            var Command = new SQLiteCommand("SELECT * FROM Familles", Connection);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefFamille = Reader.GetInt32(0);
                var Nom = Reader.GetString(1);
                Familles.Add(new Famille(RefFamille, Nom));
            }

            Reader.Close();

            return Familles;
        }

        public Famille GetFamilleByID(int Ref_Famille)
        {
            var RefFamille = 0;
            var Nom = "";
            var Command = new SQLiteCommand("SELECT * FROM Familles WHERE RefFamille = :RefFamille", Connection);
            Command.Parameters.AddWithValue("RefFamille", Ref_Famille);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                RefFamille = Reader.GetInt32(0);
                Nom = Reader.GetString(1);
            }

            Reader.Close();
            var Famille = new Famille(RefFamille, Nom);

            return Famille;
        }

        public void DeleteAllFamilles()
        {
            var Transaction = Connection.BeginTransaction();
            SQLiteCommand Command = new SQLiteCommand("DELETE FROM Familles", Connection);
            Command.ExecuteNonQuery();
            Transaction.Commit();
        }
    }
}
