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
    public partial class PartnerForm : Form
    {
        DBConnection dbc = new DBConnection();
        string userID = "";
        int pageID = -1;

        public PartnerForm()
        {
            InitializeComponent();
        }

        //Show all the Partner Requests
        public PartnerForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            DgvStudents.Visible = false;
            LblTitle.Text = "Partner Requests";
            BtnDel.Visible = false;
            UpdateProjectPageDataGridView(dbc.GetFriendRequestsProjectPagesIDByStudentIDAns(userID));
        }

        //Show your partner/the partner you invited/list of students you can invite
        public PartnerForm(string userID, int pageID)
        {
            InitializeComponent();
            this.userID = userID;
            this.pageID = pageID;
            DgvFriendRequestProjectPage.Visible = false;
            BtnDel.Visible = false;
            LblTitle.Text = "Invite A Partner";
            if (dbc.GetStudentsByProjectPageID(pageID).Rows.Count == Program.MAX_STUDENTS_PER_PAGE)
            {
                DgvStudents.Visible = false;
                BtnDel.Visible = true;
                LblTitle.Text = "Your Partner is \n" + dbc.GetPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(pageID, userID);
                BtnDel.Text = "Delete Partner";
            }
            else if (dbc.IsProjectPageHaveFriendRequestByProjectPageID(pageID))
            {
                DgvStudents.Visible = false;
                BtnDel.Visible = true;
                LblTitle.Text = "You Already Invite:\n" + dbc.GetInvitedStudentIDAndName(pageID);
            }
            else
            {
                UpdateStudentsToInviteByIsPageLineToBook();
            }
        }

        /*
        This function show list of student that you can invite
        If my page link to book is show only students that have page in the same book and they dont have partner
        Otherwise it shows all students.
        */
        private void UpdateStudentsToInviteByIsPageLineToBook()
        {
            if (dbc.IsProjectPageLinkToBook(pageID))
            {
                UpdateStudentDataGridView(dbc.GetStudentsOnSameBookThatDontHavePartnerExceptMyStudentIDByProjectBookID(userID, dbc.GetProjectBookIDByProjectPageID(pageID)));
            }
            else
            {
                UpdateStudentDataGridView(dbc.GetStudentsExceptMyStudentID(userID));
            }
        }

        private void UpdateStudentDataGridView(DataTable dt)
        {
            DgvStudents.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DgvStudents.Rows.Add(dt.Rows[row]["UserID"], dt.Rows[row]["FirstName"] + " " + dt.Rows[row]["LastName"], "Add");
                }
            }
        }

        private void UpdateProjectPageDataGridView(DataTable dt)
        {
            DgvFriendRequestProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DataTable stu = dbc.GetStudentsByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    DataRow page = dbc.GetProjectPageAndProjectBookIDByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    DgvFriendRequestProjectPage.Rows.Add(stu.Rows[0]["UserID"].ToString(), stu.Rows[0]["FirstName"].ToString() + " " + stu.Rows[0]["LastName"].ToString(), page["ProjectPageID"], page["ProjectPageName"], dbc.GetProjectBookNameByID(int.Parse(page["ProjectBookID"].ToString())), "Approve", "Reject");
                }
            }
            DgvFriendRequestProjectPage.Columns["Approve"].DefaultCellStyle.BackColor = Color.Green;
            DgvFriendRequestProjectPage.Columns["Reject"].DefaultCellStyle.BackColor = Color.Red;
        }

        private void DgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvStudents.Rows[e.RowIndex];
            if (DgvStudents.Columns[e.ColumnIndex].Name == "Add")
            {
                dbc.AddProjectPageFriendRequest(pageID, userID, selectedRow.Cells["StudentID"].Value.ToString());
                this.Close();
            }
        }

        private void DgvFriendRequestProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvFriendRequestProjectPage.Rows[e.RowIndex];
            if (DgvFriendRequestProjectPage.Columns[e.ColumnIndex].Name == "Approve")
            {
                if (dbc.GetStudentsByProjectPageID(dbc.GetMyProjectPageIDThatLinkToBookByProjectBookIDAndStudentID(userID, dbc.GetProjectBookIDByProjectPageID(int.Parse(selectedRow.Cells["pageID"].Value.ToString())))).Rows.Count == 2)
                {
                    MessageBox.Show("You already have a partner to a page in the book", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool flag = false;
                    if (dbc.IsProjectPageLinkToBook(int.Parse(selectedRow.Cells["pageID"].Value.ToString())))
                    {
                        if (MessageBox.Show("Are you sure you approve the friend request?\n(Your page linked to that book will be deleted (including the partner request if you have)!!!", "System message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            dbc.DeleteProjectPageByProjectPageID(dbc.GetMyProjectPageIDThatLinkToBookByProjectBookIDAndStudentID(userID, dbc.GetProjectBookIDByProjectPageID(int.Parse(selectedRow.Cells["pageID"].Value.ToString()))));
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        dbc.AddStudentProjectPage(userID, int.Parse(selectedRow.Cells["pageID"].Value.ToString()));
                        dbc.DeleteProjectPageFriendRequest(int.Parse(selectedRow.Cells["pageID"].Value.ToString()));
                    }

                }
            }
            if (DgvFriendRequestProjectPage.Columns[e.ColumnIndex].Name == "Reject")
            {
                dbc.RejectInvite(int.Parse(selectedRow.Cells["pageID"].Value.ToString()));
            }
            if (dbc.GetFriendRequestsProjectPagesIDByStudentIDAns(userID).Rows.Count == 0)//No more friend requests
            {
                this.Close();
            }
            UpdateProjectPageDataGridView(dbc.GetFriendRequestsProjectPagesIDByStudentIDAns(userID));
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (dbc.IsProjectPageHaveFriendRequestByProjectPageID(pageID))
            {
                if (MessageBox.Show("Are you sure you want to delete this invite?", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.DeleteProjectPageFriendRequest(pageID);
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this partner from working together?", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.DeletePartnerFromProjectPageByProjectPageIDAndMyStudentID(pageID, userID);
                    this.Close();
                }
            }
        }
    }
}
