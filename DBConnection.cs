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
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.ApplicationServices;


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
        public int deleteUserByID(string userID)
        {
            try
            {
                DataTable pages = getProjectPageAndProjectBookIDByStudentID(userID);//only in case the user in student bc only students link to page
                for (int i = 0; i < pages.Rows.Count; i++)
                {
                    deleteProjectPageByProjectPageIDAndStudentID(int.Parse(pages.Rows[i]["ProjectPageID"].ToString()), userID);
                }
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.Users WHERE UserID='" + userID + "';";
                MessageBox.Show("deleteUserByID: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("deleteUserByID: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return -1;
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
        public DataTable login(string id, string password)//data table???
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
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE (FirstName LIKE '%" + name + "%' OR LastName LIKE '%" + name + "%') AND Role=" + role + ";";
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
        public DataTable getStudentsExceptStudentID(string studentID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE Role=" + int.Parse(Program.studentRole) + " AND UserID <> '"+ studentID + "';";
                MessageBox.Show("getStudentsExceptStudentID: " + mySqlCommand.CommandText);
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
        public int updateUser(string id, string firstName, string lastName, string email, string password, string imgPath, int role)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.Users SET UserID='" + id + "',FirstName='" + firstName + "',LastName='" + lastName + "',Email='" + email + "',Password='" + password + "',Image='" + imgPath + "',Role=" + role + " WHERE UserID='" + id + "';";
                MessageBox.Show("updateUser: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("updateUser: " + num);
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

        //PROJECTBOOK
        public int addProjectBook(string bookName, int bookYear, string bookOpenPage)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectBook VALUES('" + bookName + "', '" + bookOpenPage.Replace("'", "''") + "'," + bookYear + ")";
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
        public DataRow getProjectBookByProjectBookID(int projectBookID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.ProjectBook WHERE ProjectBookID=" + projectBookID;
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
        public string getProjectBookNameByID(int projectBookID)
        {
            string result = "";
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT ProjectBookName FROM projectDB.dbo.ProjectBook WHERE ProjectBookID=" + projectBookID;
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result += mySqlDataReader["ProjectBookName"].ToString();//need to be 1 time bc ProjectBookID IS PK
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return result;
        }
        public int updateProjectBook(int projectBookID, string bookName, int bookYear, string bookOpenPage)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.ProjectBook SET ProjectBookName='" + bookName + "',ProjectBookOpenPage='" + bookOpenPage.Replace("'", "''") + "',ProjectBookYear=" + bookYear + " WHERE ProjectBookID=" + projectBookID;
                MessageBox.Show("updateProjectBook: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("updateProjectBook: " + num);
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
        public int deleteProjectBookByProjectBookID(int projectBookID)
        {
            try
            {
                DataTable pages = getProjectPageIDByProjectBookID(projectBookID);
                {
                    for (int i = 0; i < pages.Rows.Count; i++)
                    {
                        deleteProjectPageInBookByProjectPageID(int.Parse(pages.Rows[i][0].ToString()));
                    }
                }
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectBook WHERE ProjectBookID=" + projectBookID;
                MessageBox.Show("deleteProjectBookByProjectBookID: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("deleteProjectBookByProjectBookID: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return -1;
        }

        //PROJECTPAGE
        public int addProjectPage(string pageName, string pageData)
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
        public string getProjectPageNameByProjectPageID(int projectPageID)
        {
            string result = "";
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT ProjectPageName FROM projectDB.dbo.ProjectPage WHERE ProjectPageID=" + projectPageID;
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result += mySqlDataReader["ProjectPageName"].ToString();//need to be 1 time bc ProjectBookID IS PK
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return result;
        }
        public DataTable getAllProjectPageAndProjectBookID()
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT pp.ProjectPageID,pp.ProjectPageName,pp.ProjectPageCreationDate,ISNULL(ppib.ProjectBookID,'-1') AS ProjectBookID FROM projectDB.dbo.ProjectPage pp LEFT JOIN projectDB.dbo.ProjectPageInBook ppib ON pp.ProjectPageID=ppib.ProjectPageID";
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
        public DataRow getProjectPageAndProjectBookIDByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT pp.ProjectPageID,pp.ProjectPageName,pp.ProjectPageCreationDate,ISNULL(ppib.ProjectBookID,'-1') AS ProjectBookID FROM projectDB.dbo.ProjectPage pp LEFT JOIN projectDB.dbo.ProjectPageInBook ppib ON pp.ProjectPageID=ppib.ProjectPageID Where pp.ProjectPageID="+projectPageID;
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
        public DataTable getProjectPageAndProjectBookIDByStudentID(string studentID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT pp.ProjectPageID,pp.ProjectPageName,pp.ProjectPageCreationDate,pp.ProjectPageData,ISNULL(ppib.ProjectBookID,'-1') AS ProjectBookID FROM projectDB.dbo.ProjectPage pp LEFT JOIN projectDB.dbo.ProjectPageInBook ppib ON pp.ProjectPageID=ppib.ProjectPageID,projectDB.dbo.StudentProjectPage spp WHERE pp.ProjectPageID = spp.ProjectPageID AND spp.StudentID='" + studentID + "'";
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
        public DataRow getProjectPageByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.ProjectPage WHERE ProjectPageID=" + projectPageID;
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
        public int updateProjectPage(int projectPageID, string pageName, string pageData)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.ProjectPage SET ProjectPageName=N'" + pageName + "',ProjectPageData=N'" + pageData + "' WHERE ProjectPageID=" + projectPageID;
                MessageBox.Show("updateProjectPage: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("updateProjectPage: " + num);
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
        //public int deleteProjectPageByProjectPageID(int projectPageID)
        public int deleteProjectPageByProjectPageID(int projectPageID)
        {
            try
            {
                deleteStudentProjectPageByProjectPageID(projectPageID);
                deleteProjectPageInBookByProjectPageID(projectPageID);
                return deleteProjectPageByProjectPageIDCommand(projectPageID);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        public int deleteProjectPageByProjectPageIDAndStudentID(int projectPageID, string studentID)
        {
            try
            {
                deleteStudentProjectPageByProjectPageIDAndStudentID(projectPageID, studentID);
                if (getStudentByProjectPageID(projectPageID).Rows.Count == 0)
                {
                    deleteProjectPageInBookByProjectPageID(projectPageID);//IN CASE WE DELETE STUDENT AND HE HAVE PAGE LINK TO BOOK
                    return deleteProjectPageByProjectPageIDCommand(projectPageID);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        private int deleteProjectPageByProjectPageIDCommand(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectPage WHERE ProjectPageID=" + projectPageID;
                MessageBox.Show("deleteProjectPageByProjectPageID: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("deleteProjectPageByProjectPageID: " + num);
                mySqlConnection.Close();
                return num;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return -1;
        }

        //STUDENTPROJECTPAGE
        public int addStudentProjectPage(string studentID, int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.StudentProjectPage VALUES('" + studentID + "', " + projectPageID + ")";
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
        private int deleteStudentProjectPageByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.StudentProjectPage WHERE ProjectPageID="+projectPageID;
                MessageBox.Show("deleteStudentProjectPageByProjectPageID: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("deleteStudentProjectPageByProjectPageID: " + num);
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
        private int deleteStudentProjectPageByProjectPageIDAndStudentID(int projectPageID, string studentID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.StudentProjectPage WHERE ProjectPageID=" + projectPageID + " AND StudentID='" + studentID + "';";
                MessageBox.Show("deleteStudentProjectPageByProjectPageIDAndStudentID: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("deleteStudentProjectPageByProjectPageIDAndStudentID: " + num);
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
        public string getPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(int projectPageID, string studentID)
        {
            string result = "";
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT u.UserID,u.FirstName,u.LastName FROM projectDB.dbo.Users u,projectDB.dbo.StudentProjectPage spp WHERE u.UserID = spp.StudentID AND spp.ProjectPageID=" + projectPageID + " AND spp.StudentID <> '"+ studentID + "';";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader["UserID"].ToString() + " - " + mySqlDataReader["FirstName"].ToString() + " " + mySqlDataReader["LastName"].ToString();
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return result;
        }
        public DataTable getStudentByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT u.UserID,u.FirstName,u.LastName FROM projectDB.dbo.Users u,projectDB.dbo.StudentProjectPage spp WHERE u.UserID = spp.StudentID AND spp.ProjectPageID=" + projectPageID;
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
        public string getStudentNameByProjectPageID(int projectPageID)
        {
            string result = "";
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT u.FirstName,u.LastName FROM projectDB.dbo.Users u,projectDB.dbo.StudentProjectPage spp WHERE u.UserID = spp.StudentID AND spp.ProjectPageID=" + projectPageID;
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result += mySqlDataReader["FirstName"].ToString() + " " + mySqlDataReader["LastName"].ToString() + ", ";
                }
                result = result.Remove(result.Length - 2);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return result;
        }

        //PROJECTPAGEINBOOK
        public int addProjectPageInBook(int projectPageID, int projectBookID)
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
        public DataTable getProjectPageIDByProjectBookID(int projectBookID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT ProjectPageID FROM projectDB.dbo.ProjectPageInBook ppib WHERE ppib.ProjectBookID=" + projectBookID;
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
        public bool isProjectPageLinkToBook(int projectPageID)
        {
            bool ans = false;
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT COUNT(*) FROM projectDB.dbo.ProjectPageInBook WHERE ProjectPageID=" + projectPageID;
                ans = Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0 ? true : false;
                mySqlConnection.Close();
                return ans;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return ans;
        }
        public string getLinkedProjectBookNameByProjectPageID(int projectPageID)
        {
            string result = "";
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT pb.ProjectBookName FROM projectDB.dbo.ProjectPageInBook ppib,projectDB.dbo.ProjectBook pb WHERE ppib.ProjectBookID=pb.ProjectBookID AND ProjectPageID=" + projectPageID;
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result += mySqlDataReader["ProjectBookName"].ToString();
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return result;
        }
        public int deleteProjectPageInBookByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectPageInBook WHERE ProjectPageID=" + projectPageID;
                MessageBox.Show("deleteProjectPageInBookByProjectPageID: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("deleteProjectPageInBookByProjectPageID: " + num);
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

        //PROJECTPAGEFRIENDREQUEST
        public int addProjectPageFriendRequest(int projectPageID, string studentIDReq, string studentIDAns)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectPageFriendRequest VALUES(" + projectPageID + ",'" +studentIDReq + "','" + studentIDAns+"')";
                MessageBox.Show("addProjectPageFriendRequest: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("addProjectPageFriendRequest: " + num);
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
        public DataTable getFriendRequestsProjectPageIDByStudentIDAns(string studentIDAns)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT ProjectPageID FROM projectDB.dbo.ProjectPageFriendRequest WHERE StudentIDAns='"+ studentIDAns + "';";
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
        public bool isProjectPageHaveFriendRequestByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.ProjectPageFriendRequest WHERE ProjectPageID=" + projectPageID;
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table.Rows.Count > 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return false;
        }
        public bool isProjectPageHaveRejectFriendRequestByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.ProjectPageFriendRequest WHERE ProjectPageID=" + projectPageID + " AND StudentIDAns IS NULL";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(mySqlDataReader);
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return table.Rows.Count > 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return false;
        }
        public string getInvitedStudentIDAndName(int projectPageID)
        {
            string result = "";
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT u.UserID,u.FirstName,u.LastName FROM projectDB.dbo.Users u,projectDB.dbo.ProjectPageFriendRequest ppfq WHERE u.UserID = ppfq.StudentIDAns AND ppfq.ProjectPageID=" + projectPageID;
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader["UserID"].ToString() + " - " + mySqlDataReader["FirstName"].ToString() + " " + mySqlDataReader["LastName"].ToString();
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return result;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return result;
        }
        public int rejectInvite(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.ProjectPageFriendRequest SET StudentIDAns=NULL WHERE ProjectPageID=" + projectPageID;
                MessageBox.Show("rejectInvite: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("rejectInvite: " + num);
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
        public int deleteProjectPageFriendRequest(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectPageFriendRequest WHERE ProjectPageID=" + projectPageID;
                MessageBox.Show("deleteProjectPageFriendRequest: " + mySqlCommand.CommandText);
                int num = mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("deleteProjectPageFriendRequest: " + num);
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

        //OTHER
        public bool isStudentLinkToBook(string studentID, int projectBookID)
        {
            bool ans = false;
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT COUNT(*) FROM projectDB.dbo.StudentProjectPage spp, projectDB.dbo.ProjectPageInBook ppib WHERE spp.ProjectPageID=ppib.ProjectPageID AND ppib.ProjectBookID=" + projectBookID + " AND spp.StudentID='" + studentID + "'";
                ans = Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0 ? true : false;
                mySqlConnection.Close();
                return ans;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return ans;
        }
        public int deletePartnerFromProjectPageByProjectPageIDAndMyStudentID(int projectPageID,string studentID)
        {
            try
            {
                deleteStudentProjectPageByProjectPageIDAndStudentID(projectPageID,studentID);
                addProjectPage(getProjectPageNameByProjectPageID(projectPageID), getProjectPageByProjectPageID(projectPageID)["ProjectPageData"].ToString());
                return addStudentProjectPage(studentID, getLastProjectPageID());
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