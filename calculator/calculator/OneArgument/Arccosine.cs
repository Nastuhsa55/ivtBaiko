﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgument
{
    class Arccosine : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
