using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sinhvien5tot.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Sinhvien5tot.Models
{
    public class AccountEntity : DbContext
    {
        public AccountEntity() : base("UserConnection")
        {
        }
        public DbSet<Account> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Account>().ToTable("Users");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);

        }

    }
}