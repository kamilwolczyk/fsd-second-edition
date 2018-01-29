using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Arek.Cs.Ex4.Web.Models.CustomValidators
{
    public class GratherThanZero : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Decimal number = Convert.ToDecimal(value);

            if (number < 0)
                return new ValidationResult("Number should be greater than 0");
            else
                return ValidationResult.Success;
        }
    }
}