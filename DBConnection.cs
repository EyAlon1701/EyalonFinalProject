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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Text.RegularExpressions;


namespace EyalonFinalProject
{
    internal class DBConnection
    {
        public static SqlConnection mySqlConnection = new SqlConnection("server = DESKTOP-EYALON1\\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //USERS
        public int AddUser(string id, string firstName, string lastName, string email, string password, string imgPath, int role)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.Users VALUES('" + id + "', '" + firstName + "', '" + lastName + "', '" + email + "', '" + password + "', '" + imgPath + "', " + role + ")";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int DeleteUserByID(string userID)
        {
            try
            {
                DataTable pages = GetProjectPagesAndProjectBookIDByStudentID(userID);//only in case the user is student bc only students link to page
                for (int i = 0; i < pages.Rows.Count; i++)
                {
                    DataTable requests = GetFriendRequestsProjectPagesIDByStudentIDAns(userID);
                    {
                        for(int j = 0; j < requests.Rows.Count; j++)
                        {
                            RejectInvite(int.Parse(requests.Rows[j]["ProjectPageID"].ToString()));
                        }
                    }
                    DeleteProjectPageByProjectPageIDAndStudentID(int.Parse(pages.Rows[i]["ProjectPageID"].ToString()), userID);
                }
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.Users WHERE UserID='" + userID + "';";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public DataTable GetAllUsers()
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
        public DataTable Login(string id, string password)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE UserID COLLATE Latin1_General_CS_AS ='" + id + "' AND Password COLLATE Latin1_General_CS_AS ='" + password + "';";
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
        public DataTable GetUsersByName(string name)
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
        public DataTable GetUsersByRole(int role)
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
        public DataTable GetUsersByRoleAndName(int role, string name)
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
        public DataTable GetStudentsExceptMyStudentID(string studentID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE Role=" + int.Parse(Program.STUDENT_ROLE) + " AND UserID <> '"+ studentID + "';";
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
        public DataRow GetUserByID(string userID)
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
        public int UpdateUser(string id, string firstName, string lastName, string email, string password, string imgPath, int role)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.Users SET UserID='" + id + "',FirstName='" + firstName + "',LastName='" + lastName + "',Email='" + email + "',Password='" + password + "',Image='" + imgPath + "',Role=" + role + " WHERE UserID='" + id + "';";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int AddProjectBook(string bookName, int bookYear, string bookOpenPage)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectBook VALUES('" + bookName + "', '" + bookOpenPage.Replace("'", "''") + "'," + bookYear + ")";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public DataTable GetAllProjectBook()
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
        public DataTable GetProjectBooksByName(string name)
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
        public DataRow GetProjectBookByProjectBookID(int projectBookID)
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
        public string GetProjectBookNameByID(int projectBookID)
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
                    result += mySqlDataReader["ProjectBookName"].ToString();//need to be 1 time because ProjectBookID IS PK
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
        public int UpdateProjectBook(int projectBookID, string bookName, int bookYear, string bookOpenPage)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.ProjectBook SET ProjectBookName='" + bookName + "',ProjectBookOpenPage='" + bookOpenPage.Replace("'", "''") + "',ProjectBookYear=" + bookYear + " WHERE ProjectBookID=" + projectBookID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int DeleteProjectBookByProjectBookID(int projectBookID)
        {
            try
            {
                DataTable pages = GetProjectPagesIDByProjectBookID(projectBookID);
                {
                    for (int i = 0; i < pages.Rows.Count; i++)
                    {
                        DeleteProjectPageInBookByProjectPageID(int.Parse(pages.Rows[i][0].ToString()));
                    }
                }
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectBook WHERE ProjectBookID=" + projectBookID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int AddProjectPage(string pageName, string pageData)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectPage VALUES('" + pageName + "', '" + pageData + "','" + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff") + "')";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int GetLastProjectPageID()
        {
            int maxID = -1;
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT max(ProjectPageID) FROM projectDB.dbo.ProjectPage";
                maxID = Convert.ToInt32(mySqlCommand.ExecuteScalar());
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
        public string GetProjectPageNameByProjectPageID(int projectPageID)
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
        public DataTable GetAllProjectPageAndProjectBookID()
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
        public DataRow GetProjectPageAndProjectBookIDByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT pp.ProjectPageID,pp.ProjectPageName,pp.ProjectPageCreationDate,ISNULL(ppib.ProjectBookID,'-1') AS ProjectBookID FROM projectDB.dbo.ProjectPage pp LEFT JOIN projectDB.dbo.ProjectPageInBook ppib ON pp.ProjectPageID=ppib.ProjectPageID WHERE pp.ProjectPageID="+projectPageID;
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
        public DataTable GetProjectPagesAndProjectBookIDByStudentID(string studentID)
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
        public DataRow GetProjectPageByProjectPageID(int projectPageID)
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
        public DataTable GetProjectPagesAndProjectBookIDByProjectPageName(string projectPageName)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT pp.ProjectPageID,pp.ProjectPageName,pp.ProjectPageCreationDate,ISNULL(ppib.ProjectBookID,'-1') AS ProjectBookID FROM projectDB.dbo.ProjectPage pp LEFT JOIN projectDB.dbo.ProjectPageInBook ppib ON pp.ProjectPageID=ppib.ProjectPageID WHERE pp.ProjectPageName LIKE '%" + projectPageName + "%'";
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
        public int UpdateProjectPage(int projectPageID, string pageName, string pageData)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.ProjectPage SET ProjectPageName='" + pageName + "',ProjectPageData='" + pageData + "' WHERE ProjectPageID=" + projectPageID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int DeleteProjectPageByProjectPageID(int projectPageID)
        {
            try
            {
                DeleteStudentProjectPageByProjectPageID(projectPageID);
                DeleteProjectPageInBookByProjectPageID(projectPageID);
                return DeleteProjectPageByProjectPageIDCommand(projectPageID);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        public int DeleteProjectPageByProjectPageIDAndStudentID(int projectPageID, string studentID)
        {
            try
            {
                DeleteStudentProjectPageByProjectPageIDAndStudentID(projectPageID, studentID);
                if (GetStudentsByProjectPageID(projectPageID).Rows.Count == 0)
                {
                    DeleteProjectPageInBookByProjectPageID(projectPageID);//IN CASE WE DELETE STUDENT AND HE HAVE PAGE LINK TO BOOK
                    return DeleteProjectPageByProjectPageIDCommand(projectPageID);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        private int DeleteProjectPageByProjectPageIDCommand(int projectPageID)
        {
            try
            {
                DeleteProjectPageFriendRequest(projectPageID);
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectPage WHERE ProjectPageID=" + projectPageID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int AddStudentProjectPage(string studentID, int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.StudentProjectPage VALUES('" + studentID + "', " + projectPageID + ")";
                int num = mySqlCommand.ExecuteNonQuery();
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
        private int DeleteStudentProjectPageByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.StudentProjectPage WHERE ProjectPageID="+projectPageID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        private int DeleteStudentProjectPageByProjectPageIDAndStudentID(int projectPageID, string studentID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.StudentProjectPage WHERE ProjectPageID=" + projectPageID + " AND StudentID='" + studentID + "';";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public string GetPartnerStudentIDAndNameByProjectPageIdAndMyStudentID(int projectPageID, string studentID)
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
        public DataTable GetStudentsByProjectPageID(int projectPageID)
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
        private string GetPartnerStudentIDByProjectPageIdAndMyStudentID(int projectPageID, string studentID)
        {
            string partnerStudentID = null;
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT StudentID FROM projectDB.dbo.StudentProjectPage WHERE ProjectPageID=" + projectPageID + " AND StudentID <> '" + studentID + "';";
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    partnerStudentID = mySqlDataReader["StudentID"].ToString();
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
                return partnerStudentID;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return partnerStudentID;
        }
        public string GetStudentNameByProjectPageID(int projectPageID)
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
        public int AddProjectPageInBook(int projectPageID, int projectBookID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectPageInBook VALUES(" + projectPageID + ", " + projectBookID + ")";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public DataTable GetProjectPagesIDByProjectBookID(int projectBookID)
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
        public int GetProjectBookIDByProjectPageID(int projectPageID)
        {
            int projectBookID = -1;
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT ProjectBookID FROM projectDB.dbo.ProjectPageInBook ppib WHERE ppib.ProjectPageID=" + projectPageID;
                projectBookID = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                mySqlConnection.Close();
                return projectBookID;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return projectBookID;
        }
        public bool IsProjectPageLinkToBook(int projectPageID)
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
        public int DeleteProjectPageInBookByProjectPageID(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectPageInBook WHERE ProjectPageID=" + projectPageID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int AddProjectPageFriendRequest(int projectPageID, string studentIDReq, string studentIDAns)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "INSERT INTO projectDB.dbo.ProjectPageFriendRequest VALUES(" + projectPageID + ",'" +studentIDReq + "','" + studentIDAns+"')";
                int num = mySqlCommand.ExecuteNonQuery();
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
        public DataTable GetFriendRequestsProjectPagesIDByStudentIDAns(string studentIDAns)
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
        public bool IsProjectPageHaveFriendRequestByProjectPageID(int projectPageID)
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
        public bool IsProjectPageHaveRejectFriendRequestByProjectPageID(int projectPageID)
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
        public string GetInvitedStudentIDAndName(int projectPageID)
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
        public int RejectInvite(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "UPDATE projectDB.dbo.ProjectPageFriendRequest SET StudentIDAns=NULL WHERE ProjectPageID=" + projectPageID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        public int DeleteProjectPageFriendRequest(int projectPageID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.ProjectPageFriendRequest WHERE ProjectPageID=" + projectPageID;
                int num = mySqlCommand.ExecuteNonQuery();
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
        public bool IsProjectPageInTheFriendRequestHaveSameBookLikeMyProjectPage(string studentIDAns,int myProjectPageProjectBookID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.ProjectPageInBook ppib,(SELECT ProjectPageID FROM projectDB.dbo.ProjectPageFriendRequest WHERE StudentIDAns='" + studentIDAns + "') friendRequestProjectPage WHERE friendRequestProjectPage.ProjectPageID=ppib.ProjectPageID AND ppib.ProjectBookID=" + myProjectPageProjectBookID;
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

        //OTHER
        public bool IsStudentLinkToBook(string studentID, int projectBookID)
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
        public int DeletePartnerFromProjectPageByProjectPageIDAndMyStudentID(int projectPageID,string studentID)
        {
            try
            {
                string partnerStudentID = GetPartnerStudentIDByProjectPageIdAndMyStudentID(projectPageID,studentID);
                if (partnerStudentID != null)
                {
                    DeleteStudentProjectPageByProjectPageIDAndStudentID(projectPageID, partnerStudentID);
                    AddProjectPage(GetProjectPageNameByProjectPageID(projectPageID), GetProjectPageByProjectPageID(projectPageID)["ProjectPageData"].ToString());
                    if (IsProjectPageLinkToBook(projectPageID))
                    {
                        AddProjectPageInBook(GetLastProjectPageID(), GetProjectBookIDByProjectPageID(projectPageID));
                    }
                    return AddStudentProjectPage(partnerStudentID, GetLastProjectPageID());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                mySqlConnection.Close();
            }
            return -1;
        }
        public DataTable GetStudentsOnSameBookThatDontHavePartnerExceptMyStudentIDByProjectBookID(string studentID,int projectBookID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT u.UserID,u.FirstName,u.LastName FROM (SELECT ppib.ProjectPageID FROM (SELECT ProjectPageID FROM projectDB.dbo.StudentProjectPage GROUP BY ProjectPageID HAVING COUNT(*) = 1) alonePage,(SELECT ProjectPageID FROM projectDB.dbo.ProjectPageInBook WHERE ProjectBookID=" + projectBookID + ") ppib WHERE alonePage.ProjectPageID = ppib.ProjectPageID) goodPage,(SELECT * FROM projectDB.dbo.StudentProjectPage) spp,(SELECT * FROM projectDB.dbo.Users) u WHERE spp.ProjectPageID=goodPage.ProjectPageID AND u.UserID=spp.StudentID AND UserID <> '" + studentID + "';";
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
        public int GetMyProjectPageIDThatLinkToBookByProjectBookIDAndStudentID(string studentID, int projectBookID)
        {
            int projectPageID = -1;
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT spp.ProjectPageID FROM projectDB.dbo.StudentProjectPage spp, projectDB.dbo.ProjectPageInBook ppib WHERE spp.ProjectPageID=ppib.ProjectPageID AND ppib.ProjectBookID=" + projectBookID + " AND spp.StudentID='" + studentID + "'";
                projectPageID = Convert.ToInt32(mySqlCommand.ExecuteScalar());
                mySqlConnection.Close();
                return projectPageID;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                mySqlConnection.Close();
            }
            return projectPageID;
        }
    }
}