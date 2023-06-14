using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        //ADD NEW USER
        public UserForm(int accessRole)
        {
            InitializeComponent();
            if (accessRole == int.Parse(Program.ADMIN_ROLE))
            {
                txtID.Enabled = true;
                cbRole.Enabled = true;
                cbRole.Items.RemoveAt(int.Parse(Program.ADMIN_ROLE));
                cbRole.SelectedIndex = 0;
            }
        }

        //UPDATE USER
        public UserForm(int accessRole, string userID)
        {
            InitializeComponent();
            DataRow userRow = dbc.getUserByID(userID);
            setData(userRow["UserID"].ToString(), userRow["FirstName"].ToString(), userRow["LastName"].ToString(), userRow["Email"].ToString(), userRow["Password"].ToString(), userRow["Image"].ToString(), int.Parse(userRow["Role"].ToString()));

            if(accessRole == int.Parse(Program.ADMIN_ROLE))
            {
                cbRole.Items.RemoveAt(int.Parse(Program.ADMIN_ROLE));
                cbRole.Enabled = true;
                if (cbRole.SelectedIndex == int.Parse(Program.ADMIN_ROLE))//If user is admin
                {
                    lblRole.Visible = false;
                    cbRole.Visible = false;
                }
            }
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
            if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("You must fill in all fields (image is not required)", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtID.Text.Length > 9)
            {
                MessageBox.Show("The ID can't contain more than 9 characters", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isAdd)//true - add user
                {
                    int num = dbc.addUser(txtID.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, pictureBox.ImageLocation, cbRole.SelectedIndex);
                    if (num == 1)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //false - update user
                {
                    dbc.updateUser(txtID.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, pictureBox.ImageLocation, cbRole.SelectedIndex);
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
