using Bacchus.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
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

        public List<Marque> GetMarques()
        {
            MarqueDAO MarqueDao = new MarqueDAO();
            return MarqueDao.GetAllMarques();
        }

        public List<Famille> GetFamilles()
        {
            FamilleDAO FamilleDao = new FamilleDAO();
            return FamilleDao.GetAllFamilles();
        }

        public List<SousFamille> GetSousFamilles()
        {
            SousFamilleDAO SousFamilleDao = new SousFamilleDAO();
            return SousFamilleDao.GetAllSousFamilles();
        }
        public List<Article> GetArticles()
        {
            ArticleDAO ArticleDao = new ArticleDAO();
            return ArticleDao.GetAllArticles();
           
        }
        public Marque SearchMarque(string Nom_Marque)
        {
            foreach (var Marque in Marques)
            {
                if (Marque.Nom.Equals(Nom_Marque))
                    return Marque;
            }

            return null;
        }

        public Famille SearchFamille(string Nom_Famille)
        {
            foreach (var Famille in Familles)
            {
                if (Famille.Nom.Equals(Nom_Famille))
                    return Famille;
            }

            return null;
        }

        public SousFamille SearchSousFamille(string Nom_SousFamille)
        {
            foreach (var SousFamille in SousFamilles)
            {
                if (SousFamille.Nom.Equals(Nom_SousFamille))
                    return SousFamille;
            }

            return null;
        }

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


