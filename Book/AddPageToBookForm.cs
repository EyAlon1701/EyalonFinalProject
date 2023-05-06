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
            DataGridViewRow selectedRow = dgvStudentsPages.Rows[e.RowIndex];
            if (dgvStudentsPages.Columns[e.ColumnIndex].Name == "Add")
            {
                int res = dbc.addProjectPage(dbc.getProjectBookNameByID(bookID), "");
                if (res == 1)
                {
                    dbc.addStudentProjectPage(selectedRow.Cells["UserID"].Value.ToString(), dbc.getLastProjectPageID());
                    if(dbc.addProjectPageInBook(dbc.getLastProjectPageID(), bookID) == 1)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
