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
            this.BtnSumbit = new System.Windows.Forms.Button();
            this.LblPageName = new System.Windows.Forms.Label();
            this.TxtPageName = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblPageData = new System.Windows.Forms.Label();
            this.LblBookName = new System.Windows.Forms.Label();
            this.RtfPageData = new System.Windows.Forms.RichTextBox();
            this.LblPartnerDetails = new System.Windows.Forms.Label();
            this.BtnPartner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSumbit
            // 
            this.BtnSumbit.Location = new System.Drawing.Point(595, 26);
            this.BtnSumbit.Name = "BtnSumbit";
            this.BtnSumbit.Size = new System.Drawing.Size(185, 45);
            this.BtnSumbit.TabIndex = 40;
            this.BtnSumbit.Text = "Add";
            this.BtnSumbit.UseVisualStyleBackColor = true;
            this.BtnSumbit.Click += new System.EventHandler(this.BtnSumbit_Click);
            // 
            // LblPageName
            // 
            this.LblPageName.AutoSize = true;
            this.LblPageName.Location = new System.Drawing.Point(14, 172);
            this.LblPageName.Name = "LblPageName";
            this.LblPageName.Size = new System.Drawing.Size(88, 20);
            this.LblPageName.TabIndex = 34;
            this.LblPageName.Text = "Page Name:";
            // 
            // TxtPageName
            // 
            this.TxtPageName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPageName.Location = new System.Drawing.Point(117, 167);
            this.TxtPageName.Name = "TxtPageName";
            this.TxtPageName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPageName.Size = new System.Drawing.Size(663, 30);
            this.TxtPageName.TabIndex = 35;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(14, 21);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(241, 50);
            this.LblTitle.TabIndex = 33;
            this.LblTitle.Text = "Project Page";
            // 
            // LblPageData
            // 
            this.LblPageData.AutoSize = true;
            this.LblPageData.Location = new System.Drawing.Point(14, 207);
            this.LblPageData.Name = "LblPageData";
            this.LblPageData.Size = new System.Drawing.Size(80, 20);
            this.LblPageData.TabIndex = 37;
            this.LblPageData.Text = "Page Data:";
            // 
            // LblBookName
            // 
            this.LblBookName.AutoSize = true;
            this.LblBookName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblBookName.Location = new System.Drawing.Point(14, 77);
            this.LblBookName.Name = "LblBookName";
            this.LblBookName.Size = new System.Drawing.Size(153, 32);
            this.LblBookName.TabIndex = 41;
            this.LblBookName.Text = "BookName: ";
            // 
            // RtfPageData
            // 
            this.RtfPageData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtfPageData.Location = new System.Drawing.Point(117, 202);
            this.RtfPageData.Name = "RtfPageData";
            this.RtfPageData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RtfPageData.Size = new System.Drawing.Size(663, 208);
            this.RtfPageData.TabIndex = 42;
            this.RtfPageData.Text = "";
            // 
            // LblPartnerDetails
            // 
            this.LblPartnerDetails.AutoSize = true;
            this.LblPartnerDetails.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPartnerDetails.Location = new System.Drawing.Point(14, 117);
            this.LblPartnerDetails.Name = "LblPartnerDetails";
            this.LblPartnerDetails.Size = new System.Drawing.Size(191, 32);
            this.LblPartnerDetails.TabIndex = 43;
            this.LblPartnerDetails.Text = "PartnerDetails: ";
            // 
            // BtnPartner
            // 
            this.BtnPartner.Location = new System.Drawing.Point(404, 26);
            this.BtnPartner.Name = "BtnPartner";
            this.BtnPartner.Size = new System.Drawing.Size(185, 45);
            this.BtnPartner.TabIndex = 44;
            this.BtnPartner.Text = "Partner";
            this.BtnPartner.UseVisualStyleBackColor = true;
            this.BtnPartner.Click += new System.EventHandler(this.BtnPartner_Click);
            // 
            // PageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.BtnPartner);
            this.Controls.Add(this.LblPartnerDetails);
            this.Controls.Add(this.RtfPageData);
            this.Controls.Add(this.LblBookName);
            this.Controls.Add(this.BtnSumbit);
            this.Controls.Add(this.LblPageData);
            this.Controls.Add(this.LblPageName);
            this.Controls.Add(this.TxtPageName);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PageForm";
            this.Text = "PageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnSumbit;
        private Label LblPageName;
        private TextBox TxtPageName;
        private Label LblTitle;
        private Label LblPageData;
        private Label LblBookName;
        private RichTextBox RtfPageData;
        private Label LblPartnerDetails;
        private Button BtnPartner;
    }
}