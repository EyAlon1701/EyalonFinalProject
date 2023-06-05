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
                    DataTable stu = dbc.getStudentByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
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
                /*
                PageForm bookForm = new PageForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()),selectedRow.Cells["PageName"].Value.ToString(), dbc.getProjectPageByID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()))["ProjectPageData"].ToString() , selectedRow.Cells["PageBookName"].Value.ToString());
                bookForm.ShowDialog();
                */
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
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            updateUserDataGridView(dbc.getAllUsers());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateUserDataGridView(dbc.getUsersByName(txtSearch.Text));
        }

        private void cbSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSelectTable.SelectedIndex==0) 
            {
                dgvUsers.Visible = true;
                dgvUsers.Enabled = true;//checl
                cbRole.Visible = true;
                dgvProjectBook.Visible = false;
                dgvProjectBook.Enabled = false;////checl
                dgvProjectPage.Visible = false;
                dgvProjectPage.Enabled = false;////check
                updateUserDataGridView(dbc.getAllUsers());
            }
            else if(cbSelectTable.SelectedIndex == 1) 
            {
                dgvUsers.Visible = false;
                dgvUsers.Enabled = false;
                cbRole.Visible = false;
                dgvProjectBook.Visible = true;
                dgvProjectBook.Enabled = true;
                dgvProjectPage.Visible = false;
                dgvProjectPage.Enabled = false;
                updateProjectBookDataGridView(dbc.getAllProjectBook());
            }
            else if(cbSelectTable.SelectedIndex == 2)
            {
                dgvUsers.Visible = false;
                dgvUsers.Enabled = false;
                cbRole.Visible = false;
                dgvProjectBook.Visible = false;
                dgvProjectBook.Enabled = false;
                dgvProjectPage.Visible = true;
                dgvProjectPage.Enabled = true;
                updateProjectPageDataGridView(dbc.getAllProjectPageAndProjectBookID());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            updateUserDataGridView(dbc.getAllUsers());
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
