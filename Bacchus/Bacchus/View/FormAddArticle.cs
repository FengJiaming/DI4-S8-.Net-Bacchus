using Bacchus.Controller;
using System;
using Bacchus.Model;
using System.Windows.Forms;
using System.Globalization;

namespace Bacchus.View
{
    public partial class FormAddArticle : Form
    {
        public MainController MainController;
        public FormAddArticle()
        {
            InitializeComponent();
            MainController = new MainController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxRef.Text == "" || textBoxPrix.Text == "" || textBoxQuan.Text =="")
            {
                MessageBox.Show("Le champ doit remplir");
            }
            else
            {
                var Ref = textBoxRef.Text;
                var Desc = textBoxDesc.Text;

                var SousFamille = ((FormMain)Owner).BacchusModel.SearchSousFamille(comboBoxSous.Text);
                var Marque = ((FormMain)Owner).BacchusModel.SearchMarque(comboBoxMarque.Text);

                var PrixHT = float.Parse(textBoxPrix.Text, CultureInfo.InvariantCulture);
                var Quantite = int.Parse(textBoxQuan.Text);
                Article Article = new Article(Ref, Desc, SousFamille, Marque, PrixHT, Quantite);

                if (((FormMain)Owner).BacchusModel.SearchArticle(Ref) != null)
                {
                    MessageBox.Show("Ce Article existe");
                }
                else
                {
                    MainController.InsertElement(Article);
                    ((FormMain)Owner).BacchusModel.Articles.Add(Article);
                    ((FormMain)Owner).UpdateListView();
                    Close();
                }
            }
        }

        private void FormAddArticle_Load(object sender, EventArgs e)
        {
            var BacchusModel = ((FormMain)Owner).BacchusModel;

            comboBoxMarque.DataSource = BacchusModel.Marques;
            comboBoxMarque.DisplayMember = "Nom";
            comboBoxMarque.ValueMember = "Ref_Marque";

            comboBoxSous.DataSource = BacchusModel.SousFamilles;
            comboBoxSous.DisplayMember = "Nom";
            comboBoxSous.ValueMember = "Ref_SousFamille";
        }
    }
}
