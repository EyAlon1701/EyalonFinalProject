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
                TxtID.Enabled = true;
                CbRole.Enabled = true;
                CbRole.Items.RemoveAt(int.Parse(Program.ADMIN_ROLE));
                CbRole.SelectedIndex = 0;
            }
        }

        //UPDATE USER
        public UserForm(int accessRole, string userID)
        {
            InitializeComponent();
            DataRow userRow = dbc.GetUserByID(userID);
            SetData(userRow["UserID"].ToString(), userRow["FirstName"].ToString(), userRow["LastName"].ToString(), userRow["Email"].ToString(), userRow["Password"].ToString(), userRow["Image"].ToString(), int.Parse(userRow["Role"].ToString()));

            if(accessRole == int.Parse(Program.ADMIN_ROLE))
            {
                CbRole.Items.RemoveAt(int.Parse(Program.ADMIN_ROLE));
                CbRole.Enabled = true;
                if (CbRole.SelectedIndex == int.Parse(Program.ADMIN_ROLE))//If user is admin
                {
                    LblRole.Visible = false;
                    CbRole.Visible = false;
                }
            }
        }

        private void SetData(string id, string firstName, string lastName, string email, string password, string imgPath, int role)
        {
            TxtID.Text = id;
            TxtFirstName.Text = firstName;
            TxtLastName.Text = lastName;
            TxtEmail.Text = email;
            TxtPassword.Text = password;
            PictureBox.ImageLocation = imgPath;
            try
            {
                PictureBox.Image = Image.FromFile(imgPath);
            }
            catch (Exception error)
            {
            }
            CbRole.SelectedIndex = role;
            BtnSubmit.Text = "Update";
            isAdd = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "" || TxtFirstName.Text == "" || TxtLastName.Text == "" || TxtEmail.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("You must fill in all fields (image is not required)", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtID.Text.Length > 9)
            {
                MessageBox.Show("The ID can't contain more than 9 characters", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isAdd)//true - add user
                {
                    int num = dbc.AddUser(TxtID.Text, TxtFirstName.Text, TxtLastName.Text, TxtEmail.Text, TxtPassword.Text, PictureBox.ImageLocation, CbRole.SelectedIndex);
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
                    dbc.UpdateUser(TxtID.Text, TxtFirstName.Text, TxtLastName.Text, TxtEmail.Text, TxtPassword.Text, PictureBox.ImageLocation, CbRole.SelectedIndex);
                    this.Close();
                }
            }
        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Picture | *.jpg; *.jpeg; *.png;";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
                PictureBox.ImageLocation = OpenFileDialog.FileName;
            }
        }
    }
}
