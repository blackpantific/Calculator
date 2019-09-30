using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public class VariableSign
    {

        public List<string> calculateString;
        //public List<string> calculateStringFirstNumber;
        //public List<string> calculateStringSecondNumber;
        private bool _clearString = false;

        public bool ClearString { get => _clearString; set => _clearString = value; }

        public VariableSign(int defaultvalue)
        {
            calculateString = new List<string>();
            calculateString.Add(defaultvalue.ToString());
           // calculateStringFirstNumber = new List<string>();
           // calculateStringSecondNumber = new List<string>();
        }

        public string ReturnStringValue()
        {
            return calculateString.Aggregate((x, y) => x + y);
        }

        public void AddNewValueToString(string value, bool comaClicked)
        {
            if((calculateString.ElementAt(0) == "0") && (comaClicked == false))
            {
                calculateString.RemoveAt(0);
                calculateString.Add(value);
            }
            else
            {
                calculateString.Add(value);
            }
            
        }
        

    }
}
