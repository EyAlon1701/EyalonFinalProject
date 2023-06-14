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
            if(isPage)//true - is page
            {
                MakePage(dbc.GetProjectPageByProjectPageID(id));
            }
            else//false - is book
            {
                MakeBook(dbc.GetProjectBookByProjectBookID(id));
            }
        }

        private void MakePage(DataRow page)
        {
            SaveFileDialog.FileName = dbc.GetStudentNameByProjectPageID(int.Parse(page["ProjectPageID"].ToString())) + " - " + page["ProjectPageName"].ToString();
            AppendText(dbc.GetStudentNameByProjectPageID(int.Parse(page["ProjectPageID"].ToString())) + " - " + page["ProjectPageName"].ToString() + "\n", titleFont);
            AppendText(page["ProjectPageData"].ToString(), dataFont);
        }

        private void MakeBook(DataRow book)
        {
            MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(book["ProjectBookOpenPage"].ToString()));
            RtbPageData.LoadFile(stream, RichTextBoxStreamType.RichText);

            RtbPageData.AppendText("\n\n");

            DataTable pages = dbc.GetProjectPagesIDByProjectBookID(int.Parse(book["ProjectBookID"].ToString()));
            for(int i = 0; i < pages.Rows.Count; i++)
            {
                RtbPageData.AppendText("\n\n");
                MakePage(dbc.GetProjectPageByProjectPageID(int.Parse(pages.Rows[i][0].ToString())));
            }

            SaveFileDialog.FileName = book["ProjectBookName"].ToString() + " - " + book["ProjectBookYear"].ToString();
        }

        private void AppendText(string text, Font font)
        {
            RtbPageData.SelectionStart = RtbPageData.TextLength;
            RtbPageData.SelectionFont = font;
            RtbPageData.AppendText(text);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RtbPageData.SaveFile(SaveFileDialog.FileName+".rtf");
            }
        } 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
