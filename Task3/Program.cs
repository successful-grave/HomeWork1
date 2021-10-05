using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.WriteLine($"Первая строка: {s1}");
            Console.Write("\nВведите вторую строку: ");
            string s2 = Console.ReadLine();
            Console.WriteLine($"Вторая строка: {s2}");
            string s3 = s1;
            s1 = s2;
            s2 = s3;
            Console.WriteLine("\nСтроки поменяны местами");
            Console.WriteLine($"\nПервая строка: {s1}");
            Console.WriteLine($"Вторая строка: {s2}");
        }
    }
}
