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
        HandlePreUnaryOperatorInput handlePreUnaryOperatorInput = new HandlePreUnaryOperatorInput();
        HandleLParanthesisInput handleLParanthesisInput = new HandleLParanthesisInput();
        HandleRParanthesisInput handleRParanthesisInput = new HandleRParanthesisInput();
        HandlePostUnaryOperatorInput handlePostUnaryOperatorInput = new HandlePostUnaryOperatorInput();

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
        public void HandlePreUnaryOperatorInput(string input)
        {
            handlePreUnaryOperatorInput.HandleInput(c.inputSequence, input);
        }
        public void HandlePostUnaryOperatorInput(string input)
        {
            handlePostUnaryOperatorInput.HandleInput(c.inputSequence, input);
        }
        public void HandleLParanthesisInput()
        {
            handleLParanthesisInput.HandleInput(c.inputSequence);
        }
        public void HandleRParanthesisInput()
        {
            handleRParanthesisInput.HandleInput(c.inputSequence);
        }


        public bool CanHandleNumericInput()
        {
            return handleNumericInput.CanHandle(c.inputSequence, c.postUnaryOperators);
        }
        public bool CanHandleDotInput()
        {
            return handleDotInput.CanHandle(c.inputSequence, c.postUnaryOperators);
        }
        public bool CanHandleBinaryOperatorInput()
        {
            return handleBinaryOperatorInput.CanHandle(c.inputSequence);
        }
        public bool CanHandleMinusInput()
        {
            return handleMinusInput.CanHandle(c.inputSequence);
        }
        public bool CanHandlePreUnaryOperatorInput()
        {
            return handlePreUnaryOperatorInput.CanHandle(c.inputSequence);
        }
        public bool CanHandlePostUnaryOperatorInput()
        {
            return handlePostUnaryOperatorInput.CanHandle(c.inputSequence);
        }
        public bool CanHandleLParanthesisInput()
        {
            return handleLParanthesisInput.CanHandle(c.inputSequence);
        }
        public bool CanHandleRParanthesisInput()
        {
            return handleRParanthesisInput.CanHandle(c.inputSequence, c.binaryOperators);
        }

    }
}
