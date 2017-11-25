using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Bartek.Ex4.Services.Validation
{
    public static class DateCheck
    {
        public static bool DataChecker(string date)
        {
            string[] result = date.Split('.');

            if((int.Parse(result[2]) < DateTime.Now.Year))
                       return true;

            if ((int.Parse(result[2]) == DateTime.Now.Year))
                if ((int.Parse(result[1]) < DateTime.Now.Month))
                    return true;

            if ((int.Parse(result[2]) == DateTime.Now.Year))
                if ((int.Parse(result[1]) == DateTime.Now.Month))
                    if ((int.Parse(result[0]) <= DateTime.Now.Day))
                        return true;

                return false;
        }
    }
}
