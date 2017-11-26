using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Fsd.Sebastian.Cs.Ex4.Services.Sql
{
    public static class SqlSetter
    {
        public static void Insert(string producer, string model, decimal price, DateTime date, ProductType type)
        {
            string connectionString = @"Server=.\SQLEXPRESS;Database=music_equipment;User Id=sa;Password=lubieplacki;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Products(Producer, Model, Price, Date, Type) VALUES('{producer}', '{model}', {price}, '{date.ToString("yyyyMMdd")}', '{type}')";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(new DataSet());
            }
        }
    }
}
