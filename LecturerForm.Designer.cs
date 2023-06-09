namespace EyalonFinalProject
{
    partial class LecturerForm
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
            lblWelcome = new Label();
            btnAdd = new Button();
            dgvProjectBook = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            BookYear = new DataGridViewTextBoxColumn();
            BookOpenPage = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnEditUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProjectBook).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(12, 15);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(119, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(936, 59);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 33);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProjectBook
            // 
            dgvProjectBook.AllowUserToAddRows = false;
            dgvProjectBook.AllowUserToDeleteRows = false;
            dgvProjectBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjectBook.BackgroundColor = SystemColors.ActiveCaption;
            dgvProjectBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectBook.Columns.AddRange(new DataGridViewColumn[] { ID, BookName, BookYear, BookOpenPage, View, Edit, Delete });
            dgvProjectBook.Location = new Point(0, 106);
            dgvProjectBook.Margin = new Padding(3, 2, 3, 2);
            dgvProjectBook.Name = "dgvProjectBook";
            dgvProjectBook.ReadOnly = true;
            dgvProjectBook.RowHeadersWidth = 51;
            dgvProjectBook.RowTemplate.Height = 29;
            dgvProjectBook.Size = new Size(1137, 324);
            dgvProjectBook.TabIndex = 34;
            dgvProjectBook.CellContentClick += dgvProjectBook_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 25.71429F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // BookName
            // 
            BookName.FillWeight = 72.12859F;
            BookName.HeaderText = "BookName";
            BookName.MinimumWidth = 6;
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            // 
            // BookYear
            // 
            BookYear.FillWeight = 26.03723F;
            BookYear.HeaderText = "BookYear";
            BookYear.MinimumWidth = 6;
            BookYear.Name = "BookYear";
            BookYear.ReadOnly = true;
            // 
            // BookOpenPage
            // 
            BookOpenPage.FillWeight = 94.33855F;
            BookOpenPage.HeaderText = "OpenPage";
            BookOpenPage.MinimumWidth = 6;
            BookOpenPage.Name = "BookOpenPage";
            BookOpenPage.ReadOnly = true;
            // 
            // View
            // 
            View.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            View.HeaderText = "View";
            View.MinimumWidth = 6;
            View.Name = "View";
            View.ReadOnly = true;
            View.Width = 38;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 33;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 46;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.Location = new Point(505, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(96, 32);
            lblSearch.TabIndex = 37;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(416, 54);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(275, 29);
            txtSearch.TabIndex = 36;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(936, 16);
            btnEditUser.Margin = new Padding(3, 2, 3, 2);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(181, 33);
            btnEditUser.TabIndex = 38;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // LecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1134, 427);
            Controls.Add(btnEditUser);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvProjectBook);
            Controls.Add(btnAdd);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LecturerForm";
            Text = "LecturerForm";
            ((System.ComponentModel.ISupportInitialize)dgvProjectBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnAdd;
        private DataGridView dgvProjectBook;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookYear;
        private DataGridViewTextBoxColumn BookOpenPage;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEditUser;
    }
}