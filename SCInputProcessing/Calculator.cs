using SCInputProcessing.Displaying;
using SCInputProcessing.InputHandling;
using SCInputProcessing.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing
{
    public class Calculator
    {
        public List<string> inputSequence;

        public InputHandler inputHandler;
        public Processor processor;
        public Display display;

        public Calculator()
        {
            inputSequence = new List<string>() { "" };
            inputHandler = new InputHandler(this);
            processor = new Processor(this);
            display = new Display(this);
        }

        
    }
}
