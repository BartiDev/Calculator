using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleNumericInput
    {
        public void HandleInput(List<string> inputSequence, string input)
        {
            int sLenght = inputSequence.Count;
            inputSequence[sLenght - 1] += input;
        }

        public bool CanHandle(List<string> inputSequence)
        {
            return true;
        }
    }
}
