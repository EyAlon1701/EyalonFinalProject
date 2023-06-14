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
            UpdateStudentsPagesDataGridView(dbc.GetUsersByRole(int.Parse(Program.STUDENT_ROLE)));
        }

        private void UpdateStudentsPagesDataGridView(DataTable dt)
        {
            DgvStudentsPages.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    if (!dbc.IsStudentLinkToBook(dt.Rows[row]["UserID"].ToString(), bookID))//TO NOT SHOW STUDENT THAT ALREADY LINK TO THE BOOK
                    {
                        DgvStudentsPages.Rows.Add(dt.Rows[row]["UserID"], dt.Rows[row]["FirstName"], dt.Rows[row]["LastName"], "Add");
                    }
                }
            }
        }

        private void DgvStudentsPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvStudentsPages.Rows[e.RowIndex];
            if (DgvStudentsPages.Columns[e.ColumnIndex].Name == "Add")
            {
                dbc.AddProjectPage(dbc.GetProjectBookNameByID(bookID), "");
                dbc.AddStudentProjectPage(selectedRow.Cells["UserID"].Value.ToString(), dbc.GetLastProjectPageID());
                dbc.AddProjectPageInBook(dbc.GetLastProjectPageID(), bookID);
                UpdateStudentsPagesDataGridView(dbc.GetUsersByRole(int.Parse(Program.STUDENT_ROLE)));
                if (DgvStudentsPages.Rows.Count == 0)//No more students to add
                {
                    this.Close();
                }
            }
        }

        private void BtnAddSelectedRows_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in DgvStudentsPages.SelectedRows)
            {
                dbc.AddProjectPage(dbc.GetProjectBookNameByID(bookID), "");
                dbc.AddStudentProjectPage(selectedRow.Cells["UserID"].Value.ToString(), dbc.GetLastProjectPageID());
                dbc.AddProjectPageInBook(dbc.GetLastProjectPageID(), bookID);
            }
            this.Close();
        }
    }
}
