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
            variableSign = new VariableSign(СlcMachine._default_value);
            numbersBlock.Text = variableSign.ReturnStringValue();


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
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("1", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("1", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void Number2_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(2);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("2", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("2", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }
        private void Number3_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(3);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("3", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("3", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void Number4_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(4);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("4", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("4", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void Number5_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(5);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("5", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("5", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void Number6_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(6);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("6", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("6", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void Number7_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(7);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("7", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("7", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void Number8_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(8);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("8", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("8", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void Number9_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(9);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("9", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("9", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }


        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(0);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("0", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }
                
                variableSign.AddNewValueToString("0", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
     
        }

        private void CommaButton_Click(object sender, RoutedEventArgs e)
        {
            //calculator.ComaClicked = true;
            calculator.StringRepresOfNum.Add(",");
            ComaButton.IsEnabled = false;
            calculator.ComaClicked = true;
            variableSign.AddNewValueToString(",", calculator.ComaClicked);
            numbersBlock.Text = variableSign.ReturnStringValue();
        }


        private void Calculate_Button(object sender, RoutedEventArgs e)
        {
            calculator.ResultCalculation(calculator.OperatorValue);
            ComaButton.IsEnabled = true;
            //копирнуть эти 3 строчки
            variableSign.calculateString.Clear();
            variableSign.calculateString.Add(calculator.Result.ToString());
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "+";
            calculator.ComaClicked = false;
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void DivisionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "/";
            calculator.ComaClicked = false;
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "*";
            calculator.ComaClicked = false;
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void SubstractionButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.ConvertFirstValue();
            calculator.OperatorValue = "-";
            calculator.ComaClicked = false;
            calculator.OperatorClicked = true;
            ComaButton.IsEnabled = true;
        }

        private void FactorialButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Factorial(Math.Round(calculator.Result));

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Factorial(Math.Round(calculator.FirstValue));

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            ComaButton.IsEnabled = true;
        }

        private void SignButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.SignSecondValue = !calculator.SignSecondValue;
            }
            else
            {
                calculator.FirstSignValue = !calculator.FirstSignValue;
            }
        }

        private void SinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Sinus(calculator.Result);

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Sinus(calculator.FirstValue);

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            ComaButton.IsEnabled = true;
        }

        private void CosinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Cosinus(calculator.Result);

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Cosinus(calculator.FirstValue);

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            ComaButton.IsEnabled = true;
        }

        private void TangensButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculator.OperatorClicked)
            {
                calculator.ResultCalculation(calculator.OperatorValue);
                calculator.Result = calculator.Tangens(calculator.Result);

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            else
            {
                calculator.ConvertFirstValue();
                calculator.Result = calculator.Tangens(calculator.FirstValue);

                variableSign.calculateString.Clear();
                variableSign.calculateString.Add(calculator.Result.ToString());
                numbersBlock.Text = variableSign.ReturnStringValue();
            }
            ComaButton.IsEnabled = true;
        }

        private void SquareRootButton_Click(object sender, RoutedEventArgs e)
        {
            if (snapToArrow.Picked)
            {
                if (calculator.OperatorClicked)
                {
                    calculator.ResultCalculation(calculator.OperatorValue);
                    calculator.Result = Math.Sqrt(calculator.Result);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
                else
                {
                    calculator.ConvertFirstValue();
                    calculator.Result = Math.Sqrt(calculator.FirstValue);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
            }
            else
            {
                if (calculator.OperatorClicked)
                {
                    calculator.ResultCalculation(calculator.OperatorValue);
                    calculator.Result = 1/(calculator.Result);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
                else
                {
                    calculator.ConvertFirstValue();
                    calculator.Result = 1/(calculator.FirstValue);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
            }
            ComaButton.IsEnabled = true;
        }

        private void LogarithmButton_Click(object sender, RoutedEventArgs e)
        {
            if (snapToArrow.Picked)
            {
                if (calculator.OperatorClicked)
                {
                    calculator.ResultCalculation(calculator.OperatorValue);
                    calculator.Result = calculator.Logarithm(calculator.Result);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
                else
                {
                    calculator.ConvertFirstValue();
                    calculator.Result = calculator.Logarithm(calculator.FirstValue);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
            }
            else
            {
                if (calculator.OperatorClicked)
                {
                    calculator.ResultCalculation(calculator.OperatorValue);
                    calculator.Result = Math.Log(calculator.Result);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
                else
                {
                    calculator.ConvertFirstValue();
                    calculator.Result = Math.Log(calculator.FirstValue);

                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add(calculator.Result.ToString());
                    numbersBlock.Text = variableSign.ReturnStringValue();
                }
            }
            ComaButton.IsEnabled = true;
        }

        private void PiButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(3.14);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("3,14", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("3,14", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }

        private void ExponentButton_Click(object sender, RoutedEventArgs e)
        {
            calculator.AddToExpression(2.718281);
            if (!calculator.OperatorClicked)
            {
                variableSign.AddNewValueToString("2.718281", calculator.ComaClicked);
            }
            else
            {
                if (!variableSign.ClearString)
                {
                    variableSign.calculateString.Clear();
                    variableSign.calculateString.Add("0");
                    variableSign.ClearString = true;
                }

                variableSign.AddNewValueToString("2.718281", calculator.ComaClicked);
            }
            numbersBlock.Text = variableSign.ReturnStringValue();
        }
    }
}
