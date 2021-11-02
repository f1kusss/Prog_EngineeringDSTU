using System;

namespace Скидка
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите стоимость покупки: ");
            a = Convert.ToDouble(Console.ReadLine());
            if ((a >= 500) && (a < 1000))
            {
                a *= 0.97;
                Console.WriteLine($"С учетом скидки в 3% ваша стоимость покупки {a}р.");
            }
            else if (a >= 1000)
            {
                a *= 0.95;
                Console.WriteLine($"С учетом скидки в 5% ваша стоимость покупки {a}р.");
            }
            else
            {
                Console.WriteLine($"У вас нет скидки. Стоимость вашей покупки {a}р.");
            }
            Console.ReadKey();
        }
    }
}
