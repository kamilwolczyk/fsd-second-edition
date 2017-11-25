using Fsd.Arek.Cs.Ex4.Core.SQL;
using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Arek.Cs.Ex4.Services.Services
{
    public class Warehause : IWarehause
    {
        private ISqlDatabase _sqlDatabase;

        public Warehause(ISqlDatabase sqlDatabase)
        {
            _sqlDatabase = sqlDatabase;
        }

        public int GetProductCount()
        {
            return GetAllProducts().Count();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return SqlDataReaderConverter.ConvertDataReaderToProduct(_sqlDatabase.SqlSelectNoParametrs("SELECT * FROM Car"));
        }

        public void AddProduct(List<string> listValues)
        {
            IEnumerable<string> nameProperites = GetPropertyName<Product>();
            Dictionary<string, string> valueToDatabase = new Dictionary<string, string>();
            int i = 0;

            foreach (string name in nameProperites)
            {
                valueToDatabase.Add(name, listValues[i]);
                i++;
            }
            _sqlDatabase.InsertToDatabaseTable(valueToDatabase, "Car");
        }

        public IEnumerable<string> GetPropertyName<TType>()
        {
            List<string> propertyNameList = new List<string>();
            int i = 0;
            foreach (PropertyInfo p in typeof(TType).GetProperties())
            {
                if (i != 0)
                    propertyNameList.Add(p.Name);
                i++;
            }
            return propertyNameList;
        }
    }
}
