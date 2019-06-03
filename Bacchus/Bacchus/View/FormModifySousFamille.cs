using Bacchus.Controller;
using Bacchus.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacchus.View
{
    public partial class FormModifySousFamille : Form
    {
        public MainController MainController;

        private SousFamille SousFamille;
        public FormModifySousFamille()
        {
            InitializeComponent();
            MainController = new MainController();
        }

        public void FillField(SousFamille SousFamille)
        {
            textBox1.Text = SousFamille.Nom;

            this.SousFamille = SousFamille;

            comboBox1.DataSource = ((FormMain)Owner).BacchusModel.Familles;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "Ref_Famille";
            comboBox1.SelectedItem = SousFamille.Famille;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Le champ doit remplir");
            }
            else
            {
                var SousFamille = ((FormMain)Owner).BacchusModel.SearchSousFamille(this.SousFamille.Nom);
                SousFamille.Nom = textBox1.Text;
                SousFamille.Famille = ((FormMain)Owner).BacchusModel.SearchFamille(comboBox1.Text);
                
                MainController.UpdateElement(SousFamille);

                ((FormMain)Owner).UpdateListView();
                Close();
            }
        }
    }
}
