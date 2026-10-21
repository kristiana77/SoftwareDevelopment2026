using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSchool
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private int grade;
        private double avarageScore;
        private decimal fee;
        private bool hasScholarship;
        private char classLetter;
        private DateTime birthDate;

        public int Id
        {
            get { return id; }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Идентификаторът трябва да бъде положително цяло число.");
                }
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Името не може да бъде празно или само празни символи.");
                }
                name = value;
            }

        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Възрастта трябва да бъде между 6 и 20 години.");
                }
                age = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Класът трябва да бъде между 1 и 12.");
                }
                grade = value;
            }
        }

        public double AvarageScore
        {
            get { return avarageScore; }
            set
            {
                if (value < 2.00 || value > 6.00)
                {
                    throw new ArgumentOutOfRangeException("Средният успех трябва да бъде между 2.00 и 6.00.");
                }
                avarageScore = value;
            }
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Таксата не може да бъде отрицателна.");
                }
                fee = value;
            }
        }

        public bool HasScholarship
        {
            get { return hasScholarship; }
            set { hasScholarship = value; }
        }

        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("Паралелката трябва да е буква.");
                }
                classLetter = value;
            }
        }


        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Дата на раждане не може да бъде в бъдещето.");
                }
                birthDate = value;
            }
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Име: {Name}");
            Console.WriteLine($"Възраст: {Age}");
            Console.WriteLine($"Клас: {Grade}");
            Console.WriteLine($"Среден успех: {AvarageScore:F2}");
            Console.WriteLine($"Такса: {Fee:C}");
            Console.WriteLine($"Стипендия: {(HasScholarship ? "Да" : "Не")}");
            Console.WriteLine($"Паралелка: {ClassLetter}");
            Console.WriteLine($"Дата на раждане: {BirthDate:dd.MM.yyyy}\n");
        }

    }
}
