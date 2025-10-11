using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DomainModel.Models;

namespace DataAccessLayer
{
    public class UserDataAccess
    {
        public bool AddUser(User user)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["SPOFConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                    return false;

                connection.Open();

                using (SqlCommand check = new SqlCommand(
                    "SELECT COUNT(1) FROM dbo.Users WHERE Username=@u", connection))
                {
                    check.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = user.Username.Trim();
                    int exists = Convert.ToInt32(check.ExecuteScalar());
                    if (exists > 0)
                        return false;
                }

                using (SqlCommand insert = new SqlCommand(
                    "INSERT INTO dbo.Users (Username, Password) VALUES (@u, @p)", connection))
                {
                    insert.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = user.Username.Trim();
                    insert.Parameters.Add("@p", SqlDbType.NVarChar, 50).Value = user.Password;
                    insert.ExecuteNonQuery();
                }

                return true;
            }
        }

        public bool Login(string username, string password, out int userId)
        {
            userId = -1;
            string connectionString = ConfigurationManager.ConnectionStrings["SPOFConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT UserId FROM dbo.Users WHERE Username=@u AND Password=@p", connection))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = username.Trim();
                cmd.Parameters.Add("@p", SqlDbType.NVarChar, 50).Value = password;

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return false;

                userId = Convert.ToInt32(result);
                return true;
            }
        }
        public string GetUserName(int userId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SPOFConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT Username FROM dbo.Users WHERE UserId=@id", connection))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = userId;

                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return string.Empty;

                return result.ToString();
            }

        }
    }
}
