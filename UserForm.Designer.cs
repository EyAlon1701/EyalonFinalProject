namespace EyalonFinalProject
{
    partial class UserForm
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
            this.BtnImg = new System.Windows.Forms.Button();
            this.LblImg = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LblRole = new System.Windows.Forms.Label();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImg
            // 
            this.BtnImg.Location = new System.Drawing.Point(121, 341);
            this.BtnImg.Name = "BtnImg";
            this.BtnImg.Size = new System.Drawing.Size(125, 29);
            this.BtnImg.TabIndex = 27;
            this.BtnImg.Text = "open";
            this.BtnImg.UseVisualStyleBackColor = true;
            this.BtnImg.Click += new System.EventHandler(this.BtnImg_Click);
            // 
            // LblImg
            // 
            this.LblImg.AutoSize = true;
            this.LblImg.Location = new System.Drawing.Point(11, 345);
            this.LblImg.Name = "LblImg";
            this.LblImg.Size = new System.Drawing.Size(54, 20);
            this.LblImg.TabIndex = 28;
            this.LblImg.Text = "Image:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(121, 237);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(125, 27);
            this.TxtLastName.TabIndex = 22;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(11, 240);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(78, 20);
            this.LblLastName.TabIndex = 23;
            this.LblLastName.Text = "LastName:";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(121, 203);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(125, 27);
            this.TxtFirstName.TabIndex = 20;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(11, 205);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(79, 20);
            this.LblFirstName.TabIndex = 21;
            this.LblFirstName.Text = "FirstName:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(121, 307);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(125, 27);
            this.TxtPassword.TabIndex = 26;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(11, 171);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(31, 20);
            this.LblID.TabIndex = 18;
            this.LblID.Text = "ID: ";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(121, 167);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(125, 27);
            this.TxtID.TabIndex = 19;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(11, 309);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(73, 20);
            this.LblPassword.TabIndex = 25;
            this.LblPassword.Text = "Password:";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(11, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(234, 139);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 17;
            this.PictureBox.TabStop = false;
            // 
            // LblRole
            // 
            this.LblRole.AutoSize = true;
            this.LblRole.Location = new System.Drawing.Point(11, 380);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(42, 20);
            this.LblRole.TabIndex = 29;
            this.LblRole.Text = "Role:";
            // 
            // CbRole
            // 
            this.CbRole.Enabled = false;
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Items.AddRange(new object[] {
            "Student",
            "Lecturer",
            "Admin"});
            this.CbRole.Location = new System.Drawing.Point(121, 377);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(125, 28);
            this.CbRole.TabIndex = 30;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(12, 427);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(234, 40);
            this.BtnSubmit.TabIndex = 31;
            this.BtnSubmit.Text = "Add";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(11, 275);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(49, 20);
            this.LblEmail.TabIndex = 24;
            this.LblEmail.Text = "Email:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(121, 272);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(125, 27);
            this.TxtEmail.TabIndex = 25;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 479);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.CbRole);
            this.Controls.Add(this.LblRole);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.BtnImg);
            this.Controls.Add(this.LblImg);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnImg;
        private Label LblImg;
        private TextBox TxtLastName;
        private Label LblLastName;
        private TextBox TxtFirstName;
        private Label LblFirstName;
        private TextBox TxtPassword;
        private Label LblID;
        private TextBox TxtID;
        private Label LblPassword;
        private PictureBox PictureBox;
        private Label LblRole;
        private ComboBox CbRole;
        private Button BtnSubmit;
        private OpenFileDialog OpenFileDialog;
        private Label LblEmail;
        private TextBox TxtEmail;
    }
}