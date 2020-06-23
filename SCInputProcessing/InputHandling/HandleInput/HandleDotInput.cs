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
            inputSequence[sLenght - 1] += ".";
        }

        public bool CanHandle(List<string> inputSequence)
        {
            int sLenght = inputSequence.Count;
            if (inputSequence[sLenght - 1].Contains("."))
                return false;
            return true;
        }
    }
}
