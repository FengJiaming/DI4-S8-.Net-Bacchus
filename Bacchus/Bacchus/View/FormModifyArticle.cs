using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bacchus.View
{
    public partial class FormModifyArticle : Form
    {
        public MainController MainController;

        private Article Article;
        public FormModifyArticle()
        {
            InitializeComponent();
            MainController = new MainController();
        }
        public void FillField(Article Article)
        {

            textBoxRef.Text = Article.Ref_Article;
            textBoxPrix.Text = Article.PrixHT.ToString(CultureInfo.CurrentCulture);
            textBoxQuan.Text = Article.Quantite.ToString();
            textBoxDesc.Text = Article.Description;

            this.Article = Article;

            comboBoxMarque.DataSource = ((FormMain)Owner).BacchusModel.Marques;
            comboBoxMarque.DisplayMember = "Nom";
            comboBoxMarque.ValueMember = "Ref_Marque";
            comboBoxMarque.SelectedItem = Article.Marque;
            comboBoxMarque.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxSous.DataSource = MainController.GetSousFamillesByFamille(Article.SousFamille.Famille);
            comboBoxSous.DisplayMember = "Nom";
            comboBoxSous.ValueMember = "Ref_SousFamille";
            comboBoxSous.SelectedText = Article.SousFamille.Nom;
            comboBoxSous.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxRef.Text == "" || textBoxPrix.Text == "" || textBoxQuan.Text == "")
            {
                MessageBox.Show("Le champ doit remplir");
            }
            else
            {
                var Article = ((FormMain)Owner).BacchusModel.SearchArticle(this.Article.Ref_Article);

                Article.Ref_Article = textBoxRef.Text;
                Article.Description = textBoxDesc.Text;
                Article.Quantite = int.Parse(textBoxQuan.Text);
                Article.PrixHT = float.Parse(textBoxPrix.Text, CultureInfo.InvariantCulture);

                Article.SousFamille = ((FormMain)Owner).BacchusModel.SearchSousFamille(comboBoxSous.Text);
                Article.Marque = ((FormMain)Owner).BacchusModel.SearchMarque(comboBoxMarque.Text);

                MainController.UpdateElement(Article);

                ((FormMain)Owner).UpdateListView();
                Close();
            }
        }
    }
}
