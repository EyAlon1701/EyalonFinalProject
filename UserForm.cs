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
        bool isAdd = false;//false(0) - update | true - add

        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(Boolean isAdd)
        {
            InitializeComponent();
            this.isAdd = isAdd;
            if (isAdd)
            {
                btnSubmit.Text = "Add";
            }
        }
        public UserForm(int role,Boolean isAdd)
        {
            InitializeComponent();
            
            cbRole.SelectedIndex = role;
            if (role != int.Parse(Program.adminRole))
            {
                cbRole.Enabled = false;
            }
            this.isAdd = isAdd;
            if (isAdd)
            {
                btnSubmit.Text = "Add";
            }
        }

        public UserForm(String id, String firstName, String lastName, String email, String password, String imgPath, int role)
        {
            InitializeComponent();
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
