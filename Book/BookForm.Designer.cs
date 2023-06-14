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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblOpenPage = new System.Windows.Forms.Label();
            this.TxtBookYear = new System.Windows.Forms.TextBox();
            this.LblBookYear = new System.Windows.Forms.Label();
            this.LblBookName = new System.Windows.Forms.Label();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.BtnSumbit = new System.Windows.Forms.Button();
            this.BtnPages = new System.Windows.Forms.Button();
            this.RtbOpenPage = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(14, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(247, 50);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Project Book";
            // 
            // LblOpenPage
            // 
            this.LblOpenPage.AutoSize = true;
            this.LblOpenPage.Location = new System.Drawing.Point(14, 163);
            this.LblOpenPage.Name = "LblOpenPage";
            this.LblOpenPage.Size = new System.Drawing.Size(126, 20);
            this.LblOpenPage.TabIndex = 29;
            this.LblOpenPage.Text = "Book Open Page: ";
            // 
            // TxtBookYear
            // 
            this.TxtBookYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBookYear.Location = new System.Drawing.Point(158, 123);
            this.TxtBookYear.Name = "TxtBookYear";
            this.TxtBookYear.Size = new System.Drawing.Size(192, 30);
            this.TxtBookYear.TabIndex = 26;
            // 
            // LblBookYear
            // 
            this.LblBookYear.AutoSize = true;
            this.LblBookYear.Location = new System.Drawing.Point(14, 128);
            this.LblBookYear.Name = "LblBookYear";
            this.LblBookYear.Size = new System.Drawing.Size(78, 20);
            this.LblBookYear.TabIndex = 27;
            this.LblBookYear.Text = "Book Year:";
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Location = new System.Drawing.Point(14, 93);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(90, 20);
            this.LblBookName.TabIndex = 24;
            this.LblBookName.Text = "Book Name:";
            // 
            // TxtBookName
            // 
            this.TxtBookName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBookName.Location = new System.Drawing.Point(158, 88);
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(622, 30);
            this.TxtBookName.TabIndex = 25;
            // 
            // BtnSumbit
            // 
            this.BtnSumbit.Location = new System.Drawing.Point(595, 26);
            this.BtnSumbit.Name = "BtnSumbit";
            this.BtnSumbit.Size = new System.Drawing.Size(185, 45);
            this.BtnSumbit.TabIndex = 32;
            this.BtnSumbit.Text = "Add";
            this.BtnSumbit.UseVisualStyleBackColor = true;
            this.BtnSumbit.Click += new System.EventHandler(this.BtnSumbit_Click);
            // 
            // BtnPages
            // 
            this.BtnPages.Location = new System.Drawing.Point(404, 26);
            this.BtnPages.Name = "BtnPages";
            this.BtnPages.Size = new System.Drawing.Size(185, 45);
            this.BtnPages.TabIndex = 33;
            this.BtnPages.Text = "Pages";
            this.BtnPages.UseVisualStyleBackColor = true;
            this.BtnPages.Click += new System.EventHandler(this.BtnPages_Click);
            // 
            // RtbOpenPage
            // 
            this.RtbOpenPage.ContextMenuStrip = this.ContextMenuStrip;
            this.RtbOpenPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbOpenPage.Location = new System.Drawing.Point(158, 158);
            this.RtbOpenPage.Name = "RtbOpenPage";
            this.RtbOpenPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RtbOpenPage.Size = new System.Drawing.Size(622, 472);
            this.RtbOpenPage.TabIndex = 34;
            this.RtbOpenPage.Text = "";
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem});
            this.ContextMenuStrip.Name = "contextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(157, 28);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.FontToolStripMenuItem.Text = "Font";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 642);
            this.Controls.Add(this.RtbOpenPage);
            this.Controls.Add(this.BtnPages);
            this.Controls.Add(this.BtnSumbit);
            this.Controls.Add(this.LblOpenPage);
            this.Controls.Add(this.TxtBookYear);
            this.Controls.Add(this.LblBookYear);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.TxtBookName);
            this.Controls.Add(this.LblTitle);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LblTitle;
        private Label LblOpenPage;
        private TextBox TxtBookYear;
        private Label LblBookYear;
        private Label LblBookName;
        private TextBox TxtBookName;
        private Button BtnSumbit;
        private Button BtnPages;
        private RichTextBox RtbOpenPage;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem FontToolStripMenuItem;
        private FontDialog FontDialog;
    }
}