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
        public PartnerForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            dgvStudents.Visible = false;
            lblTitle.Text = "Partner Requests";
            btnDelRequest.Visible = false;
            updateProjectPageDataGridView(dbc.getFriendRequestsProjectPageIDByStudentIDAns(userID));
        }
        public PartnerForm(string userID,int pageID)
        {
            InitializeComponent();
            this.userID = userID;
            this.pageID = pageID;
            dgvFriendRequestProjectPage.Visible = false;
            btnDelRequest.Visible = false;
            lblTitle.Text = "Invite A Partner";
            if (dbc.getStudentByProjectPageID(pageID).Rows.Count == 2)
            {
                dgvStudents.Visible = false;
                btnDelRequest.Visible = true;
                lblTitle.Text = "Your Partner is \n" + dbc.getPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(pageID, userID);
                btnDelRequest.Text = "Delete Partner";
            }
            else if (dbc.isProjectPageHaveFriendRequestByProjectPageID(pageID))
            {
                dgvStudents.Visible = false;
                btnDelRequest.Visible = true;
                lblTitle.Text = "You Already Invite:\n" + dbc.getInvitedStudentIDAndName(pageID);
            }
            else
            {
                updateStudentsToInviteByIsPageLineToBook();
            }
        }
        private void updateStudentsToInviteByIsPageLineToBook()
        {
            if (dbc.isProjectPageLinkToBook(pageID))
            {
                updateStudentDataGridView(dbc.getStudentsOnSameBookThatDontHavePartnerExceptMyStudentIDByProjectBookID(userID, dbc.getProjectBookIDByProjectPageID(pageID)));
            }
            else
            {
                updateStudentDataGridView(dbc.getStudentsExceptMyStudentID(userID));
            }
        }

        private void updateStudentDataGridView(DataTable dt)
        {
            dgvStudents.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvStudents.Rows.Add(dt.Rows[row]["UserID"], dt.Rows[row]["FirstName"] + " " + dt.Rows[row]["LastName"], "Add");
                }
            }
        }

        private void updateProjectPageDataGridView(DataTable dt)
        {
            dgvFriendRequestProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {

                    DataTable stu = dbc.getStudentByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    DataRow page = dbc.getProjectPageAndProjectBookIDByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()));
                    dgvFriendRequestProjectPage.Rows.Add(stu.Rows[0]["UserID"].ToString(), stu.Rows[0]["FirstName"].ToString() + " " + stu.Rows[0]["LastName"].ToString(),page["ProjectPageID"],page["ProjectPageName"], dbc.getProjectBookNameByID(int.Parse(page["ProjectBookID"].ToString())), "Approve", "Reject");
                }
            }
            dgvFriendRequestProjectPage.Columns["Approve"].DefaultCellStyle.BackColor = Color.Green;
            dgvFriendRequestProjectPage.Columns["Reject"].DefaultCellStyle.BackColor = Color.Red;
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvStudents.Rows[e.RowIndex];
            if (dgvStudents.Columns[e.ColumnIndex].Name == "Add")
            {
                dbc.addProjectPageFriendRequest(pageID, userID, selectedRow.Cells["StudentID"].Value.ToString());
                this.Close();
            }
        }

        private void dgvFriendRequestProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvFriendRequestProjectPage.Rows[e.RowIndex];
            if (dgvFriendRequestProjectPage.Columns[e.ColumnIndex].Name == "Approve")
            {
                if (dbc.getStudentByProjectPageID(dbc.getMyProjectPageIDThatLinkToBookByProjectBookIDAndStudentID(userID, dbc.getProjectBookIDByProjectPageID(int.Parse(selectedRow.Cells["pageID"].Value.ToString())))).Rows.Count == 2)
                {
                    MessageBox.Show("You already have a partner to a page in the book", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool flag = false;
                    if (dbc.isProjectPageLinkToBook(int.Parse(selectedRow.Cells["pageID"].Value.ToString())))
                    {
                        if(MessageBox.Show("Are you sure you approve the friend request?\n(Your page linked to that book will be deleted (including the partner request if you have)!!!", "System message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            dbc.deleteProjectPageByProjectPageID(dbc.getMyProjectPageIDThatLinkToBookByProjectBookIDAndStudentID(userID, dbc.getProjectBookIDByProjectPageID(int.Parse(selectedRow.Cells["pageID"].Value.ToString()))));
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        dbc.addStudentProjectPage(userID, int.Parse(selectedRow.Cells["pageID"].Value.ToString()));
                        dbc.deleteProjectPageFriendRequest(int.Parse(selectedRow.Cells["pageID"].Value.ToString()));
                    }
                
                }
            }
            if (dgvFriendRequestProjectPage.Columns[e.ColumnIndex].Name == "Reject")
            {
                dbc.rejectInvite(int.Parse(selectedRow.Cells["pageID"].Value.ToString()));
            }
            if (dbc.getFriendRequestsProjectPageIDByStudentIDAns(userID).Rows.Count == 0)
            {
                this.Close();
            }
            updateProjectPageDataGridView(dbc.getFriendRequestsProjectPageIDByStudentIDAns(userID));
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if(dbc.isProjectPageHaveFriendRequestByProjectPageID(pageID))
            {
                if (MessageBox.Show("Are you sure you want to delete this invite?", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.deleteProjectPageFriendRequest(pageID);
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this partner from working together?", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.deletePartnerFromProjectPageByProjectPageIDAndMyStudentID(pageID, userID);
                    this.Close();
                }
            }
        }


    }
}
