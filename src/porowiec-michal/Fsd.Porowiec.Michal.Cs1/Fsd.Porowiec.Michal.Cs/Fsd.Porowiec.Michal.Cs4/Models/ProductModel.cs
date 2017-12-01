using Fsd.Porowiec.Michal.Data.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Porowiec.Michal.Cs4.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Prosze wpisać nazwę modelu.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Proszę wpisać nazwę producenta.")]
        public string Producer { get; set; }

        [Required(ErrorMessage = "Proszę wpisać cenę.")]
        [Range(0, int.MaxValue, ErrorMessage = "Prosze podać wartość większą niż 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Proszę wprowadzi datę." )]
        [DataType(DataType.Date)]
        public DateTime DateOfProduction { get; set; }

        [Required]
        public ProductType Type { get; set; }

    }
}