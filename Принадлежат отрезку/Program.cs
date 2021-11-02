using System;

namespace Принадлежат_отрезку
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите 3 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a >= 1) && (a <= 3))
            {

                Console.WriteLine($"Число {a} принадлежит отрезку");
            }
            if ((b >= 1) && (b <= 3))
            {
                Console.WriteLine($"Число {b} принадлежит отрезку");
            }
            if ((c >= 1) && (c <= 3))
            {
                Console.WriteLine($"Число {c} принадлежит отрезку");
            }
        }
    }
}
