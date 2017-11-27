using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Sebastian.Cs.Ex4.Web.Attributes
{
    public class TodayIsMaxAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return Convert.ToDateTime(value) <= DateTime.Now;
        }
    }
}