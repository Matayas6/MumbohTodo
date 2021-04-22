using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MumbohTodo.Data;
using MumbohTodo.Models;

namespace MumbohTodo.Pages.Admin.MyToDo
{

    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly MumbohTodo.Data.ToDoDbContext _context;

        public DeleteModel(MumbohTodo.Data.ToDoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ToDo ToDo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDo = await _context.ToDos
                .FirstOrDefaultAsync(m => m.ToDoID == id);

            if (ToDo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDo = await _context.ToDos.FindAsync(id);

            if (ToDo != null)
            {
                _context.ToDos.Remove(ToDo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
