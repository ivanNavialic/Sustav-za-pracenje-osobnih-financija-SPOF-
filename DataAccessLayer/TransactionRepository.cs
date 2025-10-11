using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DomainModel.Models;

namespace DataAccessLayer
{
    public class TransactionRepository
    {
        private readonly string connectionString;

        public TransactionRepository()
        {
            connectionString = ConfigurationManager
                .ConnectionStrings["SPOFConnectionString"]
                .ConnectionString;
        }

        public bool AddTransaction(Transactions transaction)
        {
            if (transaction == null ||
                transaction.UserId <= 0 ||
                string.IsNullOrWhiteSpace(transaction.Title) ||
                string.IsNullOrWhiteSpace(transaction.Type) ||
                transaction.Amount <= 0)
            {
                return false;
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO dbo.Transactions (UserId, Title, Amount, Type) VALUES (@userId, @title, @amount, @type)",
                sqlConnection))
            {
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = transaction.UserId;
                cmd.Parameters.Add("@title", SqlDbType.NVarChar, 200).Value = transaction.Title.Trim();
                cmd.Parameters.Add("@amount", SqlDbType.Decimal).Value = transaction.Amount;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar, 20).Value = transaction.Type;

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public List<Transactions> GetAllTransactions(int userId)
        {
            List<Transactions> list = new List<Transactions>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT TransactionId, UserId, Title, Amount, Type, CreatedAt " +
                "FROM dbo.Transactions WHERE UserId = @userId ORDER BY CreatedAt DESC",
                sqlConnection))
            {
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                sqlConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Transactions item = new Transactions
                        {
                            TransactionId = reader.GetInt32(0),
                            UserId = reader.GetInt32(1),
                            Title = reader.GetString(2),
                            Amount = reader.GetDecimal(3),
                            Type = reader.GetString(4),
                            CreatedAt = reader.GetDateTime(5)
                        };
                        list.Add(item);
                    }
                }
            }

            return list;
        }

        public bool DeleteTransaction(int transactionId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM dbo.Transactions WHERE TransactionId = @id",
                sqlConnection))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = transactionId;

                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public decimal GetBalance(int userId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT COALESCE(
                    SUM(CASE 
                        WHEN Type = N'Prihod'  THEN Amount
                        WHEN Type = N'Rashod'  THEN -Amount
                        WHEN Type = N'Štednja' THEN -Amount
                        ELSE 0
                    END), 0)
                FROM dbo.Transactions
                WHERE UserId = @uid;", sqlConnection))
            {
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userId;

                sqlConnection.Open();
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value) return 0m;

                return Convert.ToDecimal(result);
            }
        }

        public decimal GetNetStednja(int userId)
        {
            var sve = GetAllTransactions(userId);

            decimal ukupno = sve
                .Where(t => t.Type == "Štednja")
                .Sum(t => t.Amount);

            decimal isplaceno = sve
                .Where(t => t.Title == "Isplata štednje")
                .Sum(t => t.Amount);

            return ukupno - isplaceno;
        }
    }
}