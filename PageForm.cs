using Microsoft.VisualBasic.ApplicationServices;
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
            btnPartner.Enabled = false;
        }

        public PageForm(int pageID,string userID, string pageName, string pageData, string projectBookName, string partnerDetails)
        {
            InitializeComponent();
            this.pageID = pageID;//??
            this.userID = userID;
            txtPageName.Text = pageName;    
            rtfPageData.Text = pageData;
            btnSumbit.Text = "Update";
            isAdd = false;
            lblBookName.Text += projectBookName;
            lblPartnerDetails.Text += partnerDetails;
            MessageBox.Show(btnPartner.BackColor.ToString());
            MessageBox.Show(btnSumbit.BackColor.ToString());
            updateBtnPartnerColor();
        }

        private void updateBtnPartnerColor()
        {
            if(dbc.isProjectPageHaveRejectFriendRequestByProjectPageID(pageID))
            {
                btnPartner.BackColor = Color.Red;
            }
            else if (dbc.isProjectPageHaveFriendRequestByProjectPageID(pageID))
            {
                btnPartner.BackColor = Color.Yellow;
            }
            else
            {
                btnPartner.BackColor = Color.Transparent;
            }
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

        private void btnPartner_Click(object sender, EventArgs e)
        {
            PartnerForm partnerForm = new PartnerForm(userID,pageID);
            partnerForm.ShowDialog();
            updateBtnPartnerColor();
        }
    }
}
