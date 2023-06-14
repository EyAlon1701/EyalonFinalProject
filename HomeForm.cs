using Microsoft.VisualBasic.Logging;
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
    public partial class HomeForm : Form
    {
        DBConnection dbc = new DBConnection();
        public HomeForm()
        {
            InitializeComponent();
            PnlLogin.Visible = true;
            PnlReg.Visible = false;
            PictureBox.Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = dbc.Login(TxtLoginID.Text,TxtLoginPassword.Text);
            if(dt.Rows.Count > 0)//User exist
            {
                this.Hide();
                if (dt.Rows[0]["Role"].ToString() == Program.STUDENT_ROLE)
                {
                    StudentForm studentForm = new StudentForm(dt.Rows[0]);
                    studentForm.ShowDialog();
                    HomeForm homeForm = new HomeForm();
                    homeForm.ShowDialog();
                }
                else if (dt.Rows[0]["Role"].ToString() == Program.LECTURER_ROLE)
                {
                    LecturerForm lecturerForm = new LecturerForm(dt.Rows[0]);
                    lecturerForm.ShowDialog();
                    HomeForm homeForm = new HomeForm();
                    homeForm.ShowDialog();
                }
                else if (dt.Rows[0]["Role"].ToString() == Program.ADMIN_ROLE)
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    HomeForm homeForm = new HomeForm();
                    homeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("The ID or password is incorrect");
            }
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (TxtRegID.Text == "" || TxtRegFirstName.Text == "" || TxtRegLastName.Text == "" || TxtRegEmail.Text == "" || TxtRegPassword.Text == "")
            {
                MessageBox.Show("You must fill in all fields (image is not required)", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(TxtRegID.Text.Length>9)
            {
                MessageBox.Show("The ID can't contain more than 9 characters", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int num = dbc.AddUser(TxtRegID.Text, TxtRegFirstName.Text, TxtRegLastName.Text, TxtRegEmail.Text, TxtRegPassword.Text, PictureBox.ImageLocation, int.Parse(Program.STUDENT_ROLE));
                if (num == 1)
                {
                    MessageBox.Show("Registration successfully completed. Sign in now");
                    PnlLogin.Visible = true;
                    PnlReg.Visible = false;
                    BtnRegImg.BackColor = SystemColors.Window;
                }
                else
                {
                    MessageBox.Show("ERROR", "System message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnGoLogin_Click(object sender, EventArgs e)
        {
            PnlLogin.Visible = true;
            PnlReg.Visible = false;
            BtnRegImg.BackColor = SystemColors.Window;
        }

        private void BtnGoReg_Click(object sender, EventArgs e)
        {
            PnlReg.Visible = true;
            PnlLogin.Visible = false;
        }

        private void BtnRegImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Picture | *.jpg; *.jpeg; *.png;";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = Image.FromFile(OpenFileDialog.FileName);
                PictureBox.ImageLocation = OpenFileDialog.FileName;
                BtnRegImg.BackColor = Color.Green;
            }
        }

        private void LblImg_MouseHover(object sender, EventArgs e)
        {
            PictureBox.Visible = true;
        }

        private void LblImg_MouseLeave(object sender, EventArgs e)
        {
            PictureBox.Visible = false;
        }
    }
}
