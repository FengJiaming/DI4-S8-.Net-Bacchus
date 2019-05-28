using Bacchus.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bacchus.Model;
namespace Bacchus.DAO
{
    class ArticleDAO
    {
        SQLiteConnection Connection;
        public ArticleDAO()
        {
            this.Connection = ConnectionDB.GetConnection();
        }

        /*public Article MakeArticle(String Ref, string Des, int RefSubF, int RefMark, float Price, int Quantity)
        {
            Article Article = new Article();
            Article.Ref_Article = Ref;
            Article.Description = Des;
            Article.PrixHT = Price;
            Article.Quantite = Quantity;

            // insert mark
            MarqueDAO MarqueDAO = new MarqueDAO();
            Article.Ref_Marque = RefMark;

            //insert subfamilly
            SousFamilleDAO SousFamilleDAO = new SousFamilleDAO();
            Article.Ref_SousFamille = RefSubF;

            return Article;
        }*/

        public int Insert(Article Article)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Transaction = Connection.BeginTransaction())
            {
                InsertCommand.CommandText = "INSERT INTO Articles (RefArticle, Description, RefSousFamille, RefMarque, PrixHT" +
                    "Quantite) VALUES (:RefArticle, :Description, :RefSousFamille, :RefMarque, :PrixHT, :quantite)";
                InsertCommand.Parameters.AddWithValue("RefArticle", Article.Ref_Article);
                InsertCommand.Parameters.AddWithValue("Description", Article.Description);
                InsertCommand.Parameters.AddWithValue("RefSousFamille", Article.SousFamille.Ref_SousFamille);
                InsertCommand.Parameters.AddWithValue("RefMarque", Article.Marque.Ref_Marque);
                InsertCommand.Parameters.AddWithValue("PrixHT", Article.PrixHT);
                InsertCommand.Parameters.AddWithValue("quantite", Article.Quantite);

                Count = InsertCommand.ExecuteNonQuery();
                Transaction.Commit();
                InsertCommand.Dispose();

            }
            return Count;


        }
        
    }
}


   