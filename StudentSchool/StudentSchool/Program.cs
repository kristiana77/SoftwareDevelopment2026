using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSchool
{
    internal class Program
    {
        static int nextId = 1;
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("--- МЕНЮ УПРАВЛЕНИЕ НА УЧЕНИЦИ ---");
                Console.WriteLine("1. Добавяне на нов ученик");
                Console.WriteLine("2. Проверка на ученик");
                Console.WriteLine("3. Справка за всички ученици");
                Console.WriteLine("4. Изход");
                Console.Write("Изберете опция (1-4): ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddNewStudent();
                }
                else if (choice == "2")
                {
                    CheckStudent();
                }
                else if (choice == "3")
                {
                    ShowAllStudents();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Благодарим ви, че използвахте програмата. Приятен ден!");
                    break;
                }
                else
                {
                    Console.WriteLine("Невалиден избор. Моля, опитайте отново.");
                }

            }
        }        
    }
}
