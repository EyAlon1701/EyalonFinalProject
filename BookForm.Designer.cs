namespace EyalonFinalProject
{
    partial class BookForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 54);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Project Book";
            this.lblTitle.Click += new System.EventHandler(this.lblReg_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(158, 146);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 28;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 20);
            this.lblLastName.TabIndex = 29;
            this.lblLastName.Text = "Open Page: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(158, 112);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(125, 27);
            this.txtFirstName.TabIndex = 26;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(128, 20);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "Project Book Year:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 80);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(140, 20);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "Project Book Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 25;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(604, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 51);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTitle);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblID;
        private TextBox txtID;
        private Button btnSubmit;
    }
}