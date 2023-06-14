namespace EyalonFinalProject
{
    partial class AddPageToBookForm
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
            this.DgvStudentsPages = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAddSelectedRows = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentsPages)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStudentsPages
            // 
            this.DgvStudentsPages.AllowUserToAddRows = false;
            this.DgvStudentsPages.AllowUserToDeleteRows = false;
            this.DgvStudentsPages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStudentsPages.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvStudentsPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudentsPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FirstName,
            this.LastName,
            this.Add});
            this.DgvStudentsPages.Location = new System.Drawing.Point(0, 85);
            this.DgvStudentsPages.Name = "DgvStudentsPages";
            this.DgvStudentsPages.ReadOnly = true;
            this.DgvStudentsPages.RowHeadersWidth = 51;
            this.DgvStudentsPages.RowTemplate.Height = 29;
            this.DgvStudentsPages.Size = new System.Drawing.Size(808, 411);
            this.DgvStudentsPages.TabIndex = 1;
            this.DgvStudentsPages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentsPages_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 82;
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
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Add.HeaderText = "Add";
            this.Add.MinimumWidth = 6;
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Width = 43;
            // 
            // BtnAddSelectedRows
            // 
            this.BtnAddSelectedRows.Location = new System.Drawing.Point(507, 21);
            this.BtnAddSelectedRows.Name = "BtnAddSelectedRows";
            this.BtnAddSelectedRows.Size = new System.Drawing.Size(289, 50);
            this.BtnAddSelectedRows.TabIndex = 34;
            this.BtnAddSelectedRows.Text = "Add Selected Rows";
            this.BtnAddSelectedRows.UseVisualStyleBackColor = true;
            this.BtnAddSelectedRows.Click += new System.EventHandler(this.BtnAddSelectedRows_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(14, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(358, 50);
            this.LblTitle.TabIndex = 35;
            this.LblTitle.Text = "Add Pages To Book";
            // 
            // AddPageToBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 496);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnAddSelectedRows);
            this.Controls.Add(this.DgvStudentsPages);
            this.Name = "AddPageToBookForm";
            this.Text = "AddPageToBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentsPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvStudentsPages;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewButtonColumn Add;
        private Button BtnAddSelectedRows;
        private Label LblTitle;
    }
}