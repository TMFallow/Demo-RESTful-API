using Microsoft.EntityFrameworkCore;

namespace Student_Repo
{
    public class Student_Repo<T> :IStudent_Repo<T> where T: class
    {
        private readonly Student_Repo_Context context;

        private DbSet<T> students;

        string errorString = string.Empty;

        public Student_Repo(Student_Repo_Context context1)
        {
            context = context1;
            students = context.Set<T>();
        }

        public IEnumerable<T> GetAllStudents()
        {
            return students.ToList();
        }

        public T? GetStudent(int? Id)
        {
            return students.Find(Id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            else
            {
                students.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            else
            {
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            else
            {
                students.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            else
            {
                students.Remove(entity);
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}