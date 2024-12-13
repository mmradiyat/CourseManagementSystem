using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class DefaultContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=CourseManagementSystem;Trusted_Connection=True;ConnectRetryCount=0");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
