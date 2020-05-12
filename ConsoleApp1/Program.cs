using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            input1();
        }

        public static void input(int c)
        {
            Unsafe uns = new Unsafe();

            double d;
            int e;
            switch (c)
            {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    Console.Write("Введите число, благодаря которому будут производиться вычисления = ");
                    while (!double.TryParse(Console.ReadLine(), out d))
                    {
                        Console.WriteLine("Ошибка ввода!\n");
                        input(c);
                    }
                    Console.Write("Введите действие, которое хотите выполнить:\n" +
                        "1.Деление само на себя\n" +
                        "2.Умножение само на себя\n" +
                        "3.Сложение самого себя\n" +
                        "4.Вычитание из самого себя\n");
                    while (!int.TryParse(Console.ReadLine(), out e))
                    {
                        Console.WriteLine("Ошибка ввода!\n");
                        input(c);
                    }
                    uns.mas(d, e);
                    input1();
                    break;
                default:
                    Console.Write("Введите значение снова.\n");
                    input1();
                    break;
            } 
        }
        public static void input1()
        {
            int c;
            Console.Write("Выберите дальнейшее действие:\n" +
                "1.Закончить рабту\n" +
                "2.Продолжить\n");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Ошибка ввода!\n");
                input(c);
            }
            input(c);
        }
    }
}