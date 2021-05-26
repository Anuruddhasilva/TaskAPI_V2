using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Titel { get; set; }

        public string Description { get; set; }

        public DateTime createDate { get; set; }

        public DateTime DueDate { get; set; }

        public TodoStatus Status { get; set; }
    }
}
