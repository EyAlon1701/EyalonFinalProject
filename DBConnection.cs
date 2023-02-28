using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing.Drawing2D;
using System.Xml.Linq;


namespace EyalonFinalProject
{
    internal class DBConnection
    {
        public static SqlConnection mySqlConnection = new SqlConnection("server = DESKTOP-EYALON1\\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //USERS
        public int addUser(string id, string firstName, string lastName, string email, string password, string imgPath, int role)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.Users VALUES('" + id + "', '" + firstName + "', '" + lastName + "', '" + email + "', '" + password + "', '" + imgPath + "', " + role + ")";
                MessageBox.Show("addUserSQL: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("addUser: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        public void deleteUserByID(string userID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.Users WHERE UserID='" + userID + "';";
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show(num + " DELETED USER");
                mySqlConnection.Close();
                //CHANGE FUNC TO INT LIKE ADD
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public DataTable getAllUsers()
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users;";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        public DataTable login(string id, string password)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE UserID='" + id + "' AND Password='" + password + "';";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        public DataTable getUsersByName(string name)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE FirstName LIKE '%" + name + "%' OR LastName LIKE '%" + name + "%';";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        public DataTable getUsersByRole(int role)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE Role=" + role + ";";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        public DataTable getUsersByRoleAndName(int role, string name)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE (FirstName LIKE '%" + name + "%' OR LastName LIKE '%" + name + "%') AND Role="+role+";";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        public DataRow getUserByID(string userID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE UserID='" + userID + "';";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table.Rows[0];
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        
        //PROJECTBOOK
        public int addProjectBook(string bookName, string bookYear, string bookOpenPage)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectBook VALUES('" + bookName + "', '" + bookOpenPage + "'," + bookYear + ")";
                MessageBox.Show("addProjectBook: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("addProjectBook: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        public DataTable getAllProjectBook()
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.ProjectBook";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        public DataTable getProjectBookByName(string name)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.ProjectBook WHERE ProjectBookName LIKE '%" + name + "%';";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }

        //PROJECTPAGE
        public int addProjectPage(string pageName,string pageData)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectPage VALUES('" + pageName + "', '" + pageData + "','" + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff") + "')";
                MessageBox.Show("addProjectPage: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("addProjectPage: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        public int getLastProjectPageID()
        {
            int maxID = -1;
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT max(ProjectPageID) FROM projectDB.dbo.ProjectPage";
                MessageBox.Show("getLastProjectPageID: " + mySqlCommand.CommandText);
                maxID = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                MessageBox.Show(maxID.ToString());
                mySqlConnection.Close();
                return maxID;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return maxID;
        }
        public DataTable getProjectPageByID(string userID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT pp.ProjectPageID,pp.ProjectPageName,pp.ProjectPageCreationDate,pp.ProjectPageData FROM projectDB.dbo.ProjectPage pp,projectDB.dbo.StudentProjectPage spp WHERE pp.ProjectPageID = spp.ProjectPageID AND spp.StudentID='" + userID+"'";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return null;
        }
        
        //STUDENTPROJECTPAGE
        public int addStudentProjectPage(string StudentID,int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.StudentProjectPage VALUES('" + StudentID + "', " + projectPageID + ")";
                MessageBox.Show("addStudentProjectPage: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("addStudentProjectPage: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                mySqlConnection.Close();
            }
            return -1;
        }

        //PROJECTPAGEINBOOK
        public int addProjectPageInBook(int projectPageID,int projectBookID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectPageInBook VALUES(" + projectPageID + ", " + projectBookID + ")";
                MessageBox.Show("addProjectPageInBook: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("addProjectPageInBook: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
    }
}

