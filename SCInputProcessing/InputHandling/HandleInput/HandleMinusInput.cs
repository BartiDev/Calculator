using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleMinusInput
    {
        public void HandleInput(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;
            if(sLenght>1&& inputSequence[sLenght - 1] == ""&& inputSequence[sLenght - 2] == ")")
            {
                inputSequence.Add("-");
                inputSequence.Add("");
            }
            else if (inputSequence[sLenght - 1] == "")
                inputSequence[sLenght - 1] += "-";
            else
            {
                inputSequence.Add("-");
                inputSequence.Add("");
            }
        }

        public bool CanHandle(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;

            if (inputSequence[sLenght - 1] == "-")
                return false;

            if (inputSequence.Count > 1)
                if (inputSequence[sLenght - 2] == "-")
                    return false;

            return true;
        }
    }
}
