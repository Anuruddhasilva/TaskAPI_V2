using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Controllers
{
    //  First Test APP
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTask()
        {
            var Result = new string[] { "String 1" ,"String 2" };

            return Ok(Result);
        }


        [HttpPost]
        public IActionResult GetNewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            return Ok();
        }
    }
}
