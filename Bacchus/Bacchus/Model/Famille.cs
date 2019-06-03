
namespace Bacchus.Model
{
    ///<summary>
    ///Class: Famille
    ///Type: Model
    ///Fonction: Attribut/Données: Famille
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
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
