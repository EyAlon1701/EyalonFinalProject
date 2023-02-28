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
    public partial class AddPageToBookForm : Form
    {
        DBConnection dbc = new DBConnection();
        int bookID = -1;
        public AddPageToBookForm(int bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
            updateStudentsPagesDataGridView(dbc.getUsersByRole(int.Parse(Program.studentRole)));
        }

        private void updateStudentsPagesDataGridView(DataTable dt)
        {
            dgvStudentsPages.Rows.Clear();
            DataGridViewComboBoxColumn combo = null;
            if (dt != null)
            {
                combo = new DataGridViewComboBoxColumn();
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    combo.Items.Add("New Page");
                    dgvStudentsPages.Rows.Add(dt.Rows[row]["UserID"], dt.Rows[row]["FirstName"], dt.Rows[row]["LastName"], combo, "Add");
                }
            }
        }

        private void dgvStudentsPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
