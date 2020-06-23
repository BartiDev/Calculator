using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class InputHandler
    {
        Calculator c;

        public InputHandler(Calculator calculator)
        {
            c = calculator;
        }

        public void HandleNumericInput(string input)
        {
            int sLenght = c.inputSequence.Count;
            c.inputSequence[sLenght - 1] += input;
        }
    }
}
