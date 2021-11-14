using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StaticWebsite.Services
{
    public class EmployeesDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}