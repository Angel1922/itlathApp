using itlathApp.DAL.Core;
using System;

namespace itlathApp.DAL.Entities
{
    public class Student : Person
    {
        public int Id { get; set; }
        public DateTime Enrollment { get; set; }
        public DateTime DeletedDate { get; internal set; }
        public object EnrollmentDate { get; internal set; }
    }
}
