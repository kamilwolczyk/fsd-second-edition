using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Arek.Cs.Ex4.Web.Models.CustomValidators
{
    public class GreaterThanCurrentDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date = Convert.ToDateTime(value);

            if (date > DateTime.Now)
                return new ValidationResult("Date can not be grater than current date");
            else
                return ValidationResult.Success;
        }
    }
}