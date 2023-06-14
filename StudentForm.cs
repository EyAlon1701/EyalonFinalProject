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
    public partial class StudentForm : Form
    {
        DBConnection dbc = new DBConnection();
        string userID = "";

        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(DataRow userRow)
        {
            InitializeComponent();
            BtnPartner.BackColor = Color.LightGreen;
            this.userID = userRow["UserID"].ToString();
            LblWelcome.Text += " " + userRow["FirstName"].ToString();
            UpdateProjectPageDataGridView(dbc.GetProjectPagesAndProjectBookIDByStudentID(userID));
        }

        //If there are partner requests the button will be visible otherwise not
        private void UpdatePartnerBtn(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                BtnPartner.Visible = false;
            }
            else
            {
                BtnPartner.Visible = true;
            }
        }

        private void UpdateProjectPageDataGridView(DataTable dt)
        {
            DgvProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DgvProjectPage.Rows.Add(dt.Rows[row]["ProjectPageID"], dt.Rows[row]["ProjectPageName"], dt.Rows[row]["ProjectPageCreationDate"], dt.Rows[row]["ProjectPageData"], dbc.GetProjectBookNameByID(int.Parse(dt.Rows[row]["ProjectBookID"].ToString())), dbc.GetPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()), userID), "View", "Edit", "Delete");

                    //UPDATE COLUMN PARTNER NAME STATUS(VALUE AND COLOR)
                    if (dbc.IsProjectPageHaveRejectFriendRequestByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())))
                    {
                        DgvProjectPage.Rows[row].Cells["PartnerDetails"].Value = "PARTNER REJECT THE INVITE";
                        DgvProjectPage.Rows[row].Cells["PartnerDetails"].Style.BackColor = Color.Red;
                    }
                    else if (dbc.IsProjectPageHaveFriendRequestByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())))
                    {
                        DgvProjectPage.Rows[row].Cells["PartnerDetails"].Value = "WAITING FOR PARTNER APPROVE!";
                        DgvProjectPage.Rows[row].Cells["PartnerDetails"].Style.BackColor = Color.Yellow;
                    }
                }
            }
            UpdatePartnerBtn(dbc.GetFriendRequestsProjectPagesIDByStudentIDAns(userID));
        }

        private void BtnAddPage_Click(object sender, EventArgs e)
        {
            PageForm pageForm = new PageForm(userID);
            pageForm.ShowDialog();
            UpdateProjectPageDataGridView(dbc.GetProjectPagesAndProjectBookIDByStudentID(userID));
        }

        private void DgvProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = DgvProjectPage.Rows[e.RowIndex];
            if (dbc.IsProjectPageHaveRejectFriendRequestByProjectPageID(int.Parse(selectedRow.Cells["ID"].Value.ToString())))
            {
                if (MessageBox.Show("Your Partner Reject The Friend Request To The Page", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dbc.DeleteProjectPageFriendRequest(int.Parse(selectedRow.Cells["ID"].Value.ToString()));
                }
            }
            if (DgvProjectPage.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()), true);
                viewPageForm.ShowDialog();
            }
            if (DgvProjectPage.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (dbc.IsProjectPageInTheFriendRequestHaveSameBookLikeMyProjectPage(userID, dbc.GetProjectBookIDByProjectPageID(int.Parse(selectedRow.Cells["ID"].Value.ToString()))))
                {
                    MessageBox.Show("You have partner request to other page in the same book \nPlease Approve/Reject the partner request For the page", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    PageForm pageForm = new PageForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()), userID, selectedRow.Cells["PageName"].Value.ToString(), selectedRow.Cells["PageData"].Value.ToString());
                    pageForm.ShowDialog();
                }
            }
            if (DgvProjectPage.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (!(dbc.IsProjectPageLinkToBook(int.Parse(selectedRow.Cells["ID"].Value.ToString()))))
                {
                    if (MessageBox.Show("Are you sure you want to delete this page?", "System message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbc.DeleteProjectPageByProjectPageIDAndStudentID(int.Parse(selectedRow.Cells["ID"].Value.ToString()), userID);
                    }
                }
                else
                {
                    MessageBox.Show("You cant delete page that linked to a book");
                }
            }
            UpdateProjectPageDataGridView(dbc.GetProjectPagesAndProjectBookIDByStudentID(userID));
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(int.Parse(Program.STUDENT_ROLE), userID);
            userForm.ShowDialog();
            LblWelcome.Text = "Welcome " + dbc.GetUserByID(userID)["FirstName"].ToString();//name can change after update
        }

        private void BtnPartner_Click(object sender, EventArgs e)
        {
            PartnerForm partnerForm = new PartnerForm(userID);
            partnerForm.ShowDialog();
            UpdateProjectPageDataGridView(dbc.GetProjectPagesAndProjectBookIDByStudentID(userID));
        }
    }
}
