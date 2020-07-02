using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleNumericInput
    {
        public void HandleInput(List<string> inputSequence, List<string> constants, string input)
        {
            int sLenght = inputSequence.Count;

            if(sLenght==1 && !constants.Contains(inputSequence[sLenght - 1]))
                inputSequence[sLenght - 1] += input;
            else if(inputSequence[sLenght - 1] == "" && inputSequence[sLenght - 2] == ")")
            {
                inputSequence[sLenght - 1] += "x";
                inputSequence.Add(input);
            }
            else if (constants.Contains(inputSequence[sLenght - 1]))
            {
                inputSequence.Add("x");
                inputSequence.Add(input);
            }
            else
                inputSequence[sLenght - 1] += input;
        }


        public bool CanHandle(List<string> inputSequence, List<string> postUnaryOperators)
        {
            int sLenght = inputSequence.Count;

            if (postUnaryOperators.Contains(inputSequence[sLenght - 1]))
                return false;
            return true;
        }
    }
}
