namespace EyalonFinalProject
{
    partial class ViewPageForm
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
            this.rtbPageData = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbPageData
            // 
            this.rtbPageData.Location = new System.Drawing.Point(10, 13);
            this.rtbPageData.Name = "rtbPageData";
            this.rtbPageData.ReadOnly = true;
            this.rtbPageData.Size = new System.Drawing.Size(430, 552);
            this.rtbPageData.TabIndex = 0;
            this.rtbPageData.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbPageData);
            this.Name = "ViewPageForm";
            this.Text = "ViewPageForm";
            this.Load += new System.EventHandler(this.ViewPageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbPageData;
        private Button button1;
    }
}