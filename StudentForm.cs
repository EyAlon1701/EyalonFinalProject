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
        DataRow userRow = null;
        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(DataRow userRow)
        {
            InitializeComponent();
            this.userRow = userRow;
            this.userID = userRow["UserID"].ToString();
            lblWelcome.Text += " " + userRow["FirstName"].ToString();
        }

        private void updateProjectPageDataGridView(DataTable dt)
        {
            dgvProjectPage.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvProjectPage.Rows.Add(dt.Rows[row]["ProjectPageID"], dt.Rows[row]["ProjectPageName"], dt.Rows[row]["ProjectPageCreationDate"], dt.Rows[row]["ProjectPageData"], "Edit", "Delete");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PageForm pageForm = new PageForm(userID);
            pageForm.ShowDialog();
        }

        private void dgvProjectPage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            updateProjectPageDataGridView(dbc.getProjectPageByID(userID));
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(int.Parse(Program.studentRole), userID);
            userForm.ShowDialog();
        }
    }
}
