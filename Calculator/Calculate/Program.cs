using System.Text.RegularExpressions;
using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue, result = 0;
                string action;
                bool check;

                for (int i = 0; ; i++)
                {
                    try
                    {                       
                        if (i == 0)
                        {
                            Console.Write("Введите первое число:\t");
                            check = double.TryParse(Console.ReadLine().Replace(".", ","), out firstValue);
                            if (!check)
                                throw new Exception("\nПервое значение имеет не верный формат!\n");
                        }
                        else
                        {
                            firstValue = result;
                        }

                        Console.Write("\nВведите действие ( + - * / ) или clean для отчистки:\t");

                        action = Console.ReadLine();
                        Regex regex = new Regex("^[-+*/]$");

                        if (action == "clean")
                        {
                            break;
                        }

                        if (!regex.IsMatch(action))
                            throw new Exception("\nВведено не верное действие\n");

                        Console.Write("\nВведите второе число:\t");
                        check = double.TryParse(Console.ReadLine().Replace(".", ","), out secondValue);
                        if (!check)
                            throw new Exception("\nВтороеое значение имеет не верный формат!\n");
                        if (secondValue == 0 && action == "/")
                            throw new Exception("\nНа ноль делить нельзя!\n");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                        if (i != 0)
                        {
                            Console.WriteLine($"Предыдущее значение = {result}");
                        }

                        continue;
                    }

                    var calc = new Calculator();

                    switch (action)
                    {
                        case "+":
                            result = calc.Count(new Addition(), firstValue, secondValue, action);
                            break;
                        case "-":
                            result = calc.Count(new Division(), firstValue, secondValue, action);
                            break;
                        case "*":
                            result = calc.Count(new Multiplication(), firstValue, secondValue, action);
                            break;
                        case "/":
                            result = calc.Count(new Subtraction(), firstValue, secondValue, action);
                            break;
                    }
                }
            }
        }
    }  
}
