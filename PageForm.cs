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
        //ADD NEW PAGE
        public PageForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            BtnPartner.Enabled = false;
        }
        //UPDATE PAGE
        public PageForm(int pageID,string userID, string pageName, string pageData)
        {
            InitializeComponent();
            this.pageID = pageID;
            this.userID = userID;
            TxtPageName.Text = pageName;    
            RtfPageData.Text = pageData;
            BtnSumbit.Text = "Update";
            isAdd = false;
            LblBookName.Text += dbc.GetProjectBookNameByID(dbc.GetProjectBookIDByProjectPageID(pageID));
            UpdateBtnPartnerColorAndLblPartnerDetails();
        }

        /*
        This function will set the details of the partner of the project page if there is a partner to the page
        Also If the page has a partner request that is waiting for approval the partner button will be yellow.
        */
        private void UpdateBtnPartnerColorAndLblPartnerDetails()
        {
            LblPartnerDetails.Text = "PartnerDetails: " + dbc.GetPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(pageID, userID);
            if (dbc.IsProjectPageHaveFriendRequestByProjectPageID(pageID))
            {
                BtnPartner.BackColor = Color.Yellow;
            }
            else
            {
                BtnPartner.BackColor = Color.Transparent;
            }
        }

        private void BtnSumbit_Click(object sender, EventArgs e)
        {
            if (TxtPageName.Text == "")
            {
                MessageBox.Show("You must fill in the page name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isAdd)//true - add project page
                {
                    int num = dbc.AddProjectPage(TxtPageName.Text, RtfPageData.Text);
                    if (num == 1)
                    {
                        dbc.AddStudentProjectPage(userID, dbc.GetLastProjectPageID());
                        this.Close();
                    }
                }
                else //false - update project page
                {
                    dbc.UpdateProjectPage(pageID, TxtPageName.Text, RtfPageData.Text);
                    this.Close();
                }
            }
        }

        private void BtnPartner_Click(object sender, EventArgs e)
        {
            PartnerForm partnerForm = new PartnerForm(userID,pageID);
            partnerForm.ShowDialog();
            UpdateBtnPartnerColorAndLblPartnerDetails();//In case you delete your partner from the page you need to reset the partner details to empty/if you invite someone the button need to change color
        }
    }
}
