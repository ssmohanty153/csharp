using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAplication
{
    class SchoolContext : DbContext

    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=laptop-3avnc6qp;Database=add-migration CreateSchoolDB;Trusted_Connection=True;");
        }

    }
   
}

   
