
namespace Bacchus.Model
{
    ///<summary>
    ///Class: SousFamille
    ///Type: Model
    ///Fonction: Attribut/Données: SousFamille
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
    public class SousFamille
    {
        public SousFamille(int Ref_SousFamille,  Famille Famille, string Nom)
        {
            this.Ref_SousFamille = Ref_SousFamille;
            this.Famille = Famille;
            this.Nom = Nom;
        }

        public int Ref_SousFamille { get; set; }

        public Famille Famille { get; set; }

        public string Nom { get; set; }

        public string[] ToRow()
        {
            string[] Row = { Nom, Famille.Nom };
            return Row;
        }
    }
}
