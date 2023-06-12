namespace EyalonFinalProject
{
    partial class BookForm
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOpenPage = new System.Windows.Forms.Label();
            this.txtBookYear = new System.Windows.Forms.TextBox();
            this.lblBookYear = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.btnPages = new System.Windows.Forms.Button();
            this.rtbOpenPage = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(14, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 50);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Project Book";
            // 
            // lblOpenPage
            // 
            this.lblOpenPage.AutoSize = true;
            this.lblOpenPage.Location = new System.Drawing.Point(14, 162);
            this.lblOpenPage.Name = "lblOpenPage";
            this.lblOpenPage.Size = new System.Drawing.Size(126, 20);
            this.lblOpenPage.TabIndex = 29;
            this.lblOpenPage.Text = "Book Open Page: ";
            // 
            // txtBookYear
            // 
            this.txtBookYear.Location = new System.Drawing.Point(158, 124);
            this.txtBookYear.Name = "txtBookYear";
            this.txtBookYear.Size = new System.Drawing.Size(192, 27);
            this.txtBookYear.TabIndex = 26;
            // 
            // lblBookYear
            // 
            this.lblBookYear.AutoSize = true;
            this.lblBookYear.Location = new System.Drawing.Point(14, 127);
            this.lblBookYear.Name = "lblBookYear";
            this.lblBookYear.Size = new System.Drawing.Size(78, 20);
            this.lblBookYear.TabIndex = 27;
            this.lblBookYear.Text = "Book Year:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(14, 92);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(90, 20);
            this.lblBookName.TabIndex = 24;
            this.lblBookName.Text = "Book Name:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(158, 89);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(622, 27);
            this.txtBookName.TabIndex = 25;
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(595, 26);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(185, 45);
            this.btnSumbit.TabIndex = 32;
            this.btnSumbit.Text = "Add";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // btnPages
            // 
            this.btnPages.Location = new System.Drawing.Point(404, 26);
            this.btnPages.Name = "btnPages";
            this.btnPages.Size = new System.Drawing.Size(185, 45);
            this.btnPages.TabIndex = 33;
            this.btnPages.Text = "Pages";
            this.btnPages.UseVisualStyleBackColor = true;
            this.btnPages.Click += new System.EventHandler(this.btnPages_Click);
            // 
            // rtbOpenPage
            // 
            this.rtbOpenPage.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbOpenPage.Location = new System.Drawing.Point(158, 158);
            this.rtbOpenPage.Name = "rtbOpenPage";
            this.rtbOpenPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbOpenPage.Size = new System.Drawing.Size(622, 472);
            this.rtbOpenPage.TabIndex = 34;
            this.rtbOpenPage.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 28);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 642);
            this.Controls.Add(this.rtbOpenPage);
            this.Controls.Add(this.btnPages);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.lblOpenPage);
            this.Controls.Add(this.txtBookYear);
            this.Controls.Add(this.lblBookYear);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblTitle);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private Label lblOpenPage;
        private TextBox txtBookYear;
        private Label lblBookYear;
        private Label lblBookName;
        private TextBox txtBookName;
        private Button btnSumbit;
        private Button btnPages;
        private RichTextBox rtbOpenPage;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog fontDialog1;
    }
}