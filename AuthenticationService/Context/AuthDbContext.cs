using System.Collections.Generic;
using AuthenticationService.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.Context
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}
