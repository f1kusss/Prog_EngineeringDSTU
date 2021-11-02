using System;

namespace Парные_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum, schet;
            sum = 0;
            schet = 0;
            Console.Write("Введите до какого числа нужно посчитать парные числа: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    schet++;
                    sum += i;
                }
            }
            Console.WriteLine($"Количество парных чисел:{schet}");
            Console.WriteLine($"Сумма этих чисел:{sum}");
        }
    }
}
