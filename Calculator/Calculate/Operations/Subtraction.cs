using System;

namespace Calculator
{
    class Subtraction : Operation
    {
        public override double count(double firstValue, double secondValue)
        {
            result = firstValue / secondValue;

            return result;
        }
    }
}
