using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandlePostUnaryOperatorInput
    {
        public void HandleInput(List<string> inputSequence, string input)
        {
            int sLenght = inputSequence.Count;

            inputSequence.Add(inputSequence[sLenght - 1]);
            inputSequence[sLenght - 1] = "(";
            inputSequence.Add(")");
            inputSequence.Add(input);
        }

        public bool CanHandle(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;

            if (inputSequence[sLenght - 1] == "")
                return false;
            if (inputSequence[sLenght - 1].Contains("-"))
                return false;

            return true;
        }
    }
}
