using Fsd.Sebastian.Cs.Ex4.Data.Enums;
using Fsd.Sebastian.Cs.Ex4.Web.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Sebastian.Cs.Ex4.Web.Models.Products
{
    public class ProductModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string Producer { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Model { get; set; }

        [Required(ErrorMessage = "This field is required")]        
        [GreaterThanZero(ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Date)]
        [TodayIsMax(ErrorMessage = "Must be today or before")]
        public DateTime Date { get; set; }

        [Required]
        public ProductType Type { get; set; }
    }
}