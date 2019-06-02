using Bacchus.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bacchus.Model;

namespace Bacchus
{
    public partial class FormImport : Form
    {

        public FormImport()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog()
            {
                Filter = "csv files|*.csv",
            };
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileBox.Text = OpenFileDialog.FileName;
            }
        }

        private void ImportButtonAppend_Click(object sender, EventArgs e)
        {
            ToolStripProgressBar.Visible = true;
            if (FileBox.Text == "")
            {
                MessageBox.Show("Aucune Ficher Sélectionné."); 
                return;
            }
            else
            {
                string Message = Parser.ReadFile(FileBox.Text, false, this, ((FormMain)Owner).BacchusModel);

                var Result = MessageBox.Show(Message , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Result != DialogResult.OK) return;

                ((FormMain)Owner).UpdateListView();
                Close();
            }

        }

        private void ImportButtonOverwrite_Click(object sender, EventArgs e)
        {
            ToolStripProgressBar.Visible = true;
            if (FileBox.Text == "")
            {
                MessageBox.Show("Aucune Ficher Sélectionné.");
                return;
            }
            else
            {
                string Message = Parser.ReadFile(FileBox.Text, true, this, ((FormMain)Owner).BacchusModel);

                var Result = MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Result != DialogResult.OK) return;

                ((FormMain)Owner).UpdateListView();
                Close();
            }
        }
    }
}
