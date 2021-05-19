using System;

namespace Калькулятор1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstValue, secondeValue;
                string action;

                Console.WriteLine("Введите число 1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число 2");
                secondeValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/' '^' ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondeValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondeValue);
                        break;
                    case "^":
                        Console.WriteLine(firstValue * firstValue);
                        Console.WriteLine(secondeValue * secondeValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondeValue);
                        break;
                    case "/":
                        if (secondeValue == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondeValue);
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неправильное действие!");
                        break;



                }

                Console.ReadLine();


            }
        }
    }
}
