using System;
using System.ComponentModel.DataAnnotations;

namespace Fsd.Sebastian.Cs.Ex4.Web.Attributes
{
    public class TodayIsMaxAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime d = Convert.ToDateTime(value);
            return d <= DateTime.Now;
        }
    }
}