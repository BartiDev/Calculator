using Caliburn.Micro;
using SCInputProcessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SCDesctopUI.ViewModels
{
    public class ShellViewModel : Screen
    {
		private string _calculatorDisplay = "0";
		private string _calculatorAnsDisplay = "0";
		private Visibility _inverseMode = Visibility.Collapsed;
		private Visibility _normalMode = Visibility.Visible;
		private Calculator calculator = new Calculator();
		private static System.Timers.Timer timer;

		public string CalculatorDisplay
		{
			get { return _calculatorDisplay; }
			set { _calculatorDisplay = value; NotifyOfPropertyChange(() => CalculatorDisplay); }
		}
		public string CalculatorAnsDisplay
		{
			get { return _calculatorAnsDisplay; }
			set { _calculatorAnsDisplay = value; NotifyOfPropertyChange(() => CalculatorAnsDisplay); }
		}

		public Visibility InverseMode 
		{
			get { return _inverseMode; } 
			set { _inverseMode = value; NotifyOfPropertyChange(() => InverseMode); } 
		}

		public Visibility NormalMode
		{
			get { return _normalMode; }
			set { _normalMode = value; NotifyOfPropertyChange(() => NormalMode); }
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
		public void MakeEraseInput(MouseButtonEventArgs e)
		{
			if(e.RoutedEvent == UIElement.PreviewMouseLeftButtonDownEvent)
			{
				timer = new System.Timers.Timer(1000);
				timer.Elapsed += Timer_Elapsed;
				timer.AutoReset = false;
				timer.Enabled = true;
			}
			if(e.RoutedEvent == UIElement.PreviewMouseLeftButtonUpEvent)
			{
				timer.Close();
				calculator.inputHandler.HandleEraseInput();

				CalculatorDisplay = calculator.display.SendDisplay();
				UpdateProperties();
			}
		}


		public bool CanMakeEqualInput
		{
			get { return calculator.inputHandler.CanHandleEqualInput(); }
		}
		public void MakeEqualInput()
		{
			calculator.inputHandler.HandleEqualInput();

			CalculatorDisplay = calculator.display.SendDisplay();
			CalculatorAnsDisplay = CalculatorDisplay;
			calculator.ans = CalculatorDisplay;
			UpdateProperties();
		}


		public void MakeInverseInput()
		{
			if (NormalMode == Visibility.Visible)
			{
				NormalMode = Visibility.Collapsed;
				InverseMode = Visibility.Visible;
			}
			else
			{
				NormalMode = Visibility.Visible;
				InverseMode = Visibility.Collapsed;
			}
		}


		public bool CanMakeDegRadConversionInput
		{
			get { return calculator.inputHandler.CanHandleDegRadConversionInput(); }
		}
		public void MakeDegRadConversionInput(string text)
		{
			calculator.inputHandler.HandleDegRadConversionInput(text);

			CalculatorDisplay = calculator.display.SendDisplay();
			UpdateProperties();
		}


		private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			calculator.inputHandler.HandleEraseAllInput();
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
			NotifyOfPropertyChange(() => CanMakeDegRadConversionInput);
		}
	}
}
