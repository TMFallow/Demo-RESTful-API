using Student_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Services
{
    public interface IStudent_Service
    {
        IEnumerable<Student> GetAllStudents();

        Student? GetStudent(int? Id);

        void Insert(Student entity);

        void Update(Student entity);

        void Delete(Student entity);

        void Remove(Student entity);

        void SaveChanges();
    }
}
