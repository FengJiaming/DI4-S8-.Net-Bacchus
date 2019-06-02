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
            this.ImportGroupBox.SuspendLayout();
            this.tableLayoutPanelFile.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.statusStrip1);
            this.panel.Controls.Add(this.ImportGroupBox);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(504, 190);
            this.panel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.ToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 168);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
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
            this.ToolStripProgressBar.Size = new System.Drawing.Size(400, 16);
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
            this.tableLayoutPanelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
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
            this.SelectFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectFileButton.Location = new System.Drawing.Point(352, 3);
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 1);
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
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(427, 31);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // ImportButtonAppend
            // 
            this.ImportButtonAppend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImportButtonAppend.Location = new System.Drawing.Point(52, 4);
            this.ImportButtonAppend.Name = "ImportButtonAppend";
            this.ImportButtonAppend.Size = new System.Drawing.Size(108, 23);
            this.ImportButtonAppend.TabIndex = 0;
            this.ImportButtonAppend.Text = "Importer(ajout)";
            this.ImportButtonAppend.UseVisualStyleBackColor = true;
            this.ImportButtonAppend.Click += new System.EventHandler(this.ImportButtonAppend_Click);
            // 
            // ImportButtonOverwrite
            // 
            this.ImportButtonOverwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImportButtonOverwrite.Location = new System.Drawing.Point(260, 4);
            this.ImportButtonOverwrite.Name = "ImportButtonOverwrite";
            this.ImportButtonOverwrite.Size = new System.Drawing.Size(120, 23);
            this.ImportButtonOverwrite.TabIndex = 1;
            this.ImportButtonOverwrite.Text = "Importer(écrasement)";
            this.ImportButtonOverwrite.UseVisualStyleBackColor = true;
            this.ImportButtonOverwrite.Click += new System.EventHandler(this.ImportButtonOverwrite_Click);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 228);
            this.Controls.Add(this.panel);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        internal System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
    }
}