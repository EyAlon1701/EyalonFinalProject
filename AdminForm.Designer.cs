namespace EyalonFinalProject
{
    partial class AdminForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvProjectBook = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookOpenPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbSelectTable = new System.Windows.Forms.ComboBox();
            this.dgvProjectPage = new System.Windows.Forms.DataGridView();
            this.PageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewPage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditPage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeletePage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditUser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectPage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.Password,
            this.Image,
            this.Role,
            this.MoreUser,
            this.EditUser,
            this.DeleteUser});
            this.dgvUsers.Location = new System.Drawing.Point(0, 144);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.Size = new System.Drawing.Size(1207, 427);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 75);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(150, 60);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1045, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 60);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(881, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 52);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(544, 86);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(134, 46);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // dgvProjectBook
            // 
            this.dgvProjectBook.AllowUserToAddRows = false;
            this.dgvProjectBook.AllowUserToDeleteRows = false;
            this.dgvProjectBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProjectBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.BookYear,
            this.BookOpenPage,
            this.ViewBook,
            this.EditBook,
            this.DeleteBook});
            this.dgvProjectBook.Location = new System.Drawing.Point(0, 144);
            this.dgvProjectBook.Name = "dgvProjectBook";
            this.dgvProjectBook.ReadOnly = true;
            this.dgvProjectBook.RowHeadersWidth = 51;
            this.dgvProjectBook.RowTemplate.Height = 29;
            this.dgvProjectBook.Size = new System.Drawing.Size(1207, 427);
            this.dgvProjectBook.TabIndex = 35;
            this.dgvProjectBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectBook_CellContentClick);
            // 
            // BookID
            // 
            this.BookID.FillWeight = 25.71429F;
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.FillWeight = 72.12859F;
            this.BookName.HeaderText = "BookName";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookYear
            // 
            this.BookYear.FillWeight = 26.03723F;
            this.BookYear.HeaderText = "BookYear";
            this.BookYear.MinimumWidth = 6;
            this.BookYear.Name = "BookYear";
            this.BookYear.ReadOnly = true;
            // 
            // BookOpenPage
            // 
            this.BookOpenPage.FillWeight = 94.33855F;
            this.BookOpenPage.HeaderText = "OpenPage";
            this.BookOpenPage.MinimumWidth = 6;
            this.BookOpenPage.Name = "BookOpenPage";
            this.BookOpenPage.ReadOnly = true;
            // 
            // ViewBook
            // 
            this.ViewBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ViewBook.HeaderText = "View";
            this.ViewBook.MinimumWidth = 6;
            this.ViewBook.Name = "ViewBook";
            this.ViewBook.ReadOnly = true;
            this.ViewBook.Width = 47;
            // 
            // EditBook
            // 
            this.EditBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EditBook.HeaderText = "Edit";
            this.EditBook.MinimumWidth = 6;
            this.EditBook.Name = "EditBook";
            this.EditBook.ReadOnly = true;
            this.EditBook.Width = 41;
            // 
            // DeleteBook
            // 
            this.DeleteBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DeleteBook.HeaderText = "Delete";
            this.DeleteBook.MinimumWidth = 6;
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.ReadOnly = true;
            this.DeleteBook.Width = 59;
            // 
            // cbSelectTable
            // 
            this.cbSelectTable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectTable.FormattingEnabled = true;
            this.cbSelectTable.Items.AddRange(new object[] {
            "USERS",
            "BOOKS",
            "PAGES"});
            this.cbSelectTable.Location = new System.Drawing.Point(11, 12);
            this.cbSelectTable.Name = "cbSelectTable";
            this.cbSelectTable.Size = new System.Drawing.Size(151, 39);
            this.cbSelectTable.TabIndex = 36;
            this.cbSelectTable.SelectedIndexChanged += new System.EventHandler(this.cbSelectTable_SelectedIndexChanged);
            // 
            // dgvProjectPage
            // 
            this.dgvProjectPage.AllowUserToAddRows = false;
            this.dgvProjectPage.AllowUserToDeleteRows = false;
            this.dgvProjectPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProjectPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageID,
            this.StudentID,
            this.StudentName,
            this.PageName,
            this.PageCreationDate,
            this.PageBookName,
            this.ViewPage,
            this.EditPage,
            this.DeletePage});
            this.dgvProjectPage.Location = new System.Drawing.Point(0, 144);
            this.dgvProjectPage.Name = "dgvProjectPage";
            this.dgvProjectPage.ReadOnly = true;
            this.dgvProjectPage.RowHeadersWidth = 51;
            this.dgvProjectPage.RowTemplate.Height = 29;
            this.dgvProjectPage.Size = new System.Drawing.Size(1207, 427);
            this.dgvProjectPage.TabIndex = 37;
            this.dgvProjectPage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectPage_CellContentClick);
            // 
            // PageID
            // 
            this.PageID.FillWeight = 25.71429F;
            this.PageID.HeaderText = "PageID";
            this.PageID.MinimumWidth = 6;
            this.PageID.Name = "PageID";
            this.PageID.ReadOnly = true;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 104;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 129;
            // 
            // PageName
            // 
            this.PageName.HeaderText = "PageName";
            this.PageName.MinimumWidth = 6;
            this.PageName.Name = "PageName";
            this.PageName.ReadOnly = true;
            // 
            // PageCreationDate
            // 
            this.PageCreationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PageCreationDate.HeaderText = "PageCreationDate";
            this.PageCreationDate.MinimumWidth = 6;
            this.PageCreationDate.Name = "PageCreationDate";
            this.PageCreationDate.ReadOnly = true;
            this.PageCreationDate.Width = 158;
            // 
            // PageBookName
            // 
            this.PageBookName.FillWeight = 72.12859F;
            this.PageBookName.HeaderText = "BookName";
            this.PageBookName.MinimumWidth = 6;
            this.PageBookName.Name = "PageBookName";
            this.PageBookName.ReadOnly = true;
            // 
            // ViewPage
            // 
            this.ViewPage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ViewPage.HeaderText = "View";
            this.ViewPage.MinimumWidth = 6;
            this.ViewPage.Name = "ViewPage";
            this.ViewPage.ReadOnly = true;
            this.ViewPage.Width = 47;
            // 
            // EditPage
            // 
            this.EditPage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EditPage.HeaderText = "Edit";
            this.EditPage.MinimumWidth = 6;
            this.EditPage.Name = "EditPage";
            this.EditPage.ReadOnly = true;
            this.EditPage.Width = 41;
            // 
            // DeletePage
            // 
            this.DeletePage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DeletePage.HeaderText = "Delete";
            this.DeletePage.MinimumWidth = 6;
            this.DeletePage.Name = "DeletePage";
            this.DeletePage.ReadOnly = true;
            this.DeletePage.Width = 59;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "STUDENTS",
            "LECTURERS",
            "ADMINS",
            "ALL"});
            this.cbRole.Location = new System.Drawing.Point(698, 103);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(151, 28);
            this.cbRole.TabIndex = 39;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // MoreUser
            // 
            this.MoreUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MoreUser.HeaderText = "More";
            this.MoreUser.MinimumWidth = 6;
            this.MoreUser.Name = "MoreUser";
            this.MoreUser.ReadOnly = true;
            this.MoreUser.Width = 50;
            // 
            // EditUser
            // 
            this.EditUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EditUser.HeaderText = "Edit";
            this.EditUser.MinimumWidth = 6;
            this.EditUser.Name = "EditUser";
            this.EditUser.ReadOnly = true;
            this.EditUser.Text = "Edit";
            this.EditUser.UseColumnTextForButtonValue = true;
            this.EditUser.Width = 41;
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DeleteUser.HeaderText = "Delete";
            this.DeleteUser.MinimumWidth = 6;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.ReadOnly = true;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseColumnTextForButtonValue = true;
            this.DeleteUser.Width = 59;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 571);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.dgvProjectPage);
            this.Controls.Add(this.cbSelectTable);
            this.Controls.Add(this.dgvProjectBook);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvUsers);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnShow;
        private Button btnAdd;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvProjectBook;
        private ComboBox cbSelectTable;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookYear;
        private DataGridViewTextBoxColumn BookOpenPage;
        private DataGridViewButtonColumn ViewBook;
        private DataGridViewButtonColumn EditBook;
        private DataGridViewButtonColumn DeleteBook;
        private DataGridView dgvProjectPage;
        private ComboBox cbRole;
        private DataGridViewTextBoxColumn PageID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewTextBoxColumn PageCreationDate;
        private DataGridViewTextBoxColumn PageBookName;
        private DataGridViewButtonColumn ViewPage;
        private DataGridViewButtonColumn EditPage;
        private DataGridViewButtonColumn DeletePage;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewButtonColumn MoreUser;
        private DataGridViewButtonColumn EditUser;
        private DataGridViewButtonColumn DeleteUser;
    }
}