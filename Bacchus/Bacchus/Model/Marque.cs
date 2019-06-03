
namespace Bacchus.Model
{
    ///<summary>
    ///Class: Marque
    ///Type: Model
    ///Fonction: Attribut/Données: Marque
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
    public class Marque
    {
        public Marque(int Ref_Marque, string Nom)
        {
            this.Ref_Marque = Ref_Marque;
            this.Nom = Nom;
        }

        public int Ref_Marque { get; set; }

        public string Nom { get; set; }

        public string[] ToRow()
        {
            string[] Row = { Nom };
            return Row;
        }
    }
}
