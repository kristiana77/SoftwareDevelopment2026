using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упражнение
{
    internal class Class
    {
        public int Id { get; set; }
        public string Zaglavie {  get; set; }
        public string Opisanie { get; set; }
        public int KraenSrok {  get; set; }
        public bool Mark {  get; set; }

        public Class(int id,string zaglavie, string opisanie, int kraenSrok)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id трябва да е положително");
            }
            if (string.IsNullOrEmpty(zaglavie))
            {
                throw new ArgumentNullException("Заглоавие е задължително");
            }
            Id = id;
            Zaglavie = zaglavie;
            Opisanie = opisanie;
            KraenSrok = kraenSrok;
            Mark = false;
        }

        public override string ToString()
        {
            string status = Mark ? "[X] изпълнена" : "[ ] неизпълнена";
            return $"{status} | Заглавие:{Zaglavie} | Описание:{Opisanie} | Краен срок:{KraenSrok} |";
        }
    }
}
