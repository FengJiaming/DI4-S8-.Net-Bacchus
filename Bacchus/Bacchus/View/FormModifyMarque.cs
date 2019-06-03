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
    public partial class FormModifyMarque : Form
    {
        public MainController MainController;

        private Marque Marque;
        public FormModifyMarque()
        {
            InitializeComponent();
            MainController = new MainController();
        }

        public void FillField(Marque Marque)
        {
            textBox1.Text = Marque.Nom;
            this.Marque = Marque;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Le champ doit remplir");
            }
            else
            {
                var Marque = ((FormMain)Owner).BacchusModel.SearchMarque(this.Marque.Nom);
                Marque.Nom = textBox1.Text;

                MainController.UpdateElement(Marque);

                ((FormMain)Owner).UpdateListView();
                Close();
            }
        }
    }
}
