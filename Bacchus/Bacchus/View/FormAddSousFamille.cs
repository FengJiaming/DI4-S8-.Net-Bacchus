using Bacchus.Controller;
using System;
using System.Windows.Forms;
using Bacchus.Model;
namespace Bacchus.View
{
    public partial class FormAddSousFamille : Form
    {
        public MainController MainController;
        public FormAddSousFamille()
        {
            InitializeComponent();
            MainController = new MainController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Le nom doit remplir");
            }
            else
            {
                var Nom = textBox1.Text;
                var Famille = ((FormMain)Owner).BacchusModel.SearchFamille(comboBox1.Text);
                SousFamille SousFamille = new SousFamille(0, Famille, Nom);

                if (((FormMain)Owner).BacchusModel.SearchMarque(Nom) != null)
                {
                    MessageBox.Show("Ce famille existe");
                }
                else
                {
                    MainController.InsertElement(SousFamille);
                    ((FormMain)Owner).BacchusModel.SousFamilles.Add(SousFamille);
                    ((FormMain)Owner).UpdateListView();
                    Close();
                }
            }
        }

        private void FormAddSousFamille_Load(object sender, EventArgs e)
        {
            var BacchusModel = ((FormMain)Owner).BacchusModel;
            comboBox1.DataSource = BacchusModel.Familles;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "Ref_Famille";
        }
    }
}
