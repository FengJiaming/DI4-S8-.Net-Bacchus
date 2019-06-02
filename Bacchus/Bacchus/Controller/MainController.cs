using Bacchus.DAO;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.Controller
{
    
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


        public void DeleteElement(String ListItem, String ListView, BacchusModel BacchusModel)
        {
            

            if (ListView.Equals("Articles"))
            {
  
                var Result = MessageBox.Show("Supprimer l'article " + ListItem ,"Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var Article = BacchusModel.SearchArticle(ListItem);
                if (Article != null)
                {
                    BacchusModel.Articles.Remove(Article);
                    ArticleDao.Delete(Article);
                }

            }

            else if (ListView.Equals("Marques"))
            {

                var Result = MessageBox.Show("Supprimer la marque " + ListItem , "Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var Marque = BacchusModel.SearchMarque(ListItem);
                if (Marque == null)
                {
                    BacchusModel.Marques.Remove(Marque);
                    MarqueDao.Delete(Marque);
                }

            }

            else if (ListView.Equals("Familles"))
            {

                var Result = MessageBox.Show("Supprimer la famille " + ListItem, "Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var Famille = BacchusModel.SearchFamille(ListItem);
                if (Famille == null)
                {
                    BacchusModel.Familles.Remove(Famille);
                    FamilleDao.Delete(Famille);
                }


            }
            else if (ListView.Equals("Sous-Familles"))
            {

                var Result = MessageBox.Show("Supprimer l'article " + ListItem, "Attention!", MessageBoxButtons.YesNo);

                if (Result != DialogResult.Yes) return;

                var SousFamille = BacchusModel.SearchSousFamille(ListItem);
                if (SousFamille == null)
                {
                    
                    BacchusModel.SousFamilles.Remove(SousFamille);
                    SousFamilleDao.Delete(SousFamille);
                }

            }
        }

        public void ModifyElement()
        {

        }

    }
}
