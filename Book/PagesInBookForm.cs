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
            updatePagesInBookDataGridView(dbc.getProjectPagesIDByProjectBookID(bookID));
        }

        private void updatePagesInBookDataGridView(DataTable dt)
        {
            dgvPagesInBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataTable stu = dbc.getStudentsByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    string stuID = "",stuName="";
                    for (int stuRow = 0; stuRow < stu.Rows.Count; stuRow++)
                    {
                        stuID += stu.Rows[stuRow]["UserID"].ToString() + ", ";
                        stuName += stu.Rows[stuRow]["FirstName"].ToString() +  " " + stu.Rows[stuRow]["LastName"].ToString() + ", ";
                    }
                    stuID = stuID.Remove(stuID.Length - 2);
                    stuName = stuName.Remove(stuName.Length - 2);
                    dgvPagesInBook.Rows.Add(dt.Rows[row]["ProjectPageID"].ToString(), stuID, stuName, dbc.getProjectPageNameByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())), "View", "Delete");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPageToBookForm addPageToBookForm = new AddPageToBookForm(bookID);
            addPageToBookForm.ShowDialog();
            updatePagesInBookDataGridView(dbc.getProjectPagesIDByProjectBookID(bookID));
        }

        private void dgvPagesInBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

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
                    updatePagesInBookDataGridView(dbc.getProjectPagesIDByProjectBookID(bookID));
                }
            }
        }
    }
}
