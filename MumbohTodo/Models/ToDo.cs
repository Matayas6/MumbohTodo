using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MumbohTodo.Models
{
    public class ToDo
    {
        public int ToDoID { get; set; }

        [EmailAddress]
        public String Email { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public String AddedDate { get; set; }

        
        public String DueDate { get; set; }

        public String Done { get; set; }

        public String DoneDate { get; set; }

        public int AddToDoID { get; set; }

        public AddToDo AddToDo { get; set;  }
    }
}
