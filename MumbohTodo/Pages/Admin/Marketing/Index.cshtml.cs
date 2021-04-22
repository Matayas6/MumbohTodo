using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MumbohTodo.Data;
using MumbohTodo.Models;

namespace MumbohTodo.Pages.Admin.Marketing
{
    public class IndexModel : PageModel
    {
        private readonly MumbohTodo.Data.ToDoDbContext _context;

        public IndexModel(MumbohTodo.Data.ToDoDbContext context)
        {
            _context = context;
        }

        public IList<ToDo> ToDo { get;set; }

        public async Task OnGetAsync()
        {
            ToDo = await _context.ToDos.ToListAsync();
        }
    }
}
