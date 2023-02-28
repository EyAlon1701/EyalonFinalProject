using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public BookForm(int bookID,string bookName,string bookYear,string bookOpenPage)
        {
            InitializeComponent();
            this.bookID = bookID;
            txtBookName.Text = bookName;
            txtBookYear.Text = bookYear;
            txtOpenPage.Text = bookOpenPage;
            btnSumbit.Text = "Update";
            isAdd = false;
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if (isAdd)//true - add project book
            {
                int num = dbc.addProjectBook(txtBookName.Text, txtBookYear.Text, txtOpenPage.Text);
                if (num == 1)
                {
                    this.Close();
                }
            }
            else // false - update project book
            {

            }
        }

        private void btnPages_Click(object sender, EventArgs e)
        {
            PagesInBook pagesInBook = new PagesInBook(bookID);
            pagesInBook.ShowDialog();
        }
    }
}
