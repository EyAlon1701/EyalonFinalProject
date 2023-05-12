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
    public partial class LecturerForm : Form
    {
        DBConnection dbc = new DBConnection();
        string userID = "";
        DataRow userRow = null;
        public LecturerForm()
        {
            InitializeComponent();
        }
        public LecturerForm(DataRow userRow)
        {
            InitializeComponent();
            this.userRow = userRow;
            this.userID = userRow["UserID"].ToString();
            lblWelcome.Text += " " + userRow["FirstName"].ToString();
            updateProjectBookDataGridView(dbc.getAllProjectBook());
        }

        private void updateProjectBookDataGridView(DataTable dt)
        {
            dgvProjectBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvProjectBook.Rows.Add(dt.Rows[row]["ProjectBookID"], dt.Rows[row]["ProjectBookName"], dt.Rows[row]["ProjectBookYear"], dt.Rows[row]["ProjectBookOpenPage"], "View","Edit", "Delete");
                }
            }
        }

 
        private void dgvProjectBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvProjectBook.Rows[e.RowIndex];
            if(dgvProjectBook.Columns[e.ColumnIndex].Name == "View")
            {
                ViewForm viewPageForm = new ViewForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()), false);
                viewPageForm.ShowDialog();
            }
            if (dgvProjectBook.Columns[e.ColumnIndex].Name == "Edit")
            {
                BookForm bookForm = new BookForm(int.Parse(selectedRow.Cells["ID"].Value.ToString()), selectedRow.Cells["BookName"].Value.ToString(), int.Parse(selectedRow.Cells["BookYear"].Value.ToString()), selectedRow.Cells["BookOpenPage"].Value.ToString());
                bookForm.ShowDialog();
            }
            if (dgvProjectBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this book?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbc.deleteProjectBookByProjectBookID(int.Parse(selectedRow.Cells["ID"].Value.ToString()));
                }
            }
            updateProjectBookDataGridView(dbc.getAllProjectBook());
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
            updateProjectBookDataGridView(dbc.getAllProjectBook());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            updateProjectBookDataGridView(dbc.getProjectBookByName(txtSearch.Text));
        }
    }
}
