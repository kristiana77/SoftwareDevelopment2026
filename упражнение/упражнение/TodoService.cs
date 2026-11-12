using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace упражнение
{
    internal class TodoService
    {
        private readonly TodoStorage storage;
        private readonly FileStorage fileStorage;

        public TodoService(FileStorage file)
        {
            this.storage = fileStorage.Load();
            fileStorage = file;
        }

        public IReadOnlyList<TodoItem> GetAll()
        {
            return storage.Todos;
        }


        public TodoItem FindById(int id)
        {
            TodoItem targetTodo = null;
            foreach (TodoItem todoItem in storage.Todos)
            {
                if (todoItem.Id == id)
                {
                    return todoItem;
                }

            }
            return null;
        }

        public void Completed(int id)
        {
            TodoItem todo = FindById(id);
            if (todo == null)
            {
                throw new ArgumentException("Няма задача с такова ID.");
            }
            todo.Completed();

            fileStorage.Save(storage);

        }


        public void Add(string title,string description, DateTime dueDate)
        {
            TodoItem todoItem = new TodoItem(storage.NextId, title, description, dueDate);
            storage.Todos.Add(todoItem);
            storage.NextId++;

            fileStorage.Save(storage);
            
        }


        public void Delete(int id)
        {
            TodoItem todo = FindById(id);
            if (todo == null)
            {
                throw new ArgumentException("Няма задача с такова ID.");
            }
            storage.Todos.Remove(todo);

            fileStorage.Save(storage);
        }

    }
}
