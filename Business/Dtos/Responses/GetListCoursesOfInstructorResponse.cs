using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses
{
    public class GetListCoursesOfInstructorResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
    }

}
