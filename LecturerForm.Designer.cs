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
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DgvProjectBook = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookOpenPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnEditUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectBook)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWelcome.Location = new System.Drawing.Point(24, 33);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(167, 46);
            this.LblWelcome.TabIndex = 1;
            this.LblWelcome.Text = "Welcome";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(994, 27);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(289, 45);
            this.BtnAdd.TabIndex = 33;
            this.BtnAdd.Text = "Add Book";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgvProjectBook
            // 
            this.DgvProjectBook.AllowUserToAddRows = false;
            this.DgvProjectBook.AllowUserToDeleteRows = false;
            this.DgvProjectBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProjectBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvProjectBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjectBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BookName,
            this.BookYear,
            this.BookOpenPage,
            this.View,
            this.Edit,
            this.Delete});
            this.DgvProjectBook.Location = new System.Drawing.Point(0, 161);
            this.DgvProjectBook.Name = "DgvProjectBook";
            this.DgvProjectBook.ReadOnly = true;
            this.DgvProjectBook.RowHeadersWidth = 51;
            this.DgvProjectBook.RowTemplate.Height = 29;
            this.DgvProjectBook.Size = new System.Drawing.Size(1295, 410);
            this.DgvProjectBook.TabIndex = 34;
            this.DgvProjectBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectBook_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 25.71429F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 47;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 41;
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
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSearch.Location = new System.Drawing.Point(24, 110);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(278, 37);
            this.LblSearch.TabIndex = 37;
            this.LblSearch.Text = "Search book by name:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearch.Location = new System.Drawing.Point(308, 114);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(314, 34);
            this.TxtSearch.TabIndex = 36;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.Location = new System.Drawing.Point(994, 78);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(289, 45);
            this.BtnEditUser.TabIndex = 38;
            this.BtnEditUser.Text = "Edit User";
            this.BtnEditUser.UseVisualStyleBackColor = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 571);
            this.Controls.Add(this.BtnEditUser);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvProjectBook);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblWelcome;
        private Button BtnAdd;
        private DataGridView DgvProjectBook;
        private Label LblSearch;
        private TextBox TxtSearch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookYear;
        private DataGridViewTextBoxColumn BookOpenPage;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button BtnEditUser;
    }
}