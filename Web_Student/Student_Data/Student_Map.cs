using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Data
{
    public class Student_Map
    {
        public Student_Map(EntityTypeBuilder<Student> modelBuilder)
        {
            modelBuilder.HasKey(x => x.Id);

            modelBuilder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            modelBuilder.Property(x => x.Name).IsRequired();

            modelBuilder.Property(x => x.Classroom).IsRequired();

            modelBuilder.Property(x => x.DateOfBirth).IsRequired();
        }
    }
}

