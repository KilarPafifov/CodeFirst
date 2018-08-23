
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;


namespace CodeFirst.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
       
    }
}