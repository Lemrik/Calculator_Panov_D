using System;

namespace Calculator
{
    class Addition : Operation
    {
        public override double count(double firstValue, double secondValue)
        {
            result = firstValue + secondValue;

            return result;
        }
    }
}
