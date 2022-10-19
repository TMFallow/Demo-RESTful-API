using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Repo
{
    public class Student_Repo_Context : DbContext
    {
        public Student_Repo_Context(DbContextOptions<Student_Repo_Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new Student_Map(modelBuilder.Entity<Student>());

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(Student_Repo_Context).Assembly);
        }

        public DbSet<Student> Students { get; set; }
    }
}
