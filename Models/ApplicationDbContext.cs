using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cred_operation.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext ():base("Data Source=ASHISH-OWD\\SQLEXPRESS;" +
            "Initial Catalog=cred_operation;Integrated Security=True"){}

       public DbSet<Employee> Employees{ get; set; }


    }
}