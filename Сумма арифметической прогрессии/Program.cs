using System;

namespace Сумма_арифметической_прогрессии
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum, shag, chlen;
            sum = 0;
            Console.Write("Введите шаг: ");
            shag = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите первый член: ");
            chlen = Convert.ToInt32(Console.ReadLine());
            Console.Write("До какого члена считаем? ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += chlen;
                chlen += shag;
            }
            Console.WriteLine($"Сумма вашей арифметической прогрессии равна {sum}");
        }
    }
}
