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
    public partial class StudentForm : Form
    {
        DBConnection dbc = new DBConnection();
        string userID="";
        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(DataRow userRow)
        {
            InitializeComponent();
            this.userID = userRow["UserID"].ToString();
            lblWelcome.Text += " " + userRow["FirstName"].ToString();
            updateProjectPageDataGridView(dbc.getProjectPageByStudentID(userID));
        }

        private void updateProjectPageDataGridView(DataTable dt)
        {
            dgvProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvProjectPage.Rows.Add(dt.Rows[row]["ProjectPageID"], dt.Rows[row]["ProjectPageName"], dt.Rows[row]["ProjectPageCreationDate"], dt.Rows[row]["ProjectPageData"], "View" ,"Edit", "Delete");

                    if(dbc.isProjectPageLinkToBook(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())))
                    {
                        dgvProjectPage.Rows[row].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PageForm pageForm = new PageForm(userID);
            pageForm.ShowDialog();
            updateProjectPageDataGridView(dbc.getProjectPageByStudentID(userID));
        }

        private void dgvProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvProjectPage.Rows[e.RowIndex];
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()),true);
                viewPageForm.ShowDialog();
            }
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "Edit")
            {
                PageForm bookForm = new PageForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()),userID,selectedRow.Cells["PageName"].Value.ToString(), selectedRow.Cells["PageData"].Value.ToString(),(selectedRow.DefaultCellStyle.BackColor == Color.Gray ? true : false));
                bookForm.ShowDialog();
            }
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (!(dbc.isProjectPageLinkToBook(int.Parse(selectedRow.Cells["ID"].Value.ToString()))))
                {
                    if (MessageBox.Show("Are you sure you want to delete this page?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbc.deleteProjectPageByProjectPageID(int.Parse(selectedRow.Cells["ID"].Value.ToString()),userID);
                    }
                }
                else
                {
                    MessageBox.Show("You cant delete page that linked to a book");
                }
            }
            updateProjectPageDataGridView(dbc.getProjectPageByStudentID(userID));
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(int.Parse(Program.studentRole), userID);
            userForm.ShowDialog();
            lblWelcome.Text = "Welcome " + dbc.getUserByID(userID)["FirstName"].ToString();//name can change after update
        }
    }
}
