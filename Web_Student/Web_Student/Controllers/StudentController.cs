using Microsoft.AspNetCore.Mvc;
using Student_Data;
using Student_Services;
using Web_Student.Models;

namespace Web_Student.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent_Service student_Service;

        public StudentController(IStudent_Service student_Service)
        {
            this.student_Service = student_Service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //List<StudentViewModel> model = new List<StudentViewModel>();
            //student_Service.GetAllStudents().ToList().ForEach(t =>
            //{
            //    StudentViewModel student = new StudentViewModel
            //    {
            //        Name = t.Name,
            //        Classroom = t.Classroom,
            //        DateOfBirth = t.DateOfBirth,
            //    };
            //    model.Add(student);
            //});
            var model = student_Service.GetAllStudents();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            StudentViewModel model = new StudentViewModel();
            return View("AddStudent", model);
        }

        [HttpPost]
        public IActionResult AddStudent(StudentViewModel student)
        {
            Student stnt = new Student
            {
                Name = student.Name,
                Classroom = student.Classroom,
                DateOfBirth = student.DateOfBirth,
            };

            student_Service.Insert(stnt);
            if(stnt.Id >0)
            {
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult EditStudent(int? Id)
        {
            //StudentViewModel model = new StudentViewModel();
            //if(Id.HasValue && Id.Value >0)
            //{
            Student std = student_Service.GetStudent(Id);
            //    model.Name = std.Name;
            //    model.Classroom = std.Classroom;
            //    model.DateOfBirth = std.DateOfBirth;
            //}
            return View("EditStudent", std);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentViewModel model)
        {
            Student std = student_Service.GetStudent(model.Id);
            std.Name = model.Name;
            std.Classroom = model.Classroom;
            std.DateOfBirth = model.DateOfBirth;
            student_Service.Update(std);
            if(std.Id>0)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteStudent(int? Id)
        {
            Student student = student_Service.GetStudent(Id);
            return View("DeleteStudent", student);
        }

        [HttpPost]
        public IActionResult DeleteStudent(int? Id, StudentViewModel model)
        {
            Student std = student_Service.GetStudent(Id);
            student_Service.Delete(std);
            return RedirectToAction("Index");
        }
    }
}
