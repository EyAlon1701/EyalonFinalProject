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
    public partial class PagesInBookForm : Form
    {
        DBConnection dbc = new DBConnection();
        int bookID = -1;

        public PagesInBookForm()
        {
            InitializeComponent();
        }
        public PagesInBookForm(int bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
            UpdatePagesInBookDataGridView(dbc.GetProjectPagesIDByProjectBookID(bookID));
        }

        private void UpdatePagesInBookDataGridView(DataTable dt)
        {
            DgvPagesInBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataTable stu = dbc.GetStudentsByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    string stuID = "",stuName="";
                    for (int stuRow = 0; stuRow < stu.Rows.Count; stuRow++)
                    {
                        stuID += stu.Rows[stuRow]["UserID"].ToString() + ", ";
                        stuName += stu.Rows[stuRow]["FirstName"].ToString() +  " " + stu.Rows[stuRow]["LastName"].ToString() + ", ";
                    }
                    stuID = stuID.Remove(stuID.Length - 2);
                    stuName = stuName.Remove(stuName.Length - 2);
                    DgvPagesInBook.Rows.Add(dt.Rows[row]["ProjectPageID"].ToString(), stuID, stuName, dbc.GetProjectPageNameByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())), "View", "Delete");
                }
            }
        }

        private void BtnAddPageToBook_Click(object sender, EventArgs e)
        {
            AddPageToBookForm addPageToBookForm = new AddPageToBookForm(bookID);
            addPageToBookForm.ShowDialog();
            UpdatePagesInBookDataGridView(dbc.GetProjectPagesIDByProjectBookID(bookID));
        }

        private void DgvPagesInBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvPagesInBook.Rows[e.RowIndex];
            if (DgvPagesInBook.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()), true);
                viewPageForm.ShowDialog();
            }
            if (DgvPagesInBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this project page from the book?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.DeleteProjectPageInBookByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()));
                    UpdatePagesInBookDataGridView(dbc.GetProjectPagesIDByProjectBookID(bookID));
                }
            }
        }
    }
}
