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
    ///<summary>
    ///Class: Parser
    ///Type: Utils
    ///Fonction: Solveur(Importer les données à cote de serveur)
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
    public static class Parser
    {
        /// <summary>
        /// Lire le fichier.csv pour obtenir les données
        /// </summary>
        /// <param name="FilePath">string: Chemin d’accès au fichier importé</param>
        /// <param name="Flag">bool: true->lancer l’intégration en mode écrasement; false->lancer l’intégration en mode ajout</param>
        /// <param name="Form_Import">FormImport: View_FormImport_Objet</param>
        /// <param name="BacchusModel">BacchusModel: Model_Tous_Objet</param>
        /// <returns>
        /// string : Résultats de l’importation de données
        /// </returns>
        public static string ReadFile(string FilePath, bool Flag, FormImport Form_Import, BacchusModel BacchusModel)
        {

            if (Flag == true)
             {
                BacchusModel.Articles.Clear();
                BacchusModel.Marques.Clear();
                BacchusModel.SousFamilles.Clear();
                BacchusModel.Familles.Clear();

                ArticleDAO ArticleDao = new ArticleDAO();
                ArticleDao.DeleteAllArticles();
                SousFamilleDAO SousFamilleDao = new SousFamilleDAO();
                SousFamilleDao.DeleteAllSousFamilles();
                MarqueDAO MarqueDao = new MarqueDAO();
                MarqueDao.DeleteAllMarques();
                FamilleDAO FamilleDao = new FamilleDAO();
                FamilleDao.DeleteAllFamilles();
            }

            int AddedProducts = 0;
            int ExistingProducts = 0;

            using (var StreamReader = new StreamReader(FilePath, Encoding.Default))
            {
                var NbLines = File.ReadAllLines(FilePath).Length;

                //La barre de progression: l’intégration des données
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
                        ExistingProducts += 1;
                        continue;
                    }
                    else
                    {
                        AddedProducts += 1;
                    }

                    //Ajouter un élément à Marque
                    Marque Marque = BacchusModel.SearchMarque(Nom_Marque);
                    if (Marque == null)
                    {
                        Marque = new Marque(0, Nom_Marque);
                        BacchusModel.Marques.Add(Marque);
                        MarqueDAO MarqueDao = new MarqueDAO();
                        int countmarque = MarqueDao.Insert(Marque);
                        
                    }

                    //Ajouter un élément à Famille 
                    Famille Famille = BacchusModel.SearchFamille(Nom_Famille);
                    if (Famille == null)
                    {
                        Famille = new Famille(0, Nom_Famille);
                        BacchusModel.Familles.Add(Famille);
                        FamilleDAO FamilleDao = new FamilleDAO();
                        int countfamille = FamilleDao.Insert(Famille);
                    }

                    //Ajouter un élément à SousFamille
                    SousFamille SousFamille = BacchusModel.SearchSousFamille(Nom_SousFamille);
                    if (SousFamille == null)
                    {
                        SousFamille = new SousFamille(0, Famille, Nom_SousFamille);
                        BacchusModel.SousFamilles.Add(SousFamille);
                        SousFamilleDAO SousFamilleDao = new SousFamilleDAO();
                        SousFamilleDao.Insert(SousFamille);
                    }

                    //Ajouter un élément à Article
                    Article Article = new Article(Ref_Article, Description, SousFamille, Marque, PrixHT, 1);
                    BacchusModel.Articles.Add(Article);
                    ArticleDAO ArticleDao = new ArticleDAO();
                    ArticleDao.Insert(Article);
                    
                    Form_Import.ToolStripProgressBar.Value++;
                }
                StreamReader.Close();
            }

            //Le résultat de l’intégration, nombre d’articles ajoutés, anomalies
            string Message = "Résultat: \n" +
                             "Nombre d'articles ajoutés " + AddedProducts + "\n" +
                             "Nombre d'articles anomalies " + ExistingProducts;
            return Message;
        }
    }
}
