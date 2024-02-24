using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Course:Entity<Guid>
{
    public Guid CategoryId { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public List<CoursesOfInstructor> CoursesOfInstructors { get; set; }


}
