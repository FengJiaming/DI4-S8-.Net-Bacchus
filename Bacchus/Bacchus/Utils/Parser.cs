using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bacchus.Model;
using Bacchus.DAO;

namespace Bacchus.Utils
{
    public static class Parser
    {
        //public delegate void UpdateBar(int Progress);
        //public static event UpdateBar HasToUpdate;
        public static int ReadFile(string FilePath, bool Flag, FormImport Form_Import, BacchusModel BacchusModel)
        {
            int nbImport = 0;
            if (Flag = true)
             {
                 // On vide les données du modèle existant
                 //BacchusModel.ClearAll();
                 //Dao.ClearTables();
             }
            
            using (var StreamReader = new StreamReader(FilePath, Encoding.Default))
            {
                var NbLines = File.ReadAllLines(FilePath).Length;

                Form_Import.ToolStripProgressBar.Maximum = NbLines;
                Form_Import.ToolStripProgressBar.Value = 0;

                StreamReader.ReadLine();

                string Line;
                while ((Line = StreamReader.ReadLine()) != null)
                {

                    var Values = Line.Split(';');

                    var Description = Values[0].Trim();
                    var Ref_Article= Values[1].Trim();
                    var Nom_Marque = Values[2].Trim();
                    var Nom_Famille = Values[3].Trim();
                    var Nom_SousFamille = Values[4].Trim();
                    var PrixHT = float.Parse(Values[5].Trim());

                    if (BacchusModel.SearchArticle(Ref_Article) != null)
                    {
                        continue;
                    }

                    Marque Marque = BacchusModel.SearchMarque(Nom_Marque);
                    if (Marque == null)
                    {
                        Marque = new Marque(0, Nom_Marque);
                        BacchusModel.Marques.Add(Marque);
                        MarqueDAO MarqueDao = new MarqueDAO();
                        int countmarque = MarqueDao.Insert(Marque);
                        
                    }

                    Famille Famille = BacchusModel.SearchFamille(Nom_Famille);
                    if (Famille == null)
                    {
                        Famille = new Famille(0, Nom_Famille);
                        BacchusModel.Familles.Add(Famille);
                        FamilleDAO FamilleDao = new FamilleDAO();
                        int countfamille = FamilleDao.Insert(Famille);
                    }

                    SousFamille SousFamille = BacchusModel.SearchSousFamille(Nom_SousFamille);
                    if (SousFamille == null)
                    {
                        SousFamille = new SousFamille(0, Famille, Nom_SousFamille);
                        BacchusModel.SousFamilles.Add(SousFamille);
                        SousFamilleDAO SousFamilleDao = new SousFamilleDAO();
                        SousFamilleDao.Insert(SousFamille);
                    }

                    Article Article = new Article(Ref_Article, Description, SousFamille, Marque, PrixHT, 1);
                    BacchusModel.Articles.Add(Article);
                    ArticleDAO ArticleDao = new ArticleDAO();
                    ArticleDao.Insert(Article);
                    nbImport += 1;
                    Form_Import.ToolStripProgressBar.Value++;
                }
                StreamReader.Close();
            }

            return nbImport;
        }
    }
}
