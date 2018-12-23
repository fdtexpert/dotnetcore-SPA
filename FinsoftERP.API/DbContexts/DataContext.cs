using Microsoft.EntityFrameworkCore;
using FinsoftERP.API.Models;

namespace FinsoftERP.API.DbContexts
{
    public class ERPContext : DbContext
    {

        public ERPContext(DbContextOptions<ERPContext> options) : base(options)   {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ControlAccountConfigration());
            modelBuilder.ApplyConfiguration(new GeneralAccountConfigration());
            modelBuilder.ApplyConfiguration(new SubsidiaryAccountConfigration());
            modelBuilder.ApplyConfiguration(new AccountTypeSubConfigration());
        }

        //Every time you need to add new Table you add them here.
        public DbSet<ControlAccount> ControlAccounts { get; set; }
        public DbSet<GeneralAccount> GeneralAccounts { get; set; }
        public DbSet<SubsidiaryAccount> SubsidiaryAccounts { get; set; }
        public DbSet<AccountTypeSub> AccountTypeSubCodes { get; set; }

    }
}