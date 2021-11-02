using System;

namespace Перевод_числа_в_день_недели
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write("Введите номер: ");
            day = Convert.ToInt32(Console.ReadLine());
            string dayname;
            switch (day)
            {
                case 1:
                    dayname = "Понедельник";
                    break;
                case 2:
                    dayname = "Вторник";
                    break;
                case 3:
                    dayname = "Среда";
                    break;
                case 4:
                    dayname = "Четверг";
                    break;
                case 5:
                    dayname = "Пятница";
                    break;
                case 6:
                    dayname = "Суббота";
                    break;
                case 7:
                    dayname = "Воскресенье";
                    break;
                default:
                    dayname = $"Ошибка: дня с номером {day} не существует";
                    break;
            }
            Console.WriteLine(dayname);
            Console.ReadKey();
        }
    }
}
