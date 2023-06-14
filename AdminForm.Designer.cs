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
            this.DgvUsers = new System.Windows.Forms.DataGridView();
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.DgvProjectBook = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookOpenPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CbSelectTable = new System.Windows.Forms.ComboBox();
            this.DgvProjectPage = new System.Windows.Forms.DataGridView();
            this.PageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewPage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditPage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeletePage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.LblTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectPage)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DgvUsers.Location = new System.Drawing.Point(0, 161);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowHeadersWidth = 51;
            this.DgvUsers.RowTemplate.Height = 29;
            this.DgvUsers.Size = new System.Drawing.Size(1295, 410);
            this.DgvUsers.TabIndex = 0;
            this.DgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellContentClick);
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
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(979, 33);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(289, 40);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add User";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearch.Location = new System.Drawing.Point(313, 106);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(314, 34);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSearch.Location = new System.Drawing.Point(24, 100);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(101, 37);
            this.LblSearch.TabIndex = 4;
            this.LblSearch.Text = "Search:";
            // 
            // DgvProjectBook
            // 
            this.DgvProjectBook.AllowUserToAddRows = false;
            this.DgvProjectBook.AllowUserToDeleteRows = false;
            this.DgvProjectBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProjectBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvProjectBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjectBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookName,
            this.BookYear,
            this.BookOpenPage,
            this.ViewBook,
            this.EditBook,
            this.DeleteBook});
            this.DgvProjectBook.Location = new System.Drawing.Point(0, 161);
            this.DgvProjectBook.Name = "DgvProjectBook";
            this.DgvProjectBook.ReadOnly = true;
            this.DgvProjectBook.RowHeadersWidth = 51;
            this.DgvProjectBook.RowTemplate.Height = 29;
            this.DgvProjectBook.Size = new System.Drawing.Size(1295, 410);
            this.DgvProjectBook.TabIndex = 35;
            this.DgvProjectBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectBook_CellContentClick);
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
            // CbSelectTable
            // 
            this.CbSelectTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbSelectTable.FormattingEnabled = true;
            this.CbSelectTable.Items.AddRange(new object[] {
            "USERS",
            "BOOKS",
            "PAGES"});
            this.CbSelectTable.Location = new System.Drawing.Point(232, 37);
            this.CbSelectTable.Name = "CbSelectTable";
            this.CbSelectTable.Size = new System.Drawing.Size(180, 36);
            this.CbSelectTable.TabIndex = 36;
            this.CbSelectTable.SelectedIndexChanged += new System.EventHandler(this.CbSelectTable_SelectedIndexChanged);
            // 
            // DgvProjectPage
            // 
            this.DgvProjectPage.AllowUserToAddRows = false;
            this.DgvProjectPage.AllowUserToDeleteRows = false;
            this.DgvProjectPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProjectPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvProjectPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjectPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageID,
            this.StudentID,
            this.StudentName,
            this.PageName,
            this.PageCreationDate,
            this.PageBookName,
            this.ViewPage,
            this.EditPage,
            this.DeletePage});
            this.DgvProjectPage.Location = new System.Drawing.Point(0, 161);
            this.DgvProjectPage.Name = "DgvProjectPage";
            this.DgvProjectPage.ReadOnly = true;
            this.DgvProjectPage.RowHeadersWidth = 51;
            this.DgvProjectPage.RowTemplate.Height = 29;
            this.DgvProjectPage.Size = new System.Drawing.Size(1295, 410);
            this.DgvProjectPage.TabIndex = 37;
            this.DgvProjectPage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectPage_CellContentClick);
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
            // CbRole
            // 
            this.CbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Items.AddRange(new object[] {
            "STUDENTS",
            "LECTURERS",
            "ADMINS",
            "ALL"});
            this.CbRole.Location = new System.Drawing.Point(156, 104);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(151, 36);
            this.CbRole.TabIndex = 39;
            this.CbRole.SelectedIndexChanged += new System.EventHandler(this.CbRole_SelectedIndexChanged);
            // 
            // LblTable
            // 
            this.LblTable.AutoSize = true;
            this.LblTable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTable.Location = new System.Drawing.Point(24, 33);
            this.LblTable.Name = "LblTable";
            this.LblTable.Size = new System.Drawing.Size(202, 37);
            this.LblTable.TabIndex = 40;
            this.LblTable.Text = "Choose a Table:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 571);
            this.Controls.Add(this.LblTable);
            this.Controls.Add(this.CbRole);
            this.Controls.Add(this.DgvProjectPage);
            this.Controls.Add(this.CbSelectTable);
            this.Controls.Add(this.DgvProjectBook);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvUsers;
        private Button BtnAdd;
        private TextBox TxtSearch;
        private Label LblSearch;
        private DataGridView DgvProjectBook;
        private ComboBox CbSelectTable;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookYear;
        private DataGridViewTextBoxColumn BookOpenPage;
        private DataGridViewButtonColumn ViewBook;
        private DataGridViewButtonColumn EditBook;
        private DataGridViewButtonColumn DeleteBook;
        private DataGridView DgvProjectPage;
        private ComboBox CbRole;
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
        private DataGridViewTextBoxColumn PageID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewTextBoxColumn PageCreationDate;
        private DataGridViewTextBoxColumn PageBookName;
        private DataGridViewButtonColumn ViewPage;
        private DataGridViewButtonColumn EditPage;
        private DataGridViewButtonColumn DeletePage;
        private Label LblTable;
    }
}