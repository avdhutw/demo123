using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace DemoMvc.Models
{

    public class Employeecontext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
    }
    
}