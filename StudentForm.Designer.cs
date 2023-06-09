namespace EyalonFinalProject
{
    partial class StudentForm
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
            dgvProjectPage = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PageName = new DataGridViewTextBoxColumn();
            PageCreationDate = new DataGridViewTextBoxColumn();
            PageData = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            PartnerDetails = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnEditUser = new Button();
            btnPartner = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProjectPage).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(21, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(119, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(859, 25);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(253, 34);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Add Page";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProjectPage
            // 
            dgvProjectPage.AllowUserToAddRows = false;
            dgvProjectPage.AllowUserToDeleteRows = false;
            dgvProjectPage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjectPage.BackgroundColor = SystemColors.ActiveCaption;
            dgvProjectPage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectPage.Columns.AddRange(new DataGridViewColumn[] { ID, PageName, PageCreationDate, PageData, BookName, PartnerDetails, View, Edit, Delete });
            dgvProjectPage.Location = new Point(0, 136);
            dgvProjectPage.Margin = new Padding(3, 2, 3, 2);
            dgvProjectPage.Name = "dgvProjectPage";
            dgvProjectPage.ReadOnly = true;
            dgvProjectPage.RowHeadersWidth = 51;
            dgvProjectPage.RowTemplate.Height = 29;
            dgvProjectPage.Size = new Size(1135, 294);
            dgvProjectPage.TabIndex = 35;
            dgvProjectPage.CellContentClick += dgvProjectPage_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ID.FillWeight = 42.78075F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 43;
            // 
            // PageName
            // 
            PageName.HeaderText = "PageName";
            PageName.MinimumWidth = 6;
            PageName.Name = "PageName";
            PageName.ReadOnly = true;
            // 
            // PageCreationDate
            // 
            PageCreationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            PageCreationDate.FillWeight = 43.31802F;
            PageCreationDate.HeaderText = "PageCreationDate";
            PageCreationDate.MinimumWidth = 6;
            PageCreationDate.Name = "PageCreationDate";
            PageCreationDate.ReadOnly = true;
            PageCreationDate.Width = 127;
            // 
            // PageData
            // 
            PageData.FillWeight = 156.9506F;
            PageData.HeaderText = "PageData";
            PageData.MinimumWidth = 6;
            PageData.Name = "PageData";
            PageData.ReadOnly = true;
            // 
            // BookName
            // 
            BookName.HeaderText = "BookName";
            BookName.MinimumWidth = 6;
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            // 
            // PartnerDetails
            // 
            PartnerDetails.HeaderText = "PartnerDetails";
            PartnerDetails.MinimumWidth = 6;
            PartnerDetails.Name = "PartnerDetails";
            PartnerDetails.ReadOnly = true;
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
            // btnEditUser
            // 
            btnEditUser.Location = new Point(859, 67);
            btnEditUser.Margin = new Padding(3, 2, 3, 2);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(253, 36);
            btnEditUser.TabIndex = 37;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnPartner
            // 
            btnPartner.Location = new Point(16, 71);
            btnPartner.Margin = new Padding(3, 2, 3, 2);
            btnPartner.Name = "btnPartner";
            btnPartner.Size = new Size(253, 40);
            btnPartner.TabIndex = 38;
            btnPartner.Text = "Partner Requests";
            btnPartner.UseVisualStyleBackColor = true;
            btnPartner.Click += btnPartner_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1133, 428);
            Controls.Add(btnPartner);
            Controls.Add(btnEditUser);
            Controls.Add(dgvProjectPage);
            Controls.Add(btnAdd);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dgvProjectPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnAdd;
        private DataGridView dgvProjectPage;
        private Button btnEditUser;
        private Button btnPartner;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewTextBoxColumn PageCreationDate;
        private DataGridViewTextBoxColumn PageData;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn PartnerDetails;
        private DataGridViewButtonColumn View;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}