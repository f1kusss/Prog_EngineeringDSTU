using System;

namespace Четные_соседи
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, counter=0;

            n = int.Parse(Console.ReadLine());
            int[] array;
            array = new int[n+2];
            array[0] = 0;
            array[n + 1] = 0;
            for (i = 1; i <= n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (i = 1; i <= n; i++)
            {
                if (array[i - 1] % 2 == 0 & array[i + 1] % 2 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Кол-во данных элементов {counter}");
        }
    }
}
