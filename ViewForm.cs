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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Font = System.Drawing.Font;

namespace EyalonFinalProject
{
    public partial class ViewForm : Form
    {
        DBConnection dbc = new DBConnection();
        Font titleFont = new Font("Calibri", 14, FontStyle.Bold);
        Font dataFont = new Font("Calibri", 11, FontStyle.Regular);

        public ViewForm(int id, Boolean isPage)
        {
            InitializeComponent();
            if(isPage)
            {
                makePage(dbc.getProjectPageByProjectPageID(id));
            }
            else
            {
                makeBook(dbc.getProjectBookByProjectBookID(id));
            }
        }

        private void makePage(DataRow page)
        {
            rtbPageData.SelectionAlignment = HorizontalAlignment.Right;
            saveFileDialog1.FileName = dbc.getStudentNameByProjectPageID(int.Parse(page["ProjectPageID"].ToString())) + " - " + page["ProjectPageName"].ToString();
            AppendText(dbc.getStudentNameByProjectPageID(int.Parse(page["ProjectPageID"].ToString())) + " - " + page["ProjectPageName"].ToString() + "\n", titleFont);
            AppendText(page["ProjectPageData"].ToString(), dataFont);
        }

        private void makeBook(DataRow book)
        {
            MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(book["ProjectBookOpenPage"].ToString()));
            rtbPageData.LoadFile(stream, RichTextBoxStreamType.RichText);

            rtbPageData.AppendText("\n\n\n");
            DataTable pages = dbc.getProjectPageIDByProjectBookID(int.Parse(book["ProjectBookID"].ToString()));
            for(int i = 0; i < pages.Rows.Count; i++)
            {
                rtbPageData.AppendText("\n");
                makePage(dbc.getProjectPageByProjectPageID(int.Parse(pages.Rows[i][0].ToString())));
            }
            saveFileDialog1.FileName = book["ProjectBookName"].ToString() + " - " + book["ProjectBookYear"].ToString();
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
