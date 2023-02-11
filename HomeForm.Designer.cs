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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.txtLoginID = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnGoReg = new System.Windows.Forms.Button();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnGoLogin = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.btnRegImg = new System.Windows.Forms.Button();
            this.lblImg = new System.Windows.Forms.Label();
            this.txtRegLastName = new System.Windows.Forms.TextBox();
            this.lblRegLastName = new System.Windows.Forms.Label();
            this.txtRegFirstName = new System.Windows.Forms.TextBox();
            this.lblRegFirstName = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegID = new System.Windows.Forms.Label();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlLogin.SuspendLayout();
            this.pnlReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(13, 162);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(234, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.Location = new System.Drawing.Point(13, 86);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(31, 20);
            this.lblLoginID.TabIndex = 1;
            this.lblLoginID.Text = "ID: ";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(13, 119);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(70, 20);
            this.lblLoginPassword.TabIndex = 4;
            this.lblLoginPassword.Text = "Password";
            // 
            // txtLoginID
            // 
            this.txtLoginID.Location = new System.Drawing.Point(122, 83);
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.Size = new System.Drawing.Size(125, 27);
            this.txtLoginID.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(122, 116);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(125, 27);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.btnGoReg);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.lblLoginID);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtLoginID);
            this.pnlLogin.Controls.Add(this.lblLoginPassword);
            this.pnlLogin.Location = new System.Drawing.Point(46, 48);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(260, 258);
            this.pnlLogin.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(66, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(127, 54);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            // 
            // btnGoReg
            // 
            this.btnGoReg.Location = new System.Drawing.Point(13, 202);
            this.btnGoReg.Name = "btnGoReg";
            this.btnGoReg.Size = new System.Drawing.Size(234, 34);
            this.btnGoReg.TabIndex = 5;
            this.btnGoReg.Text = "Register";
            this.btnGoReg.UseVisualStyleBackColor = true;
            this.btnGoReg.Click += new System.EventHandler(this.btnGoReg_Click);
            // 
            // pnlReg
            // 
            this.pnlReg.Controls.Add(this.pictureBox);
            this.pnlReg.Controls.Add(this.btnGoLogin);
            this.pnlReg.Controls.Add(this.btnReg);
            this.pnlReg.Controls.Add(this.lblReg);
            this.pnlReg.Controls.Add(this.txtRegEmail);
            this.pnlReg.Controls.Add(this.lblRegEmail);
            this.pnlReg.Controls.Add(this.btnRegImg);
            this.pnlReg.Controls.Add(this.lblImg);
            this.pnlReg.Controls.Add(this.txtRegLastName);
            this.pnlReg.Controls.Add(this.lblRegLastName);
            this.pnlReg.Controls.Add(this.txtRegFirstName);
            this.pnlReg.Controls.Add(this.lblRegFirstName);
            this.pnlReg.Controls.Add(this.txtRegPassword);
            this.pnlReg.Controls.Add(this.lblRegID);
            this.pnlReg.Controls.Add(this.txtRegID);
            this.pnlReg.Controls.Add(this.lblRegPassword);
            this.pnlReg.Location = new System.Drawing.Point(46, 48);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(260, 371);
            this.pnlReg.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(130, 165);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(110, 110);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // btnGoLogin
            // 
            this.btnGoLogin.Location = new System.Drawing.Point(13, 327);
            this.btnGoLogin.Name = "btnGoLogin";
            this.btnGoLogin.Size = new System.Drawing.Size(234, 34);
            this.btnGoLogin.TabIndex = 7;
            this.btnGoLogin.Text = "Login";
            this.btnGoLogin.UseVisualStyleBackColor = true;
            this.btnGoLogin.Click += new System.EventHandler(this.btnGoLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(13, 287);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(234, 34);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReg.Location = new System.Drawing.Point(41, 16);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(178, 54);
            this.lblReg.TabIndex = 7;
            this.lblReg.Text = "Register";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(122, 182);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(125, 27);
            this.txtRegEmail.TabIndex = 18;
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Location = new System.Drawing.Point(13, 185);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(49, 20);
            this.lblRegEmail.TabIndex = 17;
            this.lblRegEmail.Text = "Email:";
            // 
            // btnRegImg
            // 
            this.btnRegImg.Location = new System.Drawing.Point(122, 252);
            this.btnRegImg.Name = "btnRegImg";
            this.btnRegImg.Size = new System.Drawing.Size(125, 29);
            this.btnRegImg.TabIndex = 16;
            this.btnRegImg.Text = "open";
            this.btnRegImg.UseVisualStyleBackColor = true;
            this.btnRegImg.Click += new System.EventHandler(this.btnRegImg_Click);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(13, 255);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(51, 20);
            this.lblImg.TabIndex = 15;
            this.lblImg.Text = "Image";
            this.lblImg.MouseLeave += new System.EventHandler(this.lblImg_MouseLeave);
            this.lblImg.MouseHover += new System.EventHandler(this.lblImg_MouseHover);
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.Location = new System.Drawing.Point(122, 147);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.Size = new System.Drawing.Size(125, 27);
            this.txtRegLastName.TabIndex = 14;
            // 
            // lblRegLastName
            // 
            this.lblRegLastName.AutoSize = true;
            this.lblRegLastName.Location = new System.Drawing.Point(13, 150);
            this.lblRegLastName.Name = "lblRegLastName";
            this.lblRegLastName.Size = new System.Drawing.Size(75, 20);
            this.lblRegLastName.TabIndex = 13;
            this.lblRegLastName.Text = "LastName";
            // 
            // txtRegFirstName
            // 
            this.txtRegFirstName.Location = new System.Drawing.Point(122, 112);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.Size = new System.Drawing.Size(125, 27);
            this.txtRegFirstName.TabIndex = 12;
            // 
            // lblRegFirstName
            // 
            this.lblRegFirstName.AutoSize = true;
            this.lblRegFirstName.Location = new System.Drawing.Point(13, 115);
            this.lblRegFirstName.Name = "lblRegFirstName";
            this.lblRegFirstName.Size = new System.Drawing.Size(76, 20);
            this.lblRegFirstName.TabIndex = 11;
            this.lblRegFirstName.Text = "FirstName";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(122, 217);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(125, 27);
            this.txtRegPassword.TabIndex = 8;
            // 
            // lblRegID
            // 
            this.lblRegID.AutoSize = true;
            this.lblRegID.Location = new System.Drawing.Point(13, 80);
            this.lblRegID.Name = "lblRegID";
            this.lblRegID.Size = new System.Drawing.Size(31, 20);
            this.lblRegID.TabIndex = 5;
            this.lblRegID.Text = "ID: ";
            // 
            // txtRegID
            // 
            this.txtRegID.Location = new System.Drawing.Point(122, 77);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(125, 27);
            this.txtRegID.TabIndex = 7;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(13, 220);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(70, 20);
            this.lblRegPassword.TabIndex = 6;
            this.lblRegPassword.Text = "Password";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.pnlReg);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlReg.ResumeLayout(false);
            this.pnlReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogin;
        private Label lblLoginID;
        private Label lblLoginPassword;
        private TextBox txtLoginID;
        private TextBox txtLoginPassword;
        private Panel pnlLogin;
        private Panel pnlReg;
        private TextBox txtRegPassword;
        private Label lblRegID;
        private TextBox txtRegID;
        private Label lblRegPassword;
        private TextBox txtRegFirstName;
        private Label lblRegFirstName;
        private TextBox txtRegLastName;
        private Label lblRegLastName;
        private OpenFileDialog openFileDialog1;
        private Button btnRegImg;
        private Label lblImg;
        private Button btnGoReg;
        private TextBox txtRegEmail;
        private Label lblRegEmail;
        private Label lblLogin;
        private Button btnGoLogin;
        private Button btnReg;
        private Label lblReg;
        private PictureBox pictureBox;
    }
}