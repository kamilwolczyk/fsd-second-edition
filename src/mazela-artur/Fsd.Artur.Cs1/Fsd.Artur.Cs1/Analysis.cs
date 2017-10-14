using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs1
{
    public class Analysis
    {
        private static int Check(string parameter, int instruction)
        {
            int counter = 0;

            if(instruction == 1)
            {
                for (var i = 0; i < parameter.Length; i++)
                {
                    char item = parameter[i];
                    if(Char.IsUpper(item) == true)
                    {
                        counter++;
                    }
                }
            }
            else if(instruction == 2)
            {
                for (var i = 0; i < parameter.Length; i++)
                {
                    char item = parameter[i];
                    if (Char.IsLower(item) == true)
                    {
                        counter++;
                    }
                }               
            }
            else
            {
                for (var i = 0; i < parameter.Length; i++)
                {
                    char item = parameter[i];
                    if (Char.IsDigit(item) == true)
                    {
                        counter++;
                    }
                }            
            }
            
            return counter;
        }  

        public static int UpperCounter(string parameter)
        {
            return Check(parameter, 1);
        }

        public static int LowerCounter(string parameter)
        {
            return Check(parameter, 2);
        }

        public static int DigitCounter(string parameter)
        {
            return Check(parameter, 3);
        }
    }
}
