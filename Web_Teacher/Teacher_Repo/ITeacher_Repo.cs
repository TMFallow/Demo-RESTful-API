using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Repo
{
    public interface ITeacher_Repo<T> where T : class
    {
        IEnumerable<T> GetAllTeachers();

        T? GetTeacher(int? Id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Remove(T entity);

        void SaveChanges();
    }
}
