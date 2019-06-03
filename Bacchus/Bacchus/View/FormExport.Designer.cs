namespace Bacchus.View
{
    partial class FormExport
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
            this.ExportGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFile = new System.Windows.Forms.TableLayoutPanel();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.ExportButtonAppend = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ExportGroupBox.SuspendLayout();
            this.tableLayoutPanelFile.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.statusStrip1);
            this.panel.Controls.Add(this.ExportGroupBox);
            this.panel.Location = new System.Drawing.Point(24, 27);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(672, 263);
            this.panel.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.ToolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 234);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(672, 29);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(96, 24);
            this.toolStripStatusLabel.Text = "Progression";
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(533, 23);
            // 
            // ExportGroupBox
            // 
            this.ExportGroupBox.Controls.Add(this.tableLayoutPanelFile);
            this.ExportGroupBox.Controls.Add(this.tableLayoutPanelButtons);
            this.ExportGroupBox.Location = new System.Drawing.Point(31, 22);
            this.ExportGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExportGroupBox.Name = "ExportGroupBox";
            this.ExportGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ExportGroupBox.Size = new System.Drawing.Size(604, 192);
            this.ExportGroupBox.TabIndex = 0;
            this.ExportGroupBox.TabStop = false;
            this.ExportGroupBox.Text = "Exporter";
            // 
            // tableLayoutPanelFile
            // 
            this.tableLayoutPanelFile.ColumnCount = 3;
            this.tableLayoutPanelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.62823F));
            this.tableLayoutPanelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.37177F));
            this.tableLayoutPanelFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelFile.Controls.Add(this.SelectFileButton, 2, 0);
            this.tableLayoutPanelFile.Controls.Add(this.FileBox, 1, 0);
            this.tableLayoutPanelFile.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelFile.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanelFile.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelFile.Name = "tableLayoutPanelFile";
            this.tableLayoutPanelFile.RowCount = 1;
            this.tableLayoutPanelFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFile.Size = new System.Drawing.Size(584, 38);
            this.tableLayoutPanelFile.TabIndex = 1;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectFileButton.Location = new System.Drawing.Point(507, 4);
            this.SelectFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(73, 30);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            // 
            // FileBox
            // 
            this.FileBox.Location = new System.Drawing.Point(148, 4);
            this.FileBox.Margin = new System.Windows.Forms.Padding(4);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(351, 26);
            this.FileBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du fichier (.csv)";
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.ExportButtonAppend, 0, 0);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(20, 112);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(569, 43);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // ExportButtonAppend
            // 
            this.ExportButtonAppend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExportButtonAppend.Location = new System.Drawing.Point(212, 5);
            this.ExportButtonAppend.Margin = new System.Windows.Forms.Padding(4);
            this.ExportButtonAppend.Name = "ExportButtonAppend";
            this.ExportButtonAppend.Size = new System.Drawing.Size(144, 32);
            this.ExportButtonAppend.TabIndex = 0;
            this.ExportButtonAppend.Text = "Exporter";
            this.ExportButtonAppend.UseVisualStyleBackColor = true;
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 316);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormExport";
            this.Text = "FormExport";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ExportGroupBox.ResumeLayout(false);
            this.tableLayoutPanelFile.ResumeLayout(false);
            this.tableLayoutPanelFile.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        internal System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
        private System.Windows.Forms.GroupBox ExportGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFile;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox FileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button ExportButtonAppend;
    }
}