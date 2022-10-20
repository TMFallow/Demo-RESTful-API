using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Data
{
    public class Teacher_Map
    {
        public Teacher_Map(EntityTypeBuilder<Teacher> modelBuilder)
        {
            modelBuilder.HasKey(x => x.Id);

            modelBuilder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            modelBuilder.Property(x => x.FirstName).IsRequired();

            modelBuilder.Property(x => x.LastName).IsRequired();

            modelBuilder.Property(x => x.DateOfBirth).IsRequired();
        }
    }
}
