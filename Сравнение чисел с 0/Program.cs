using System;

namespace Сравнение_чисел_с_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if (a < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число равно нулю");
            }
            Console.ReadKey();
        }
    }
}
