using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = (5 * a + Math.Pow(b, 4)) / (b - a);
            //По хорошему здесь нужна проверка, что b != a
            //иначе получим ошибку деления на 0
            //но if мы пока не знаем :)
            Console.WriteLine($"(5 * {a} + {b}^4)/({b - a}) = {result}");
        }
    }
}
