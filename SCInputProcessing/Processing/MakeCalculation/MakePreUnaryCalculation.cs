using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class MakePreUnaryCalculation
    {
        public string calculate(string num, string operatorr)
        {
            double result = 0;
            switch (operatorr)
            {
                case "ln":
                    result = Math.Log(Convert.ToDouble(num));
                    break;
                case "log":
                    result = Math.Log10(Convert.ToDouble(num));
                    break;
                case "sqrt":
                    result = Math.Sqrt(Convert.ToDouble(num));
                    break;
            }
            return Convert.ToString(result);
        }
    }
}
