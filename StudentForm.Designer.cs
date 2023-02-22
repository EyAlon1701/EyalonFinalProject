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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
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
            this.btnAdd.Location = new System.Drawing.Point(844, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 55);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
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
            this.Edit,
            this.Delete});
            this.dgvProjectPage.Location = new System.Drawing.Point(0, 181);
            this.dgvProjectPage.Name = "dgvProjectPage";
            this.dgvProjectPage.ReadOnly = true;
            this.dgvProjectPage.RowHeadersWidth = 51;
            this.dgvProjectPage.RowTemplate.Height = 29;
            this.dgvProjectPage.Size = new System.Drawing.Size(1041, 473);
            this.dgvProjectPage.TabIndex = 35;
            this.dgvProjectPage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectPage_CellContentClick);
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
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 115);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(150, 60);
            this.btnShow.TabIndex = 36;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(844, 12);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(185, 55);
            this.btnEditUser.TabIndex = 37;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 654);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnShow);
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewTextBoxColumn PageCreationDate;
        private DataGridViewTextBoxColumn PageData;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnShow;
        private Button btnEditUser;
    }
}