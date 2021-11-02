using System;

namespace Нахождение_факториала
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, factorial, b;
            factorial = 1;
            Console.Write("Факториал какого числа вам надо посчитать? ");
            p = Convert.ToInt32(Console.ReadLine());
            b = p;
            if (p >= 1)
            {
                do
                {
                    factorial *= p;
                    p--;
                }
                while (p > 0);
                Console.WriteLine($"{b}!={factorial}");
            }
            else if (p == 0)
            {
                Console.WriteLine("0!=1");
            }
            else
            {
                Console.WriteLine("Невозможно посчитать данный факториал");
            }
            
            
        }
    }
}
