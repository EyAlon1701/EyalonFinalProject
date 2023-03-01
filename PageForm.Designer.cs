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
            this.txtPageData = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPageName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(603, 12);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(185, 55);
            this.btnSumbit.TabIndex = 40;
            this.btnSumbit.Text = "Add";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // txtPageData
            // 
            this.txtPageData.Location = new System.Drawing.Point(158, 153);
            this.txtPageData.Name = "txtPageData";
            this.txtPageData.Size = new System.Drawing.Size(125, 27);
            this.txtPageData.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 121);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(88, 20);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "Page Name:";
            // 
            // txtPageName
            // 
            this.txtPageName.Location = new System.Drawing.Point(158, 118);
            this.txtPageName.Name = "txtPageName";
            this.txtPageName.Size = new System.Drawing.Size(125, 27);
            this.txtPageName.TabIndex = 35;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 54);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Project Page";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 156);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "Page Data:";
            // 
            // PageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.txtPageData);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPageName);
            this.Controls.Add(this.lblTitle);
            this.Name = "PageForm";
            this.Text = "PageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSumbit;
        private TextBox txtPageData;
        private Label lblID;
        private TextBox txtPageName;
        private Label lblTitle;
        private Label lblFirstName;
    }
}