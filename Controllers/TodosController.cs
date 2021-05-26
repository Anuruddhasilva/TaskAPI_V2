using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Controllers
{
    //  First Test APP
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Todos() 
        {
            var result = GetAllTodos();
            return Ok(result);
        }

        private List<Todo> GetAllTodos()
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
                Id = 1,
                Titel = "School",
                Description = "School trninng",
                createDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed
            };

            todos.Add(todo1);


            var todo2 = new Todo()
            {
                Id = 1,
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
