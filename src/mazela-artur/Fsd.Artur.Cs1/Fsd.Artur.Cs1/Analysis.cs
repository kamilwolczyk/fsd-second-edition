using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Artur.Cs1
{
    public class AnalysisSymbols
    {
        private static int Check(string parameter, NumberOfInstruction instruction)
        {
            int counter = 0;

            if(instruction == NumberOfInstruction.First)
            {
                for (var i = 0; i < parameter.Length; i++)
                {
                    char item = parameter[i];
                    if(Char.IsUpper(item) == true)
                        counter++;
                }
            }
            else if(instruction == NumberOfInstruction.Second)
            {
                for (var i = 0; i < parameter.Length; i++)
                {
                    char item = parameter[i];
                    if (Char.IsLower(item) == true)
                        counter++;
                }               
            }
            else
            {
                for (var i = 0; i < parameter.Length; i++)
                {
                    char item = parameter[i];
                    if (Char.IsDigit(item) == true)
                        counter++;
                }            
            }
            
            return counter;
        }  

        public static int UpperCounter(string parameter)
        {
            return Check(parameter, NumberOfInstruction.First);
        }

        public static int LowerCounter(string parameter)
        {
            return Check(parameter, NumberOfInstruction.Second);
        }

        public static int DigitCounter(string parameter)
        {
            return Check(parameter, NumberOfInstruction.Third);
        }
    }
}
