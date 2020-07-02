using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Displaying
{
    public class Display
    {
        Calculator c;
        List<string> displaySequence;
        List<string> operatorsToSwap;
        List<string> operatorsToSwapInEscapeSeq;

        public Display(Calculator calculator)
        {
            c = calculator;

            operatorsToSwap = new List<string> { "/", "x", "sqrt", "pi" };
            operatorsToSwapInEscapeSeq = new List<string> { "\u00F7", "\u00D7", "\u221A", "\u03C0" };
        }

        public string SendDisplay()
        {
            displaySequence = new List<string>(c.inputSequence);

            for (int i = 0; i < operatorsToSwap.Count; i++)
                for (int j = 0; j < c.inputSequence.Count; j++)
                    if (operatorsToSwap[i] == c.inputSequence[j])
                        displaySequence[j] = operatorsToSwapInEscapeSeq[i];


            return string.Join("", displaySequence);
        }
    }
}
