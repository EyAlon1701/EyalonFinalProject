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
            this.dgvStudentsPages = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddSelectedRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentsPages
            // 
            this.dgvStudentsPages.AllowUserToAddRows = false;
            this.dgvStudentsPages.AllowUserToDeleteRows = false;
            this.dgvStudentsPages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentsPages.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudentsPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FirstName,
            this.LastName,
            this.Add});
            this.dgvStudentsPages.Location = new System.Drawing.Point(0, 65);
            this.dgvStudentsPages.Name = "dgvStudentsPages";
            this.dgvStudentsPages.ReadOnly = true;
            this.dgvStudentsPages.RowHeadersWidth = 51;
            this.dgvStudentsPages.RowTemplate.Height = 29;
            this.dgvStudentsPages.Size = new System.Drawing.Size(808, 402);
            this.dgvStudentsPages.TabIndex = 1;
            this.dgvStudentsPages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsPages_CellContentClick);
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
            // btnAddSelectedRows
            // 
            this.btnAddSelectedRows.Location = new System.Drawing.Point(611, 4);
            this.btnAddSelectedRows.Name = "btnAddSelectedRows";
            this.btnAddSelectedRows.Size = new System.Drawing.Size(185, 55);
            this.btnAddSelectedRows.TabIndex = 34;
            this.btnAddSelectedRows.Text = "Add Selected Rows";
            this.btnAddSelectedRows.UseVisualStyleBackColor = true;
            this.btnAddSelectedRows.Click += new System.EventHandler(this.btnAddSelectedRows_Click);
            // 
            // AddPageToBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 467);
            this.Controls.Add(this.btnAddSelectedRows);
            this.Controls.Add(this.dgvStudentsPages);
            this.Name = "AddPageToBookForm";
            this.Text = "AddPageToBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsPages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvStudentsPages;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewButtonColumn Add;
        private Button btnAddSelectedRows;
    }
}