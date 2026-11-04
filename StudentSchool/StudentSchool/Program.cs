using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSchool
{
    internal class Program
    {

        private static int nextId = 1;
        private static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            

            Console.WriteLine("=== РЕГИСТРАЦИЯ НА УЧЕНИЦИ ===");
            Console.WriteLine();

            bool running = true;
            while (running)
            {
                Student student = null;
                Console.WriteLine();
               
                while (student == null)
                {
                    Console.Write("Име: ");
                    string nameInput = Console.ReadLine();

                    try
                    {
                        student = new Student(nextId, nameInput);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Грешка: {ex.Message}");
                    }
                }

                
                while (true)
                {
                    Console.Write("Възраст: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("Моля, въведете цяло число.");
                        continue;
                    }

                    try
                    {
                        student.Age = age;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Грешка: {ex.Message}");
                    }
                }

                
                while (true)
                {
                    Console.Write("Клас: ");
                    if (!int.TryParse(Console.ReadLine(), out int grade))
                    {
                        Console.WriteLine("Моля, въведете цяло число.");
                        continue;
                    }

                    try
                    {
                        student.Grade = grade;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Грешка: {ex.Message}");
                    }
                }

               
                while (true)
                {
                    Console.Write("Среден успех (например 4.49): ");
                    if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double score))
                    {
                        Console.WriteLine("Невалиден формат на успеха.");
                        continue;
                    }

                    try
                    {
                        student.AverageScore = score;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Грешка: {ex.Message}");
                    }
                }

                
                while (true)
                {
                    Console.Write("Такса (например 225.50): ");
                    if (!decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal fee))
                    {
                        Console.WriteLine("Невалиден формат на таксата.");
                        continue;
                    }

                    try
                    {
                        student.Fee = fee;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Грешка: {ex.Message}");
                    }
                }

               
                while (true)
                {
                    Console.Write("Паралелка: ");
                    if (!char.TryParse(Console.ReadLine(), out char letter))
                    {
                        Console.WriteLine("Въведете само една буква.");
                        continue;
                    }

                    try
                    {
                        student.ClassLetter = letter;
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Грешка: {ex.Message}");
                    }
                }

                
                while (true)
                {
                    Console.Write("Дата на раждане (дд.ММ.гггг): ");
                    if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                    {
                        Console.WriteLine("Невалиден формат. Например: 08.02.2007");
                        continue;
                    }

                    try
                    {
                        student.BirthDate = date;
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine($"Грешка: {ex.Message}");
                    }
                }

                
                students.Add(student);
                nextId++;

                Console.WriteLine("\nУченикът е записан успешно в списъка!\n");



                Console.WriteLine("=== СПИСЪК С ВСИЧКИ РЕГИСТРИРАНИ УЧЕНИЦИ ===");

                foreach (var s in students)
                {
                    Console.WriteLine();
                    Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
                    Console.WriteLine();
                    Console.WriteLine($"Id: {s.Id}");
                    Console.WriteLine($"Име: {s.Name}");
                    Console.WriteLine($"Възраст: {s.Age}");
                    Console.WriteLine($"Клас: {s.Grade}");
                    Console.WriteLine($"Среден успех: {s.AverageScore.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Такса: {s.Fee.ToString("F2", CultureInfo.InvariantCulture)} лв.");
                    Console.WriteLine($"Стипендия: {(s.HasScholarship ? "Да" : "Не")}");
                    Console.WriteLine($"Паралелка: {s.ClassLetter}");
                    Console.WriteLine($"Дата на раждане: {s.BirthDate:dd.MM.yyyy}");
                }

            }

            
            //Console.WriteLine("=== СПИСЪК С ВСИЧКИ РЕГИСТРИРАНИ УЧЕНИЦИ ===");

            //foreach (var student in students)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
            //    Console.WriteLine();
            //    Console.WriteLine($"Id: {student.Id}");
            //    Console.WriteLine($"Име: {student.Name}");
            //    Console.WriteLine($"Възраст: {student.Age}");
            //    Console.WriteLine($"Клас: {student.Grade}");
            //    Console.WriteLine($"Среден успех: {student.AverageScore.ToString("F2", CultureInfo.InvariantCulture)}");
            //    Console.WriteLine($"Такса: {student.Fee.ToString("F2", CultureInfo.InvariantCulture)} лв.");
            //    Console.WriteLine($"Стипендия: {(student.HasScholarship ? "Да" : "Не")}");
            //    Console.WriteLine($"Паралелка: {student.ClassLetter}");
            //    Console.WriteLine($"Дата на раждане: {student.BirthDate:dd.MM.yyyy}");
            //}

        }
        


    }
}
   

    