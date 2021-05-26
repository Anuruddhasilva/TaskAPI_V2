using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    //  First Test APP
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _TodoService;

        public TodosController(ITodoRepository repository)
        {
            _TodoService = repository;
        }

        [HttpGet]
        public IActionResult Todos(int? ID)
        {
            var result = _TodoService.GetAllTodos();

            if (ID is null) return Ok(result);
            else result = result.Where(t => t.Id == ID).ToList(); return Ok(result);

            return Ok(result);
        }
    }
}