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

        static void AddNewStudent()
        {
            Console.WriteLine("\n--- ДОБАВЯНЕ НА НОВ УЧЕНИК ---");

            int currentId = nextId++;
            string name = ReadValidName();

            // Създаваме обекта с валидни ID и име
            Student student = new Student(currentId, name);

            // Всички останали свойства се задават през методи, които хвърлят изключение 
            // при грешка и я прихващат, докато стойността не се запише успешно в обекта.
            ReadValidAge(student);
            ReadValidGrade(student);
            ReadValidAverageScore(student);
            ReadValidFee(student);
            ReadValidHasScholarship(student);
            ReadValidClassLetter(student);
            ReadValidBirthDate(student);

            students.Add(student);
            Console.WriteLine("\nУченикът е добавен успешно!");
            student.PrintInfo();
        }

        static void CheckStudent()
        {
            Console.WriteLine("\n--- ПРОВЕРКА НА УЧЕНИК ---");
            Console.Write("Въведете име или ID на ученика: ");
            string searchInput = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id.ToString() == searchInput || students[i].Name.ToLower() == searchInput.ToLower())
                {
                    Console.WriteLine("\nНамерено съвпадение:");
                    students[i].PrintInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Не е намерен ученик по въведените критерии.\n");
            }
        }

        static void ShowAllStudents()
        {
            Console.WriteLine("\n--- СПИСЪК С ВСИЧКИ УЧЕНИЦИ ---");
            if (students.Count == 0)
            {
                Console.WriteLine("Няма налични ученици в системата.\n");
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                students[i].PrintInfo();
            }
        }

        static string ReadValidName()
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете име на ученика: ");
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new ArgumentException("Името не може да бъде празно или само интервали.");
                    }
                    return name;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Опитайте отново.");
                }
            }
        }

        static void ReadValidAge(Student student)
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете възраст: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        throw new FormatException("Невалиден формат за цяло число.");
                    }
                    student.Age = age; // Сетърът в Student хвърля ArgumentOutOfRangeException при грешка
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Опитайте отново.");
                }
            }
        }

        static void ReadValidGrade(Student student)
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете клас (1-12): ");
                    if (!int.TryParse(Console.ReadLine(), out int grade))
                    {
                        throw new FormatException("Невалиден формат за цяло число.");
                    }
                    student.Grade = grade;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка: {ex.Message} Опитайте отново.");
                }
            }
        }




    }
}
