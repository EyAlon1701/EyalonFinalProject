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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPagesInBook = new System.Windows.Forms.DataGridView();
            this.PageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagesInBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(752, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(289, 50);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(14, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 50);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Pages in book";
            // 
            // dgvPagesInBook
            // 
            this.dgvPagesInBook.AllowUserToAddRows = false;
            this.dgvPagesInBook.AllowUserToDeleteRows = false;
            this.dgvPagesInBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagesInBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPagesInBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagesInBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageID,
            this.StudentID,
            this.StudentName,
            this.PageName,
            this.View,
            this.Delete});
            this.dgvPagesInBook.Location = new System.Drawing.Point(0, 85);
            this.dgvPagesInBook.Name = "dgvPagesInBook";
            this.dgvPagesInBook.ReadOnly = true;
            this.dgvPagesInBook.RowHeadersWidth = 51;
            this.dgvPagesInBook.RowTemplate.Height = 29;
            this.dgvPagesInBook.Size = new System.Drawing.Size(1053, 401);
            this.dgvPagesInBook.TabIndex = 35;
            this.dgvPagesInBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagesInBook_CellContentClick);
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
            this.Controls.Add(this.dgvPagesInBook);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Name = "PagesInBook";
            this.Text = "PagesInBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagesInBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Label lblTitle;
        private DataGridView dgvPagesInBook;
        private DataGridViewTextBoxColumn PageID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Delete;
    }
}