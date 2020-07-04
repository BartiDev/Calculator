using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class Processor
    {
        Calculator c;
        ExtractInnerMostParanthesis extractInnerMostParanthesis = new ExtractInnerMostParanthesis();
        CalculateExpression calculateExpression = new CalculateExpression();
        EvaluateConstants evaluateConstants = new EvaluateConstants();

        public Processor(Calculator calculator)
        {
            c = calculator;
        }

        public void PerformCalculation()
        {

            evaluateConstants.Evaluate(c.inputSequence, c.ans);

            int[] innerMostParanthesis = null;
            bool minusBeforeLParanthesis;
            List<string> exprestionToCalculate;
            string result;

            if (c.inputSequence[c.inputSequence.Count - 1] == "")
                c.inputSequence.RemoveAt(c.inputSequence.Count - 1);

            do
            {
                innerMostParanthesis = extractInnerMostParanthesis.Extract(c.inputSequence);
                if (innerMostParanthesis != null)
                {
                    minusBeforeLParanthesis = (c.inputSequence[innerMostParanthesis[0]] == "-(") ? true : false;

                    exprestionToCalculate = c.inputSequence.GetRange(innerMostParanthesis[0] + 1, innerMostParanthesis[1] - innerMostParanthesis[0] - 1);
                    result = calculateExpression.calculate(exprestionToCalculate, c.operatorList, c.binaryOperators,
                        c.preUnaryOperators, c.postUnaryOperators);

                    if (minusBeforeLParanthesis)
                    {
                        if (result.Contains("-"))
                        {
                            result = result.Remove(0, 1);
                            c.inputSequence[innerMostParanthesis[0]] = result;
                        }
                        else
                            c.inputSequence[innerMostParanthesis[0]] = "-" + result;
                    }
                    else
                        c.inputSequence[innerMostParanthesis[0]] = result;

                    c.inputSequence.RemoveRange(innerMostParanthesis[0] + 1, innerMostParanthesis[1] - innerMostParanthesis[0]);
                }
                else
                {
                    c.inputSequence[0] = calculateExpression.calculate(c.inputSequence, c.operatorList, c.binaryOperators, 
                        c.preUnaryOperators, c.postUnaryOperators);
                }
            } while (innerMostParanthesis != null);
        }

        public void PerformDegRadConversion(string input)
        {
            double value = 0;

            if (c.constants.Contains(c.inputSequence[0]))
            {
                EvaluateConstants evaluateConstants = new EvaluateConstants();
                evaluateConstants.Evaluate(c.inputSequence, c.ans);
            }


            if (input == "Deg")
                value = Convert.ToDouble(c.inputSequence[0]) * 180 / Math.PI;
            if (input == "Rad")
                value = Convert.ToDouble(c.inputSequence[0]) * Math.PI / 180;
            c.inputSequence[0] = Convert.ToString(value);
        }
    }
}
