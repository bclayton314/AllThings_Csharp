using ProjectAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectAPI.Data
{
    public class ProjectAPIContext : DbContext
    {
        public ProjectAPIContext(DbContextOptions<ProjectAPIContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}