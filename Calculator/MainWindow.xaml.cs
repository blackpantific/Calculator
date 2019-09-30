using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public SnapToArrow snapToArrow;
        public СlcMachine calculator;
        public VariableSign variableSign;
        public MainWindow()
        {
            InitializeComponent();
            //обработка клика стрелки
            snapToArrow = new SnapToArrow();
            //данные для кнопок (и приложения)
            MainGrid.DataContext = snapToArrow;


            //объект калькулятор, в котором производятся все вычислени

            calculator = new СlcMachine();
            variableSign = new VariableSign();


            //вынести привязку в отдельный метод

        }




        private void ArrowButton_Click(object sender, RoutedEventArgs e)
        {

            snapToArrow.Picked = !snapToArrow.Picked;
            snapToArrow.TextDeclaration(snapToArrow.Picked);

        }

        private void Number1_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(1);
        }

        private void Number2_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(2);
        }
        private void Number3_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(3);
        }

        private void Number4_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(4);
        }

        private void Number5_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(5);
        }

        private void Number6_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(6);
        }

        private void Number7_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(7);
        }

        private void Number8_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(8);
        }

        private void Number9_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(9);
        }


        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(0);
        }

        private void CommaButton_Click(object sender, RoutedEventArgs e)
        {
            //calculator.ComaClicked = true;
            calculator.StringRepresOfNum.Add(",");
            ComaButton.IsEnabled = false;
        }


        private void Calculate_Button(object sender, RoutedEventArgs e)
        {
            calculator.ResultCalculation(calculator.OperatorValue);
            ComaButton.IsEnabled = true;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "+";
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "/";
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "*";
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void SubstractionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "-";
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void FactorialButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Factorial(Math.Round(calculator.Result));
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Factorial(Math.Round(calculator.FirstValue));
            }
            ComaButton.IsEnabled = true;
        }

        private void SignButton_Click(object sender, RoutedEventArgs e)
        {
            //if(variableSign.SignEvent != null)
            //variableSign.SignEvent.Invoke(this, null);
        }

        private void SinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Sinus(calculator.Result);
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Sinus(calculator.FirstValue);
            }
            ComaButton.IsEnabled = true;
        }

        private void CosinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Cosinus(calculator.Result);
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Cosinus(calculator.FirstValue);
            }
            ComaButton.IsEnabled = true;
        }

        private void TangensButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Tangens(calculator.Result);
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Tangens(calculator.FirstValue);
            }
            ComaButton.IsEnabled = true;
        }

        private void SquareRootButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Tangens(calculator.Result);
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Tangens(calculator.FirstValue);
            }
            ComaButton.IsEnabled = true;
        }

        private void LogarithmButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Logarithm(calculator.Result);
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Logarithm(calculator.FirstValue);
            }
            ComaButton.IsEnabled = true;
        }

        private void PiButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.SecondValue = 3.141592;
            }
            else
            {
                calculator.FirstValue = 3.141592;
            }
            ComaButton.IsEnabled = true;
        }

        private void ExponentButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.SecondValue = 2.718281;
            }
            else
            {
                calculator.FirstValue = 2.718281;
            }
            ComaButton.IsEnabled = true;
        }
    }
}
