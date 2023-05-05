using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyalonFinalProject
{
    public partial class BookForm : Form
    {
        DBConnection dbc = new DBConnection();
        bool isAdd = true;
        int bookID = -1;
        public BookForm()
        {
            InitializeComponent();
            btnPages.Enabled = false;
        }

        public BookForm(int bookID, string bookName, int bookYear, string bookOpenPage)
        {
            InitializeComponent();
            this.bookID = bookID;
            txtBookName.Text = bookName;
            txtBookYear.Text = bookYear.ToString();
            try
            {
                MemoryStream stream = new MemoryStream(ASCIIEncoding.Default.GetBytes(bookOpenPage));
                rtbOpenPage.LoadFile(stream, RichTextBoxStreamType.RichText);
            }
            catch
            {
                rtbOpenPage.Text = "";
            }
            btnSumbit.Text = "Update";
            isAdd = false;
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd)//true - add project book
                {
                    int num = dbc.addProjectBook(txtBookName.Text, int.Parse(txtBookYear.Text), rtbOpenPage.Rtf);
                    if (num == 1)
                    {
                        this.Close();
                    }
                }
                else // false - update project books
                {
                    int num = dbc.updateProjectBook(bookID, txtBookName.Text, int.Parse(txtBookYear.Text), rtbOpenPage.Rtf);
                    if (num == 1)
                    {
                        this.Close();
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("You need to enter a year as an integer","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void btnPages_Click(object sender, EventArgs e)
        {
            PagesInBook pagesInBook = new PagesInBook(bookID);
            pagesInBook.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbOpenPage.SelectionFont = fontDialog1.Font;
            }
        }
    }
}

