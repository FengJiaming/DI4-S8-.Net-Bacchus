using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Windows.Forms;

namespace Bacchus.View
{
    public partial class FormModifyFamille : Form
    {
        public MainController MainController;

        private Famille Famille;
        public FormModifyFamille()
        {
            InitializeComponent();
            MainController = new MainController();
        }
        public void FillField(Famille Famille)
        {
            // On remplit les champs texte
            textBox1.Text = Famille.Nom;
            this.Famille = Famille;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Le champ doit remplir");
            }
            else
            {
                var Famille = ((FormMain)Owner).BacchusModel.SearchFamille(this.Famille.Nom);
                Famille.Nom = textBox1.Text;
 
                MainController.UpdateElement(Famille);

                ((FormMain)Owner).UpdateListView();
                Close();
            }
        }
    }
}
