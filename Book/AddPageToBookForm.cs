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
    public partial class AddPageToBookForm : Form
    {
        DBConnection dbc = new DBConnection();
        int bookID = -1;
        public AddPageToBookForm(int bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
            updateStudentsPagesDataGridView(dbc.getUsersByRole(int.Parse(Program.studentRole)));
        }

        private void updateStudentsPagesDataGridView(DataTable dt)
        {
            dgvStudentsPages.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    if (!dbc.isStudentLinkToBook(dt.Rows[row]["UserID"].ToString(), bookID))//TO NOT SHOW STUDENT THAT ALREADY LINK TO THE BOOK
                    {
                        dgvStudentsPages.Rows.Add(dt.Rows[row]["UserID"], dt.Rows[row]["FirstName"], dt.Rows[row]["LastName"], "Add");
                    }
                }
            }
        }

        private void dgvStudentsPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvStudentsPages.Rows[e.RowIndex];
            if (dgvStudentsPages.Columns[e.ColumnIndex].Name == "Add")
            {
                dbc.addProjectPage(dbc.getProjectBookNameByID(bookID), "");
                dbc.addStudentProjectPage(selectedRow.Cells["UserID"].Value.ToString(), dbc.getLastProjectPageID());
                dbc.addProjectPageInBook(dbc.getLastProjectPageID(), bookID);
                updateStudentsPagesDataGridView(dbc.getUsersByRole(int.Parse(Program.studentRole)));
                if (dgvStudentsPages.Rows.Count == 0)
                {
                    this.Close();
                }
            }
        }

        private void btnAddSelectedRows_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvStudentsPages.SelectedRows)
            {
                dbc.addProjectPage(dbc.getProjectBookNameByID(bookID), "");
                dbc.addStudentProjectPage(selectedRow.Cells["UserID"].Value.ToString(), dbc.getLastProjectPageID());
                dbc.addProjectPageInBook(dbc.getLastProjectPageID(), bookID);
            }
            this.Close();
        }
    }
}
