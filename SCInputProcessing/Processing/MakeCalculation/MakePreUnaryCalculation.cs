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
                case "sin":
                    result = Math.Sin(Convert.ToDouble(num) * Math.PI / 180);
                    break;
                case "cos":
                    result = Math.Cos(Convert.ToDouble(num) * Math.PI / 180);
                    break;
                case "tan":
                    result = Math.Tan(Convert.ToDouble(num) * Math.PI / 180);
                    break;
                case "sin-1":
                    result = Math.Asin(Convert.ToDouble(num)) * 180 / Math.PI;
                    break;
                case "cos-1":
                    result = Math.Acos(Convert.ToDouble(num)) * 180 / Math.PI;
                    break;
                case "tan-1":
                    result = Math.Atan(Convert.ToDouble(num)) * 180 / Math.PI;
                    break;
                case "E":
                    result = Math.Pow(10, Convert.ToDouble(num));
                    break;
                case "10^":
                    result = Math.Pow(10, Convert.ToDouble(num));
                    break;
                case "e^":
                    result = Math.Pow(Math.E, Convert.ToDouble(num));
                    break;
            }
            return Convert.ToString(result);
        }
    }
}
