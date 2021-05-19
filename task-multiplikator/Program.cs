using System;

namespace task_multiplikator
{

    class Program
    {
        
        
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Контроль нажатия клавиш. Для выхода нажмите Esc.");
                    ConsoleKey k = Console.ReadKey().Key;
                    if (k == ConsoleKey.Escape)
                    {
                        break;
                    }
                    int a;
                    int b;
                    int c;
                    Console.WriteLine("Введите 3 числа");
                    try
                    {
                        a = Convert.ToInt16(Console.ReadLine());
                        b = Convert.ToInt16(Console.ReadLine());
                        c = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введено ненедопустимое значение");
                        continue;
                    }

                    if (a < 0 || b < 0 || c < 0)
                    {
                        Console.WriteLine("Нельзя вводить отриц. значения");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("НОК=" + NOK(a, b, c));
                        Console.WriteLine("НОД=" + NOD(a, b, c));
                    }

                }
            }
            static double NOK(double a, double b, double c)
            {
                double Nok = a * b * c;
                for (int i = 1; i <= Nok; i++)
                {
                    if ((i % a == 0) && (i % b == 0) && (i % c == 0))
                    {
                        return i;
                    }
                }
                return Nok;
            }
            static double NOD(int a, int b, int c)
            {
                int Nod = Math.Min(a, Math.Min(b, c));
                for (; Nod > 1; Nod--)
                {
                    if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                        break;
                }
                return Nod;
            }

        
    }
}

