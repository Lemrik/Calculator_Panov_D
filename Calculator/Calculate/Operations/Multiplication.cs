﻿using System;

namespace Calculator
{
    class Multiplication : Operation
    {
        public override double count(double firstValue, double secondValue)
        {
            result = firstValue * secondValue;

            return result;
        }
    }
}
