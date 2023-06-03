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
        string userID="";
        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(DataRow userRow)
        {
            InitializeComponent();
            btnPartner.BackColor = Color.LightGreen;
            this.userID = userRow["UserID"].ToString();
            lblWelcome.Text += " " + userRow["FirstName"].ToString();
            updateProjectPageDataGridView(dbc.getProjectPageAndProjectBookIDByStudentID(userID));
        }

        private void updatePartnerBtn(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                btnPartner.Visible = false;
            }
            else
            {
                btnPartner.Visible = true;
            }
        }

        private void updateProjectPageDataGridView(DataTable dt)
        {
            dgvProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvProjectPage.Rows.Add(dt.Rows[row]["ProjectPageID"], dt.Rows[row]["ProjectPageName"], dt.Rows[row]["ProjectPageCreationDate"], dt.Rows[row]["ProjectPageData"], dbc.getProjectBookNameByID(int.Parse(dt.Rows[row]["ProjectBookID"].ToString())),dbc.getPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()),userID), "View" ,"Edit", "Delete");

                    //UPDATE COLUMN PARTNER NAME STATUS(VALUE AND COLOR)
                    if (dbc.isProjectPageHaveRejectFriendRequestByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())))
                    {
                        dgvProjectPage.Rows[row].Cells["PartnerName"].Value = "PARTNER REJECT THE INVITE";
                        dgvProjectPage.Rows[row].Cells["PartnerName"].Style.BackColor = Color.Red;
                    }
                    else if(dbc.isProjectPageHaveFriendRequestByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())))
                    {
                        dgvProjectPage.Rows[row].Cells["PartnerName"].Value = "WAITING FOR PARTNER APPROVE!";
                        dgvProjectPage.Rows[row].Cells["PartnerName"].Style.BackColor = Color.Yellow;
                    }
                }
            }
            updatePartnerBtn(dbc.getFriendRequestsProjectPageIDByStudentIDAns(userID));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PageForm pageForm = new PageForm(userID);
            pageForm.ShowDialog();
            updateProjectPageDataGridView(dbc.getProjectPageAndProjectBookIDByStudentID(userID));
        }

        private void dgvProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvProjectPage.Rows[e.RowIndex];

            if (dbc.isProjectPageHaveRejectFriendRequestByProjectPageID(int.Parse(selectedRow.Cells["ID"].Value.ToString())))
            {
                if (MessageBox.Show("Your Partner Reject The Friend Request To The Page", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dbc.deleteProjectPageFriendRequest(int.Parse(selectedRow.Cells["ID"].Value.ToString()));
                }
            }

            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()),true);
                viewPageForm.ShowDialog();
            }
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "Edit")
            {
                PageForm pageForm = new PageForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()),userID,selectedRow.Cells["PageName"].Value.ToString(), selectedRow.Cells["PageData"].Value.ToString(), selectedRow.Cells["BookName"].Value.ToString());
                pageForm.ShowDialog();
            }
            if (dgvProjectPage.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (!(dbc.isProjectPageLinkToBook(int.Parse(selectedRow.Cells["ID"].Value.ToString()))))
                {
                    if (MessageBox.Show("Are you sure you want to delete this page?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dbc.deleteProjectPageByProjectPageIDAndStudentID(int.Parse(selectedRow.Cells["ID"].Value.ToString()),userID);
                    }
                }
                else
                {
                    MessageBox.Show("You cant delete page that linked to a book");
                }
            }
            updateProjectPageDataGridView(dbc.getProjectPageAndProjectBookIDByStudentID(userID));
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(int.Parse(Program.studentRole), userID);
            userForm.ShowDialog();
            lblWelcome.Text = "Welcome " + dbc.getUserByID(userID)["FirstName"].ToString();//name can change after update
        }

        private void btnPartner_Click(object sender, EventArgs e)
        {
            PartnerForm partnerForm = new PartnerForm(userID);
            partnerForm.ShowDialog();
            updateProjectPageDataGridView(dbc.getProjectPageAndProjectBookIDByStudentID(userID));
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
