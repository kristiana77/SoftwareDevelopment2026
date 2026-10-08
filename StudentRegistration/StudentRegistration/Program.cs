using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задача1
            Console.Write("Възраст: ");

            if (int.TryParse(Console.ReadLine(), out int age)) { Console.WriteLine($"Възраст: {age}"); }
            else
            {
                Console.WriteLine("Невалидна възраст.");

            }

            //zadacha2
            Console.Write("Kлас: ");

            while (byte.TryParse(Console.ReadLine(), out byte clas)) { Console.WriteLine($"Клас: {clas}"); }
            Console.WriteLine("Невалиден клас.");






        }
    }
}
