using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class MakeBinaryCalculation
    {
        public string calculate(string lNum, string operatorr, string rNum)
        {
            double result = 0;
            switch (operatorr)
            {
                case "+":
                    result = Convert.ToDouble(lNum) + Convert.ToDouble(rNum);
                    break;
                case "-":
                    result = Convert.ToDouble(lNum) - Convert.ToDouble(rNum);
                    break;
                case "x":
                    result = Convert.ToDouble(lNum) * Convert.ToDouble(rNum);
                    break;
                case "/":
                    result = Convert.ToDouble(lNum) / Convert.ToDouble(rNum);
                    break;
                case "%":
                    result = Convert.ToDouble(lNum) % Convert.ToDouble(rNum);
                    break;
                case "^":
                    result = Math.Pow(Convert.ToDouble(lNum), Convert.ToDouble(rNum));
                    break;
            }
            return Convert.ToString(result);
        }
    }
}
