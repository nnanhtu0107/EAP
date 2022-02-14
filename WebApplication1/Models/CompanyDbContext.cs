using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("name=DefaultConnection"){ }
        public DbSet<Employee> Employees { get; set; }
    }
}

