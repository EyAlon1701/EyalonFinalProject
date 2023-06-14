namespace EyalonFinalProject
{
    partial class PartnerForm
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
            this.DgvStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DgvFriendRequestProjectPage = new System.Windows.Forms.DataGridView();
            this.PageStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFriendRequestProjectPage)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStudents
            // 
            this.DgvStudents.AllowUserToAddRows = false;
            this.DgvStudents.AllowUserToDeleteRows = false;
            this.DgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Add});
            this.DgvStudents.Location = new System.Drawing.Point(0, 161);
            this.DgvStudents.Name = "DgvStudents";
            this.DgvStudents.ReadOnly = true;
            this.DgvStudents.RowHeadersWidth = 51;
            this.DgvStudents.RowTemplate.Height = 29;
            this.DgvStudents.Size = new System.Drawing.Size(698, 310);
            this.DgvStudents.TabIndex = 1;
            this.DgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudents_CellContentClick);
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
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Add.HeaderText = "Add";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Width = 43;
            // 
            // DgvFriendRequestProjectPage
            // 
            this.DgvFriendRequestProjectPage.AllowUserToAddRows = false;
            this.DgvFriendRequestProjectPage.AllowUserToDeleteRows = false;
            this.DgvFriendRequestProjectPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFriendRequestProjectPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvFriendRequestProjectPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFriendRequestProjectPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageStudentID,
            this.PageStudentName,
            this.PageID,
            this.PageName,
            this.BookName,
            this.Approve,
            this.Reject});
            this.DgvFriendRequestProjectPage.Location = new System.Drawing.Point(0, 161);
            this.DgvFriendRequestProjectPage.Name = "DgvFriendRequestProjectPage";
            this.DgvFriendRequestProjectPage.ReadOnly = true;
            this.DgvFriendRequestProjectPage.RowHeadersWidth = 51;
            this.DgvFriendRequestProjectPage.RowTemplate.Height = 29;
            this.DgvFriendRequestProjectPage.Size = new System.Drawing.Size(698, 310);
            this.DgvFriendRequestProjectPage.TabIndex = 2;
            this.DgvFriendRequestProjectPage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFriendRequestProjectPage_CellContentClick);
            // 
            // PageStudentID
            // 
            this.PageStudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PageStudentID.HeaderText = "StudentID";
            this.PageStudentID.MinimumWidth = 6;
            this.PageStudentID.Name = "PageStudentID";
            this.PageStudentID.ReadOnly = true;
            this.PageStudentID.Width = 104;
            // 
            // PageStudentName
            // 
            this.PageStudentName.HeaderText = "StudentName";
            this.PageStudentName.MinimumWidth = 6;
            this.PageStudentName.Name = "PageStudentName";
            this.PageStudentName.ReadOnly = true;
            // 
            // PageID
            // 
            this.PageID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PageID.HeaderText = "PageID";
            this.PageID.MinimumWidth = 6;
            this.PageID.Name = "PageID";
            this.PageID.ReadOnly = true;
            this.PageID.Width = 85;
            // 
            // PageName
            // 
            this.PageName.HeaderText = "PageName";
            this.PageName.MinimumWidth = 6;
            this.PageName.Name = "PageName";
            this.PageName.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "BookName";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Approve
            // 
            this.Approve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Approve.HeaderText = "Approve";
            this.Approve.MinimumWidth = 6;
            this.Approve.Name = "Approve";
            this.Approve.ReadOnly = true;
            this.Approve.Width = 72;
            // 
            // Reject
            // 
            this.Reject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Reject.HeaderText = "Reject";
            this.Reject.MinimumWidth = 6;
            this.Reject.Name = "Reject";
            this.Reject.ReadOnly = true;
            this.Reject.Width = 56;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(698, 107);
            this.LblTitle.TabIndex = 34;
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(258, 111);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(185, 45);
            this.BtnDel.TabIndex = 39;
            this.BtnDel.Text = "Delete Request";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // PartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 471);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.DgvFriendRequestProjectPage);
            this.Controls.Add(this.DgvStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PartnerForm";
            this.Text = "PartnerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFriendRequestProjectPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DgvStudents;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewButtonColumn Add;
        private DataGridView DgvFriendRequestProjectPage;
        private DataGridViewTextBoxColumn PageStudentID;
        private DataGridViewTextBoxColumn PageStudentName;
        private DataGridViewTextBoxColumn PageID;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewButtonColumn Approve;
        private DataGridViewButtonColumn Reject;
        private Label LblTitle;
        private Button BtnDel;
    }
}