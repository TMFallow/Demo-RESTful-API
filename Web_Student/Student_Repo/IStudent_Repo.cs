using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Repo
{
    public interface IStudent_Repo<T> where T : class
    {
        IEnumerable<T> GetAllStudents();

        T? GetStudent(int? Id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Remove(T entity);

        void SaveChanges();
    }
}
