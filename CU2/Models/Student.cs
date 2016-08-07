using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CU2.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Enrollments property is a navigation property.Navigation properties hold other entities that are related to this entity
        //Navigation properties are typically defined as virtual so that they can take advantage of certain Entity Framework functionality such as lazy loading. 
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}