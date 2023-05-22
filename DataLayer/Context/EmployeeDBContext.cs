using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace DataLayer.Context
{
  public class EmployeeDBContext : DbContext
  {
    public EmployeeDBContext (DbContextOptions<EmployeeDBContext> options) : base(options)
    {

    }
    // these are your context tables
    // refernced as using DataLayer.Context ;
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }
  }
}
