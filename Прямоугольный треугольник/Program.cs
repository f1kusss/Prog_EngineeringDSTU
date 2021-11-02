using System;

namespace Прямоугольный_треугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m, j;
            Console.Write("Введите длину катета: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    for (int b = 1; b <= 5000000; b++)
                    {

                    }
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
