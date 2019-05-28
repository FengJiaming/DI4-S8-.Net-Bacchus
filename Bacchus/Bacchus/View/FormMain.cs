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
           
            //BacchusModel.SousFamilles = GetAllSousFamilles(BacchusModel);
           //BacchusModel.Articles = GetAllArticles(BacchusModel);

        }

        public BacchusModel BacchusModel { get; private set; }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImport FormImporter = new FormImport
            {
                StartPosition = FormStartPosition.CenterParent
            };
            FormImporter.ShowDialog(this);
        }
    }
}
