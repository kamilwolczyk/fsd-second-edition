using Fsd.Arek.Cs.Ex4.Core.SQL;
using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Services.Services
{
    public class Warehause : IWarehause
    {
        public int GetProductCount()
        {
            return GetAllProducts().Count();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return SqlDataReaderConverter.ConvertDataReaderToProduct(SqlHellper.SqlAllValue("SELECT * FROM Car")); 
        }

        public void AddProduct()
        {
            SqlHellper.InsertToDatabaseTable("Car");
        }
    }
}
