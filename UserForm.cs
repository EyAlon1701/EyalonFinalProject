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
    public partial class UserForm : Form
    {
        DBConnection dbc = new DBConnection();
        bool isAdd = true;

        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(int accessRole, string userID)
        {
            InitializeComponent();
            if(accessRole == int.Parse(Program.studentRole))
            {
                txtID.Enabled = false;
                cbRole.Enabled = false;
            }
            //ELSE LEC NOT ABLE PUT ADMIN!!!

            DataRow userRow = dbc.getUserByID(userID);
            setData(userRow["UserID"].ToString(), userRow["FirstName"].ToString(), userRow["LastName"].ToString(), userRow["Email"].ToString(), userRow["Password"].ToString(), userRow["Image"].ToString(), int.Parse(userRow["Role"].ToString()));
        }

        private void setData(string id, string firstName, string lastName, string email, string password, string imgPath, int role)
        {
            txtID.Text = id;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtEmail.Text = email;
            txtPassword.Text = password;
            pictureBox.ImageLocation = imgPath;
            try
            {
                pictureBox.Image = Image.FromFile(imgPath);
            }
            catch (Exception error)
            {
            }
            cbRole.SelectedIndex = role;
            btnSubmit.Text = "Update";
            isAdd = false;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isAdd)//true - add user
            {
                int num = dbc.addUser(txtID.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, pictureBox.ImageLocation, cbRole.SelectedIndex);
                if (num == 1)
                {
                    this.Close();
                }
            }
            else // false - update user
            {
                int num = dbc.updateUser(txtID.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, pictureBox.ImageLocation, cbRole.SelectedIndex);
                if (num == 1)
                {
                    this.Close();
                }
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Picture | *.jpg; *.jpeg; *.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
