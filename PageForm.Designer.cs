namespace EyalonFinalProject
{
    partial class PageForm
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
            this.btnSumbit = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPageName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.rtfPageData = new System.Windows.Forms.RichTextBox();
            this.lblPartnerDetails = new System.Windows.Forms.Label();
            this.btnPartner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(595, 26);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(185, 45);
            this.btnSumbit.TabIndex = 40;
            this.btnSumbit.Text = "Add";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 171);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(88, 20);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "Page Name:";
            // 
            // txtPageName
            // 
            this.txtPageName.Location = new System.Drawing.Point(117, 168);
            this.txtPageName.Name = "txtPageName";
            this.txtPageName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPageName.Size = new System.Drawing.Size(663, 27);
            this.txtPageName.TabIndex = 35;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(14, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 50);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Project Page";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 218);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "Page Data:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.Location = new System.Drawing.Point(14, 77);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(153, 32);
            this.lblBookName.TabIndex = 41;
            this.lblBookName.Text = "BookName: ";
            // 
            // rtfPageData
            // 
            this.rtfPageData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtfPageData.Location = new System.Drawing.Point(117, 213);
            this.rtfPageData.Name = "rtfPageData";
            this.rtfPageData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtfPageData.Size = new System.Drawing.Size(663, 197);
            this.rtfPageData.TabIndex = 42;
            this.rtfPageData.Text = "";
            // 
            // lblPartnerDetails
            // 
            this.lblPartnerDetails.AutoSize = true;
            this.lblPartnerDetails.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPartnerDetails.Location = new System.Drawing.Point(14, 117);
            this.lblPartnerDetails.Name = "lblPartnerDetails";
            this.lblPartnerDetails.Size = new System.Drawing.Size(191, 32);
            this.lblPartnerDetails.TabIndex = 43;
            this.lblPartnerDetails.Text = "PartnerDetails: ";
            // 
            // btnPartner
            // 
            this.btnPartner.Location = new System.Drawing.Point(404, 26);
            this.btnPartner.Name = "btnPartner";
            this.btnPartner.Size = new System.Drawing.Size(185, 45);
            this.btnPartner.TabIndex = 44;
            this.btnPartner.Text = "Partner";
            this.btnPartner.UseVisualStyleBackColor = true;
            this.btnPartner.Click += new System.EventHandler(this.btnPartner_Click);
            // 
            // PageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.btnPartner);
            this.Controls.Add(this.lblPartnerDetails);
            this.Controls.Add(this.rtfPageData);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPageName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PageForm";
            this.Text = "PageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSumbit;
        private Label lblID;
        private TextBox txtPageName;
        private Label lblTitle;
        private Label lblFirstName;
        private Label lblBookName;
        private RichTextBox rtfPageData;
        private Label lblPartnerDetails;
        private Button btnPartner;
    }
}