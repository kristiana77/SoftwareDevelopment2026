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

        }
    }
}
