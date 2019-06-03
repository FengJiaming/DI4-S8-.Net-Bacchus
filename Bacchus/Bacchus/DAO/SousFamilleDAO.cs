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
    ///<summary>
    ///Class: SousFamilleDAO
    ///Type: DAO
    ///Fonction: Traiter le Model SousFamille et réaliser les fonctions comme des ajouts, suppressions et modifications et recherches
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
    public class SousFamilleDAO
    {
        SQLiteConnection Connection;

        FamilleDAO FamilleDao;
        public SousFamilleDAO()
        {
            this.Connection = ConnectionDB.GetConnection();
            this.FamilleDao = new FamilleDAO();
        }

        /// <summary>
        /// Ajoute un sous-famille à la base de données
        /// </summary>
        /// <param name="SousFamille">Objet: SousFamille</param>
        /// <returns>
        /// int : Compte le nombre de sous-familles dans la base de donéee
        /// </returns>
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
                InsertCommand.Parameters.AddWithValue("RefFamille", SousFamille.Famille.Ref_Famille);
                InsertCommand.Parameters.AddWithValue("Nom", SousFamille.Nom);

                Count = InsertCommand.ExecuteNonQuery();
                Transaction.Commit();
                InsertCommand.Dispose();
            }
            return Count;

        }

        /// <summary>
        /// Mise a jour les sous-familles de la base de données
        /// </summary>
        /// <param name="SousFamille">Objet: SousFamille</param>
        public void Update(SousFamille SousFamille)
        {
            var Command = new SQLiteCommand("UPDATE SousFamilles SET Nom = :nom, RefFamille = :refFamille WHERE RefSousFamille = :refSousFamille",Connection);
            Command.Parameters.AddWithValue("nom", SousFamille.Nom);
            Command.Parameters.AddWithValue("refFamille", SousFamille.Famille.Ref_Famille);
            Command.Parameters.AddWithValue("refSousFamille", SousFamille.Ref_SousFamille);
            Command.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprimer un sous-famille à la base de données
        /// </summary>
        /// <param name="SousFamille">Objet: SousFamille</param>
        public void Delete(SousFamille SousFamille)
        {

            var Command = new SQLiteCommand("DELETE FROM SousFamilles WHERE RefSousFamille = :refSousFamille",
                Connection);
            Command.Parameters.AddWithValue("refSousFamille", SousFamille.Ref_SousFamille);
            Command.ExecuteNonQuery();

        }

        /// <summary>
        /// Obtenir tous les sous-familles de la base de données
        /// </summary>
        /// <returns>
        /// List<SousFamille> : Liste de tous les sous-familles
        /// </returns>
        public List<SousFamille> GetAllSousFamilles()
        {
            var SousFamilles = new List<SousFamille>();

            var Command = new SQLiteCommand("SELECT * FROM SousFamilles", Connection);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefSousFamille = Reader.GetInt32(0);
                var Famille = FamilleDao.GetFamilleByID(Reader.GetInt32(1));
                var Nom = Reader.GetString(2);

                SousFamilles.Add(new SousFamille(RefSousFamille, Famille, Nom));
            }

            Reader.Close();

            return SousFamilles;
        }

        /// <summary>
        /// Obtenir la sous-famille correspondant à la ref en entrée
        /// </summary>
        /// <param name="Ref_SousFamille">int</param>
        /// <returns>
        /// SousFamille : Objet
        /// </returns>
        public SousFamille GetSousFamilleByID(int Ref_SousFamille)
        {
            var RefSousFamille = 0;
            var RefFamille = 0;
            var Nom = "";
            var Command = new SQLiteCommand("SELECT * FROM SousFamilles WHERE RefSousFamille = :RefSousFamille", Connection);
            Command.Parameters.AddWithValue("RefSousFamille", Ref_SousFamille);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                RefSousFamille = Reader.GetInt32(0);
                RefFamille = Reader.GetInt32(1);
                Nom = Reader.GetString(2);
            }

            Reader.Close();
            var Famille = FamilleDao.GetFamilleByID(RefFamille);
            var SousFamille = new SousFamille(RefFamille, Famille, Nom);

            return SousFamille;
        }

        /// <summary>
        /// Obtenir la sous-famille correspondant à la famille en entrée
        /// </summary>
        /// <param name="Famille">Famille</param>
        /// <returns>
        /// List<SousFamille> : Liste de tous les sous-familles
        /// </returns>
        public List<SousFamille> GetSousFamillesByFamille(Famille Famille)
        {
            var SousFamilles = new List<SousFamille>();

            var Command = new SQLiteCommand("SELECT * FROM SousFamilles WHERE RefFamille = :refFamille", Connection);
            Command.Parameters.AddWithValue("refFamille", Famille.Ref_Famille);
            var Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                var RefSousFamille = Reader.GetInt32(0);
                var Nom = Reader.GetString(2);

                SousFamilles.Add(new SousFamille(RefSousFamille, Famille, Nom));
            }

            Reader.Close();
  
            return SousFamilles;
        }

        /// <summary>
        /// Supprimer tous les sous-familles de la base de données
        /// </summary>
        public void DeleteAllSousFamilles()
        {
            var Transaction = Connection.BeginTransaction();
            SQLiteCommand Command = new SQLiteCommand("DELETE FROM SousFamilles", Connection);
            Command.ExecuteNonQuery();
            Transaction.Commit();
        }
    }
}
