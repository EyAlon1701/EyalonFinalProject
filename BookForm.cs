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
    public partial class BookForm : Form
    {
        DBConnection dbc = new DBConnection();
        bool isAdd = false;//false(0) - update | true - add
        public BookForm()
        {
            InitializeComponent();
        }
        public BookForm(Boolean isAdd)
        {
            InitializeComponent();
            this.isAdd = isAdd;
            if (isAdd)
            {
                btnSubmit.Text = "Add";
            }
        }

        public BookForm(string bookName,string bookYear,string bookOpenPage)
        {
            InitializeComponent();
            txtBookName.Text = bookName;
            txtBookYear.Text = bookYear;
            txtOpenPage.Text = bookOpenPage;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isAdd)//true - add project book
            {
                int num = dbc.addProjectBook(txtBookName.Text, txtBookYear.Text, txtOpenPage.Text);
                if (num == 1)
                {
                    this.Close();
                }
            }
            else // false - update project book
            {

            }
        }
    }
}
