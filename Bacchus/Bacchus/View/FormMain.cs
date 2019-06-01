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

namespace Bacchus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            BacchusModel = new BacchusModel();
            
            TreeView.Nodes.Add("Articles", "Articles");
            TreeView.Nodes.Add("Marques", "Marques");
            TreeView.Nodes.Add("Familles", "Familles");
            TreeView.Nodes.Add("Sous-Familles", "Sous-Familles");
            
            TreeView.Sort();
            //BacchusModel.SousFamilles = GetAllSousFamilles(BacchusModel);
            //BacchusModel.Articles = GetAllArticles(BacchusModel);

        }

        public BacchusModel BacchusModel { get; private set; }

        private ListViewColumnSorter ColumnSorter;

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImport FormImporter = new FormImport
            {
                StartPosition = FormStartPosition.CenterParent
            };
            FormImporter.ShowDialog(this);
        }

        public void UpdateListView()
        {
            ListView.Clear();
            var Node = TreeView.SelectedNode;

            ListView.Hide();

            if (Node.Name.Equals("Articles"))
            {
                /*
                 * On crée la liste des articles
                 */
                ListView.Columns.Add("Référence", "Référence");
                ListView.Columns.Add("Description", "Description");
                ListView.Columns.Add("Marque", "Marque");
                ListView.Columns.Add("Sous-Famille", "Sous-Famille");
                ListView.Columns.Add("Prix", "Prix H.T.");
                ListView.Columns.Add("Quantité", "Quantité");

                foreach (var Article in BacchusModel.Articles)
                {
                    ListView.Items.Add(new ListViewItem(Article.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Articles";
            }

            else if (Node.Name.Equals("Marques"))
            {
                /*
                 * On crée la liste des marques
                 */
                ListView.Columns.Add("Nom", "Nom");

                foreach (var Marque in BacchusModel.Marques)
                {
                    ListView.Items.Add(new ListViewItem(Marque.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Marques";
            }

            else if (Node.Name.Equals("Familles"))
            {
                /*
                 * On crée la liste des familles
                 */
                ListView.Columns.Add("Nom", "Nom");

                foreach (var Famille in BacchusModel.Familles)
                {
                    ListView.Items.Add(new ListViewItem(Famille.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Familles";
            }

            else if (Node.Name.Equals("Sous-Familles"))
            {
                /*
                 * On crée la liste des sous familles
                 */
                ListView.Columns.Add("Nom", "Nom");
                ListView.Columns.Add("Famille", "Famille");

                foreach (var SousFamille in BacchusModel.SousFamilles)
                {
                    ListView.Items.Add(new ListViewItem(SousFamille.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = @"Sous-Familles";
            }

            ListView.Sort();
            ListView.Show();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ColumnSorter = new ListViewColumnSorter();
            ListView.ListViewItemSorter = ColumnSorter;
            UpdateListView();
        }

        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ListView_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    UpdateListView();
                    break;
                /*case Keys.Delete:
                    DeleteElement();
                    break;
                case Keys.Enter:
                    ModifyAction(ListView.SelectedItems[0]);
                    break;*/
            }
        }
    }
}
