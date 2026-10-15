using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Начало на програмата");

            try
            {
                Console.Write("Въведете число: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine($"Въведохте: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Грешка! Трябва да въведете число.");
            }

            Console.WriteLine("Край на програмата");


            //2
            int a = 20;
            int b = 4;

            Console.WriteLine("Изчисляване на частно");

            try
            {
                int result = a / b;
                Console.WriteLine($"Резултат: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Грешка! Деление на нула е невъзможно.");
            }
            Console.WriteLine("Изчислението приключи.");



        }
    }
}
