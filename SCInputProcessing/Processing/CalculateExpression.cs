using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class CalculateExpression
    {
        MakeBinaryCalculation makeBinaryCalculation = new MakeBinaryCalculation();
        MakePreUnaryCalculation makePreUnaryCalculation = new MakePreUnaryCalculation();
        MakePostUnaryCalculation makePostUnaryCalculation = new MakePostUnaryCalculation();

        public string calculate(List<string> expression, List<List<string>> operatorList, List<string> binaryOperators, 
            List<string> preUnaryOperators, List<string> postUnaryOperators) 
        {

            bool firstOrderDone = false;
            bool secondOrderDone = false;

            while (true)
            {
                int eLength = expression.Count;
                string result = "";
                
                if (eLength == 1)
                    return expression[0];
                else
                {
                    if (!firstOrderDone)
                    {
                        for(int i = 0; i < eLength; i++)
                        {
                            if (operatorList[0].Contains(expression[i]))
                            {
                                if (preUnaryOperators.Contains(expression[i]))
                                {
                                    result = makePreUnaryCalculation.calculate(expression[i + 1], expression[i]);
                                    expression[i] = result;
                                    expression.RemoveAt(i + 1);
                                    break;
                                }
                                else if (postUnaryOperators.Contains(expression[i]))
                                {
                                    result = makePostUnaryCalculation.calculate(expression[i - 1], expression[i]);
                                    expression[i - 1] = result;
                                    expression.RemoveAt(i);
                                    break;
                                }
                                else if (binaryOperators.Contains(expression[i]))
                                {
                                    result = makeBinaryCalculation.calculate(expression[i - 1], expression[i], expression[i + 1]);
                                    expression[i - 1] = result;
                                    expression.RemoveAt(i);
                                    expression.RemoveAt(i);
                                    break;
                                }
                            }
                            if (i == eLength - 1)
                                firstOrderDone = true;
                        }
                    }

                    if (!firstOrderDone)
                        continue;

                    if (!secondOrderDone)
                    {
                        for (int i = 0; i < eLength; i++)
                        {
                            if (operatorList[1].Contains(expression[i]))
                            {
                                result = makeBinaryCalculation.calculate(expression[i - 1], expression[i], expression[i + 1]);
                                expression[i - 1] = result;
                                expression.RemoveAt(i);
                                expression.RemoveAt(i);
                                break;
                            }
                            if (i == eLength - 1)
                                secondOrderDone = true;
                        }
                    }

                    if (!secondOrderDone)
                        continue;

                    
                        for (int i = 0; i < eLength; i++)
                        {
                            if (operatorList[2].Contains(expression[i]))
                            {
                                result = makeBinaryCalculation.calculate(expression[i - 1], expression[i], expression[i + 1]);
                                expression[i - 1] = result;
                                expression.RemoveAt(i);
                                expression.RemoveAt(i);
                                break;
                            }
                        }
                }
            }
        }
    }
}
