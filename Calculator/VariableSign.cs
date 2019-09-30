using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public class VariableSign
    {
       

        public event EventHandler SignEvent;

        


        public VariableSign()
        {

            this.SignEvent += this.ChangeSign;
        }

        public void ChangeSign(object o, object e)
        {
            
        }

        

    }
}
