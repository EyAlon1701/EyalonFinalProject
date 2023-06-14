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
    public partial class LecturerForm : Form
    {
        DBConnection dbc = new DBConnection();
        string userID = "";

        public LecturerForm()
        {
            InitializeComponent();
        }

        public LecturerForm(DataRow userRow)
        {
            InitializeComponent();
            this.userID = userRow["UserID"].ToString();
            LblWelcome.Text += " " + userRow["FirstName"].ToString();
            UpdateProjectBookDataGridView(dbc.GetAllProjectBook());
        }

        private void UpdateProjectBookDataGridView(DataTable dt)
        {
            DgvProjectBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DgvProjectBook.Rows.Add(dt.Rows[row]["ProjectBookID"], dt.Rows[row]["ProjectBookName"], dt.Rows[row]["ProjectBookYear"], dt.Rows[row]["ProjectBookOpenPage"], "View", "Edit", "Delete");
                }
            }
        }


        private void DgvProjectBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = DgvProjectBook.Rows[e.RowIndex];
            if (DgvProjectBook.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()), false);
                viewPageForm.ShowDialog();
            }
            if (DgvProjectBook.Columns[e.ColumnIndex].Name == "Edit")
            {
                BookForm bookForm = new BookForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()), selectedRow.Cells["BookName"].Value.ToString(), int.Parse(selectedRow.Cells["BookYear"].Value.ToString()), selectedRow.Cells["BookOpenPage"].Value.ToString());
                bookForm.ShowDialog();
            }
            if (DgvProjectBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this book?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.DeleteProjectBookByProjectBookID(int.Parse(selectedRow.Cells["ID"].Value.ToString()));
                }
            }
            UpdateProjectBookDataGridView(dbc.GetAllProjectBook());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
            UpdateProjectBookDataGridView(dbc.GetAllProjectBook());
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateProjectBookDataGridView(dbc.GetProjectBooksByName(TxtSearch.Text));
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(int.Parse(Program.LECTURER_ROLE), userID);
            userForm.ShowDialog();
            LblWelcome.Text = "Welcome " + dbc.GetUserByID(userID)["FirstName"].ToString();//name can change after update
        }
    }
}
