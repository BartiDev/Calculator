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
        public string ans = "0";

        public InputHandler inputHandler;
        public Processor processor;
        public Display display;

        public List<List<string>> operatorList;
        public List<string> binaryOperators;
        public List<string> preUnaryOperators;
        public List<string> postUnaryOperators;
        public List<string> constants;

        public Calculator()
        {
            inputSequence = new List<string> { "" };
            inputHandler = new InputHandler(this);
            processor = new Processor(this);
            display = new Display(this);

            //operators list according to the order of operation
            operatorList = new List<List<string>>
            {
                new List<string>{"!", "^2", "ln", "log", "sin", "cos", "tan", "E", "^", "sqrt", "e^", "10^", "sin-1", "cos-1", "tan-1"},
                new List<string>{"x", "/", "%"},
                new List<string>{"+", "-"}
            };
            binaryOperators = new List<string> { "^", "x", "/", "%", "+", "-" };
            preUnaryOperators = new List<string> { "ln", "log", "sqrt", "sin", "cos", "tan", "E", "e^", "10^", "sin-1", "cos-1", "tan-1" };
            postUnaryOperators = new List<string> { "!", "^2" };
            constants = new List<string> { "e", "pi" };
        }

        
    }
}
