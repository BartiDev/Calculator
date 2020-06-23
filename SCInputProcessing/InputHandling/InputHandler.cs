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
        HandleNumericInput handleNumericInput = new HandleNumericInput();
        HandleDotInput handleDotInput = new HandleDotInput();
        HandleBinaryOperatorInput handleBinaryOperatorInput = new HandleBinaryOperatorInput();
        HandleMinusInput handleMinusInput = new HandleMinusInput();

        public InputHandler(Calculator calculator)
        {
            c = calculator;
        }

        public void HandleNumericInput(string input)
        {
            handleNumericInput.HandleInput(c.inputSequence, input);
        }
        public void HandleDotInput()
        {
            handleDotInput.HandleInput(c.inputSequence);
        }
        public void HandleBinaryOperatorInput(string input)
        {
            handleBinaryOperatorInput.HandleInput(c.inputSequence, input);
        }
        public void HandleMinusInput()
        {
            handleMinusInput.HandleInput(c.inputSequence);
        }


        public bool CanHandleNumericInput()
        {
            return handleNumericInput.CanHandle(c.inputSequence);
        }
        public bool CanHandleDotInput()
        {
            return handleDotInput.CanHandle(c.inputSequence);
        }
        public bool CanHandleBinaryOperatorInput()
        {
            return handleBinaryOperatorInput.CanHandle(c.inputSequence);
        }
        public bool CanHandleMinusInput()
        {
            return handleMinusInput.CanHandle(c.inputSequence);
        }

    }
}
