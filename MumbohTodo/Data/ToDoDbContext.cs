using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MumbohTodo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MumbohTodo.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
