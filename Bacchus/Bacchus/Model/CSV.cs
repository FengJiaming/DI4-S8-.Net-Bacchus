using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Model
{
    class CSV
    {
        public string Description { get; set; }
        public string Ref_Article { get; set; }
        public Marque Marque { get; set; }
        public Famille Famille { get; set; }
        public SousFamille SousFamille { get; set; }
        public float PrixHT { get; set; }
    }
}
