using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class Processor
    {
        Calculator c;
        ExtractInnerMostParanthesis extractInnerMostParanthesis = new ExtractInnerMostParanthesis();
        CalculateExpression calculateExpression = new CalculateExpression();

        public Processor(Calculator calculator)
        {
            c = calculator;
        }

        public void PerformCalculation()
        {
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
    }
}
