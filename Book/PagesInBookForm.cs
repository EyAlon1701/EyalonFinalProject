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
            updatePagesInBookDataGridView(dbc.getProjectPageIDByProjectBookID(bookID));
        }

        private void updatePagesInBookDataGridView(DataTable dt)
        {
            dgvPagesInBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    //CHECK!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    DataTable stu = dbc.getStudentByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    string stuID = "",stuName="";
                    for (int stuRow = 0; stuRow < stu.Rows.Count; stuRow++)//RN ONLY ONE USER PER PAGE
                    {
                        stuID = stu.Rows[stuRow]["UserID"].ToString();
                        stuName = stu.Rows[stuRow]["FirstName"].ToString() +  " " + stu.Rows[stuRow]["LastName"].ToString();
                    }
                    dgvPagesInBook.Rows.Add(dt.Rows[row]["ProjectPageID"].ToString(), stuID, stuName, dbc.getProjectPageNameByID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())), "View", "Delete");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPageToBookForm addPageToBookForm = new AddPageToBookForm(bookID);
            addPageToBookForm.ShowDialog();
            updatePagesInBookDataGridView(dbc.getProjectPageIDByProjectBookID(bookID));
        }

        private void dgvPagesInBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvPagesInBook.Rows[e.RowIndex];
            if (dgvPagesInBook.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()), true);
                viewPageForm.ShowDialog();
            }
            if (dgvPagesInBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this project page from the book?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.deleteProjectPageInBookByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()));
                    updatePagesInBookDataGridView(dbc.getProjectPageIDByProjectBookID(bookID));
                }
            }
        }
    }
}
