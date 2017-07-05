using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgument
{
    class DecimalLogarithm : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}
