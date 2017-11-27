using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using Fsd.Sebastian.Cs.Ex4.Services.Sql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Fsd.Sebastian.Cs.Ex4.Services.Products.Sql
{
    public static class SqlSetter
    {
        public static void Insert(string producer, string model, decimal price, DateTime date, ProductType type)
        {
            using (SqlService.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(SqlService.GetCommand("INSERT " +
                    "INTO Products(Producer, Model, Price, Date, Type) " +
                    $"VALUES('{producer}', '{model}', {price}, '{date.ToString("yyyyMMdd")}', '{type}')"));

                adapter.Fill(new DataSet());
            }
        }
    }
}
