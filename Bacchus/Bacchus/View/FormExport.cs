using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bacchus.Utils;

namespace Bacchus.View
{
    public partial class FormExport : Form
    {
        public FormExport()
        {
            InitializeComponent();
        }

        private void SelectPathButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "csv files|*.csv";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    FileBox.Text = sfd.FileName;
                }
            }
        }

        private void ExportButtonAppend_Click(object sender, EventArgs e)
        {
            ToolStripProgressBar.Visible = true;
            if (FileBox.Text == "")
            {
                MessageBox.Show("Aucune Chemin Sélectionné.");
                return;
            }
            else
            {
                string Message = Integrer.ExportToCsv(FileBox.Text, this, ((FormMain)Owner).BacchusModel);

                var Result = MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Result != DialogResult.OK) return;

                //((FormMain)Owner).UpdateListView();
                Close();
            }
        }
    }
}
