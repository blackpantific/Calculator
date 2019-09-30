using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class СlcMachine
    {
        public const int _default_value = 0;
        public double Result { get; set; }

        public bool _operatorClicked = false;

        private bool comaClicked = false;

        private bool _signFirstValue = true;
        private bool _signSecondValue = true;

        //список символов, которые добавляются в него при кликам по кнопкам
        public List<String> StringRepresOfNum;

        //первый операнд
        public double FirstValue { get; set; }

        //второй операнд
        public double SecondValue { get; set; }

        public string OperatorValue { get; set; }

        


        //public bool ComaClicked { get; set; }

        public bool OperatorClicked
        {
            get { return _operatorClicked; }
            set
            {
                _operatorClicked = value;
            }
        }

        public bool FirstSignValue { get => _signFirstValue; set => _signFirstValue = value; }
        public bool SignSecondValue { get => _signSecondValue; set => _signSecondValue = value; }
        public bool ComaClicked { get => comaClicked; set => comaClicked = value; }

        public СlcMachine()
        {
            StringRepresOfNum = new List<string>();
        }


        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Substraction(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Factorial(double x)
        {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }
    
        }

        public double Sinus(double x)
        {
            return Math.Sin(x);
        }

        public double Cosinus(double x)
        {
            return Math.Cos(x);
        }

        public double Tangens(double x)
        {
            return Math.Tan(x);
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public double Logarithm(double x)
        {
            return Math.Log10(x);
        }

        public void AddToExpression(object num)
        {
            StringRepresOfNum.Add(Convert.ToString(num));
        }

        public double SignConverter(bool signValue)
        {
            if (signValue)
            {
                return 1;
            }else
            {
                return -1;
            }
        }

        public void ConvertFirstValue()
        {
            FirstValue = SignConverter(this.FirstSignValue) * Convert.ToDouble(StringRepresOfNum.Aggregate((x, y) => x + y));
            StringRepresOfNum.Clear();
        }
        public void ConvertSecondValue()
        {
            SecondValue = SignConverter(this.SignSecondValue) * Convert.ToDouble(StringRepresOfNum.Aggregate((x, y) => x + y));
            StringRepresOfNum.Clear();
        }

       

        public void ResultCalculation(string _operator)
        {
            switch(_operator)
            {
                case "+":
                    this.ConvertSecondValue();
                    this.Result = this.Sum(FirstValue, SecondValue);
                    break;
                case "-":
                    this.ConvertSecondValue();
                    this.Result = this.Substraction(FirstValue, SecondValue);
                    break;
                case "*":
                    this.ConvertSecondValue();
                    this.Result = this.Mul(FirstValue, SecondValue);
                    break;
                case "/":
                    this.ConvertSecondValue();
                    this.Result = this.Div(FirstValue, SecondValue);
                    break;
                default:
                    this.Result = 0;
                    break;
            }
        }

    }
}
