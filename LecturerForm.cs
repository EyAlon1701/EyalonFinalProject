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
        public LecturerForm()
        {
            InitializeComponent();
        }

        private void updateProjectBookDataGridView(DataTable dt)
        {
            dgvProjectBook.Rows.Clear();
            if (dt != null)
            {
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    dgvProjectBook.Rows.Add(dt.Rows[row]["ProjectBookID"], dt.Rows[row]["ProjectBookName"], dt.Rows[row]["ProjectBookYear"], dt.Rows[row]["ProjectBookOpenPage"], "Edit", "Delete");
                }
            }
        }

 
        private void dgvProjectBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(true);
            bookForm.ShowDialog();
            //updateUserDataGridView(dbc.getAllUsers());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            updateProjectBookDataGridView(dbc.getAllProjectBook());
        }
    }
}
