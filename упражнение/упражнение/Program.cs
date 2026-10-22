using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace упражнение
{
    internal class Program
    {
        static string filePath = "Zadachi.txt";
        static List<Class> zadacha = new List<Class>();
        private static int nextId = 1;
        
        static void Main(string[] args)
        {
            zarediFile();
            while (true)
            {
                Console.WriteLine("==== TO DO MANAGER ====");
                Console.WriteLine("1.Добави задача");
                Console.WriteLine("2.Всички задачи");
                Console.WriteLine("3.Маркирай решена");
                Console.WriteLine("4.Изтрий задача");
                Console.WriteLine("5.Изход");
                Console.WriteLine("Изберете 1-5:");

                string izbor = Console.ReadLine();

                if (izbor == "1") dobaviZadacha();
                else if (izbor == "2") vijVsichki();
                else if (izbor == "3") Mark();
                else if (izbor == "4") Iztrii();
                else if (izbor == "5")
                {
                    Console.WriteLine("Край"); break;
                }
                else Console.WriteLine("Невалиден избор.Опитай отново.");
            }
        }

        static void zapaziFile()
        {
            List <string> redove=new List<string>();
            foreach (var item in zadacha)
            {
                string red = $"{item.Zaglavie};{item.Opisanie};{item.KraenSrok};{item.Mark}";
                redove.Add(red);
            }
            File.WriteAllLines(filePath, redove);
        }

        static void zarediFile()
        {
            if (!File.Exists(filePath))
            {
                filePath = "Zadachi.txt";
            }
            if (File.Exists(filePath))
                {
                    string[] redove=File.ReadAllLines(filePath);
                    zadacha.Clear();
                    foreach (string red in redove)
                    {
                        string[] chasti = red.Split(';');
                        if( chasti.Length==4)
                        {
                        string zaglavie = chasti[0];
                        string opisanie= chasti[1];
                        int kraenSrok= int.Parse(chasti[2]);
                        bool mark= bool.Parse(chasti[3]);
                        Class z=new Class(nextId,zaglavie, opisanie,kraenSrok);
                        zadacha.Add(z);
                        }
                    }
            }
            
        }

        static void Iztrii()
        {
            vijVsichki();
            if (zadacha.Count == 0) return;
            Console.WriteLine("Въведете номер на задачата:");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= zadacha.Count)
            {
                zadacha.RemoveAt(num - 1);
                Console.WriteLine("Задачата е изтрита");
                vijVsichki();
            }
            else Console.WriteLine("Невалиден номер");

        }

        static void Mark()
        {
            vijVsichki();
            if (zadacha.Count == 0) return;
            Console.WriteLine("Маркирай номер на задача като изпълнена:");
            int num=int.Parse(Console.ReadLine());
            if (num >= 1 && num <= zadacha.Count)
            {
                zadacha[num - 1].Mark = true;
                Console.WriteLine("Задачата е решена");
            }
            else Console.WriteLine("Задачата не е решена");
        }

        static void vijVsichki()
        {
            Console.WriteLine("---Всички задачи---");
            if (zadacha.Count == 0)
            {
                Console.WriteLine("Няма намерени задачи");
                return;
            }
            for(int i = 0; i < zadacha.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {zadacha[i]}");
            }
        }

       

        private static void dobaviZadacha()
        {
            Console.Clear();
            Console.WriteLine("=== Добавяне на задача ===");
            Console.Write("Въведете заглавие:");
            string zaglavie= Console.ReadLine();

            Console.Write("Въведете описание:");
            string opisanie= Console.ReadLine();

            Console.Write("Въведете краен срок:");
            int kraenSrok = int.Parse(Console.ReadLine());

            Class todoItem = new Class(nextId,zaglavie,opisanie,kraenSrok);

            zadacha.Add(todoItem);
            zapaziFile();
            Console.WriteLine("Задачата е добавена успешно");

            
        }


    }
}
