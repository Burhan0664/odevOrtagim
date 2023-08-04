using System;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Abstract;
using Concrete;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;

namespace Controllers
{
    public class TeacherController:Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            this._teacherRepository=teacherRepository;
        }
        public IActionResult Index()
    {
        
        return View(_teacherRepository.GetAll());
    }
        [HttpGet]
        public IActionResult Index(string explore, int min_price, int max_price, DateTime Date, string Gender)
        {
            if (!string.IsNullOrEmpty(explore))
            {
                var teacherByName = _teacherRepository.GetByName(explore);
                if (teacherByName.Count > 0)
                {
                    return View(teacherByName);
                }
                else{
                    return View("notFound");
                }
            }

            var teachersByFilter = _teacherRepository.GetByFilter(min_price, max_price, Gender);
            if (teachersByFilter.Count >0)
            {
                return View(teachersByFilter);  
            }
            else{
                return View(_teacherRepository.GetAll());
            }
        }


    }
}