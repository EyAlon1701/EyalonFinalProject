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
            pnlLogin.Visible = true;
            pnlReg.Visible = false;
            pictureBox.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = dbc.login(txtLoginID.Text,txtLoginPassword.Text);
            if(dt.Rows.Count > 0)
            {
                this.Hide();
                if (dt.Rows[0]["Role"].ToString() == Program.studentRole)
                {
                    StudentForm studentForm = new StudentForm(dt.Rows[0]);
                    studentForm.ShowDialog();
                    HomeForm homeForm = new HomeForm();
                    homeForm.ShowDialog();
                }
                else if (dt.Rows[0]["Role"].ToString() == Program.lecturerRole)
                {
                    LecturerForm lecturerForm = new LecturerForm(dt.Rows[0]);
                    lecturerForm.ShowDialog();
                    HomeForm homeForm = new HomeForm();
                    homeForm.ShowDialog();
                }
                else if (dt.Rows[0]["Role"].ToString() == Program.adminRole)
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

        private void btnReg_Click(object sender, EventArgs e)
        {
            int num = dbc.addUser(txtRegID.Text, txtRegFirstName.Text, txtRegLastName.Text, txtRegEmail.Text, txtRegPassword.Text ,pictureBox.ImageLocation, int.Parse(Program.studentRole));
            if(num == 1)
            {
                MessageBox.Show("Registration successfully completed. Sign in now");
                pnlLogin.Visible = true;
                pnlReg.Visible = false;
                btnRegImg.BackColor = SystemColors.Window;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlReg.Visible = false;
            btnRegImg.BackColor = SystemColors.Window;
        }

        private void btnGoReg_Click(object sender, EventArgs e)
        {
            pnlReg.Visible = true;
            pnlLogin.Visible = false;
        }

        private void btnRegImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Picture | *.jpg; *.jpeg; *.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox.ImageLocation = openFileDialog1.FileName;
                btnRegImg.BackColor = Color.Green;
            }
        }

        private void lblImg_MouseHover(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
        }

        private void lblImg_MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Visible = false;
        }

    }
}
