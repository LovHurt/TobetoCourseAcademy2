using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts.EntityConfigurations
{
    public class CoursesOfInstructorConfiguration
    {
        public void Configure(EntityTypeBuilder<CoursesOfInstructor> builder)
        {
            builder.ToTable("CoursesOfInstructors").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("CoursesOfInstructorId").IsRequired();
            builder.Property(b => b.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(b => b.InstructorId).HasColumnName("InstructorId").IsRequired();
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }

    }
}