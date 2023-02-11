using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace EyalonFinalProject
{
    internal class DBConnection
    {
        public static SqlConnection mySqlConnection = new SqlConnection("server = DESKTOP-EYALON1\\SQLEXPRESS02;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public int addUser(String id, String firstName, String lastName,String email, String password, String imgPath, int role)
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

        public void deleteUserByID(String userID)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "DELETE FROM projectDB.dbo.Users WHERE ID='" + userID + "';";
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
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users";
                mySqlConnection.Open();
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

        public DataTable login(String id,String password)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlConnection.Open();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE ID='" + id + "' AND Password='" + password + "';";
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

        public DataTable getUsersByName(String name)
        {
            try
            {
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "SELECT * FROM projectDB.dbo.Users WHERE FirstName LIKE '%"+name+"%' OR LastName LIKE '%"+name+"%';";
                mySqlConnection.Open();
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
    }
}

