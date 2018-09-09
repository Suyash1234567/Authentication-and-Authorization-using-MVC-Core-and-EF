using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Authorization.Models;

namespace Authorization.DAL
{
    public class UserContext: DbContext
    {
        public UserContext() : base("UserContext")
        {

        }
        public DbSet<UserLogin> UserLogin { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
