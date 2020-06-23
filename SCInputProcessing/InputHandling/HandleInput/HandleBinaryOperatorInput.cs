using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleBinaryOperatorInput
    {
        public void HandleInput(List<string> inputSequence, string input)
        {
            inputSequence.Add(input);
            inputSequence.Add("");
        }

        public bool CanHandle(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;
            if (inputSequence[sLenght - 1] == "")
                return false;
            return true;
        }
    }
}
