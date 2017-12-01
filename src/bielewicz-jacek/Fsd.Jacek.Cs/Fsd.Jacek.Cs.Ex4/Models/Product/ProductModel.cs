using System;
using Fsd.Jacek.Cs.Ex4.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Fsd.Jacek.Cs.Ex4.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Manufacterer")]
        [Required(ErrorMessage = "Manufacterer cannot be empty")]
        public string Manufacterer { get; set; }

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