using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class Article
    {
        public string Ref_Article { get; set; }
        public string Description { get; set; }
        //public int Ref_SousFamille { get; set; }
        public SousFamille SousFamille { get; set; }

        public Marque Marque { get; set; }

        //public int Ref_Marque { get; set; }
        public int Quantite { get; set; }
        public float PrixHT { get; set; }

        public Article(string RefArticle, string Description, SousFamille SousFamille, Marque Marque, float PrixHT, int Quantite)
        {
            this.Ref_Article = RefArticle;
            this.Description = Description;
            this.SousFamille = SousFamille;
            this.Marque = Marque;
            this.PrixHT = PrixHT;
            this.Quantite = Quantite;
        }

        public override string ToString()
        {
            return Description + " - " + PrixHT + " - " + Quantite;
        }

        public string[] ToRow()
        {
            string[] Row =
            {
                Ref_Article, Description, Marque.Nom, SousFamille.Nom, PrixHT.ToString(CultureInfo.InvariantCulture),
                Quantite.ToString()
            };
            return Row;
        }
    }
}

