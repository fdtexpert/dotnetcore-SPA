using Microsoft.EntityFrameworkCore;
using FinsoftERP.API.Models;

namespace FinsoftERP.API.DbContexts
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options)   {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfigration());
        }

        //Every time you need to add new Table you add them here.
        public DbSet<User> Users { get; set; }

    }
}