using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class MakePostUnaryCalculation
    {
        public string calculate(string num, string operatorr)
        {
            double result = 0;
            switch (operatorr)
            {
                case "!":
                    result = calculateFactorial(num);
                    break;
            }
            return Convert.ToString(result);
        }

        public double calculateFactorial(string num)
        {
            int number;
            double result = 1;
            if(Int32.TryParse(num, out number))
            {
                if (number == 0 || number == 1)
                    return result;
                else if (number > 0)
                {
                    for (int i = 1; i <= number; i++)
                        result = result * i;
                    return result;
                }
                else
                    return result;
            }
            else
            {
                return result;
            }
        }
    }
}
