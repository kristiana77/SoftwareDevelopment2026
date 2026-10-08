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
            int age;
            while(!int.TryParse(Console.ReadLine(), out age)) 
            { Console.Write("Възраст: "); Console.WriteLine("Невалидна възраст.");}
            Console.WriteLine($"Възраст: {age}"); 

            //zadacha2
            Console.Write("Kлас: ");
            byte clas;
            while (!byte.TryParse(Console.ReadLine(), out clas)) {Console.Write("Kлас: "); Console.WriteLine("Невалиден клас."); }
            Console.WriteLine($"Клас: {clas}");


            //zadacha3
            


        }
    }
}
