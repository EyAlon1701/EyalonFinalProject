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
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBookYear = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 54);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Project Book";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(126, 20);
            this.lblLastName.TabIndex = 29;
            this.lblLastName.Text = "Book Open Page: ";
            // 
            // txtBookYear
            // 
            this.txtBookYear.Location = new System.Drawing.Point(158, 112);
            this.txtBookYear.Name = "txtBookYear";
            this.txtBookYear.Size = new System.Drawing.Size(125, 27);
            this.txtBookYear.TabIndex = 26;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 20);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "Book Year:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 80);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 20);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "Book Name:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(158, 77);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(125, 27);
            this.txtBookName.TabIndex = 25;
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(603, 12);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(185, 55);
            this.btnSumbit.TabIndex = 32;
            this.btnSumbit.Text = "Add";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // btnPages
            // 
            this.btnPages.Location = new System.Drawing.Point(412, 12);
            this.btnPages.Name = "btnPages";
            this.btnPages.Size = new System.Drawing.Size(185, 55);
            this.btnPages.TabIndex = 33;
            this.btnPages.Text = "Pages";
            this.btnPages.UseVisualStyleBackColor = true;
            this.btnPages.Click += new System.EventHandler(this.btnPages_Click);
            // 
            // rtbOpenPage
            // 
            this.rtbOpenPage.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbOpenPage.Location = new System.Drawing.Point(158, 146);
            this.rtbOpenPage.Name = "rtbOpenPage";
            this.rtbOpenPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbOpenPage.Size = new System.Drawing.Size(630, 462);
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
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.rtbOpenPage);
            this.Controls.Add(this.btnPages);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBookYear);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
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
        private Label lblLastName;
        private TextBox txtBookYear;
        private Label lblFirstName;
        private Label lblID;
        private TextBox txtBookName;
        private Button btnSumbit;
        private Button btnPages;
        private RichTextBox rtbOpenPage;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog fontDialog1;
    }
}