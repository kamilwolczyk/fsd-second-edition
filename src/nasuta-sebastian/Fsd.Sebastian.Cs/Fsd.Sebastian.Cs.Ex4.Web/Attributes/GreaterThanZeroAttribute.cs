using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Sebastian.Cs.Ex4.Web.Attributes
{
    public class GreaterThanZeroAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return Convert.ToDecimal(value) > 0;
        }
    }
}