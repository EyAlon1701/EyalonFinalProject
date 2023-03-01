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
            updatePagesInBookDataGridView(dbc.getProjectPageByProjectBookID(bookID));
        }

        private void updatePagesInBookDataGridView(DataTable dt)
        {
            dgvPagesInBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataTable stu = dbc.getStudentByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    string stuID = "",stuName="";
                    for (int stuRow = 0; stuRow < stu.Rows.Count; stuRow++)//RN ONLY ONE USER PER PAGE
                    {
                        stuID = stu.Rows[stuRow]["UserID"].ToString();
                        stuName = stu.Rows[stuRow]["FirstName"].ToString() +  " " + stu.Rows[stuRow]["LastName"].ToString();
                    }
                    dgvPagesInBook.Rows.Add(dt.Rows[row]["ID"], stuID, stuName, dbc.getProjectPageNameByID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())), "View", "Delete");
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
