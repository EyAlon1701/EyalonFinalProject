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
        //Tables
        public const int USERS_TABLE = 0;
        public const int BOOKS_TABLE = 1;
        public const int PAGES_TABLE = 2;

        public const int ALL_USERS = 3;

        DBConnection dbc = new DBConnection();
        int tableMod = USERS_TABLE;
        public AdminForm()
        {
            InitializeComponent();
            UpdateUserDataGridView(dbc.GetAllUsers());
            CbSelectTable.SelectedIndex = tableMod;
            CbRole.SelectedIndex = ALL_USERS;
        }

        private void UpdateUserDataGridView(DataTable dt)
        {
            DgvUsers.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DgvUsers.Rows.Add(dt.Rows[row]["UserID"], dt.Rows[row]["FirstName"], dt.Rows[row]["LastName"], dt.Rows[row]["Email"], dt.Rows[row]["Password"], dt.Rows[row]["Image"], dt.Rows[row]["Role"].ToString() == Program.STUDENT_ROLE ? "Student" : dt.Rows[row]["Role"].ToString() == Program.LECTURER_ROLE ? "Lecturer" : "Admin" , "More", "Edit", "Delete");
                }
            }
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

        private void UpdateProjectPageDataGridView(DataTable dt)
        {
            DgvProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataTable stu = dbc.GetStudentsByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    string stuID = "", stuName = "";
                    for (int stuRow = 0; stuRow < stu.Rows.Count; stuRow++)
                    {
                        stuID += stu.Rows[stuRow]["UserID"].ToString() + ", ";
                        stuName += stu.Rows[stuRow]["FirstName"].ToString() + " " + stu.Rows[stuRow]["LastName"].ToString() + ", ";
                    }
                    stuID = stuID.Remove(stuID.Length - 2);
                    stuName = stuName.Remove(stuName.Length - 2);
                    DgvProjectPage.Rows.Add(dt.Rows[row]["ProjectPageID"], stuID, stuName, dt.Rows[row]["ProjectPageName"], dt.Rows[row]["ProjectPageCreationDate"], dbc.GetProjectBookNameByID(int.Parse(dt.Rows[row]["ProjectBookID"].ToString())), "View", "Edit", "Delete");
                }
            }
        }

        private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvUsers.Rows[e.RowIndex];
            if (DgvUsers.Columns[e.ColumnIndex].Name == "MoreUser")
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
            if (DgvUsers.Columns[e.ColumnIndex].Name == "EditUser")
            {
                UserForm userForm = new UserForm(int.Parse(Program.ADMIN_ROLE), selectedRow.Cells["UserID"].Value.ToString());
                userForm.ShowDialog();
            }
            if (DgvUsers.Columns[e.ColumnIndex].Name == "DeleteUser")
            {
                if (selectedRow.Cells["Role"].Value.ToString() != "Admin")
                {
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbc.DeleteUserByID(selectedRow.Cells["UserID"].Value.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("You can't delete admin", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            UpdateUserDataGridView(dbc.GetAllUsers());
            CbRole.SelectedIndex = ALL_USERS;//SHOW ALL USERS
        }

        private void DgvProjectBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvProjectBook.Rows[e.RowIndex];
            if (DgvProjectBook.Columns[e.ColumnIndex].Name == "ViewBook")
            {
                ViewForm viewForm = new ViewForm(int.Parse(selectedRow.Cells["BookID"].Value.ToString()), false);
                viewForm.ShowDialog();
            }
            if (DgvProjectBook.Columns[e.ColumnIndex].Name == "EditBook")
            {
                BookForm bookForm = new BookForm(int.Parse(selectedRow.Cells["BookID"].Value.ToString()), selectedRow.Cells["BookName"].Value.ToString(), int.Parse(selectedRow.Cells["BookYear"].Value.ToString()), selectedRow.Cells["BookOpenPage"].Value.ToString());
                bookForm.ShowDialog();
            }
            if (DgvProjectBook.Columns[e.ColumnIndex].Name == "DeleteBook")
            {
                if (MessageBox.Show("Are you sure you want to delete this book?", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.DeleteProjectBookByProjectBookID(int.Parse(selectedRow.Cells["BookID"].Value.ToString()));
                }
            }
            UpdateProjectBookDataGridView(dbc.GetAllProjectBook());
        }

        private void DgvProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvProjectPage.Rows[e.RowIndex];
            if (DgvProjectPage.Columns[e.ColumnIndex].Name == "ViewPage")
            {
                ViewForm viewForm = new ViewForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()),true);
                viewForm.ShowDialog();
            }
            if (DgvProjectPage.Columns[e.ColumnIndex].Name == "EditPage")
            {
                PageForm pageForm = new PageForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()), dbc.GetStudentsByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString())).Rows[0]["UserID"].ToString(), dbc.GetProjectPageByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()))["ProjectPageData"].ToString() , selectedRow.Cells["PageBookName"].Value.ToString());
                pageForm.ShowDialog();
            }
            if (DgvProjectPage.Columns[e.ColumnIndex].Name == "DeletePage")
            {
                if (MessageBox.Show("Are you sure you want to delete this page?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.DeleteProjectPageByProjectPageID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()));
                }
            }
            UpdateProjectPageDataGridView(dbc.GetAllProjectPageAndProjectBookID());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CbSelectTable.SelectedIndex == USERS_TABLE)//ADD USER
            {
                UserForm userForm = new UserForm(int.Parse(Program.ADMIN_ROLE));
                userForm.ShowDialog();
                UpdateUserDataGridView(dbc.GetAllUsers());
            }
            else if (CbSelectTable.SelectedIndex == BOOKS_TABLE)//ADD BOOK
            {
                BookForm bookForm = new BookForm();
                bookForm.ShowDialog();
                UpdateProjectBookDataGridView(dbc.GetAllProjectBook());
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(CbSelectTable.SelectedIndex == USERS_TABLE)
            {
                if(CbRole.SelectedIndex == ALL_USERS)
                {
                    UpdateUserDataGridView(dbc.GetUsersByName(TxtSearch.Text));
                }
                else //Search user by role and name
                {
                    UpdateUserDataGridView(dbc.GetUsersByRoleAndName(CbRole.SelectedIndex,TxtSearch.Text));
                }
            }
            else if (CbSelectTable.SelectedIndex == BOOKS_TABLE)
            {
                UpdateProjectBookDataGridView(dbc.GetProjectBooksByName(TxtSearch.Text));
            }
            else if(CbSelectTable.SelectedIndex == PAGES_TABLE)
            {
                UpdateProjectPageDataGridView(dbc.GetProjectPagesAndProjectBookIDByProjectPageName(TxtSearch.Text));
            }
        }

        private void CbSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbSelectTable.SelectedIndex==USERS_TABLE)
            {
                DgvUsers.Visible = true;
                DgvProjectBook.Visible = false;
                DgvProjectPage.Visible = false;
                CbRole.Visible = true;
                LblSearch.Text = "Search:";
                BtnAdd.Text = "Add User";
                BtnAdd.Visible = true;
                UpdateUserDataGridView(dbc.GetAllUsers());
            }
            else if(CbSelectTable.SelectedIndex == BOOKS_TABLE)
            {
                DgvUsers.Visible = false;
                DgvProjectBook.Visible = true;
                DgvProjectPage.Visible = false;
                CbRole.Visible=false;
                LblSearch.Text = "Search book by name:";
                BtnAdd.Text = "Add Book";
                BtnAdd.Visible = true;
                UpdateProjectBookDataGridView(dbc.GetAllProjectBook());
            }
            else if(CbSelectTable.SelectedIndex == PAGES_TABLE)
            {
                DgvUsers.Visible = false;
                DgvProjectBook.Visible = false;
                DgvProjectPage.Visible = true;
                CbRole.Visible = false;
                LblSearch.Text = "Search page by name:";
                BtnAdd.Visible = false;
                UpdateProjectPageDataGridView(dbc.GetAllProjectPageAndProjectBookID());
            }
        }

        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbRole.SelectedIndex == int.Parse(Program.STUDENT_ROLE))
            {
                UpdateUserDataGridView(dbc.GetUsersByRole(int.Parse(Program.STUDENT_ROLE)));
            }
            else if(CbRole.SelectedIndex == int.Parse(Program.LECTURER_ROLE))
            {
                UpdateUserDataGridView(dbc.GetUsersByRole(int.Parse(Program.LECTURER_ROLE)));
            }
            else if (CbRole.SelectedIndex == int.Parse(Program.ADMIN_ROLE))
            {
                UpdateUserDataGridView(dbc.GetUsersByRole(int.Parse(Program.ADMIN_ROLE)));
            }
            else
            {
                UpdateUserDataGridView(dbc.GetAllUsers());
            }
        }
    }
}
