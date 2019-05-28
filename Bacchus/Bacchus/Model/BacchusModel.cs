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
            Familles = new List<Famille>();
            Marques = new List<Marque>();
            SousFamilles = new List<SousFamille>();
            Articles = new List<Article>();
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


