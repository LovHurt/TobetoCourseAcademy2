﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Contexts;

public class TobetoContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CoursesOfInstructor> CoursesOfInstructors { get; set; }
    public DbSet<Instructor> Instructors { get; set; }

    public TobetoContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(
        dbContextOptions)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
