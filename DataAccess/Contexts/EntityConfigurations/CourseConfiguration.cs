using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Contexts.EntityConfigurations
{
    public class CourseConfiguration: IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("CourseId").IsRequired();
            builder.Property(b => b.CategoryId).HasColumnName("CategoryId");
            builder.Property(b => b.CourseName).HasColumnName("CourseName").IsRequired();
            builder.Property(b => b.Description).HasColumnName("Description");
            builder.HasIndex(indexExpression: b => b.CourseName, name: "UK_Courses_CourseName").IsUnique();
            builder.HasOne(b => b.Category);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
