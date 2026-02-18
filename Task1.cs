// Дано трехзначное число. Не прибегая к использованию строк вывести наибольшую из его цифр 

namespace FirstApp
{

    public class LogicOne // класс разделение на цифры
    {
        public static void Num(int num, out int h, out int b, out int c)
        {
            h = num / 100;
            b = (num / 10) % 10;
            c = num % 10;
        }
    }
    public class LogicTwo // класс выбор наибольшей
    {
        public static int Max(int h, int b, int c)
        {
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

            //начало логики (разделение на цифры)
            int h, b, c;
            LogicOne.Num(num, out h, out b, out c);
            //конец  логики (разделение на цифры)

            //начало логики (выбор наибольшей)
            int max = LogicTwo.Max(h, b, c);
            //конец логики (выбор наибольшей)

            // начало взаимодействия с пользователем
            Console.WriteLine($"Наибольшая цифра: {max}");
            // конец взаимодействия с пользователем
        }
    }
}