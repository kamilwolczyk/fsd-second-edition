using Fsd.Kamil.Cs.Ex5.Domain.Api.Enums;
using Fsd.Kamil.Cs.Ex5.Web.Models.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Kamil.Cs.Ex5.Models.Products
{
    public class ProductModel
    {     
        [Required(ErrorMessage = "Producent jest wymagany")]
        public string Producer { get; set; }

        [Required(ErrorMessage = "Model jest wymagany")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana i musi być większa od 0")]
        [Range(0.01, int.MaxValue, ErrorMessage = "Wprowadź wartość większą od 0")]
        public string Price { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Data produckji jest wymagana i nie może być większa od daty bieżącej")]
        [ProductionDateValidation]
        public DateTime ProductionDate { get; set; }

        [Required(ErrorMessage = "Typ jest wymagany")]
        public ProductTypes Type { get; set; }

        public bool ProductAddFailed { get; set; }
    }

    
}