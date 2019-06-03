using Bacchus.Controller;
using Bacchus.Model;
using Bacchus.View;
using System;
using System.Windows.Forms;

namespace Bacchus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            BacchusModel = new BacchusModel();
            MainController = new MainController();

            TreeView.Nodes.Add("Articles", "Articles");
            TreeView.Nodes.Add("Marques", "Marques");
            TreeView.Nodes.Add("Familles", "Familles");
            TreeView.Nodes.Add("Sous-Familles", "Sous-Familles");
            
            TreeView.Sort();
            toolStripStatusLabel1.Text = "Il y a " + BacchusModel.Articles.Count + " articles ";
        }

        public BacchusModel BacchusModel;

        public MainController MainController;

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
                ListView.Text = "Articles";
            }

            else if (Node.Name.Equals("Marques"))
            {

                ListView.Columns.Add("Nom", "Nom");

                foreach (var Marque in BacchusModel.Marques)
                {
                    ListView.Items.Add(new ListViewItem(Marque.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = "Marques";
            }

            else if (Node.Name.Equals("Familles"))
            {

                ListView.Columns.Add("Nom", "Nom");

                foreach (var Famille in BacchusModel.Familles)
                {
                    ListView.Items.Add(new ListViewItem(Famille.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = "Familles";
            }

            else if (Node.Name.Equals("Sous-Familles"))
            {

                ListView.Columns.Add("Nom", "Nom");
                ListView.Columns.Add("Famille", "Famille");

                foreach (var SousFamille in BacchusModel.SousFamilles)
                {
                    ListView.Items.Add(new ListViewItem(SousFamille.ToRow()));
                }

                ListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                ListView.Text = "Sous-Familles";
            }

            ListView.Sort();
            ListView.Show();

            toolStripStatusLabel1.Text = "Il y a " + BacchusModel.Articles.Count + " articles ";
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
                case Keys.Delete:
                    MainController.DeleteElement(ListView.SelectedItems[0].Text, ListView.Text, BacchusModel);
                    UpdateListView();
                    break;
                case Keys.Enter:
                    ModifyElement(ListView.SelectedItems[0]);
                    break;
            }
        }

        private void TreeView_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    UpdateListView();
                    break;
            }
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            if (ListView.FocusedItem.Bounds.Contains(e.Location))
                ContextMenuStrip.Show(Cursor.Position);

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ListView.Text.Equals("Articles"))
            {
                FormAddArticle FormAddArticle = new FormAddArticle
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };
                FormAddArticle.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Marques"))
            {
                FormAddMarque FormAddMarque = new FormAddMarque
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this,
                };
                FormAddMarque.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Familles"))
            {
                FormAddFamille FormAddFamille = new FormAddFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };
                FormAddFamille.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Sous-Familles"))
            {
                FormAddSousFamille FormAddSousFamille = new FormAddSousFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };
                FormAddSousFamille.ShowDialog(this);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyElement(ListView.SelectedItems[0]);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.DeleteElement(ListView.SelectedItems[0].Text, ListView.Text, BacchusModel);
            UpdateListView();
        }

        public void ModifyElement(ListViewItem Item)
        {

            if (ListView.Text.Equals("Articles"))
            {

                FormModifyArticle FormModifyArticle = new FormModifyArticle
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this,

                };
                FormModifyArticle.FillField(BacchusModel.SearchArticle(Item.Text));
                FormModifyArticle.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Marques"))
            {

                FormModifyMarque FormModifyMarque = new FormModifyMarque
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };
                FormModifyMarque.FillField(BacchusModel.SearchMarque(Item.Text));
                FormModifyMarque.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Familles"))
            {

                FormModifyFamille FormModifyFamille = new FormModifyFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this,
                };

                FormModifyFamille.FillField(BacchusModel.SearchFamille(Item.Text));
                FormModifyFamille.ShowDialog(this);
            }
            else if (ListView.Text.Equals("Sous-Familles"))
            {
                var SousFamille = BacchusModel.SearchSousFamille(Item.Text);
                FormModifySousFamille FormModifySousFamille = new FormModifySousFamille
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Owner = this
                };

                FormModifySousFamille.FillField(BacchusModel.SearchSousFamille(Item.Text));
                FormModifySousFamille.ShowDialog(this);
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ModifyElement(ListView.SelectedItems[0]);
        }
    }
}
