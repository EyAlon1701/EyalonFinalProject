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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvFriendRequestProjectPage = new System.Windows.Forms.DataGridView();
            this.PageStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendRequestProjectPage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Add});
            this.dgvStudents.Location = new System.Drawing.Point(0, 113);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 29;
            this.dgvStudents.Size = new System.Drawing.Size(611, 232);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 84;
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
            this.Add.Width = 35;
            // 
            // dgvFriendRequestProjectPage
            // 
            this.dgvFriendRequestProjectPage.AllowUserToAddRows = false;
            this.dgvFriendRequestProjectPage.AllowUserToDeleteRows = false;
            this.dgvFriendRequestProjectPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFriendRequestProjectPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFriendRequestProjectPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFriendRequestProjectPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageStudentID,
            this.PageStudentName,
            this.PageID,
            this.PageName,
            this.BookName,
            this.Approve,
            this.Reject});
            this.dgvFriendRequestProjectPage.Location = new System.Drawing.Point(0, 113);
            this.dgvFriendRequestProjectPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFriendRequestProjectPage.Name = "dgvFriendRequestProjectPage";
            this.dgvFriendRequestProjectPage.ReadOnly = true;
            this.dgvFriendRequestProjectPage.RowHeadersWidth = 51;
            this.dgvFriendRequestProjectPage.RowTemplate.Height = 29;
            this.dgvFriendRequestProjectPage.Size = new System.Drawing.Size(611, 232);
            this.dgvFriendRequestProjectPage.TabIndex = 2;
            this.dgvFriendRequestProjectPage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFriendRequestProjectPage_CellContentClick);
            // 
            // PageStudentID
            // 
            this.PageStudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PageStudentID.HeaderText = "StudentID";
            this.PageStudentID.MinimumWidth = 6;
            this.PageStudentID.Name = "PageStudentID";
            this.PageStudentID.ReadOnly = true;
            this.PageStudentID.Width = 84;
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
            this.PageID.Width = 69;
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
            this.Approve.Width = 58;
            // 
            // Reject
            // 
            this.Reject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Reject.HeaderText = "Reject";
            this.Reject.MinimumWidth = 6;
            this.Reject.Name = "Reject";
            this.Reject.ReadOnly = true;
            this.Reject.Width = 45;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(10, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 37);
            this.lblTitle.TabIndex = 34;
            // 
            // btnDelRequest
            // 
            this.btnDelRequest.Location = new System.Drawing.Point(230, 80);
            this.btnDelRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelRequest.Name = "btnDelRequest";
            this.btnDelRequest.Size = new System.Drawing.Size(141, 28);
            this.btnDelRequest.TabIndex = 39;
            this.btnDelRequest.Text = "Delete Request";
            this.btnDelRequest.UseVisualStyleBackColor = true;
            this.btnDelRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // PartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 346);
            this.Controls.Add(this.btnDelRequest);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvFriendRequestProjectPage);
            this.Controls.Add(this.dgvStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PartnerForm";
            this.Text = "PartnerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendRequestProjectPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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