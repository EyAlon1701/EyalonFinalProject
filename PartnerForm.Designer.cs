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
            dgvStudents = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Add = new DataGridViewButtonColumn();
            dgvFriendRequestProjectPage = new DataGridView();
            PageStudentID = new DataGridViewTextBoxColumn();
            PageStudentName = new DataGridViewTextBoxColumn();
            PageID = new DataGridViewTextBoxColumn();
            PageName = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            Approve = new DataGridViewButtonColumn();
            Reject = new DataGridViewButtonColumn();
            lblTitle = new Label();
            btnDelRequest = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFriendRequestProjectPage).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = SystemColors.ActiveCaption;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Add });
            dgvStudents.Location = new Point(0, 113);
            dgvStudents.Margin = new Padding(3, 2, 3, 2);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 29;
            dgvStudents.Size = new Size(611, 232);
            dgvStudents.TabIndex = 1;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StudentID.HeaderText = "StudentID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Width = 84;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "StudentName";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // Add
            // 
            Add.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Add.HeaderText = "Add";
            Add.MinimumWidth = 6;
            Add.Name = "Add";
            Add.ReadOnly = true;
            Add.Width = 35;
            // 
            // dgvFriendRequestProjectPage
            // 
            dgvFriendRequestProjectPage.AllowUserToAddRows = false;
            dgvFriendRequestProjectPage.AllowUserToDeleteRows = false;
            dgvFriendRequestProjectPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFriendRequestProjectPage.BackgroundColor = SystemColors.ActiveCaption;
            dgvFriendRequestProjectPage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFriendRequestProjectPage.Columns.AddRange(new DataGridViewColumn[] { PageStudentID, PageStudentName, PageID, PageName, BookName, Approve, Reject });
            dgvFriendRequestProjectPage.Location = new Point(0, 113);
            dgvFriendRequestProjectPage.Margin = new Padding(3, 2, 3, 2);
            dgvFriendRequestProjectPage.Name = "dgvFriendRequestProjectPage";
            dgvFriendRequestProjectPage.ReadOnly = true;
            dgvFriendRequestProjectPage.RowHeadersWidth = 51;
            dgvFriendRequestProjectPage.RowTemplate.Height = 29;
            dgvFriendRequestProjectPage.Size = new Size(611, 232);
            dgvFriendRequestProjectPage.TabIndex = 2;
            dgvFriendRequestProjectPage.CellContentClick += dgvFriendRequestProjectPage_CellContentClick;
            // 
            // PageStudentID
            // 
            PageStudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PageStudentID.HeaderText = "StudentID";
            PageStudentID.MinimumWidth = 6;
            PageStudentID.Name = "PageStudentID";
            PageStudentID.ReadOnly = true;
            PageStudentID.Width = 84;
            // 
            // PageStudentName
            // 
            PageStudentName.HeaderText = "StudentName";
            PageStudentName.MinimumWidth = 6;
            PageStudentName.Name = "PageStudentName";
            PageStudentName.ReadOnly = true;
            // 
            // PageID
            // 
            PageID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PageID.HeaderText = "PageID";
            PageID.MinimumWidth = 6;
            PageID.Name = "PageID";
            PageID.ReadOnly = true;
            PageID.Width = 69;
            // 
            // PageName
            // 
            PageName.HeaderText = "PageName";
            PageName.MinimumWidth = 6;
            PageName.Name = "PageName";
            PageName.ReadOnly = true;
            // 
            // BookName
            // 
            BookName.HeaderText = "BookName";
            BookName.MinimumWidth = 6;
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            // 
            // Approve
            // 
            Approve.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Approve.HeaderText = "Approve";
            Approve.MinimumWidth = 6;
            Approve.Name = "Approve";
            Approve.ReadOnly = true;
            Approve.Width = 58;
            // 
            // Reject
            // 
            Reject.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Reject.HeaderText = "Reject";
            Reject.MinimumWidth = 6;
            Reject.Name = "Reject";
            Reject.ReadOnly = true;
            Reject.Width = 45;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(10, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 37);
            lblTitle.TabIndex = 34;
            // 
            // btnDelRequest
            // 
            btnDelRequest.Location = new Point(230, 80);
            btnDelRequest.Margin = new Padding(3, 2, 3, 2);
            btnDelRequest.Name = "btnDelRequest";
            btnDelRequest.Size = new Size(141, 28);
            btnDelRequest.TabIndex = 39;
            btnDelRequest.Text = "Delete Request";
            btnDelRequest.UseVisualStyleBackColor = true;
            btnDelRequest.Click += btnRequest_Click;
            // 
            // PartnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 346);
            Controls.Add(btnDelRequest);
            Controls.Add(lblTitle);
            Controls.Add(dgvFriendRequestProjectPage);
            Controls.Add(dgvStudents);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "PartnerForm";
            Text = "PartnerForm";
            Load += PartnerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFriendRequestProjectPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewButtonColumn Add;
        private DataGridView dgvFriendRequestProjectPage;
        private DataGridViewTextBoxColumn PageStudentID;
        private DataGridViewTextBoxColumn PageStudentName;
        private DataGridViewTextBoxColumn PageID;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewButtonColumn Approve;
        private DataGridViewButtonColumn Reject;
        private Label lblTitle;
        private Button btnDelRequest;
    }
}