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


            Database.Connection.ConnectionString = @"Server=DESKTOP-860742Q;Database=KD5MvcLogin;Uid=sa;Pwd=tugay1905;";


        }
        public DbSet<ApplicationUser> Users { get; set; }
    }
}