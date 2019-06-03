using Bacchus.DAO;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    ///<summary>
    ///Class: MainController
    ///Type: Controller
    ///Fonction: Traiter le DAOs et réaliser les fonctions comme des ajouts, suppressions et modifications
    ///Author: FENG Jiaming && GUO Xiaoqing
    ///Date; 03/06/2019
    ///</summary>
    public class MainController
    {
        ArticleDAO ArticleDao;
        MarqueDAO MarqueDao;
        FamilleDAO FamilleDao;
        SousFamilleDAO SousFamilleDao;

        public MainController()
        {
            ArticleDao = new ArticleDAO();
            MarqueDao = new MarqueDAO();
            FamilleDao = new FamilleDAO();
            SousFamilleDao = new SousFamilleDAO();
        }

        /// <summary>
        /// Obtenir la sous-famille correspondant à la famille en entrée
        /// </summary>
        /// <param name="Famille">Famille</param>
        /// <returns>
        /// List<SousFamille> : Liste de tous les sous-familles
        /// </returns>
        public List<SousFamille> GetSousFamillesByFamille(Famille Famille)
        {
            return SousFamilleDao.GetSousFamillesByFamille(Famille);
        }

        /// <summary>
        /// Ajouter un element d'article à la base de données
        /// </summary>
        /// <param name="Article">Objet: Article</param>
        public void InsertElement(Article Article)
        {
            ArticleDao.Insert(Article);
        }

        /// <summary>
        /// Ajouter un element de famille à la base de données
        /// </summary>
        /// <param name="Famille">Objet: Famille</param>
        public void InsertElement(Famille Famille)
        {
            FamilleDao.Insert(Famille);
        }

        /// <summary>
        /// Ajouter un element de sous-famille à la base de données
        /// </summary>
        /// <param name="SousFamille">Objet: SousFamille</param>
        public void InsertElement(SousFamille SousFamille)
        {
            SousFamilleDao.Insert(SousFamille);
        }

        /// <summary>
        /// Ajouter un element de marque à la base de données
        /// </summary>
        /// <param name="Marque">Objet: Marque</param>
        public void InsertElement(Marque Marque)
        {
            MarqueDao.Insert(Marque);
        }

        /// <summary>
        /// Mise a jour un element d'article de la base de données
        /// </summary>
        /// <param name="Article">Objet: Article</param>
        public void UpdateElement(Article Article)
        {
            ArticleDao.Update(Article);
        }

        /// <summary>
        /// Mise a jour un element de famille de la base de données
        /// </summary>
        /// <param name="Famille">Objet: Famille</param>
        public void UpdateElement(Famille Famille)
        {
            FamilleDao.Update(Famille);
        }

        /// <summary>
        /// Mise a jour  un element de sous-famille de la base de données
        /// </summary>
        /// <param name="SousFamille">Objet: SousFamille</param>
        public void UpdateElement(SousFamille SousFamille)
        {
            SousFamilleDao.Update(SousFamille);
        }

        /// <summary>
        /// Mise a jour un element de marque de la base de données
        /// </summary>
        /// <param name="Marque">Objet: Marque</param>
        public void UpdateElement(Marque Marque)
        {
            MarqueDao.Update(Marque);
        }

        /// <summary>
        /// Supprimer un element de la base de données dans le ListView 
        /// </summary>
        /// <param name="ListItem">String</param>
        /// <param name="ListView">String</param>
        /// <param name="BacchusModel">Objet: BacchusModel</param>
        public void DeleteElement(String ListItem, String ListView, BacchusModel BacchusModel)
        {

            if (ListView.Equals("Articles"))//Si la colonne "Articles" est sélectionnée
            {
  
                var Result = MessageBox.Show("Supprimer l'article " + ListItem ,"Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var Article = BacchusModel.SearchArticle(ListItem);//rechercher l'article
                if (Article != null)
                {
                    BacchusModel.Articles.Remove(Article);
                    ArticleDao.Delete(Article);
                }

            }

            else if (ListView.Equals("Marques"))//Si la colonne "Marques" est sélectionnée
            {

                var Result = MessageBox.Show("Supprimer la marque " + ListItem , "Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var Marque = BacchusModel.SearchMarque(ListItem);//rechercher le marque
                if (Marque == null)
                {
                    BacchusModel.Marques.Remove(Marque);
                    MarqueDao.Delete(Marque);
                }

            }

            else if (ListView.Equals("Familles"))//Si la colonne "Familles" est sélectionnée
            {

                var Result = MessageBox.Show("Supprimer la famille " + ListItem, "Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var Famille = BacchusModel.SearchFamille(ListItem);//rechercher la famille
                if (Famille == null)
                {
                    BacchusModel.Familles.Remove(Famille);
                    FamilleDao.Delete(Famille);
                }


            }
            else if (ListView.Equals("Sous-Familles"))//Si la colonne "Sous-Familles" est sélectionnée
            {

                var Result = MessageBox.Show("Supprimer l'article " + ListItem, "Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var SousFamille = BacchusModel.SearchSousFamille(ListItem);//rechercher la sous-famille
                if (SousFamille == null)
                {
                    
                    BacchusModel.SousFamilles.Remove(SousFamille);
                    SousFamilleDao.Delete(SousFamille);
                }

            }
        }

    }
}
