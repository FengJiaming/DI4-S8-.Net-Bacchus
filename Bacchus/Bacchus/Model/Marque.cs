using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    public class Marque
    {
        public Marque(int Ref_Marque, string Nom)
        {
            this.Ref_Marque = Ref_Marque;
            this.Nom = Nom;
        }

        public int Ref_Marque { get; set; }

        public string Nom { get; set; }
    }
}
