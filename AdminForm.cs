using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EyalonFinalProject
{
    public partial class AdminForm : Form
    {
        DBConnection dbc = new DBConnection();
        int tableMod = 0; //DEFAULT 0-USERS
        public AdminForm()
        {
            InitializeComponent();
            updateUserDataGridView(dbc.getAllUsers());
            cbSelectTable.SelectedIndex = tableMod;
            cbRole.SelectedIndex = 3;
        }

        private void updateUserDataGridView(DataTable dt)
        {
            dgvUsers.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvUsers.Rows.Add(dt.Rows[row]["UserID"], dt.Rows[row]["FirstName"], dt.Rows[row]["LastName"], dt.Rows[row]["Email"], dt.Rows[row]["Password"], dt.Rows[row]["Image"], dt.Rows[row]["Role"].ToString() == Program.studentRole ? "Student" : dt.Rows[row]["Role"].ToString() == Program.lecturerRole ? "Lecturer" : "Admin" , "More", "Edit", "Delete");
                }
            }
        }

        private void updateProjectBookDataGridView(DataTable dt)
        {
            dgvProjectBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvProjectBook.Rows.Add(dt.Rows[row]["ProjectBookID"], dt.Rows[row]["ProjectBookName"], dt.Rows[row]["ProjectBookYear"], dt.Rows[row]["ProjectBookOpenPage"], "View", "Edit", "Delete");
                }
            }
        }

        private void updateProjectPageDataGridView(DataTable dt)
        {
            dgvProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataTable stu = dbc.getStudentsByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    string stuID = "", stuName = "";
                    for (int stuRow = 0; stuRow < stu.Rows.Count; stuRow++)
                    {
                        stuID += stu.Rows[stuRow]["UserID"].ToString() + ", ";
                        stuName += stu.Rows[stuRow]["FirstName"].ToString() + " " + stu.Rows[stuRow]["LastName"].ToString() + ", ";
                    }
                    stuID = stuID.Remove(stuID.Length - 2);
                    stuName = stuName.Remove(stuName.Length - 2);
                    dgvProjectPage.Rows.Add(dt.Rows[row]["ProjectPageID"], stuID, stuName, dt.Rows[row]["ProjectPageName"], dt.Rows[row]["ProjectPageCreationDate"], dbc.getProjectBookNameByID(int.Parse(dt.Rows[row]["ProjectBookID"].ToString())), "View", "Edit", "Delete");
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];
            if (dgvUsers.Columns[e.ColumnIndex].Name == "MoreUser")
            {
                if (selectedRow.Cells["Role"].Value.ToString() == "Student")
                {
                    ViewStudentPages viewStudentPages = new ViewStudentPages(selectedRow.Cells["UserID"].Value.ToString());
                    viewStudentPages.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is no more information","System message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            if (dgvUsers.Columns[e.ColumnIndex].Name == "EditUser")
            {
                UserForm userForm = new UserForm(int.Parse(Program.adminRole), selectedRow.Cells["UserID"].Value.ToString());
                userForm.ShowDialog();
            }
            if (dgvUsers.Columns[e.ColumnIndex].Name == "DeleteUser")
            {
                if (selectedRow.Cells["Role"].Value.ToString() != "Admin")
                {
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbc.deleteUserByID(selectedRow.Cells["UserID"].Value.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("You can't delete admin", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            updateUserDataGridView(dbc.getAllUsers());
        }

        private void dgvProjectBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvProjectBook.Rows[e.RowIndex];
            if (dgvProjectBook.Columns[e.ColumnIndex].Name == "ViewBook")
            {
                ViewForm viewForm = new ViewForm(int.Parse(selectedRow.Cells["BookID"].Value.ToString()), false);
                viewForm.ShowDialog();
            }
            if (dgvProjectBook.Columns[e.ColumnIndex].Name == "EditBook")
            {

                BookForm bookForm = new BookForm(int.Parse(selectedRow.Cells["BookID"].Value.ToString()), selectedRow.Cells["BookName"].Value.ToString(), int.Parse(selectedRow.Cells["BookYear"].Value.ToString()), selectedRow.Cells["BookOpenPage"].Value.ToString());
                bookForm.ShowDialog();
            }
            if (dgvProjectBook.Columns[e.ColumnIndex].Name == "DeleteBook")
            {
                if (MessageBox.Show("Are you sure you want to delete this book?", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.deleteProjectBookByProjectBookID(int.Parse(selectedRow.Cells["BookID"].Value.ToString()));
                }
            }
            updateProjectBookDataGridView(dbc.getAllProjectBook());
        }

        private void dgvProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvProjectPage.Rows[e.RowIndex];
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "ViewPage")
            {
                ViewForm viewForm = new ViewForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()),true);
                viewForm.ShowDialog();
            }
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "EditPage")
            {
                PageForm pageForm = new PageForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()), dbc.getStudentsByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString())).Rows[0]["UserID"].ToString(), dbc.getProjectPageByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()))["ProjectPageData"].ToString() , selectedRow.Cells["PageBookName"].Value.ToString());
                pageForm.ShowDialog();
            }
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "DeletePage")
            {
                if (MessageBox.Show("Are you sure you want to delete this page?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.deleteProjectPageByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()));
                }
            }
            updateProjectPageDataGridView(dbc.getAllProjectPageAndProjectBookID());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbSelectTable.SelectedIndex == 0) // USERS
            {
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
                updateUserDataGridView(dbc.getAllUsers());
            }
            else if (cbSelectTable.SelectedIndex == 1) // BOOKS
            {
                BookForm bookForm = new BookForm();
                bookForm.ShowDialog();
                updateProjectBookDataGridView(dbc.getAllProjectBook());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(cbSelectTable.SelectedIndex == 0) // USERS
            {
                if(cbRole.SelectedIndex == 3) //ALL USERS
                {
                    updateUserDataGridView(dbc.getUsersByName(txtSearch.Text));
                }
                else //user by role
                {
                    updateUserDataGridView(dbc.getUsersByRoleAndName(cbRole.SelectedIndex,txtSearch.Text));
                }
            }
            else if (cbSelectTable.SelectedIndex == 1) // BOOKS
            {
                updateProjectBookDataGridView(dbc.getProjectBooksByName(txtSearch.Text));
            }
            else if(cbSelectTable.SelectedIndex == 2) // PAGES
            {
                updateProjectPageDataGridView(dbc.getProjectPagesAndProjectBookIDByProjectPageName(txtSearch.Text));
            }
        }

        private void cbSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSelectTable.SelectedIndex==0) // USERS
            {
                dgvUsers.Visible = true;
                dgvProjectBook.Visible = false;
                dgvProjectPage.Visible = false;
                cbRole.Visible = true;
                lblSearch.Text = "Search by:";
                btnAdd.Text = "Add User";
                btnAdd.Visible = true;
                updateUserDataGridView(dbc.getAllUsers());
            }
            else if(cbSelectTable.SelectedIndex == 1) // BOOKS
            {
                dgvUsers.Visible = false;
                dgvProjectBook.Visible = true;
                dgvProjectPage.Visible = false;
                cbRole.Visible=false;
                lblSearch.Text = "Search book by name:";
                btnAdd.Text = "Add Book";
                btnAdd.Visible = true;
                updateProjectBookDataGridView(dbc.getAllProjectBook());
            }
            else if(cbSelectTable.SelectedIndex == 2) // PAGES
            {
                dgvUsers.Visible = false;
                dgvProjectBook.Visible = false;
                dgvProjectPage.Visible = true;
                cbRole.Visible = false;
                lblSearch.Text = "Search page by name:";
                btnAdd.Visible = false;
                updateProjectPageDataGridView(dbc.getAllProjectPageAndProjectBookID());
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex == int.Parse(Program.studentRole))
            {
                updateUserDataGridView(dbc.getUsersByRole(int.Parse(Program.studentRole)));
            }
            else if(cbRole.SelectedIndex == int.Parse(Program.lecturerRole))
            {
                updateUserDataGridView(dbc.getUsersByRole(int.Parse(Program.lecturerRole)));
            }
            else if (cbRole.SelectedIndex == int.Parse(Program.adminRole))
            {
                updateUserDataGridView(dbc.getUsersByRole(int.Parse(Program.adminRole)));
            }
            else
            {
                updateUserDataGridView(dbc.getAllUsers());
            }
        }
    }
}
