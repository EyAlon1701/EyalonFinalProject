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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProjectPage = new System.Windows.Forms.DataGridView();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnPartner = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectPage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 54);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1029, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 55);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add Page";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProjectPage
            // 
            this.dgvProjectPage.AllowUserToAddRows = false;
            this.dgvProjectPage.AllowUserToDeleteRows = false;
            this.dgvProjectPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectPage.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProjectPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PageName,
            this.PageCreationDate,
            this.PageData,
            this.BookName,
            this.PartnerDetails,
            this.View,
            this.Edit,
            this.Delete});
            this.dgvProjectPage.Location = new System.Drawing.Point(0, 181);
            this.dgvProjectPage.Name = "dgvProjectPage";
            this.dgvProjectPage.ReadOnly = true;
            this.dgvProjectPage.RowHeadersWidth = 51;
            this.dgvProjectPage.RowTemplate.Height = 29;
            this.dgvProjectPage.Size = new System.Drawing.Size(1226, 473);
            this.dgvProjectPage.TabIndex = 35;
            this.dgvProjectPage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectPage_CellContentClick);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(838, 12);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(185, 55);
            this.btnEditUser.TabIndex = 37;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnPartner
            // 
            this.btnPartner.Location = new System.Drawing.Point(12, 120);
            this.btnPartner.Name = "btnPartner";
            this.btnPartner.Size = new System.Drawing.Size(185, 55);
            this.btnPartner.TabIndex = 38;
            this.btnPartner.Text = "Partner Requests";
            this.btnPartner.UseVisualStyleBackColor = true;
            this.btnPartner.Click += new System.EventHandler(this.btnPartner_Click);
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
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 654);
            this.Controls.Add(this.btnPartner);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.dgvProjectPage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWelcome);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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