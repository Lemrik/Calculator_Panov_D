using System;

namespace Calculator
{ 
    class Division : Operation
    {
        public override double count(double firstValue, double secondValue)
        {
            result = firstValue - secondValue;

            return result;
        }
    }
}
