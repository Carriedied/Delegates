using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Unsafe
    {
            
        public delegate void Mydelegate(double a);

        unsafe internal void mas(double a, int b)
        {
            Mydelegate[] md = new Mydelegate[]
            {
                division, multiplication, addition, subtraction
            };

            switch (b)
            {
                case 1:
                    md[b - 1](Convert.ToDouble(a));
                    break;
                case 2:
                    md[b - 1](Convert.ToDouble(a));
                    break;
                case 3:
                    md[b - 1](Convert.ToDouble(a));
                    break;
                case 4:
                    md[b - 1](Convert.ToDouble(a));
                    break;
                default:
                    Program.input1();
                    break;
            }

            Console.ReadKey();
        }

        private static void division(double number_one)
        {
            double c = number_one / number_one;
            Console.WriteLine("division: " + c + " ");
        }

        static void multiplication(double number_one)
        {
            double c = number_one * number_one;
            Console.WriteLine("multiplication: " + c + " ");
        }

        static void addition(double number_one)
        {
            double c = number_one + number_one;
            Console.WriteLine("addition: " + c + " ");
        }

        static void subtraction(double number_one)
        {
            double c = number_one - number_one;
            Console.WriteLine("subtraction: " + c + " ");
        }
    }
}
