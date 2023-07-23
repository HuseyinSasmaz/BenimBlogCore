using BlogApi.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Models.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MYHP\\SQLEXPRESS;database=DbBenimBlogApi;integrated security=true");

        }

        public DbSet<Calısan> Calısans { get; set; }    
    }
}
