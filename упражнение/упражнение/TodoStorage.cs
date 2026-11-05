using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace упражнение
{
    internal class TodoStorage
    {
        public List<TodoItem> Todos { get; set; }
        public int NextId { get; set; } = 1;
        private readonly static List<TodoItem> todos = new List<TodoItem>();
        private int nextId = 1;

        public TodoStorage() 
        { 
        
        
        }
    }
}
