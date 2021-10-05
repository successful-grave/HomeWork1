using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число с: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Найдём неизвестную переменную Х из уравнения {a}*X + {b} = {c}");
            Console.WriteLine($"X = ({c} - {b})/{a}");
            double result = (c - b) / a;
            Console.WriteLine($"X = {result}");
        }
    }
}
