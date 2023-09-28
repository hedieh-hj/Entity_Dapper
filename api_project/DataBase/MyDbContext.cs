using api_project.Model;
using Microsoft.EntityFrameworkCore;

namespace api_project.DataBase
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {}

        public DbSet<Lock> Lock { get; set; }
    }
}
