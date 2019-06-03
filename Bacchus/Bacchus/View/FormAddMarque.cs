using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bacchus.Controller;
using Bacchus.Model;

namespace Bacchus.View
{
    public partial class FormAddMarque : Form
    {
        public MainController MainController;
        public FormAddMarque()
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
                Marque Marque = new Marque(0, Nom);

                if (((FormMain)Owner).BacchusModel.SearchMarque(Nom) != null)
                {
                    MessageBox.Show("Ce famille existe");
                }
                else
                {
                    MainController.InsertElement(Marque);
                    ((FormMain)Owner).BacchusModel.Marques.Add(Marque);
                    ((FormMain)Owner).UpdateListView();
                    Close();
                }
            }
        }
    }
}
