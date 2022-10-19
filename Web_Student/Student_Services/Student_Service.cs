using Student_Data;
using Student_Repo;

namespace Student_Services
{
    public class Student_Service : IStudent_Service
    {
        private readonly IStudent_Repo<Student> student_Repository;

        public Student_Service(IStudent_Repo<Student> student_Repository)
        {
            this.student_Repository = student_Repository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return student_Repository.GetAllStudents();
        }

        public Student GetStudent(int? id)
        {
            return student_Repository.GetStudent(id);
        }

        public void Insert(Student entity)
        {
            student_Repository.Insert(entity);
        }

        public void Update(Student entity)
        {
            student_Repository.Update(entity);
        }

        public void Delete(Student entity)
        {
            student_Repository.Delete(entity);
        }

        public void Remove(Student entity)
        {
            student_Repository.Remove(entity);
        }

        public void SaveChanges()
        {
            student_Repository.SaveChanges();
        }
    }
}