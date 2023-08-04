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
        public IActionResult Index(string explore, int min_price, int max_price, int Date, string Gender)
        {
            if (!string.IsNullOrEmpty(explore))
            {
                var studentsByName = _studentRepository.GetByName(explore);
                if (studentsByName.Count > 0)
                {
                    return View(studentsByName);
                }
                else{
                    return View("notFound");
                }
            }

            var studentsByFilter = _studentRepository.GetByFilter(min_price, max_price, Gender);
            if (studentsByFilter.Count > 0)
            {
                return View(studentsByFilter);
            }

            return View(_studentRepository.GetAll());
        }



    }
}