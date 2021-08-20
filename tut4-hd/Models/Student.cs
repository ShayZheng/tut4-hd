using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// define the data type 
namespace tut4_hd.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public virtual ICollection<Unit> Unit { get; set; }

    }
}