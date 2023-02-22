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
    public partial class PageForm : Form
    {
        DBConnection dbc = new DBConnection();
        bool isAdd = true;
        string userID="";

        public PageForm()
        {
            InitializeComponent();
        }
        public PageForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if (isAdd)//true - add project book
            {
                int num = dbc.addProjectPage(txtPageName.Text, txtPageData.Text);
                if (num == 1)
                {
                    num = dbc.addStudentProjectPage(userID,dbc.getLastProjectPageID());
                    if (num == 1)
                    {
                        this.Close();
                    }
                    else
                    {
                        //NEED TO BE ERROR
                    }
                }
            }
            else // false - update project book
            {

            }
        }
    }
}
