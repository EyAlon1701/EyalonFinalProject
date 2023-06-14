namespace EyalonFinalProject
{
    partial class HomeForm
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblLoginID = new System.Windows.Forms.Label();
            this.LblLoginPassword = new System.Windows.Forms.Label();
            this.TxtLoginID = new System.Windows.Forms.TextBox();
            this.TxtLoginPassword = new System.Windows.Forms.TextBox();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.LblLogin = new System.Windows.Forms.Label();
            this.BtnGoReg = new System.Windows.Forms.Button();
            this.PnlReg = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.BtnGoLogin = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.LblReg = new System.Windows.Forms.Label();
            this.TxtRegEmail = new System.Windows.Forms.TextBox();
            this.LblRegEmail = new System.Windows.Forms.Label();
            this.BtnRegImg = new System.Windows.Forms.Button();
            this.LblImg = new System.Windows.Forms.Label();
            this.TxtRegLastName = new System.Windows.Forms.TextBox();
            this.LblRegLastName = new System.Windows.Forms.Label();
            this.TxtRegFirstName = new System.Windows.Forms.TextBox();
            this.LblRegFirstName = new System.Windows.Forms.Label();
            this.TxtRegPassword = new System.Windows.Forms.TextBox();
            this.LblRegID = new System.Windows.Forms.Label();
            this.TxtRegID = new System.Windows.Forms.TextBox();
            this.LblRegPassword = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PnlLogin.SuspendLayout();
            this.PnlReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(13, 163);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(234, 35);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblLoginID
            // 
            this.LblLoginID.AutoSize = true;
            this.LblLoginID.Location = new System.Drawing.Point(13, 85);
            this.LblLoginID.Name = "LblLoginID";
            this.LblLoginID.Size = new System.Drawing.Size(31, 20);
            this.LblLoginID.TabIndex = 1;
            this.LblLoginID.Text = "ID: ";
            // 
            // LblLoginPassword
            // 
            this.LblLoginPassword.AutoSize = true;
            this.LblLoginPassword.Location = new System.Drawing.Point(13, 119);
            this.LblLoginPassword.Name = "LblLoginPassword";
            this.LblLoginPassword.Size = new System.Drawing.Size(70, 20);
            this.LblLoginPassword.TabIndex = 4;
            this.LblLoginPassword.Text = "Password";
            // 
            // TxtLoginID
            // 
            this.TxtLoginID.Location = new System.Drawing.Point(122, 83);
            this.TxtLoginID.Name = "TxtLoginID";
            this.TxtLoginID.Size = new System.Drawing.Size(125, 27);
            this.TxtLoginID.TabIndex = 0;
            // 
            // TxtLoginPassword
            // 
            this.TxtLoginPassword.Location = new System.Drawing.Point(122, 116);
            this.TxtLoginPassword.Name = "TxtLoginPassword";
            this.TxtLoginPassword.Size = new System.Drawing.Size(125, 27);
            this.TxtLoginPassword.TabIndex = 2;
            // 
            // PnlLogin
            // 
            this.PnlLogin.Controls.Add(this.LblLogin);
            this.PnlLogin.Controls.Add(this.BtnGoReg);
            this.PnlLogin.Controls.Add(this.TxtLoginPassword);
            this.PnlLogin.Controls.Add(this.LblLoginID);
            this.PnlLogin.Controls.Add(this.BtnLogin);
            this.PnlLogin.Controls.Add(this.TxtLoginID);
            this.PnlLogin.Controls.Add(this.LblLoginPassword);
            this.PnlLogin.Location = new System.Drawing.Point(45, 26);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(260, 370);
            this.PnlLogin.TabIndex = 5;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLogin.Location = new System.Drawing.Point(66, 16);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(127, 54);
            this.LblLogin.TabIndex = 6;
            this.LblLogin.Text = "Login";
            // 
            // BtnGoReg
            // 
            this.BtnGoReg.Location = new System.Drawing.Point(13, 203);
            this.BtnGoReg.Name = "BtnGoReg";
            this.BtnGoReg.Size = new System.Drawing.Size(234, 35);
            this.BtnGoReg.TabIndex = 5;
            this.BtnGoReg.Text = "Register";
            this.BtnGoReg.UseVisualStyleBackColor = true;
            this.BtnGoReg.Click += new System.EventHandler(this.BtnGoReg_Click);
            // 
            // PnlReg
            // 
            this.PnlReg.BackColor = System.Drawing.SystemColors.Control;
            this.PnlReg.Controls.Add(this.PictureBox);
            this.PnlReg.Controls.Add(this.BtnGoLogin);
            this.PnlReg.Controls.Add(this.BtnReg);
            this.PnlReg.Controls.Add(this.LblReg);
            this.PnlReg.Controls.Add(this.TxtRegEmail);
            this.PnlReg.Controls.Add(this.LblRegEmail);
            this.PnlReg.Controls.Add(this.BtnRegImg);
            this.PnlReg.Controls.Add(this.LblImg);
            this.PnlReg.Controls.Add(this.TxtRegLastName);
            this.PnlReg.Controls.Add(this.LblRegLastName);
            this.PnlReg.Controls.Add(this.TxtRegFirstName);
            this.PnlReg.Controls.Add(this.LblRegFirstName);
            this.PnlReg.Controls.Add(this.TxtRegPassword);
            this.PnlReg.Controls.Add(this.LblRegID);
            this.PnlReg.Controls.Add(this.TxtRegID);
            this.PnlReg.Controls.Add(this.LblRegPassword);
            this.PnlReg.Location = new System.Drawing.Point(45, 26);
            this.PnlReg.Name = "PnlReg";
            this.PnlReg.Size = new System.Drawing.Size(260, 370);
            this.PnlReg.TabIndex = 6;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(130, 165);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(110, 109);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 7;
            this.PictureBox.TabStop = false;
            // 
            // BtnGoLogin
            // 
            this.BtnGoLogin.Location = new System.Drawing.Point(13, 327);
            this.BtnGoLogin.Name = "BtnGoLogin";
            this.BtnGoLogin.Size = new System.Drawing.Size(234, 35);
            this.BtnGoLogin.TabIndex = 18;
            this.BtnGoLogin.Text = "Login";
            this.BtnGoLogin.UseVisualStyleBackColor = true;
            this.BtnGoLogin.Click += new System.EventHandler(this.BtnGoLogin_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(13, 287);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(234, 35);
            this.BtnReg.TabIndex = 17;
            this.BtnReg.Text = "Register";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // LblReg
            // 
            this.LblReg.AutoSize = true;
            this.LblReg.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReg.Location = new System.Drawing.Point(41, 16);
            this.LblReg.Name = "LblReg";
            this.LblReg.Size = new System.Drawing.Size(178, 54);
            this.LblReg.TabIndex = 7;
            this.LblReg.Text = "Register";
            // 
            // TxtRegEmail
            // 
            this.TxtRegEmail.Location = new System.Drawing.Point(122, 181);
            this.TxtRegEmail.Name = "TxtRegEmail";
            this.TxtRegEmail.Size = new System.Drawing.Size(125, 27);
            this.TxtRegEmail.TabIndex = 10;
            // 
            // LblRegEmail
            // 
            this.LblRegEmail.AutoSize = true;
            this.LblRegEmail.Location = new System.Drawing.Point(13, 185);
            this.LblRegEmail.Name = "LblRegEmail";
            this.LblRegEmail.Size = new System.Drawing.Size(49, 20);
            this.LblRegEmail.TabIndex = 18;
            this.LblRegEmail.Text = "Email:";
            // 
            // BtnRegImg
            // 
            this.BtnRegImg.Location = new System.Drawing.Point(122, 252);
            this.BtnRegImg.Name = "BtnRegImg";
            this.BtnRegImg.Size = new System.Drawing.Size(125, 29);
            this.BtnRegImg.TabIndex = 16;
            this.BtnRegImg.Text = "open";
            this.BtnRegImg.UseVisualStyleBackColor = true;
            this.BtnRegImg.Click += new System.EventHandler(this.BtnRegImg_Click);
            // 
            // LblImg
            // 
            this.LblImg.AutoSize = true;
            this.LblImg.Location = new System.Drawing.Point(13, 255);
            this.LblImg.Name = "LblImg";
            this.LblImg.Size = new System.Drawing.Size(51, 20);
            this.LblImg.TabIndex = 15;
            this.LblImg.Text = "Image";
            this.LblImg.MouseLeave += new System.EventHandler(this.LblImg_MouseLeave);
            this.LblImg.MouseHover += new System.EventHandler(this.LblImg_MouseHover);
            // 
            // TxtRegLastName
            // 
            this.TxtRegLastName.Location = new System.Drawing.Point(122, 147);
            this.TxtRegLastName.Name = "TxtRegLastName";
            this.TxtRegLastName.Size = new System.Drawing.Size(125, 27);
            this.TxtRegLastName.TabIndex = 9;
            // 
            // LblRegLastName
            // 
            this.LblRegLastName.AutoSize = true;
            this.LblRegLastName.Location = new System.Drawing.Point(13, 149);
            this.LblRegLastName.Name = "LblRegLastName";
            this.LblRegLastName.Size = new System.Drawing.Size(75, 20);
            this.LblRegLastName.TabIndex = 13;
            this.LblRegLastName.Text = "LastName";
            // 
            // TxtRegFirstName
            // 
            this.TxtRegFirstName.Location = new System.Drawing.Point(122, 112);
            this.TxtRegFirstName.Name = "TxtRegFirstName";
            this.TxtRegFirstName.Size = new System.Drawing.Size(125, 27);
            this.TxtRegFirstName.TabIndex = 8;
            // 
            // LblRegFirstName
            // 
            this.LblRegFirstName.AutoSize = true;
            this.LblRegFirstName.Location = new System.Drawing.Point(13, 115);
            this.LblRegFirstName.Name = "LblRegFirstName";
            this.LblRegFirstName.Size = new System.Drawing.Size(76, 20);
            this.LblRegFirstName.TabIndex = 11;
            this.LblRegFirstName.Text = "FirstName";
            // 
            // TxtRegPassword
            // 
            this.TxtRegPassword.Location = new System.Drawing.Point(122, 217);
            this.TxtRegPassword.Name = "TxtRegPassword";
            this.TxtRegPassword.Size = new System.Drawing.Size(125, 27);
            this.TxtRegPassword.TabIndex = 12;
            // 
            // LblRegID
            // 
            this.LblRegID.AutoSize = true;
            this.LblRegID.Location = new System.Drawing.Point(13, 80);
            this.LblRegID.Name = "LblRegID";
            this.LblRegID.Size = new System.Drawing.Size(31, 20);
            this.LblRegID.TabIndex = 5;
            this.LblRegID.Text = "ID: ";
            // 
            // TxtRegID
            // 
            this.TxtRegID.Location = new System.Drawing.Point(122, 77);
            this.TxtRegID.Name = "TxtRegID";
            this.TxtRegID.Size = new System.Drawing.Size(125, 27);
            this.TxtRegID.TabIndex = 7;
            // 
            // LblRegPassword
            // 
            this.LblRegPassword.AutoSize = true;
            this.LblRegPassword.Location = new System.Drawing.Point(13, 220);
            this.LblRegPassword.Name = "LblRegPassword";
            this.LblRegPassword.Size = new System.Drawing.Size(70, 20);
            this.LblRegPassword.TabIndex = 6;
            this.LblRegPassword.Text = "Password";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 421);
            this.Controls.Add(this.PnlReg);
            this.Controls.Add(this.PnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.PnlReg.ResumeLayout(false);
            this.PnlReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnLogin;
        private Label LblLoginID;
        private Label LblLoginPassword;
        private TextBox TxtLoginID;
        private TextBox TxtLoginPassword;
        private Panel PnlLogin;
        private Panel PnlReg;
        private TextBox TxtRegPassword;
        private Label LblRegID;
        private TextBox TxtRegID;
        private Label LblRegPassword;
        private TextBox TxtRegFirstName;
        private Label LblRegFirstName;
        private TextBox TxtRegLastName;
        private Label LblRegLastName;
        private OpenFileDialog OpenFileDialog;
        private Button BtnRegImg;
        private Label LblImg;
        private Button BtnGoReg;
        private TextBox TxtRegEmail;
        private Label LblRegEmail;
        private Label LblLogin;
        private Button BtnGoLogin;
        private Button BtnReg;
        private Label LblReg;
        private PictureBox PictureBox;
    }
}