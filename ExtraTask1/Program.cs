using System;

namespace ExtraTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Координаты первой точки: ({x1}; {y1})");
            Console.WriteLine($"Координаты второй точки: ({x2}; {y2})");

            double k = (double)(y2 - y1) / (x2 - x1);
            double free_Coefficient = -x1 * k + y1;
            Console.WriteLine($"Уравнение прямой через 2 точки: y = {k}x {free_Coefficient.ToString("+#;-#;0")}");
        }
    }
}
