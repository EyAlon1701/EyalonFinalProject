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
            DataTable dt = dbc.getProjectPageByStudentID(userID);
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvStuPages.Rows.Add(dt.Rows[row]["ProjectPageID"], dt.Rows[row]["ProjectPageName"], dbc.getLinkedProjectBookNameByProjectPageID(int.Parse(dt.Rows[row]["ProjectPageID"].ToString())), "View");
                }
            }
        }

        private void dgvStuPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvStuPages.Rows[e.RowIndex];
            if (dgvStuPages.Columns[e.ColumnIndex].Name == "View")
            {
                ViewPageForm viewPageForm = new ViewPageForm(int.Parse(selectedRow.Cells["PageID"].Value.ToString()), selectedRow.Cells["PageName"].Value.ToString(), (dbc.getProjectPageByID(int.Parse(selectedRow.Cells["PageID"].Value.ToString()))["ProjectPageData"]).ToString());
                viewPageForm.ShowDialog();
            }
        }
    }
}
