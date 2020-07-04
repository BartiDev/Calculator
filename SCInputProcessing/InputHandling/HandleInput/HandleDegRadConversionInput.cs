using SCInputProcessing.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleDegRadConversionInput
    {
        public void HandleInput()
        {
        }

        public bool CanHandle(List<string> inputSequence)
        {
            int sLength = inputSequence.Count;

            if (sLength > 1 && inputSequence[0] != "")
                return false;
            return true;
        }
    }
}
