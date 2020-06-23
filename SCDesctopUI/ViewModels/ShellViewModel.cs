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
			get { return true; }
		}
		public void MakeNumericInput(string text)
		{
			calculator.inputHandler.HandleNumericInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			NotifyOfPropertyChange(() => CanMakeNumericInput);
		}


		public bool CanMakeDotInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}
		public void MakeDotInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakeDotInput);
		}

		public bool CanMakeEqualInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}

		public void MakeEqualInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakeEqualInput);
		}

		public bool CanMakeBinaryOperatorInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}

		public void MakeBinaryOperatorInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakeBinaryOperatorInput);
		}

		public bool CanMakePreUnaryOperatorInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}

		public void MakePreUnaryOperatorInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakePreUnaryOperatorInput);
		}
		public bool CanMakePostUnaryOperatorInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}

		public void MakePostUnaryOperatorInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakePostUnaryOperatorInput);
		}

		public bool CanMakeParanthesesInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}

		public void MakeParanthesesInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakeParanthesesInput);
		}

		public bool CanMakeEraseInput
		{
			get
			{
				if (string.IsNullOrWhiteSpace(CalculatorDisplay))
					return true;
				return true;
			}
		}

		public void MakeEraseInput(string text)
		{
			CalculatorDisplay += text;
			NotifyOfPropertyChange(() => CanMakeEraseInput);
		}

	}
}
