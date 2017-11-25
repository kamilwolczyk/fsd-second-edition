using Fsd.Arek.Cs.Ex4.Web.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Arek.Cs.Ex4.Web.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Required field")]
        public string Producer { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Required field")]
        [GratherThanZero]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Date)]
        [GreaterThanCurrentDate]
        public DateTime DateOfProduction { get; set; }
    }
}