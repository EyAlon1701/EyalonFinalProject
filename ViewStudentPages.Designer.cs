namespace EyalonFinalProject
{
    partial class ViewStudentPages
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
            this.DgvStuPages = new System.Windows.Forms.DataGridView();
            this.PageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStuPages)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStuPages
            // 
            this.DgvStuPages.AllowUserToAddRows = false;
            this.DgvStuPages.AllowUserToDeleteRows = false;
            this.DgvStuPages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStuPages.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvStuPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStuPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageID,
            this.PageName,
            this.BookName,
            this.PartnerDetails,
            this.View});
            this.DgvStuPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStuPages.Location = new System.Drawing.Point(0, 0);
            this.DgvStuPages.Name = "DgvStuPages";
            this.DgvStuPages.ReadOnly = true;
            this.DgvStuPages.RowHeadersWidth = 51;
            this.DgvStuPages.RowTemplate.Height = 29;
            this.DgvStuPages.Size = new System.Drawing.Size(832, 433);
            this.DgvStuPages.TabIndex = 0;
            this.DgvStuPages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStuPages_CellContentClick);
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
            // ViewStudentPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 433);
            this.Controls.Add(this.DgvStuPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ViewStudentPages";
            this.Text = "ViewStudentPages";
            ((System.ComponentModel.ISupportInitialize)(this.DgvStuPages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DgvStuPages;
        private DataGridViewTextBoxColumn PageID;
        private DataGridViewTextBoxColumn PageName;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn PartnerDetails;
        private DataGridViewButtonColumn View;
    }
}