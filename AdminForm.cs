using Microsoft.VisualBasic;
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
    public partial class AdminForm : Form
    {
        DBConnection dbc = new DBConnection();
        public AdminForm()
        {
            InitializeComponent();
            updateUserDataGridView(dbc.getAllUsers());
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            updateUserDataGridView(dbc.getAllUsers());
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];
            if (dgvUsers.Columns[e.ColumnIndex].Name == "More")
            {
                if (selectedRow.Cells["Role"].Value.ToString() == "Student")
                {
                    ViewStudentPages viewStudentPages = new ViewStudentPages(selectedRow.Cells["UserID"].Value.ToString());
                    viewStudentPages.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is no more information");
                }
            }
            if (dgvUsers.Columns[e.ColumnIndex].Name == "Edit")
            {
                UserForm userForm = new UserForm(int.Parse(Program.adminRole), selectedRow.Cells["UserID"].Value.ToString());
                userForm.ShowDialog();
            }
            if (dgvUsers.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (selectedRow.Cells["Role"].Value.ToString() != "Admin")
                    {
                        dbc.deleteUserByID(selectedRow.Cells["UserID"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("You can't delete admin");
                    }
                }
            }
            updateUserDataGridView(dbc.getAllUsers());
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
    }
}
