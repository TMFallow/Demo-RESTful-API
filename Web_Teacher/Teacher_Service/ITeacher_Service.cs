using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher_Data;

namespace Teacher_Service
{
    public interface ITeacher_Service
    {
        IEnumerable<Teacher> GetAllTeachers();

        Teacher? GetTeacher(int? Id);

        void Insert(Teacher entity);

        void Update(Teacher entity);

        void Delete(Teacher entity);

        void Remove(Teacher entity);

        void SaveChanges();
    }
}
