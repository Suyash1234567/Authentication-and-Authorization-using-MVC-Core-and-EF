using Authorizationn.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorizationn
{
    public class LogEntity : DbContext
    {
        public DbSet<LoginTable> LoginTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"data source=localhost\SQLEXPRESS;initial catalog=TestConsoleCrudOperation;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
    }
}
