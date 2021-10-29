using System;

namespace Calculator
{
    class Calculator
    {
        private double result;
        public double Count(Operation operation, double firstValue, double secondValue, string action)
        {
            result = operation.count(firstValue, secondValue);
            Console.WriteLine($"\nРезультат: { firstValue} {action} { secondValue} = {result}");

            return result;
        }
    }
}
