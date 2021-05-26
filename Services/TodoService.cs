using System;
using System.Collections.Generic;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoService
    {
        public List<Todo> GetAllTodos()
        {
            var todos = new List<Todo>();

            var todo = new Todo()
            {
                Id = 1,
                Titel = "School",
                Description = "School trninng",
                createDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogess
            };

            todos.Add(todo);

            var todo1 = new Todo()
            {
                Id = 2,
                Titel = "School",
                Description = "School trninng",
                createDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed
            };

            todos.Add(todo1);

            var todo2 = new Todo()
            {
                Id = 3,
                Titel = "School",
                Description = "School trninng",
                createDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };

            todos.Add(todo2);

            return todos;
        }
    }
}