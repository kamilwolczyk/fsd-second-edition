using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Core.SQL
{
    public class SqlDataReaderConverter
    {
        public static List<Product> ConvertDataReaderToProduct(SqlDataReader reader)
        {
            List<Product> product = new List<Product>();

            while (reader.Read())
            {
                product.Add(new Product((int)reader[0], (string)reader[1], (string)reader[2], (decimal)reader[3], (string)reader[4], (DateTime)reader[5]));
            }
            reader.Close();
            return product;
        }
    }
}
