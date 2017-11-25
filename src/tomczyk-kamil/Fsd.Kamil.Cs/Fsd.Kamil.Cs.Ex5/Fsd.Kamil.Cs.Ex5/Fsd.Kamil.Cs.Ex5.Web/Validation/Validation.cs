using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Kamil.Cs.Ex5.Web.Models.Validation
{
    public class ProductionDateValidation : ValidationAttribute //z internetu nauczone
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime productionDate = (DateTime)value;
            if (DateTime.Now > productionDate)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Data produkcji jest wymagana i nie może być większa od daty bieżącej");
            }
        }
    }
}