using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleConstantInput
    {
        public void HandleInput(List<string> inputSequence, string input)
        {
            int sLenght = inputSequence.Count;

            if (inputSequence[0] == "")
                inputSequence[0] = input;
            else if (inputSequence[sLenght - 1] == "" && inputSequence[sLenght - 2] == ")")
            {
                inputSequence[sLenght - 1] = "x";
                inputSequence.Add(input);
            }
            else if (inputSequence[sLenght - 1] == "")
                inputSequence[sLenght - 1] = input;
            else if (inputSequence[sLenght - 1] != "")
            {
                inputSequence.Add("x");
                inputSequence.Add(input);
            }
        }

        public bool CanHandle(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;
            return true;
        }
    }
}
