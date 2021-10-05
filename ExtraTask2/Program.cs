using System;

namespace ExtraTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double Discriminate = Math.Pow(b, 2) - 4 * a * c;

            //Честно не смог придумать как это без if сделать...
            if (Discriminate >= 0)
            {
                double x1 = (-b + Math.Sqrt(Discriminate)) / 2 * a;
                double x2 = (-b - Math.Sqrt(Discriminate)) / 2 * a;

                Console.WriteLine($"Уравнение: {a.ToString("+#; -#; 0")}x^2 " +
                                             $"{b.ToString("+#; -#; 0")}x " +
                                             $"{c.ToString("+#; -#; 0")} = 0");

                Console.WriteLine($"Первый корень х1: {x1}");
                Console.WriteLine($"Второй корень х2: {x2}");
            }
            else
                Console.WriteLine("При отрицательном дискрминанте решения отсутствуют");
        }
    }
}
