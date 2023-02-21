using Microsoft.EntityFrameworkCore;
using Todo_list.Models;

namespace Todo_list.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}


