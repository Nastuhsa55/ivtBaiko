using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator  
{
    class Multiplication: ICalculator 
    {
        public double Calculate (double first, double second)
        {
            return first * second;
        }
    }
}
