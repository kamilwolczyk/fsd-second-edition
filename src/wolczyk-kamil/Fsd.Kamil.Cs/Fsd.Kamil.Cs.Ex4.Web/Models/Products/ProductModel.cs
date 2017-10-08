using Fsd.Kamil.Cs.Ex4.Data.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Kamil.Cs.Ex4.Web.Models.Products
{
    public class ProductModel
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Producer")]
        [Required(ErrorMessage = "Producer cannot be empty")]
        public string Producer { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Model")]
        [Required(ErrorMessage = "Model cannot be empty")]
        public string Model { get; set; }
        
        [DisplayName("Type")]
        [Required(ErrorMessage = "Type cannot be empty")]
        public ProductType Type { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        [Required(ErrorMessage = "Price cannot be empty")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of production")]
        [Required(ErrorMessage = "Production date cannot be empty")]
        public DateTime ProductionDate { get; set; }
    }
}
