namespace EyalonFinalProject
{
    partial class LecturerForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 54);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(604, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(184, 51);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblWelcome);
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private Button btnSubmit;
    }
}