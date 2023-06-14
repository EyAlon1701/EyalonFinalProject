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
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnAddPage = new System.Windows.Forms.Button();
            this.DgvProjectPage = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnEditUser = new System.Windows.Forms.Button();
            this.BtnPartner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectPage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWelcome.Location = new System.Drawing.Point(24, 33);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(167, 46);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Welcome";
            // 
            // BtnAddPage
            // 
            this.BtnAddPage.Location = new System.Drawing.Point(994, 27);
            this.BtnAddPage.Name = "BtnAddPage";
            this.BtnAddPage.Size = new System.Drawing.Size(289, 45);
            this.BtnAddPage.TabIndex = 34;
            this.BtnAddPage.Text = "Add Page";
            this.BtnAddPage.UseVisualStyleBackColor = true;
            this.BtnAddPage.Click += new System.EventHandler(this.BtnAddPage_Click);
            // 
            // DgvProjectPage
            // 
            this.DgvProjectPage.AllowUserToAddRows = false;
            this.DgvProjectPage.AllowUserToDeleteRows = false;
            this.DgvProjectPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProjectPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvProjectPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProjectPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PageName,
            this.PageCreationDate,
            this.PageData,
            this.BookName,
            this.PartnerDetails,
            this.View,
            this.Edit,
            this.Delete});
            this.DgvProjectPage.Location = new System.Drawing.Point(0, 161);
            this.DgvProjectPage.Name = "DgvProjectPage";
            this.DgvProjectPage.ReadOnly = true;
            this.DgvProjectPage.RowHeadersWidth = 51;
            this.DgvProjectPage.RowTemplate.Height = 29;
            this.DgvProjectPage.Size = new System.Drawing.Size(1295, 410);
            this.DgvProjectPage.TabIndex = 35;
            this.DgvProjectPage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectPage_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.FillWeight = 42.78075F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 53;
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
            this.PageCreationDate.FillWeight = 43.31802F;
            this.PageCreationDate.HeaderText = "PageCreationDate";
            this.PageCreationDate.MinimumWidth = 6;
            this.PageCreationDate.Name = "PageCreationDate";
            this.PageCreationDate.ReadOnly = true;
            this.PageCreationDate.Width = 158;
            // 
            // PageData
            // 
            this.PageData.FillWeight = 156.9506F;
            this.PageData.HeaderText = "PageData";
            this.PageData.MinimumWidth = 6;
            this.PageData.Name = "PageData";
            this.PageData.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "BookName";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // PartnerDetails
            // 
            this.PartnerDetails.HeaderText = "PartnerDetails";
            this.PartnerDetails.MinimumWidth = 6;
            this.PartnerDetails.Name = "PartnerDetails";
            this.PartnerDetails.ReadOnly = true;
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
            // BtnEditUser
            // 
            this.BtnEditUser.Location = new System.Drawing.Point(994, 78);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(289, 45);
            this.BtnEditUser.TabIndex = 37;
            this.BtnEditUser.Text = "Edit User";
            this.BtnEditUser.UseVisualStyleBackColor = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // BtnPartner
            // 
            this.BtnPartner.Location = new System.Drawing.Point(24, 110);
            this.BtnPartner.Name = "BtnPartner";
            this.BtnPartner.Size = new System.Drawing.Size(289, 45);
            this.BtnPartner.TabIndex = 38;
            this.BtnPartner.Text = "Partner Requests";
            this.BtnPartner.UseVisualStyleBackColor = true;
            this.BtnPartner.Click += new System.EventHandler(this.BtnPartner_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 571);
            this.Controls.Add(this.BtnPartner);
            this.Controls.Add(this.BtnEditUser);
            this.Controls.Add(this.DgvProjectPage);
            this.Controls.Add(this.BtnAddPage);
            this.Controls.Add(this.LblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblWelcome;
        private Button BtnAddPage;
        private DataGridView DgvProjectPage;
        private Button BtnEditUser;
        private Button BtnPartner;
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