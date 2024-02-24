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
    public class InstructorConfiguration
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("InstructorId").IsRequired();
            builder.Property(b => b.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(b => b.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(b => b.Phone).HasColumnName("Phone");
            builder.Property(b => b.Email).HasColumnName("Email");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }

}
