using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MumbohTodo.Models
{
    public class ToDo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ToDoID { get; set; }

        [EmailAddress]
        public String Email { get; set; }

        public String Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }


        
        [Display(Name ="Date Added")]
        public DateTime AddedDate { get; set; }

        
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        
        public Boolean Done { get; set; }

      
        [Display(Name = "Done Date")]
        public DateTime DoneDate { get; set; }

        
    }
}
