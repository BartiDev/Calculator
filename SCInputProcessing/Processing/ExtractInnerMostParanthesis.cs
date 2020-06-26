using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.Processing
{
    public class ExtractInnerMostParanthesis
    {
        public int[] Extract(List<string> inputSequence)
        {

            int rParanthesisIndex = inputSequence.FindIndex(s => s == ")");
            int lParanthesisIndex;

            if (rParanthesisIndex != -1)
            {
                int lPositiveParanthesisIndex = inputSequence.FindLastIndex(rParanthesisIndex, s => s == "(");
                int lMinusParanthesisIndex = inputSequence.FindLastIndex(rParanthesisIndex, s => s == "-(");


                if (lPositiveParanthesisIndex == -1)
                    lParanthesisIndex = lMinusParanthesisIndex;
                else if (lMinusParanthesisIndex == -1)
                    lParanthesisIndex = lPositiveParanthesisIndex;
                else
                    lParanthesisIndex = (lMinusParanthesisIndex > lPositiveParanthesisIndex) ? lMinusParanthesisIndex : lPositiveParanthesisIndex;
            }
            else
                return null;

            return new int[2] { lParanthesisIndex, rParanthesisIndex };
        }
    }
}
