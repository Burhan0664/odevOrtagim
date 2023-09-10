using System;
using Abstract;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [Authorize]
    public class AdvertController:Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        public AdvertController(ITeacherRepository teacherRepository,IStudentRepository studentRepository)
        {
           this._teacherRepository = teacherRepository;
           this._studentRepository = studentRepository;
        }
        
        [AllowAnonymous]
        public IActionResult TeacherAd(Teacher teacher){
            
            if (!string.IsNullOrEmpty(teacher.Name)&&teacher.Price!=null&&!string.IsNullOrEmpty(teacher.ImageUrl)&&!string.IsNullOrEmpty(teacher.Majority))
            {
                Teacher teacher1 = new Teacher(){
                    Name=teacher.Name,
                    ImageUrl=teacher.ImageUrl,
                    Price=teacher.Price,
                    Gender=teacher.Gender,
                    Majority = teacher.Majority

                };
                _teacherRepository.Create(teacher1);
                return RedirectToAction("Index","Teacher");

            }
            return View();
        }
        [AllowAnonymous]
        public IActionResult StudentAd(Student student){
              if (!string.IsNullOrEmpty(student.Name)&&student.Price!=null&&!string.IsNullOrEmpty(student.ImageUrl)&&!string.IsNullOrEmpty(student.Majority))
            {
                Student student1 = new Student(){
                    Name=student.Name,
                    ImageUrl=student.ImageUrl,
                    Price=student.Price,
                    Gender=student.Gender,
                    Majority = student.Majority

                };
                _studentRepository.Create(student1);
                return RedirectToAction("Index","Student");

            }
            return View();
        }
    }
}