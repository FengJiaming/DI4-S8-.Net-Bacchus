using Bacchus.DAO;
using System.Collections.Generic;

namespace Bacchus.Model
{
    ///<summary>
    ///Class: BacchusModel
    ///Type: Model
    ///Fonction: Tous les attributs/données: intégrer et des recherches
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
    public class BacchusModel
    {
       
        public List<Famille> Familles { get; set; }

        public List<Marque> Marques { get; set; } 

        public List<SousFamille> SousFamilles { get; set; } 

        public List<Article> Articles { get; set; } 

        public BacchusModel()
        {
            Familles = GetFamilles();
            Marques = GetMarques();
            SousFamilles = GetSousFamilles();
            Articles = GetArticles();

        }

        /// <summary>
        /// Obtenir tous les marques de la base de données
        /// </summary>
        /// <returns>
        /// List<Marque> : Liste de tous les marques
        /// </returns>
        public List<Marque> GetMarques()
        {
            MarqueDAO MarqueDao = new MarqueDAO();
            return MarqueDao.GetAllMarques();
        }

        /// <summary>
        /// Obtenir tous les familles de la base de données
        /// </summary>
        /// <returns>
        /// List<Famille> : Liste de tous les familles
        /// </returns>
        public List<Famille> GetFamilles()
        {
            FamilleDAO FamilleDao = new FamilleDAO();
            return FamilleDao.GetAllFamilles();
        }

        /// <summary>
        /// Obtenir tous les sous-familles de la base de données
        /// </summary>
        /// <returns>
        /// List<SousFamille> : Liste de tous les sous-familles
        /// </returns>
        public List<SousFamille> GetSousFamilles()
        {
            SousFamilleDAO SousFamilleDao = new SousFamilleDAO();
            return SousFamilleDao.GetAllSousFamilles();
        }

        /// <summary>
        /// Obtenir tous les articles de la base de données
        /// </summary>
        /// <returns>
        /// List<Article> : Liste de tous les articles
        /// </returns>
        public List<Article> GetArticles()
        {
            ArticleDAO ArticleDao = new ArticleDAO();
            return ArticleDao.GetAllArticles();
           
        }

        /// <summary>
        /// Rechercher un marque à la base de données par le Nom_Marque
        /// </summary>
        /// <param name="Nom_Marque">string</param>
        /// <returns>
        /// Marque : Objet
        /// </returns>
        public Marque SearchMarque(string Nom_Marque)
        {
            foreach (var Marque in Marques)
            {
                if (Marque.Nom.Equals(Nom_Marque))
                    return Marque;
            }

            return null;
        }

        /// <summary>
        /// Rechercher un Famille à la base de données par le Nom_Famille
        /// </summary>
        /// <param name="Nom_Marque">string</param>
        /// <returns>
        /// Famille : Objet
        /// </returns>
        public Famille SearchFamille(string Nom_Famille)
        {
            foreach (var Famille in Familles)
            {
                if (Famille.Nom.Equals(Nom_Famille))
                    return Famille;
            }

            return null;
        }

        /// <summary>
        /// Rechercher un SousFamille à la base de données par le Nom_SousFamille
        /// </summary>
        /// <param name="Nom_SousFamille">string</param>
        /// <returns>
        /// SousFamille : Objet
        /// </returns>
        public SousFamille SearchSousFamille(string Nom_SousFamille)
        {
            foreach (var SousFamille in SousFamilles)
            {
                if (SousFamille.Nom.Equals(Nom_SousFamille))
                    return SousFamille;
            }

            return null;
        }

        /// <summary>
        /// Rechercher un article à la base de données par le Ref_Article
        /// </summary>
        /// <param name="Ref_Article">string</param>
        /// <returns>
        /// Article : Objet
        /// </returns>
        public Article SearchArticle(string Ref_Article)
        {
            foreach (var Article in Articles)
            {
                if (Article.Ref_Article.Equals(Ref_Article))
                    return Article;
            }

            return null;
        }
    }

}


