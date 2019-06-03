using Bacchus.Model;
using Bacchus.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace Bacchus.DAO
{
    public class MarqueDAO
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

        public void Update(Marque Marque)
        {
            var Command = new SQLiteCommand("UPDATE Marques SET Nom = :nom WHERE RefMarque = :refMarque", Connection);
            Command.Parameters.AddWithValue("nom", Marque.Nom);
            Command.Parameters.AddWithValue("refMarque", Marque.Ref_Marque);
            Command.ExecuteNonQuery();
        }

        public void Delete(Marque Marque)
        {

            var Command = new SQLiteCommand("DELETE FROM Marques WHERE RefMarque = :refMarque", Connection);
            Command.Parameters.AddWithValue("refMarque", Marque.Ref_Marque);
            Command.ExecuteNonQuery();

        }
        public List<Marque> GetAllMarques()
        {
            var Marques = new List<Marque>();

            var Command = new SQLiteCommand("SELECT * FROM Marques", Connection);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefMarque = Reader.GetInt32(0);
                var Nom = Reader.GetString(1);
                Marques.Add(new Marque(RefMarque, Nom));
            }

            Reader.Close();

            return Marques;
        }

        public Marque GetMarqueByID(int Ref_Marque)
        {
            var RefMarque = 0;
            var Nom = "";
            var Command = new SQLiteCommand("SELECT * FROM Marques WHERE RefMarque = :RefMarque", Connection);
            Command.Parameters.AddWithValue("RefMarque", Ref_Marque);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                RefMarque = Reader.GetInt32(0);
                Nom = Reader.GetString(1);
            }

            Reader.Close();
            var Marque = new Marque(RefMarque, Nom);

            return Marque;
        }

        public void DeleteAllMarques()
        {
            var Transaction = Connection.BeginTransaction();
            SQLiteCommand Command = new SQLiteCommand("DELETE FROM Marques", Connection);
            Command.ExecuteNonQuery();
            Transaction.Commit();
        }
    }
}
