using Teacher_Data;
using Teacher_Repo;

namespace Teacher_Service
{
    public class Teacher_Services : ITeacher_Service
    {
        private readonly ITeacher_Repo<Teacher> teacher_Repository;

        public Teacher_Services(ITeacher_Repo<Teacher> teacher_Repository)
        {
            this.teacher_Repository = teacher_Repository;
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return teacher_Repository.GetAllTeachers();
        }

        public Teacher GetTeacher(int? id)
        {
            return teacher_Repository.GetTeacher(id);
        }

        public void Insert(Teacher entity)
        {
            teacher_Repository.Insert(entity);
        }

        public void Update(Teacher entity)
        {
            teacher_Repository.Update(entity);
        }

        public void Delete(Teacher entity)
        {
            teacher_Repository.Delete(entity);
        }

        public void Remove(Teacher entity)
        {
            teacher_Repository.Remove(entity);
        }

        public void SaveChanges()
        {
            teacher_Repository.SaveChanges();
        }
    }
}