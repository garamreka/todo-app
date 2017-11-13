using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
