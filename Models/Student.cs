using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Enrollment { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}