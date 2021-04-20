using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MumbohTodo.Models
{
    public class AddToDo
    {
        public int AddToDoID { get; set; }

        public String User { get; set; }

        public ICollection<ToDo> ToDos;
    }
}
