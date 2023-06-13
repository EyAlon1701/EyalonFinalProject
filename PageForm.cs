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
        string userID="";
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

        public PageForm(int pageID,string userID, string pageName, string pageData)
        {
            InitializeComponent();
            this.pageID = pageID;
            this.userID = userID;
            txtPageName.Text = pageName;    
            rtfPageData.Text = pageData;
            btnSumbit.Text = "Update";
            isAdd = false;
            lblBookName.Text += dbc.getProjectBookNameByID(dbc.getProjectBookIDByProjectPageID(pageID));
            updateBtnPartnerColorAndLblPartnerDetails();
        }

        private void updateBtnPartnerColorAndLblPartnerDetails()
        {
            lblPartnerDetails.Text = "PartnerDetails: " + dbc.getPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(pageID, userID);
            if (dbc.isProjectPageHaveFriendRequestByProjectPageID(pageID))
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
                dbc.addProjectPage(txtPageName.Text, rtfPageData.Text);
                dbc.addStudentProjectPage(userID,dbc.getLastProjectPageID());
                this.Close();
            }
            else //false - update project book
            {
                dbc.updateProjectPage(pageID, txtPageName.Text, rtfPageData.Text);
                this.Close();
            }
        }

        private void btnPartner_Click(object sender, EventArgs e)
        {
            PartnerForm partnerForm = new PartnerForm(userID,pageID);
            partnerForm.ShowDialog();
            updateBtnPartnerColorAndLblPartnerDetails();
        }
    }
}
