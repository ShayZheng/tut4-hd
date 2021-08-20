using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

// define the data type 
namespace tut4_hd.Models
{ 
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public class Example : DbContext
    {
        public virtual DbSet<Student> StudentSet { get; set; }
        public virtual DbSet<Unit> UnitSet { get; set; }

    }

    
}