using Fsd.Bartek.Ex4.Data.Enums;

namespace Fsd.Bartek.Ex4.Web.Models
{
    public partial class ProductAddModel
    {
        public class ProductSelectType
        {
            public int Id { get; set; }

            public ProductsType Type { get; set; }
        }
    }
}