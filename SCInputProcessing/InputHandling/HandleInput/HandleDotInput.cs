using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleDotInput
    {
        public void HandleInput(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;

            if (sLenght > 1)
            {
                if (inputSequence[sLenght - 1] == "" && inputSequence[sLenght - 2] == ")")
                {
                    inputSequence[sLenght - 1] += "x";
                    inputSequence.Add(".");
                }
                else
                    inputSequence[sLenght - 1] += ".";
            }
            else
                inputSequence[sLenght - 1] += ".";
        }

        public bool CanHandle(List<string> inputSequence, List<string> postUnaryOperators)
        {
            int sLenght = inputSequence.Count;
            if (inputSequence[sLenght - 1].Contains("."))
                return false;
            if (postUnaryOperators.Contains(inputSequence[sLenght - 1]))
                return false;
            return true;
        }
    }
}
