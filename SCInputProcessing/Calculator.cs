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

        public List<List<string>> operatorList;
        public List<string> binaryOperators;
        public List<string> preUnaryOperators;
        public List<string> postUnaryOperators;

        public Calculator()
        {
            inputSequence = new List<string> { "" };
            inputHandler = new InputHandler(this);
            processor = new Processor(this);
            display = new Display(this);

            //operators list according to the order of operation
            operatorList = new List<List<string>>
            {
                new List<string>{"!", "ln", "log", "sin", "cos", "tan", "E", "^", "sqrt"},
                new List<string>{"x", "/", "%"},
                new List<string>{"+", "-"}
            };
            binaryOperators = new List<string> { "^", "x", "/", "%", "+", "-" };
            preUnaryOperators = new List<string> { "ln", "log", "sqrt", "sin", "cos", "tan", "E" };
            postUnaryOperators = new List<string> { "!" };
        }

        
    }
}
