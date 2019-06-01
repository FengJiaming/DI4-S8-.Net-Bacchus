using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class Famille
    {
        public Famille(int Ref_Famille, string Nom)
        {
            this.Ref_Famille = Ref_Famille;
            this.Nom = Nom;
        }

        public int Ref_Famille { get; set; }

        public string Nom { get; set; }
        public string[] ToRow()
        {
            string[] Row = { Nom };
            return Row;
        }
    }
}
