using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class SousFamille
    {
        public SousFamille(int Ref_SousFamille, int Ref_Famille, string Nom)
        {
            this.Ref_SousFamille = Ref_SousFamille;
            this.Ref_Famille = Ref_Famille;
            this.Nom = Nom;
        }

        public int Ref_SousFamille { get; set; }

        public int Ref_Famille { get; set; }

        public string Nom { get; set; }

    }
}
