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
        string userID="";//???
        int pageID = -1;

        public PageForm()
        {
            InitializeComponent();
        }
        public PageForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public PageForm(int pageID, string pageName, string pageData, string projectBookName)
        {
            InitializeComponent();
            this.pageID = pageID;//??
            txtPageName.Text = pageName;    
            rtfPageData.Text = pageData;
            btnSumbit.Text = "Update";
            isAdd = false;
            lblBook.Text += projectBookName;
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if (isAdd)//true - add project book
            {
                int num = dbc.addProjectPage(txtPageName.Text, rtfPageData.Text);
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
                int num = dbc.updateProjectPage(pageID, txtPageName.Text, rtfPageData.Text);
                if(num == 1)
                {
                    this.Close();
                }
            }
        }
    }
}
