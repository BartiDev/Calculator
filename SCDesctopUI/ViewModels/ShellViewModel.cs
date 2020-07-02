using Caliburn.Micro;
using SCInputProcessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDesctopUI.ViewModels
{
    public class ShellViewModel : Screen
    {
		private string _calculatorDisplay;
		private Calculator calculator = new Calculator();

		public string CalculatorDisplay
		{
			get { return _calculatorDisplay; }
			set { _calculatorDisplay = value; NotifyOfPropertyChange(() => CalculatorDisplay); }
		}

		public bool CanMakeNumericInput 
		{ 
			get { return calculator.inputHandler.CanHandleNumericInput(); }
		}
		public void MakeNumericInput(string text)
		{
			calculator.inputHandler.HandleNumericInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeDotInput
		{
			get { return calculator.inputHandler.CanHandleDotInput(); }
		}
		public void MakeDotInput()
		{
			calculator.inputHandler.HandleDotInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeConstantInput
		{
			get { return calculator.inputHandler.CanHandleConstantInput(); }
		}
		public void MakeConstantInput(string text)
		{
			calculator.inputHandler.HandleConstantInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeBinaryOperatorInput
		{
			get { return calculator.inputHandler.CanHandleBinaryOperatorInput(); }	
		}
		public void MakeBinaryOperatorInput(string text)
		{
			calculator.inputHandler.HandleBinaryOperatorInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeMinusInput
		{
			get { return calculator.inputHandler.CanHandleMinusInput(); }
		}
		public void MakeMinusInput()
		{
			calculator.inputHandler.HandleMinusInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakePreUnaryOperatorInput
		{
			get { return calculator.inputHandler.CanHandlePreUnaryOperatorInput(); }
		}
		public void MakePreUnaryOperatorInput(string text)
		{
			calculator.inputHandler.HandlePreUnaryOperatorInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakePostUnaryOperatorInput
		{
			get { return calculator.inputHandler.CanHandlePostUnaryOperatorInput(); }
		}
		public void MakePostUnaryOperatorInput(string text)
		{
			calculator.inputHandler.HandlePostUnaryOperatorInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeLParanthesisInput
		{
			get { return calculator.inputHandler.CanHandleLParanthesisInput(); }
		}
		public void MakeLParanthesisInput()
		{
			calculator.inputHandler.HandleLParanthesisInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeRParanthesisInput
		{
			get { return calculator.inputHandler.CanHandleRParanthesisInput(); }
		}
		public void MakeRParanthesisInput()
		{
			calculator.inputHandler.HandleRParanthesisInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeEraseInput
		{
			get { return calculator.inputHandler.CanHandleEraseInput(); }
		}
		public void MakeEraseInput()
		{
			calculator.inputHandler.HandleEraseInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		public bool CanMakeEqualInput
		{
			get { return calculator.inputHandler.CanHandleEqualInput(); }
		}
		public void MakeEqualInput()
		{
			calculator.inputHandler.HandleEqualInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		

		private void UpdateProperties()
		{
			NotifyOfPropertyChange(() => CanMakeBinaryOperatorInput);
			NotifyOfPropertyChange(() => CanMakeDotInput);
			NotifyOfPropertyChange(() => CanMakeConstantInput);
			NotifyOfPropertyChange(() => CanMakeNumericInput);
			NotifyOfPropertyChange(() => CanMakeMinusInput);
			NotifyOfPropertyChange(() => CanMakePreUnaryOperatorInput);
			NotifyOfPropertyChange(() => CanMakePostUnaryOperatorInput);
			NotifyOfPropertyChange(() => CanMakeLParanthesisInput);
			NotifyOfPropertyChange(() => CanMakeRParanthesisInput);
			NotifyOfPropertyChange(() => CanMakeEraseInput);
			NotifyOfPropertyChange(() => CanMakeEqualInput);
		}
	}
}
