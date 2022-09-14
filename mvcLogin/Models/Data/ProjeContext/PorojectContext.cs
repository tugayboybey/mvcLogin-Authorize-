using mvcLogin.Models.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcLogin.Models.Data.ProjeContext
{
    public class PorojectContext:DbContext
    {
        public PorojectContext()
        {


          // Database.Connection.ConnectionString=Connection string yazılacak

        }
        public DbSet<ApplicationUser> Users { get; set; }
    }
}