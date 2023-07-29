using System;
using System.IO.Compression;
using System.Net.Http.Headers;
using Abstract;
using Concrete;
using Entity;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            return View(_studentRepository.GetAll());


        }
        [HttpGet]
        public IActionResult Index(string? explore)
        {
            if (explore!=null&&_studentRepository.GetByName(explore)!=null)
            {

                var student = _studentRepository.GetByName(explore);
                return View(new List<Student> { student });
            }
            else
            {
                return View(_studentRepository.GetAll());   
            }
        }
               
        

    }
}