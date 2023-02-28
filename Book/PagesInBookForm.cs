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
    public partial class PagesInBook : Form
    {
        DBConnection dbc = new DBConnection();
        int bookID = -1;

        public PagesInBook()
        {
            InitializeComponent();
        }
        public PagesInBook(int bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
        }

        private void updatePagesInBookDataGridView(DataTable dt)
        {
            dgvPagesInBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvPagesInBook.Rows.Add(1, "1", "1", dt.Rows[row]["ProjectPageID"], "View", "Delete");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPageToBookForm addPageToBookForm = new AddPageToBookForm(bookID);
            addPageToBookForm.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            updatePagesInBookDataGridView(dbc.getProjectPageByProjectBookID(bookID));
        }
    }
}
