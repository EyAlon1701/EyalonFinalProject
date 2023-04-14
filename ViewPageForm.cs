using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace EyalonFinalProject
{
    public partial class ViewPageForm : Form
    {
        DBConnection dbc = new DBConnection();
        int pageID = -1;
        string pageName = "";
        string pageData = "";
        public ViewPageForm(int pageID, string pageName, string pageData)
        {
            InitializeComponent();
            this.pageID = pageID;
            this.pageName = pageName;
            this.pageData = pageData;
            rtbPageData.SelectionAlignment = HorizontalAlignment.Right;
            Font titleFont = new Font("Calibri", 14, FontStyle.Bold);
            Font dataFont = new Font("Calibri", 11, FontStyle.Regular);
            rtbPageData.Font = titleFont;
            AppendText(dbc.getStudentNameByProjectPageID(pageID) + " - " + pageName + "\n", titleFont);
            AppendText(pageData,dataFont);
        }

        private void AppendText(string text, Font font)
        {
            rtbPageData.SelectionStart = rtbPageData.TextLength;
            rtbPageData.SelectionFont = font;
            rtbPageData.AppendText(text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbPageData.SaveFile(saveFileDialog1.FileName+".rtf");
            }
        } 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
