namespace EyalonFinalProject
{
    partial class PagesInBook
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
            this.BtnAddPageToBook = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.DgvPagesInBook = new System.Windows.Forms.DataGridView();
            this.PageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagesInBook)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddPageToBook
            // 
            this.BtnAddPageToBook.Location = new System.Drawing.Point(752, 21);
            this.BtnAddPageToBook.Name = "BtnAddPageToBook";
            this.BtnAddPageToBook.Size = new System.Drawing.Size(289, 50);
            this.BtnAddPageToBook.TabIndex = 33;
            this.BtnAddPageToBook.Text = "Add Pages To Book";
            this.BtnAddPageToBook.UseVisualStyleBackColor = true;
            this.BtnAddPageToBook.Click += new System.EventHandler(this.BtnAddPageToBook_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(14, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(266, 50);
            this.LblTitle.TabIndex = 34;
            this.LblTitle.Text = "Pages in book";
            // 
            // DgvPagesInBook
            // 
            this.DgvPagesInBook.AllowUserToAddRows = false;
            this.DgvPagesInBook.AllowUserToDeleteRows = false;
            this.DgvPagesInBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPagesInBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvPagesInBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPagesInBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageID,
            this.StudentID,
            this.StudentName,
            this.PageName,
            this.View,
            this.Delete});
            this.DgvPagesInBook.Location = new System.Drawing.Point(0, 85);
            this.DgvPagesInBook.Name = "DgvPagesInBook";
            this.DgvPagesInBook.ReadOnly = true;
            this.DgvPagesInBook.RowHeadersWidth = 51;
            this.DgvPagesInBook.RowTemplate.Height = 29;
            this.DgvPagesInBook.Size = new System.Drawing.Size(1053, 401);
            this.DgvPagesInBook.TabIndex = 35;
            this.DgvPagesInBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPagesInBook_CellContentClick);
            // 
            // PageID
            // 
            this.PageID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PageID.FillWeight = 42.78075F;
            this.PageID.HeaderText = "PageID";
            this.PageID.MinimumWidth = 6;
            this.PageID.Name = "PageID";
            this.PageID.ReadOnly = true;
            this.PageID.Width = 85;
            // 
            // StudentID
            // 
            this.StudentID.FillWeight = 60F;
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StudentName.FillWeight = 43.31802F;
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.MinimumWidth = 30;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 129;
            // 
            // PageName
            // 
            this.PageName.FillWeight = 156.9506F;
            this.PageName.HeaderText = "PageName";
            this.PageName.MinimumWidth = 10;
            this.PageName.Name = "PageName";
            this.PageName.ReadOnly = true;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 47;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 59;
            // 
            // PagesInBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 486);
            this.Controls.Add(this.DgvPagesInBook);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnAddPageToBook);
            this.Name = "PagesInBook";
            this.Text = "PagesInBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPagesInBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnAddPageToBook;
        private Label LblTitle;
        private DataGridView DgvPagesInBook;
        private DataGridViewTextBoxColumn PageID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Delete;
    }
}