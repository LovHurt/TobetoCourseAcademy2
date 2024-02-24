using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CoursesOfInstructor:Entity<Guid>
    {
        public Guid CourseId  { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }

}
