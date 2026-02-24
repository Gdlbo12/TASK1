// Дано трехзначное число. Не прибегая к использованию строк вывести наибольшую из его цифр 

namespace FirstApp
{
    public class Logic
    {
        public static int Max(int num)
        {
            int h = num / 100;
            int b = (num / 10) % 10;
            int c = num % 10;

            int max = h;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // начало взаимодействия с пользователем
            int num = 432;
            Console.WriteLine($"Число: {num}");
            // конец взаимодействия с пользователем

            //начало логики
            int max = Logic.Max(num);
            //конец логики

            // начало взаимодействия с пользователем
            Console.WriteLine($"Наибольшая цифра: {max}");
            // конец взаимодействия с пользователем
        }
    }
}