namespace PDFtoExcel
{
    partial class mainForm
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.chkTextSearch = new System.Windows.Forms.CheckBox();
            this.txtTextFilter = new System.Windows.Forms.TextBox();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(28, 150);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // chkTextSearch
            // 
            this.chkTextSearch.AutoSize = true;
            this.chkTextSearch.Location = new System.Drawing.Point(30, 95);
            this.chkTextSearch.Name = "chkTextSearch";
            this.chkTextSearch.Size = new System.Drawing.Size(212, 21);
            this.chkTextSearch.TabIndex = 2;
            this.chkTextSearch.Text = "Search for rows starting with:";
            this.chkTextSearch.UseVisualStyleBackColor = true;
            // 
            // txtTextFilter
            // 
            this.txtTextFilter.Location = new System.Drawing.Point(28, 122);
            this.txtTextFilter.Name = "txtTextFilter";
            this.txtTextFilter.Size = new System.Drawing.Size(214, 22);
            this.txtTextFilter.TabIndex = 3;
            // 
            // btnViewResults
            // 
            this.btnViewResults.Location = new System.Drawing.Point(109, 150);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(119, 23);
            this.btnViewResults.TabIndex = 4;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = true;
            this.btnViewResults.Visible = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 269);
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.txtTextFilter);
            this.Controls.Add(this.chkTextSearch);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Convert PDF to Excel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox chkTextSearch;
        private System.Windows.Forms.TextBox txtTextFilter;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

