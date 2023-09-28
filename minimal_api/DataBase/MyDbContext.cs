using Microsoft.EntityFrameworkCore;
using minimal_api.Model;
using System.Collections.Generic;

namespace minimal_api.DataBase
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }

        public DbSet<Lock> Lock { get; set; }
    }
}
