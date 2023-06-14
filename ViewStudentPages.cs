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
    public partial class ViewStudentPages : Form
    {
        DBConnection dbc = new DBConnection();
        public ViewStudentPages(string userID)
        {
            InitializeComponent();

            DataRow user = dbc.GetUserByID(userID);
            this.Text = "Pages of " + user["UserID"] + " - " + user["FirstName"] + " " + user["LastName"];

            DataTable dt = dbc.GetProjectPagesAndProjectBookIDByStudentID(userID);
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    DgvStuPages.Rows.Add(dt.Rows[row]["ProjectPageID"], dt.Rows[row]["ProjectPageName"], dbc.GetProjectBookNameByID(int.Parse(dt.Rows[row]["ProjectBookID"].ToString())), dbc.GetPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString()), userID), "View");
                }
            }
        }

        private void DgvStuPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = DgvStuPages.Rows[e.RowIndex];
            if (DgvStuPages.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()),true);
                viewPageForm.ShowDialog();
            }
        }
    }
}
