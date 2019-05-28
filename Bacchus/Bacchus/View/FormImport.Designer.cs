namespace Bacchus
{
    partial class FormImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.NbArticleAnomaliesLabel = new System.Windows.Forms.Label();
            this.NbArticleAddedLabel = new System.Windows.Forms.Label();
            this.NbArticleAnomalies = new System.Windows.Forms.TextBox();
            this.NbArticleAdded = new System.Windows.Forms.TextBox();
            this.ImportGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFile = new System.Windows.Forms.TableLayoutPanel();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.ImportButtonAppend = new System.Windows.Forms.Button();
            this.ImportButtonOverwrite = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.ImportGroupBox.SuspendLayout();
            this.tableLayoutPanelFile.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.statusStrip1);
            this.panel.Controls.Add(this.ResultGroupBox);
            this.panel.Controls.Add(this.ImportGroupBox);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(493, 402);
            this.panel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.ToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(493, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel.Text = "Progression";
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(350, 16);
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.NbArticleAnomaliesLabel);
            this.ResultGroupBox.Controls.Add(this.NbArticleAddedLabel);
            this.ResultGroupBox.Controls.Add(this.NbArticleAnomalies);
            this.ResultGroupBox.Controls.Add(this.NbArticleAdded);
            this.ResultGroupBox.Location = new System.Drawing.Point(23, 176);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(453, 130);
            this.ResultGroupBox.TabIndex = 1;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Résultat";
            // 
            // NbArticleAnomaliesLabel
            // 
            this.NbArticleAnomaliesLabel.AutoSize = true;
            this.NbArticleAnomaliesLabel.Location = new System.Drawing.Point(6, 87);
            this.NbArticleAnomaliesLabel.Name = "NbArticleAnomaliesLabel";
            this.NbArticleAnomaliesLabel.Size = new System.Drawing.Size(139, 13);
            this.NbArticleAnomaliesLabel.TabIndex = 3;
            this.NbArticleAnomaliesLabel.Text = "Nombre d’articles anomalies";
            // 
            // NbArticleAddedLabel
            // 
            this.NbArticleAddedLabel.AutoSize = true;
            this.NbArticleAddedLabel.Location = new System.Drawing.Point(6, 49);
            this.NbArticleAddedLabel.Name = "NbArticleAddedLabel";
            this.NbArticleAddedLabel.Size = new System.Drawing.Size(126, 13);
            this.NbArticleAddedLabel.TabIndex = 2;
            this.NbArticleAddedLabel.Text = "Nombre d’articles ajoutés";
            // 
            // NbArticleAnomalies
            // 
            this.NbArticleAnomalies.Location = new System.Drawing.Point(151, 84);
            this.NbArticleAnomalies.Name = "NbArticleAnomalies";
            this.NbArticleAnomalies.Size = new System.Drawing.Size(100, 20);
            this.NbArticleAnomalies.TabIndex = 1;
            // 
            // NbArticleAdded
            // 
            this.NbArticleAdded.Location = new System.Drawing.Point(138, 46);
            this.NbArticleAdded.Name = "NbArticleAdded";
            this.NbArticleAdded.Size = new System.Drawing.Size(100, 20);
            this.NbArticleAdded.TabIndex = 0;
            // 
            // ImportGroupBox
            // 
            this.ImportGroupBox.Controls.Add(this.tableLayoutPanelFile);
            this.ImportGroupBox.Controls.Add(this.tableLayoutPanelButtons);
            this.ImportGroupBox.Location = new System.Drawing.Point(23, 16);
            this.ImportGroupBox.Name = "ImportGroupBox";
            this.ImportGroupBox.Size = new System.Drawing.Size(453, 139);
            this.ImportGroupBox.TabIndex = 0;
            this.ImportGroupBox.TabStop = false;
            this.ImportGroupBox.Text = "Importer";
            // 
            // tableLayoutPanelFile
            // 
            this.tableLayoutPanelFile.ColumnCount = 3;
            this.tableLayoutPanelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            this.tableLayoutPanelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanelFile.Controls.Add(this.SelectFileButton, 2, 0);
            this.tableLayoutPanelFile.Controls.Add(this.FileBox, 1, 0);
            this.tableLayoutPanelFile.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelFile.Location = new System.Drawing.Point(9, 34);
            this.tableLayoutPanelFile.Name = "tableLayoutPanelFile";
            this.tableLayoutPanelFile.RowCount = 1;
            this.tableLayoutPanelFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFile.Size = new System.Drawing.Size(438, 28);
            this.tableLayoutPanelFile.TabIndex = 1;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(351, 3);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(79, 22);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = " Sélectionner";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(83, 3);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(258, 20);
            this.FileBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du fichier";
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.ImportButtonAppend, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.ImportButtonOverwrite, 1, 0);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(15, 81);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(427, 39);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // ImportButtonAppend
            // 
            this.ImportButtonAppend.Location = new System.Drawing.Point(3, 3);
            this.ImportButtonAppend.Name = "ImportButtonAppend";
            this.ImportButtonAppend.Size = new System.Drawing.Size(108, 23);
            this.ImportButtonAppend.TabIndex = 0;
            this.ImportButtonAppend.Text = "Importer(ajout)";
            this.ImportButtonAppend.UseVisualStyleBackColor = true;
            this.ImportButtonAppend.Click += new System.EventHandler(this.ImportButtonAppend_Click);
            // 
            // ImportButtonOverwrite
            // 
            this.ImportButtonOverwrite.Location = new System.Drawing.Point(216, 3);
            this.ImportButtonOverwrite.Name = "ImportButtonOverwrite";
            this.ImportButtonOverwrite.Size = new System.Drawing.Size(120, 23);
            this.ImportButtonOverwrite.TabIndex = 1;
            this.ImportButtonOverwrite.Text = "Importer(écrasement)";
            this.ImportButtonOverwrite.UseVisualStyleBackColor = true;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 426);
            this.Controls.Add(this.panel);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ImportGroupBox.ResumeLayout(false);
            this.tableLayoutPanelFile.ResumeLayout(false);
            this.tableLayoutPanelFile.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox ImportGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFile;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button ImportButtonAppend;
        private System.Windows.Forms.Button ImportButtonOverwrite;
        private System.Windows.Forms.GroupBox ResultGroupBox;
        private System.Windows.Forms.Label NbArticleAnomaliesLabel;
        private System.Windows.Forms.Label NbArticleAddedLabel;
        private System.Windows.Forms.TextBox NbArticleAnomalies;
        private System.Windows.Forms.TextBox NbArticleAdded;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        internal System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
    }
}